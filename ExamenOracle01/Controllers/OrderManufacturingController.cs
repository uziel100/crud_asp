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
        // GET: OrderManufacturing test git from fatima
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

        public ActionResult Create()
        {
            return View();
        }


        public ActionResult Edit(int Id)
        {
            OrderManufactureViewModel model = new OrderManufactureViewModel();
            using (CrudIlusionEntities db = new CrudIlusionEntities())
            {
                var prevRegister = db.OrderManufactures.Find(Id);
                model.ManufacturingOrder = prevRegister.manufacturingOrder;
                model.Status = prevRegister.status;
                model.Client = prevRegister.client;
                model.CutType = prevRegister.cuTtype;
                model.IdOrden = prevRegister.idOrden;
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            try
            {
                using (CrudIlusionEntities db = new CrudIlusionEntities())
                {
                    var prevRegister = db.OrderManufactures.Find(Id);
                    db.OrderManufactures.Remove(prevRegister);
                    db.SaveChanges();
                }
                return Content("1");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Save(OrderManufactureViewModel model)
        {
            try
            {
                using (CrudIlusionEntities db = new CrudIlusionEntities())
                {
                    var newRegister = new OrderManufacture();
                    newRegister.manufacturingOrder = model.ManufacturingOrder;
                    newRegister.status = model.Status;
                    newRegister.client = model.Client;
                    newRegister.cuTtype = model.CutType;

                    db.OrderManufactures.Add(newRegister);
                    db.SaveChanges();

                    return Content("1");
                }
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Update(OrderManufactureViewModel model)
        {
            try
            {
                using (CrudIlusionEntities db = new CrudIlusionEntities())
                {
                    var prevRegister = db.OrderManufactures.Find(model.IdOrden);
                    prevRegister.manufacturingOrder = model.ManufacturingOrder;
                    prevRegister.status = model.Status;
                    prevRegister.client = model.Client;
                    prevRegister.cuTtype = model.CutType;
                    db.Entry(prevRegister).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    return Content("1");
                }
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}