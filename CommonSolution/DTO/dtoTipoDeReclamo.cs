using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoTipoDeReclamo
    {
        public int NroDeTipoDeReclamo;

        [DisplayName("Nombre:")]
        [Required(ErrorMessage = "El Nombre es requerido")]
        [StringLength(20, ErrorMessage = "El Nombre no puede tener más de 20 caracteres")]
        public string Nombre { get; set; }

        [DisplayName("Descripción:")]
        [Required(ErrorMessage = "La Descripción es requerida")]
        [StringLength(100, ErrorMessage = "El Nombre no puede tener más de 100 caracteres")]
        public string Descripción { get; set; }

        public List<dtoReclamo> colDtoReclamo;
    }
}
