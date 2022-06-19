using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP4.EntityFrameWork.Entities;
using TP4.EntityFrameWork.Logic;
using TP4.EntityFrameWork.Web.Models;

namespace TP4.EntityFrameWork.Web.Controllers
{
    public class SuppliersController : Controller
    {
        SuppliersLogic suppliersLogic = new SuppliersLogic();
        // GET: Suppliers
        public ActionResult Index()
        {
            try
            {
            List<Suppliers> supplier = suppliersLogic.GetAll();
            List<SuppliersView> suppliersView = supplier.Select(s => new SuppliersView
            {
                Id = s.SupplierID,
                Nombre = s.CompanyName,
                Direccion = s.Address,
                Telefono = s.Phone
            }).ToList();

            return View(suppliersView);
            }
            catch (Exception)
            {

                return RedirectToAction("About", "Home");
            }
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(SuppliersView suppliersView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var supplierEntity = new Suppliers
                    {
                        CompanyName = suppliersView.Nombre,
                        Address = suppliersView.Direccion,
                        Phone = suppliersView.Telefono
                    }; 
                    suppliersLogic.Add(supplierEntity);

                    return RedirectToAction("Index");
                }
           
            }
            catch (Exception)
            {
                return View(suppliersView);
                //return RedirectToAction("About", "Home");
            }
            return View();
        }


        public ActionResult Delete(int id)
        {
            try
            {
                suppliersLogic.Delete(id);
                return RedirectToAction("Index");

            }
            catch (Exception)
            {

                return RedirectToAction("About", "Home");
            }
        }

        public ActionResult Update(int id)
        {
            List<Suppliers> supplier = suppliersLogic.GetAll();
            List<SuppliersView> suppliersView = supplier.Where(s => s.SupplierID == id)
                                                       .Select(s => new SuppliersView
                                                       {
                                                           //Id = s.SupplierID,
                                                           Nombre = s.CompanyName,                                                            
                                                           Direccion = s.Address,
                                                           Telefono = s.Phone
                                                       }).ToList();
            SuppliersView supplierView = suppliersView[0];
            return View("Update", supplierView);
        }

        [HttpPost]
        public ActionResult Update(SuppliersView suppliersView)
        {
            try
            {
            Suppliers supplierEntity = new Suppliers
            {
                SupplierID = suppliersView.Id,
                CompanyName = suppliersView.Nombre,
                Address = suppliersView.Direccion,
                Phone = suppliersView.Telefono
            };
            suppliersLogic.Update(supplierEntity);
            return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("About", "Home");
            }

        }
    }
}