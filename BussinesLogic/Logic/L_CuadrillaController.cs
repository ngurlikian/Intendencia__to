using CommonSolution.DTO;
using DataAccess.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Logic
{
    public class L_CuadrillaController
    {
        private Repository _Repository;

        public L_CuadrillaController()
        {
            this._Repository = new Repository();
        }

        public List<string> AgregarCuadrilla (dtoCuadrilla dto)
        {
            List<string> colErrores = new List<string>();
            if (colErrores.Count() == 0)
            {
                this._Repository.getCuadrillaRepository().AgregarCuadrillaRepository(dto);
            }
            return colErrores;
        }

        public List<string> ValidarBorrado(int nrocuadrilla)
        {
            List<string> colErrores = new List<string>();

            if (!this._Repository.getCuadrillaRepository().ExisteCuadrillaRepository(nrocuadrilla))
            {
                colErrores.Add("La Cuadrilla no existe");
            }

            return colErrores;
        }

        public List<string> BorrarCuadrilla(int nrocuadrilla)
        {
            List<string> colErrores = this.ValidarBorrado(nrocuadrilla);

            if (colErrores.Count == 0)
            {
                this._Repository.getCuadrillaRepository().BorrarCuadrillaRepository(nrocuadrilla);
            }

            return colErrores;
        }
    }
}
