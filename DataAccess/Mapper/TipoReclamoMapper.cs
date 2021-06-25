﻿using CommonSolution.DTO;
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

    }
}
