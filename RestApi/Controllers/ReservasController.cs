using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Model;
using SOAP_Service;
using RestSharp.Authenticators;
using RestSharp;
namespace RestApi.Controllers
    
{
    [AllowCrossSite]
    [Produces("application/json")]
    [Route("api/reservas")]
    public class ReservasController : Controller
    {
        private ReservaEntities _db = new ReservaEntities();


        // GET api/paises
        [HttpGet, Route("local")]
        public JsonResult ConsultarReservas()
        {
            Console.WriteLine("comenzamos --------------------------");
            try
            {
                if (_db.Reservas == null || !_db.Reservas.Any())
                {
                   
                    return Json(new object[] { new object() });
                }
                return Json(_db.Reservas);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("{0} Exception caught.", ex);
                return Json(ex);
            }
        }
        [HttpGet, Route("local/{codigoReserva}")]
        public JsonResult ConsultarReservas(String codigoReserva)
        {
            try
            {
                if (_db.Reservas == null || !_db.Reservas.Any())
                {
                    return Json(new object[] { new object() });
                }

                Reservas res = _db.Reservas.FirstOrDefault(p => p.CodigoReserva == codigoReserva);
                if (res == null)
                {
                    return Json(new object[] { new object() });
                }
                return Json(res);

            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
        [HttpGet, Route("proveedor/{codigoReserva}")]
        public JsonResult ConsultarReservasProveedor([FromRoute] string codigoReserva)
        {
            var service = WService.Service;
            var req = new ConsultarReservasRequest();
            var result = new ConsultarReservasResponse();
            req.CodigoReserva = codigoReserva;
            try
            {
                result = service.ConsultarReservaAsync(WService.Credential, req).Result.ConsultarReservaResult;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            return Json(result);
        }
        [AllowCrossSite]
        [HttpPost, Route("new")]
        public IActionResult CrearReserva([FromBody] SuperReserva res)
        {
            var service = WService.Service;
            var req = new ReservarVehiculoRequest();
            var result = new ReservarVehiculoResponse();
            Console.WriteLine("comenzamos --------------------------");
            req.ApellidoNombreCliente = res.ApellidoNombreCliente;
            req.FechaHoraDevolucion = res.FechaHoraDevolucion;
            req.FechaHoraRetiro = res.FechaHoraRetiro;
            req.IdVehiculoCiudad = res.IdVehiculoCiudad;
            req.LugarDevolucion = (LugarRetiroDevolucion)Enum.Parse(typeof(LugarRetiroDevolucion), res.LugarDevolucion);
            req.LugarRetiro = (LugarRetiroDevolucion)Enum.Parse(typeof(LugarRetiroDevolucion), res.LugarRetiro);
            req.NroDocumentoCliente = res.NroDocumentoCliente;

            try
            {
                Console.WriteLine("entramos al try");
                result = service.ReservarVehiculoAsync(WService.Credential, req).Result.ReservarVehiculoResult;
                Console.WriteLine(result.Reserva.CodigoReserva);
                Console.WriteLine(result.ToString());
                Console.WriteLine("hizo el request");
                Reservas newReserva = new Reservas()
                {
                    CodigoReserva = result.Reserva.CodigoReserva,
                    //CodigoReserva = "EUVMH",
                    FechaReserva = result.Reserva.FechaReserva,
                    IdCliente = result.Reserva.Id,
                    IdVendedor = result.Reserva.Id,
                    Costo = 10,
                    PrecioVenta = 20 ,
                    IdVehiculoCiudad = req.IdVehiculoCiudad,
                    IdCiudad = 1,
                    IdPais = 2,
                };

                if (_db.Reservas == null || !_db.Reservas.Any())
                {
                    return Json(new object[] { new object() });
                }
                if (res == null)
                {
                    return Json(new object[] { new object() });
                }

                _db.Reservas.Add(newReserva);

                _db.SaveChanges();


                return Json(newReserva.CodigoReserva);

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
                Console.WriteLine(result);
                return Json(ex);
            }
        }

        /*
            [HttpPut, Route("/edit")]
            public JsonResult Put(int codigoReserva, [FromBody]Reserva res)
            {
                try
                {
                    if (res == null)
                    {
                        return BadRequest();
                    }
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }
                    if ( codigoReserva != res.codigoReserva)
                    {
                        return BadRequest();
                    }
                    if (_db.Reserva.Count(e => e.Id == id) == 0)
                    {
                        return NotFound();
                    }
                    _db.Entry(res).State = System.Data.Entity.EntityState.Modified;

                    _db.SaveChanges();

                    return Ok(res);


                }
                catch (Exception ex)
                {

                    return InternalServerError(ex);
                }
            }*/
        [HttpDelete, Route("/delete/{codigoReserva}")]
        public JsonResult Delete([FromRoute] string codigoReserva)
        {
            var service = WService.Service;
            var req = new CancelarReservaRequest();
            req.CodigoReserva = codigoReserva;
            var result = new CancelarReservaResponse();

            var toBeDeleted = _db.Reservas.Find(codigoReserva);
            if (toBeDeleted == null)
            {
                return Json(result.Reserva);
            }
            _db.Reservas.Remove(toBeDeleted);
            _db.SaveChanges();
            try
            {
                result = service.CancelarReservaAsync(WService.Credential, req).Result.CancelarReservaResult;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);

            }
                return Json(result.Reserva);
        }




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}