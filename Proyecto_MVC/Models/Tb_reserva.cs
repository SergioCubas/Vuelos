//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_reserva
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_reserva()
        {
            this.Tb_pago = new HashSet<Tb_pago>();
            this.Tb_vuelo = new HashSet<Tb_vuelo>();
        }
    
        public int idReserva { get; set; }
        public Nullable<System.DateTime> F_Reserva { get; set; }
        public Nullable<System.DateTime> F_Salida { get; set; }
        public Nullable<System.DateTime> F_Llegada { get; set; }
        public string observaciones { get; set; }
        public Nullable<System.DateTime> F_Registro { get; set; }
        public Nullable<System.DateTime> F_Modificacion { get; set; }
        public Nullable<int> estado { get; set; }
        public Nullable<int> idPasajero { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_pago> Tb_pago { get; set; }
        public virtual Tb_pasajero Tb_pasajero { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_vuelo> Tb_vuelo { get; set; }
    }
}
