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
    
    public partial class TiposDeducciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposDeducciones()
        {
            this.RegistroTransacciones = new HashSet<RegistroTransacciones>();
        }
    
        public int Id_TipoDeduccion { get; set; }
        public string Nombre_TipoDeduccion { get; set; }
        public string DependeSalario_TipoDeduccion { get; set; }
        public string Estado_TipoDeduccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroTransacciones> RegistroTransacciones { get; set; }
    }
}
