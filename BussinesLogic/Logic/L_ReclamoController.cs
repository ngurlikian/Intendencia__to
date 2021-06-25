using CommonSolution.DTO;
using DataAccess.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Logic
{
    public class L_ReclamoController
    {
        private Repository _Repository;

        public L_ReclamoController()
        {
            this._Repository = new Repository();
        }

        public List<string> AgregarReclamo(dtoReclamo dto)
        {
            List<string> colErrores = new List<string>();
            if (colErrores.Count() == 0)
            {
                this._Repository.getReclamoRepository().AgregarReclamoRepository(dto);
            }
            return colErrores;
        }
    }
}
