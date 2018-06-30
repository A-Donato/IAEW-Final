using SOAP_Service;
using Microsoft.AspNetCore.Mvc;
using Clases;
using System;
using System.Collections.Generic;

namespace RestApi.Controllers
{
    [Produces("application/json")]
    [Route("api/vehiculos")]
    public class VehiculosController : Controller
    {
        // GET api/vehiculos/1/
        [HttpGet, Route("{ciudad}/")]
        public JsonResult ConsultarVehiculosDisponibles([FromRoute] int ciudad, DateTime fechaDesde, DateTime fechaHasta)
        {
            var service = WService.Service;
            var req = new ConsultarVehiculosRequest();
            req.IdCiudad = ciudad;
            req.FechaHoraRetiro = fechaDesde;
            req.FechaHoraDevolucion = fechaHasta;

            var result = service.ConsultarVehiculosDisponiblesAsync(WService.Credential, req);

           // if (!result.IsCompleted) esto no valida equisde
            //{
            //    return Json("No se han encontrado vehiculos para esa ciudad y fechas");
            //}

            List<VehiculoModel> listaVehiculos = new List<VehiculoModel>();
            foreach (VehiculoModel ve in result.Result.ConsultarVehiculosDisponiblesResult.VehiculosEncontrados)
            {
                ve.PrecioPorDia = ve.PrecioPorDia * (decimal)1.20;

                listaVehiculos.Add(ve);
            }

            return Json(listaVehiculos);
        }

    }
}