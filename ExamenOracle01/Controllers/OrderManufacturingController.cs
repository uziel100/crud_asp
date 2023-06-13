using ExamenOracle01.Models;
using ExamenOracle01.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenOracle01.Controllers
{
    public class OrderManufacturingController : Controller
    {
        // GET: OrderManufacturing
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            List<ListOrdenManufactureViewModel> lst = new List<ListOrdenManufactureViewModel>();
            using (CrudIlusionEntities db = new CrudIlusionEntities())
            {
                lst = (from d in db.OrderManufactures
                       select new ListOrdenManufactureViewModel
                       {
                           IdOrden = d.idOrden,
                           Client = d.client,
                           CutType = d.cuTtype,
                           ManufacturingOrder = d.manufacturingOrder,
                           Status = d.status
                       }).ToList();
            }
            return View(lst);
        }
    }
}