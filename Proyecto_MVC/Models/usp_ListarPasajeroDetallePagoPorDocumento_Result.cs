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
    
    public partial class usp_ListarPasajeroDetallePagoPorDocumento_Result
    {
        public string Nombre_completo { get; set; }
        public string tipo_documento { get; set; }
        public string num_documento { get; set; }
        public Nullable<System.DateTime> F_Reserva { get; set; }
        public Nullable<System.DateTime> F_Salida { get; set; }
        public Nullable<System.DateTime> F_Llegada { get; set; }
        public string medio_pago { get; set; }
        public string tipo_comprobante { get; set; }
        public string num_comprobante { get; set; }
        public string Tipo_de_Vuelo { get; set; }
        public decimal precio { get; set; }
    }
}
