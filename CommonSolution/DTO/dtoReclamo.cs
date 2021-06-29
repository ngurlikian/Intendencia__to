using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoReclamo
    {

        public int NroDeReclamo;
        public int NroDeZona;
        public string EstadoDelReclamo;
        public System.DateTime FechaDeIngreso;

        [DisplayName("Nombre De Usuario:")]
        [Required(ErrorMessage = "El Nombre de Usuario es requerido")]
        [StringLength(20, ErrorMessage = "El Nombre de Usuario no puede tener más de 20 caracteres")]
        public string NombreDeUsuario { get; set; }

        [DisplayName("Observacion:")]
        [Required(ErrorMessage = "La observacion es requerida")]
        [StringLength(100, ErrorMessage = "La observacion no puede tener más de 100 caracteres")]
        public string Observacion { get; set; }

        [DisplayName("Tipo de reclamo:")]
        [Required(ErrorMessage = "El tipo de reclamo es requerida")]
        public int NroDeTipoDeReclamo { get; set; }

        public decimal Longitud;
        public decimal Latitud;
        
    }
}
