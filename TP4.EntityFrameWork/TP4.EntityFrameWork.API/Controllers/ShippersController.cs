using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using TP4.EntityFrameWork.API.Models;
using TP4.EntityFrameWork.Entities;
using TP4.EntityFrameWork.Logic;

namespace TP4.EntityFrameWork.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ShippersController : ApiController
    {

        ShippersLogic shippersLogic = new ShippersLogic();

        /// <summary>
        /// Obtiene todos los objetos de Shippers
        /// </summary>
        /// <returns>Listado de los objetos shippers</returns>
        /// <response code ="200">Ok. Devuelve el listado de objetos solicitados</response>
        /// <response code ="400">NotFound. No se pudo devolver el listado de objetos solicitados</response>
        
        [ResponseType(typeof(IEnumerable<ShippersView>))]
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

        /// <summary>
        /// Obtiene un objeto Shippers por su ID.
        /// </summary>
        /// <param name="id">Id del objeto</param>
        /// <returns>Objeto Shippers</returns>
        /// <response code ="200">Ok. Devuelve el objetos solicitados</response>
        /// <response code ="404">NotFound. No se ha encontrado el objeto solicitado</response>
        
        [ResponseType(typeof(ShippersView))]
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

        /// <summary>
        /// Crea objeto Shippers según el modelo especificado.
        /// </summary>
        /// <param name="shipperView"></param>
        /// <returns>Mensaje satifactorio de agregado.</returns>
        /// /// <response code ="200">Ok. Mensaje satifactorio</response>
        /// <response code ="404">NotFound. No se ha podido validar el objeto solicitado</response>
        /// <response code ="500">Internal server error</response>
        public IHttpActionResult PostCreate(ShippersView shipperView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    Shippers shipper = new Shippers
                    {
                        CompanyName = shipperView.Nombre,
                        Phone = shipperView.Telefono
                    };
                    shippersLogic.Add(shipper);
                    return Ok("Add Ok!");
                }
                catch (Exception ex) { return InternalServerError(ex); }

            }
        }

        /// <summary>
        /// Borra un objeto Shipper por su ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Mensaje satifactorio de borrado.</returns>
        /// /// <response code ="200">Ok. Procedió al borrado satifactoriamente</response>
        /// <response code ="404">NotFound. No se ha encontrado el objeto solicitado</response>
        /// <response code ="500">Internal server error</response>
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest(ModelState);
            }
            else
                try
                {
                    {
                        return Ok("Delete Ok!");
                }
            }
            catch (Exception ex) { return InternalServerError(ex); } 

        }

        /// <summary>
        /// Actualiza un objeto Shipper
        /// </summary>
        /// <param name="shipperView"></param>
        /// <returns>Objeto shipper</returns>
        /// /// <response code ="200">Ok. Devuelve el objetos solicitados</response>
        /// <response code ="404">NotFound. No se ha encontrado el objeto solicitado</response>
        /// <response code ="500">Internal server error</response>
        public IHttpActionResult PatchEdit(ShippersView shipperView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    Shippers shipper = new Shippers
                    {
                        ShipperID = shipperView.Id,
                        CompanyName = shipperView.Nombre,
                        Phone = shipperView.Telefono
                    };
                    shippersLogic.Update(shipper);
                    return Ok("Update Ok!");
                }
                catch (Exception ex) { return InternalServerError(ex); }


            }
        }

    }
}
