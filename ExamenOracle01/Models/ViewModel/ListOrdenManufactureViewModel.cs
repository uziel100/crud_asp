using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenOracle01.Models.ViewModel
{
    public class ListOrdenManufactureViewModel
    {
        public int IdOrden { get; set; }
        public string ManufacturingOrder { get; set; }
        public string Status { get; set; }
        public string Client { get; set; }
        public string CutType { get; set; }
    }
}