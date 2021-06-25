using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class UbicacionZonaMapper
    {
        public UbicacionZona mapDtoUbicacionZonaToEntity(dtoUbicacionZona dto)
        {
            UbicacionZona entity = new UbicacionZona();
            entity.NroUbicacionZona = dto.NroUbicacionZona;
            entity.NroDeZona = dto.NroDeZona;
            entity.Latitud = dto.Latitud;
            entity.Longitud = dto.Longitud;
            return entity;
        }
    }
}
