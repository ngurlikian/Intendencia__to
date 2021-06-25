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
            return entity;
        }



    }
}
