//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenOracle01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderManufacture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderManufacture()
        {
            this.OrdenDetails = new HashSet<OrdenDetail>();
        }
    
        public int idOrden { get; set; }
        public string manufacturingOrder { get; set; }
        public string status { get; set; }
        public string client { get; set; }
        public string cuTtype { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDetail> OrdenDetails { get; set; }
    }
}
