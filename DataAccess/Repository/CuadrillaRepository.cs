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
    public class CuadrillaRepository
    {
        public CuadrillaRepository()
        {
           this.cuadrillaMapper = new CuadrillaMapper();
        }

        private CuadrillaMapper cuadrillaMapper;

        public bool ExisteCuadrillaRepository(int nrocuadrilla)
        {
            bool existe = false;
            using (BDToledoEntities context = new BDToledoEntities())
            {
                existe = context.Cuadrilla.AsNoTracking().Any(i => i.NroDeCuadrilla == nrocuadrilla);
            }
            return existe;
        }

        public void AgregarCuadrillaRepository(dtoCuadrilla dto)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Cuadrilla cuadrillaentity = this.cuadrillaMapper.mapDtoCuadrillaToEntity(dto);
                        context.Cuadrilla.Add(cuadrillaentity);
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

        public void BorrarCuadrillaRepository(int nrocuadrilla)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Cuadrilla EstaCuadrilla = context.Cuadrilla.FirstOrDefault(f => f.NroDeCuadrilla == nrocuadrilla);

                        if (EstaCuadrilla != null)
                        {
                            context.Cuadrilla.Remove(EstaCuadrilla);
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

        public void ModificarCuadrilla(dtoCuadrilla dto)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Cuadrilla currCuadrilla = context.Cuadrilla.FirstOrDefault(f => f.NroDeCuadrilla == dto.NroDeCuadrilla);

                        currCuadrilla.NroDeZona = dto.NroDeZona;
                        currCuadrilla.Nombre = dto.Nombre;
                        currCuadrilla.Encargado = dto.Encargado;
                        currCuadrilla.CantidadDePeones = dto.CantidadDePeones;

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
