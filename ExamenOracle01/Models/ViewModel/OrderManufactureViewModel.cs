using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Web;

namespace ExamenOracle01.Models.ViewModel
{
    public class OrderManufactureViewModel
    {
        public int IdOrden { get; set; }
        [DisplayName("Orden de Manufactura")]
        public string ManufacturingOrder { get; set; }
        [DisplayName("Status")]
        public string Status { get; set; }
        [DisplayName("Cliente")]
        public string Client { get; set; }
        [DisplayName("Tipo corte")]
        public string CutType { get; set; }
    }
}