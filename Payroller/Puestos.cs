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
    
    public partial class Puestos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Puestos()
        {
            this.Empleados = new HashSet<Empleados>();
        }
    
        public int Id_Puesto { get; set; }
        public string Nombre_Puesto { get; set; }
        public Nullable<int> Id_NivelRiesgo { get; set; }
        public Nullable<decimal> MaximoSalario_Puesto { get; set; }
        public Nullable<decimal> Minimo_Salario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleados> Empleados { get; set; }
        public virtual NivelesRiesgo NivelesRiesgo { get; set; }
    }
}
