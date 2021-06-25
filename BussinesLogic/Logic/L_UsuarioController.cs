using CommonSolution.DTO;
using DataAccess.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Logic
{
    public class L_UsuarioController
    {
        private Repository _Repository;

        public L_UsuarioController()
        {
            this._Repository = new Repository();
        }

        public List<string> AgregarUsuario(dtoUsuario dto)
        {
            List<string> colErrores = new List<string>();
            if (colErrores.Count() == 0)
            {
                dto.Funcionario = "No";
                this._Repository.getUsuarioRepository().AgregarUsuarioRepository(dto);
            }
            return colErrores;
        }

        public List<string> ValidarBorrado(string nombredeusuario) 
        {
            List<string> colErrores = new List<string>();  

            if (!this._Repository.getUsuarioRepository().ExisteUsuarioRepository(nombredeusuario))
            {
                colErrores.Add("El usuario no existe");
            }

            return colErrores;
        }

        public List<string> BorrarUsuario(string nombredeusuario)
        {
            List<string> colErrores = this.ValidarBorrado(nombredeusuario);

            if (colErrores.Count == 0)
            {
                this._Repository.getUsuarioRepository().BorrarUsuarioRepository(nombredeusuario);
            }

            return colErrores;
        }

    }
}
