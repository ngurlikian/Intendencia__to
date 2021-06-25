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
            entity.Contraseña = dto.Contraseña;
            return entity;
        }

    }
}
