using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP4.EntityFrameWork.Entities;
using TP4.EntityFrameWork.Logic;
using TP4.EntityFrameWork.Web.Models;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace TP4.EntityFrameWork.Web.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic shippersLogic = new ShippersLogic();
        // GET: Shippers
        public ActionResult Index()
        {
            try
            {
            List<Shippers> shippers = shippersLogic.GetAll();
            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                Nombre = s.CompanyName,
                telefono = s.Phone
            }).ToList();

            return View(shippersView);
            }
            catch (Exception)
            {

                return RedirectToAction("About", "Home");
            }

        }


        public ActionResult Insert()
        {
            //ViewBag.Message = TempData["mensaje"];
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShippersView shippersView)
        {
            try
            {
            if (ModelState.IsValid)
            {
                var shippersEntity = new Shippers
                {
                    CompanyName = shippersView.Nombre,
                    Phone = shippersView.telefono
                };
                shippersLogic.Add(shippersEntity);

                //TempData["mensaje"] = "El shipper se ha añadido correctamente";
                return RedirectToAction("Index");
            }
            //

            }
            catch (Exception)
            {
                return View(shippersView);
                //return RedirectToAction("About", "Home");
            }
            return View();

        }


        public ActionResult Delete(int id)
        {
            try
            {
                shippersLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("About","Home");
            }
            
        }

        public ActionResult Update(int id)
        {
            List<Shippers> shippers = shippersLogic.GetAll();
            List<ShippersView> shippersView = shippers.Where(s => s.ShipperID == id)
                                                       .Select(s => new ShippersView
                                                       {
                                                           Id = s.ShipperID,
                                                           Nombre = s.CompanyName,
                                                           telefono = s.Phone
                                                       }).ToList();
            ShippersView shipperView = shippersView[0];
            return View("Update", shipperView);
        }

        [HttpPost]
        public ActionResult Update(ShippersView shipperView)
        {
            try
            {
                Shippers shipperEntity = new Shippers
                {
                    ShipperID = shipperView.Id,
                    CompanyName = shipperView.Nombre,
                    Phone = shipperView.telefono
                };
                shippersLogic.Update(shipperEntity);
                return RedirectToAction("Index");

            }
            catch (Exception)
            {

                return RedirectToAction("About", "Home");
            }
            
            
        }



    }
}