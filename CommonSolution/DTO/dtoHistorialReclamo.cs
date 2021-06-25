using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoHistorialReclamo
    {
        public int NroDeHistorial { get; set; }
        public int NroDeReclamo { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Observacion { get; set; }
        public decimal Longitud { get; set; }
        public decimal Latitud { get; set; }
        public System.DateTime FechaDeIngreso { get; set; }
        public string EstadoDelReclamo { get; set; }
        public System.DateTime FechaDeCambioDeEstado { get; set; }
    }
}
