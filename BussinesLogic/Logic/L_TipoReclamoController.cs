using CommonSolution.DTO;
using DataAccess.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Logic
{
    public class L_TipoReclamoController
    {
        private Repository _Repository;

        public L_TipoReclamoController()
        {
            this._Repository = new Repository();
        }

        public List<string> AgregarTipoReclamo(dtoTipoDeReclamo dto)
        {
            List<string> colErrores = new List<string>();
            if (colErrores.Count() == 0)
            {
                this._Repository.getTipoReclamoRepository().AgregarTipoReclamoRepository(dto);
            }
            return colErrores;
        }

        public List<string> ValidarBorrado(int nrotiporeclamo)
        {
            List<string> colErrores = new List<string>();

            if (!this._Repository.getTipoReclamoRepository().ExisteTipoReclamoRepository(nrotiporeclamo))
            {
                colErrores.Add("El tipo de reclamo no existe");
            }

            return colErrores;
        }

        public List<string> BorrarTipoReclamo(int nrotiporeclamo)
        {
            List<string> colErrores = this.ValidarBorrado(nrotiporeclamo);

            if (colErrores.Count == 0)
            {
                this._Repository.getTipoReclamoRepository().BorrarTipoReclamoRepository(nrotiporeclamo);
            }

            return colErrores;
        }
    }
}
