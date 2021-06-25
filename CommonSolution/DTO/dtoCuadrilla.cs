using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoCuadrilla
    {
        public int NroDeCuadrilla;

        [DisplayName("Número de Zona:")]
        [Required(ErrorMessage = "El Número de Zona es requerido")]
        public int NroDeZona { get; set; }

        [DisplayName("Nombre:")]
        [Required(ErrorMessage = "El Nombre es requerido")]
        [StringLength(20, ErrorMessage = "El Nombre no puede tener más de 20 caracteres")]
        public string Nombre { get; set; }

        [DisplayName("Encargado:")]
        [Required(ErrorMessage = "El Encargado es requerido")]
        [StringLength(20, ErrorMessage = "El Encargado no puede tener más de 20 caracteres")]
        public string Encargado { get; set; }

        [DisplayName("Cantidad de Peones:")]
        [Required(ErrorMessage = "La Cantidad de Peones es requerida")]
        public int CantidadDePeones { get; set; }
    }
}
