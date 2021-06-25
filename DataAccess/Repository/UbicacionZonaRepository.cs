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
    public class UbicacionZonaRepository
    {
        public UbicacionZonaRepository()
        {
            this.ubicacionzonaMapper = new UbicacionZonaMapper();
        }

        private UbicacionZonaMapper ubicacionzonaMapper;

        public void AgregarUbicacionZonaRepository(dtoUbicacionZona dto)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        UbicacionZona ubicacionzonaentity = this.ubicacionzonaMapper.mapDtoUbicacionZonaToEntity(dto);
                        context.UbicacionZona.Add(ubicacionzonaentity);
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
