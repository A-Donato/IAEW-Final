using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Authenticator.Models;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;
using System.Text;
using RestSharp;

namespace Authenticator.Controllers
{
    [Produces("application/json")]
    [Route("api/Oauth")]
    public class OauthController : Controller
    {
        private static readonly HttpClient client = new HttpClient();


        // GET: api/Oauth
        [HttpGet]
        public async void Validation()
        {
            var url = AuthData.AuthoUrl;
            var query = url + "?scope=write&response_type=code&client_id='grupo_nro7_client'&redirect_uri=http://localhost:62904/";
            Console.WriteLine(query);
            var responseString = await client.GetStringAsync(query);
            Console.WriteLine(responseString);

            /* var client = new RestClient(AuthData.ClienteSecret);
             var request = new RestRequest(Method.POST);
             request.AddHeader("content-type", "application/json");
             request.AddParameter("application/json", "{\"grant_type\":\"authorization_code\",\"client_id\": \"grupo_nro7_client\",\"client_secret\": \"test_secret\",\"code\": \"YOUR_AUTHORIZATION_CODE\",\"redirect_uri\": \"https://YOUR_APP/callback\"}", ParameterType.RequestBody);
             IRestResponse response = client.Execute(request);
         }

         // GET: api/Oauth/5
         [HttpGet("{id}", Name = "Get")]
         public string Get(int id)
         {
             return "value";
         }

         // POST: api/Oauth
         [HttpPost]
         public void Post([FromBody]string value)
         {
         }

         // PUT: api/Oauth/5
         [HttpPut("{id}")]
         public void Put(int id, [FromBody]string value)
         {
         }

         // DELETE: api/ApiWithActions/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {

         }*/
        }
    }
}
