//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reclamo
    {
        public int NroDeReclamo { get; set; }
        public string NombreDeUsuario { get; set; }
        public int NroDeZona { get; set; }
        public Nullable<int> NroDeTipoDeReclamo { get; set; }
        public string Observacion { get; set; }
        public Nullable<decimal> Longitud { get; set; }
        public Nullable<decimal> Latitud { get; set; }
        public System.DateTime FechaDeIngreso { get; set; }
        public string EstadoDelReclamo { get; set; }
    
        public virtual TipoDeReclamo TipoDeReclamo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Zona Zona { get; set; }
    }
}
