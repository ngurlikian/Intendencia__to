using CommonSolution.Constantes;
using CommonSolution.DTO;
using DataAccess.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Logic
{
    public class L_ZonaController
    {
        private Repository _Repository;

        public L_ZonaController()
        {
            this._Repository = new Repository();
        }

        public List<string> AgregarZona(dtoZona dto)
        {
            List<string> colErrores = new List<string>();
            if (colErrores.Count() == 0)
            {
                dto.Estado = Estado.ESTADO_ACTIVO;
                this._Repository.getZonaRepository().AgregarZonaRepository(dto);
            }
            return colErrores;
        }

        public List<string> ValidarBorrado(int nrodezona)
        {
            List<string> colErrores = new List<string>();

            if (!this._Repository.getZonaRepository().ExisteZonaRepository(nrodezona))
            {
                colErrores.Add("La Zona no existe");
            }

            return colErrores;
        }

        public List<string> BorrarZona(int nrodezona)
        {
            List<string> colErrores = this.ValidarBorrado(nrodezona);

            if (colErrores.Count == 0)
            {
                this._Repository.getZonaRepository().BorrarZonaRepository(nrodezona);
            }

            return colErrores;
        }
    }
}
