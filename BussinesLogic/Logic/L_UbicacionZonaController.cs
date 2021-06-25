using CommonSolution.DTO;
using DataAccess.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Logic
{
    public class L_UbicacionZonaController
    {
        private Repository _Repository;

        public L_UbicacionZonaController()
        {
            this._Repository = new Repository();
        }

        public List<string> AgregarUbicacionZona(dtoUbicacionZona dto)
        {
            List<string> colErrores = new List<string>();
            if (colErrores.Count() == 0)
            {
                this._Repository.getUbicacionZonaRepository().AgregarUbicacionZonaRepository(dto);
            }
            return colErrores;
        }
    }
}
