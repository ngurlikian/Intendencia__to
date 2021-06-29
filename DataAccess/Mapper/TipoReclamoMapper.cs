using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class TipoReclamoMapper
    {
        public TipoDeReclamo mapDtoTipoReclamoToEntity(dtoTipoDeReclamo dto)
        {
            TipoDeReclamo entity = new TipoDeReclamo();
            entity.NroDeTipoDeReclamo = dto.NroDeTipoDeReclamo;
            entity.Nombre = dto.Nombre;
            entity.Descripción = dto.Descripción;
            return entity;
        }



        public List<dtoTipoDeReclamo> MapToDto(List<TipoDeReclamo> colEntity)
        {
            List<dtoTipoDeReclamo> colDto = new List<dtoTipoDeReclamo>();
            foreach (TipoDeReclamo item in colEntity)
            {
                dtoTipoDeReclamo dto = this.MapToEntityAToDto(item);
                colDto.Add(dto);
            }

            return colDto;
        }

        public dtoTipoDeReclamo MapToEntityAToDto(TipoDeReclamo entity)
        {
            dtoTipoDeReclamo dto = null;
            if (entity != null)
            {
                dto = new dtoTipoDeReclamo();
                dto.NroDeTipoDeReclamo = entity.NroDeTipoDeReclamo;
                dto.Nombre = entity.Nombre;
                dto.Descripción = entity.Descripción;
            }
            return dto;
        }
    }
}
