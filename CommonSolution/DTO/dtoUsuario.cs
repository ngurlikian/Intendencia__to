using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoUsuario
    {
        [DisplayName("Nombre De Usuario:")]
        [Required (ErrorMessage = "El Nombre de Usuario es requerido")]
        [StringLength(20, ErrorMessage = "El Nombre de Usuario no puede tener más de 20 caracteres")]
        public string NombreDeUsuario { get; set; }

        [DisplayName("Nombre:")]
        [Required(ErrorMessage = "El Nombre es requerido")]
        [StringLength(20, ErrorMessage = "El Nombre no puede tener más de 20 caracteres")]
        public string Nombre { get; set; }

        [DisplayName("Apellido:")]
        [Required(ErrorMessage = "El Apellido es requerido")]
        [StringLength(20, ErrorMessage = "El Apellido no puede tener más de 20 caracteres")]
        public string Apellido { get; set; }

        [DisplayName("Teléfono:")]
        [Required(ErrorMessage = "El Telefono es requerido")]
        [StringLength(10, ErrorMessage = "El Telefono no puede tener más de 10 caracteres")]
        public string Telefono { get; set; }

        [DisplayName("Contraseña:")]
        [Required(ErrorMessage = "La Constraseña es requerido")]
        [StringLength(10, ErrorMessage = "La Contraseña no puede tener más de 10 caracteres")]
        public string Contraseña { get; set; }

        [DisplayName("Correo Electrónico:")]
        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "El formato de email no es correcto, por ejemplo: xxxxx@servicio.com")]
        [StringLength(20, ErrorMessage = "El email no puede tener más de 20 caracteres")]
        public string CorreoElectronico { get; set; }

        public string Funcionario;
        public string Estado;

        public List<dtoReclamo> coldtoReclamo;
    }
}
