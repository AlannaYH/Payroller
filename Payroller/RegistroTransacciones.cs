//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Payroller
{
    using System;
    using System.Collections.Generic;
    
    public partial class RegistroTransacciones
    {
        public int Id_RegistroTransaccion { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
        public Nullable<int> Id_TipoIngreso { get; set; }
        public Nullable<int> Id_TipoDeduccion { get; set; }
        public string Tipo_RegistroTransaccion { get; set; }
        public Nullable<System.DateTime> Fecha_RegistroTransaccion { get; set; }
        public Nullable<decimal> Monto_RegistroTransaccion { get; set; }
        public string Estado_RegistroTransaccion { get; set; }
        public string Periodo_RegistroTransaccion { get; set; }
    
        public virtual Empleados Empleados { get; set; }
        public virtual TiposIngresos TiposIngresos { get; set; }
        public virtual TiposDeducciones TiposDeducciones { get; set; }
    }
}
