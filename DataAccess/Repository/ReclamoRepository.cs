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
    public class ReclamoRepository
    {
        public ReclamoRepository()
        {
            this.reclamoMapper = new ReclamoMapper();
        }

        private ReclamoMapper reclamoMapper;

        public void AgregarReclamoRepository(dtoReclamo dto)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Reclamo reclamoentity = this.reclamoMapper.mapDtoReclamoToEntity(dto);
                        dto.NroDeZona = 1;
                        dto.FechaDeIngreso = DateTime.Now;
                        dto.EstadoDelReclamo = "Pendiente";
                        context.Reclamo.Add(reclamoentity);
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
