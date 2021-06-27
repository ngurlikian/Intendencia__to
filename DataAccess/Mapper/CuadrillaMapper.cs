using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class CuadrillaMapper
    {

        public Cuadrilla mapDtoCuadrillaToEntity(dtoCuadrilla dto)
        {
            Cuadrilla entity = new Cuadrilla();
            entity.NroDeCuadrilla = dto.NroDeCuadrilla;
            entity.NroDeZona = dto.NroDeZona;
            entity.Encargado = dto.Encargado;
            entity.CantidadDePeones = dto.CantidadDePeones;
            entity.Nombre = dto.Nombre;
            entity.Estado = dto.Estado;
            return entity;
        }

        public List<dtoCuadrilla> MapToDto(List<Cuadrilla> colEntity)
        {
            List<dtoCuadrilla> colDto = new List<dtoCuadrilla>();
            foreach (Cuadrilla item in colEntity)
            {
                dtoCuadrilla dto = this.MapToEntityAToDto(item);
                colDto.Add(dto);
            }

            return colDto;
        }

        public dtoCuadrilla MapToEntityAToDto(Cuadrilla entity)
        {
            dtoCuadrilla dto = null;
            if (entity != null)
            {
                dto = new dtoCuadrilla();
                dto.NroDeCuadrilla = entity.NroDeCuadrilla;
                dto.NroDeZona = entity.NroDeZona;
                dto.Encargado = entity.Encargado;
                dto.CantidadDePeones = entity.CantidadDePeones;
                dto.Nombre =entity.Nombre;
                dto.Estado = entity.Estado;
            }
            return dto;
        }

    }
}
