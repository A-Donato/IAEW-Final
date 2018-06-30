using SOAP_Service;
using Microsoft.AspNetCore.Mvc;
using Clases;

namespace RestApi.Controllers
{
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

            var result = service.ConsultarCiudadesAsync(WService.Credential, req).Result.ConsultarCiudadesResult;

            return Json(result.Ciudades);
        }
    }
}