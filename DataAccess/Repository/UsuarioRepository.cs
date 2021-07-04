using CommonSolution.Constantes;
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
    public class UsuarioRepository
    {
        public UsuarioRepository()
        {
            this.usuarioMapper = new UsuarioMapper();
        }

        private UsuarioMapper usuarioMapper;

        public bool ExisteUsuarioRepository(string nombredeusuario)
        {
            bool existe = false;
            using (BDToledoEntities context = new BDToledoEntities())
            {
                existe = context.Usuario.AsNoTracking().Any(i => i.NombreDeUsuario == nombredeusuario);
            }
            return existe;
        }

        public string getLogin(string nombredeusuario)
        {
            string contra;
            using (BDToledoEntities context = new BDToledoEntities())
            {
                Usuario EsteUsuario = context.Usuario.AsNoTracking().FirstOrDefault(f => f.NombreDeUsuario == nombredeusuario);
                contra = EsteUsuario.Contraseña;

            }
            return contra;
        }

        public string getEstado(string nombredeusuario)
        {
            string estado;
            using (BDToledoEntities context = new BDToledoEntities())
            {
                Usuario EsteUsuario = context.Usuario.AsNoTracking().FirstOrDefault(f => f.NombreDeUsuario == nombredeusuario);
                estado = EsteUsuario.Estado;

            }
            return estado;
        }


        public dtoUsuario getUsuarioLogeadoRepository(string user)
        {
            dtoUsuario dto = new dtoUsuario();

            using (BDToledoEntities context = new BDToledoEntities())
            {
                Usuario esteUsuario = context.Usuario.FirstOrDefault(f => f.NombreDeUsuario == user);
                dto = this.usuarioMapper.MapToEntityAToDto(esteUsuario);
            }
            return dto;
        }

        public void AgregarUsuarioRepository(dtoUsuario dto)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Usuario usuarioentity = this.usuarioMapper.mapDtoUsuarioToEntity(dto);
                        context.Usuario.Add(usuarioentity);
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

     
        public void BorrarUsuarioRepository(string nombredeusuario)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Usuario EsteUsuario = context.Usuario.FirstOrDefault(f => f.NombreDeUsuario == nombredeusuario); 

                        if (EsteUsuario != null)
                        {
                            EsteUsuario.Estado = Estado.ESTADO_INACTIVO;
                            context.SaveChanges();
                            trann.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        trann.Rollback();
                    }
                }
            }
        }

        public void ModificarUsuario(dtoUsuario dto)
        {
            using (BDToledoEntities context = new BDToledoEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Usuario currUsuario = context.Usuario.FirstOrDefault(f => f.NombreDeUsuario == dto.NombreDeUsuario);

                        currUsuario.Nombre = dto.Nombre;
                        currUsuario.Apellido = dto.Apellido;
                        currUsuario.Telefono = dto.Telefono;
                        currUsuario.CorreoElectronico = dto.CorreoElectronico;
                        currUsuario.Contraseña = dto.Contraseña;
                        currUsuario.Funcionario = dto.Funcionario;

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
