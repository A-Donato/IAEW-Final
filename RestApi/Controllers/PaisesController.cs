using SOAP_Service;
using Microsoft.AspNetCore.Mvc;
using Clases;
using System;

namespace RestApi.Controllers
{ 
    [AllowCrossSite]
    [Produces("application/json")]
    [Route("api/paises")]
    public class PaisesController : Controller
    {
        // GET api/paises
        [HttpGet]
        public JsonResult ConsultarPaises()
        {
            var service = WService.Service;
            ConsultarPaisesResponse1 result = service.ConsultarPaisesAsync(WService.Credential).Result;

            return Json(result.ConsultarPaisesResult.Paises);
        }

        // GET api/paises/1/ciudades
        [HttpGet, Route("{pais}/ciudades")]
        public JsonResult ConsultarCiudades([FromRoute] int pais)
        {
            var service = WService.Service;

            var req = new ConsultarCiudadesRequest();
            
            req.IdPais = pais;

            var result = new ConsultarCiudadesResponse(); 
            try
            {
                result = service.ConsultarCiudadesAsync(WService.Credential, req).Result.ConsultarCiudadesResult;

            }catch(Exception e) {
                Console.WriteLine("{0} Exception caught.", e);
            }

            return Json(result.Ciudades);
        }
    }
}