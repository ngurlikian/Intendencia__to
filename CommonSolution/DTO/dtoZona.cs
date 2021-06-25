using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoZona
    {
        public int NroDeZona { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }

        public List<dtoCuadrilla> colDtoCuadrilla;
        public List<dtoReclamo> colDtoReclamo;
        public  List<dtoUbicacionZona> colDtoUbicacionZona { get; set; }
    }
}
