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
    
    public partial class OrdenDetail
    {
        public int id { get; set; }
        public Nullable<int> idOrden { get; set; }
        public string model { get; set; }
        public string place { get; set; }
        public string color { get; set; }
        public Nullable<int> quantity { get; set; }
    
        public virtual OrderManufacture OrderManufacture { get; set; }
    }
}
