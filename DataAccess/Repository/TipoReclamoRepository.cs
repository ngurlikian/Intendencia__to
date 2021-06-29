using CommonSolution.DTO;
using DataAccess.Mapper;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class TipoReclamoRepository
    {
        public TipoReclamoRepository()
        {
            this.tiporeclamoMapper = new TipoReclamoMapper();
        }

        private TipoReclamoMapper tiporeclamoMapper;

        public bool ExisteTipoReclamoRepository(int nrotipodereclamo)
        {
            bool existe = false;
            using (BDToledoEntities context = new BDToledoEntities())
            {
                existe = context.TipoDeReclamo.AsNoTracking().Any(i => i.NroDeTipoDeReclamo == nrotipodereclamo);
            }
            return existe;
        }

        public void AgregarTipoReclamoRepository(dtoTipoDeReclamo dto)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        TipoDeReclamo tiporeclamoentity = this.tiporeclamoMapper.mapDtoTipoReclamoToEntity(dto);
                        context.TipoDeReclamo.Add(tiporeclamoentity);
                        context.SaveChanges();
                        trann.Commit();
                    }
                    catch (Exception ex)
                    {
                        trann.Rollback();
                    }
                }
            }
        }

        public List<dtoTipoDeReclamo> getTipoReclamo()
        {
            List<dtoTipoDeReclamo> colDtoTipoReclamo = new List<dtoTipoDeReclamo>();

            using (BDToledoEntities context = new BDToledoEntities())
            {
                List<TipoDeReclamo> colTipoReclamo = context.TipoDeReclamo.AsNoTracking().Select(s => s).ToList();
                colDtoTipoReclamo = this.tiporeclamoMapper.MapToDto(colTipoReclamo);
            }

            return colDtoTipoReclamo;
        }

        public void BorrarTipoReclamoRepository(int nrotipodereclamo)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        TipoDeReclamo EsteTipoReclamo = context.TipoDeReclamo.FirstOrDefault(f => f.NroDeTipoDeReclamo == nrotipodereclamo);

                        if (EsteTipoReclamo != null)
                        {
                            context.TipoDeReclamo.Remove(EsteTipoReclamo);
                            context.SaveChanges();
                            trann.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        trann.Rollback();
                    }
                }
            }
        }

        public void ModificarTipoReclamo(dtoTipoDeReclamo dto)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        TipoDeReclamo currTipoReclamo = context.TipoDeReclamo.FirstOrDefault(f => f.NroDeTipoDeReclamo == dto.NroDeTipoDeReclamo);

                        currTipoReclamo.Nombre = dto.Nombre;
                        currTipoReclamo.Descripción = dto.Descripción;

                        context.SaveChanges();
                        trann.Commit();
                    }
                    catch (Exception ex)
                    {
                        trann.Rollback();
                    }

                }

            }

        }
    }
}
