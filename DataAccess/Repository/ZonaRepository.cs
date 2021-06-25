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
    public class ZonaRepository
    {
        public ZonaRepository()
        {
            this.zonaMapper = new ZonaMapper();
        }

        private ZonaMapper zonaMapper;

        public bool ExisteZonaRepository(int nrodezona)
        {
            bool existe = false;
            using (BDToledoEntities context = new BDToledoEntities())
            {
                existe = context.Zona.AsNoTracking().Any(i => i.NroDeZona == nrodezona);
            }
            return existe;
        }

        public void AgregarZonaRepository(dtoZona dto)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                    try
                    {
                        Zona zonaentity = this.zonaMapper.mapDtoZonaToEntity(dto);
                        context.Zona.Add(zonaentity);
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

        public void BorrarZonaRepository(int nrodezona)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Zona EstaZona = context.Zona.FirstOrDefault(f => f.NroDeZona == nrodezona);

                        if (EstaZona != null)
                        {
                            context.Zona.Remove(EstaZona);
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
    }
}
