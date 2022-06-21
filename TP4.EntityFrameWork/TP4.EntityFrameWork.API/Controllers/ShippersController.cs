using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TP4.EntityFrameWork.API.Models;
using TP4.EntityFrameWork.Entities;
using TP4.EntityFrameWork.Logic;

namespace TP4.EntityFrameWork.API.Controllers
{
    public class ShippersController : ApiController
    {

        ShippersLogic shippersLogic = new ShippersLogic();

        public IHttpActionResult GetAll()
        {
            List<Shippers> shippersList = shippersLogic.GetAll();
            List<ShippersView> shippersViews = shippersList.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                Nombre = s.CompanyName,
                Telefono = s.Phone
            }).ToList();

            if (shippersViews.Count == 0)
            {
                return NotFound();
            }
            return Ok(shippersViews);
        }

        public IHttpActionResult GetById(int id)
        {
            Shippers shipper = shippersLogic.GetOne(id);

            if (shipper == null)
            {
                return NotFound();
            }

            ShippersView shipperView = new ShippersView
            {
                Id = shipper.ShipperID,
                Nombre = shipper.CompanyName,
                Telefono = shipper.Phone
            };

            return Ok(shipperView);
        }

        public IHttpActionResult PostCreate(ShippersView shipperView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }
            else
            {
                Shippers shipper = new Shippers
                {
                    CompanyName = shipperView.Nombre,
                    Phone = shipperView.Telefono
                };
                shippersLogic.Add(shipper);
                return Ok("Add Ok!");
            }
        }

        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid ID");
            }

            else
            {
                return Ok("Delete Ok!");
            }

        }

        public IHttpActionResult PatchEdit(ShippersView shipperView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }
            else
            {
                Shippers shipper = new Shippers
                {
                    //ShipperID = shipperView.Id,
                    CompanyName = shipperView.Nombre,
                    Phone = shipperView.Telefono
                };
                shippersLogic.Update(shipper);
                return Ok("Update Ok!");
            }
        }

    }
}
