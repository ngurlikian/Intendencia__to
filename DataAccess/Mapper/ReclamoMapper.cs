using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class ReclamoMapper
    {
        public Reclamo mapDtoReclamoToEntity(dtoReclamo dto)
        {
            Reclamo entity = new Reclamo();
            entity.NroDeReclamo = dto.NroDeReclamo;
            entity.NombreDeUsuario = dto.NombreDeUsuario;
            entity.NroDeZona = dto.NroDeZona;
            entity.NroDeTipoDeReclamo = dto.NroDeTipoDeReclamo;
            entity.Observacion = dto.Observacion;
            entity.Longitud = dto.Longitud;
            entity.Latitud = dto.Latitud;
            entity.FechaDeIngreso = dto.FechaDeIngreso;
            entity.EstadoDelReclamo = dto.EstadoDelReclamo;
            return entity;
        }
    }
}
