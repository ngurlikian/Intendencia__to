using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class UsuarioMapper
    {
        public Usuario mapDtoUsuarioToEntity(dtoUsuario dto)
        {
            Usuario entity = new Usuario();
            entity.NombreDeUsuario = dto.NombreDeUsuario;
            entity.Nombre = dto.Nombre;
            entity.Apellido = dto.Apellido;
            entity.Telefono = dto.Telefono;
            entity.Contraseña = dto.Contraseña;
            entity.Funcionario = dto.Funcionario;
            entity.CorreoElectronico = dto.CorreoElectronico;
            entity.Estado = dto.Estado;
            return entity;
        }



        public dtoUsuario MapToEntityAToDto(Usuario entity)
        {
            dtoUsuario dto = null;
            if (entity != null)
            {
                dto = new dtoUsuario();
                dto.NombreDeUsuario = entity.NombreDeUsuario;
                dto.Nombre = entity.Nombre;
                dto.Apellido = entity.Apellido;
                dto.Contraseña = entity.Contraseña;
                dto.CorreoElectronico = entity.CorreoElectronico;
                dto.Telefono = entity.Telefono;
                dto.Estado = entity.Estado;
                dto.Funcionario = entity.Funcionario;
            }
            return dto;
        }

    }
}
