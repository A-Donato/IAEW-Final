using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOAP_Service;

namespace Clases
{
    public class WService    {

        private static WCFReservaVehiculosClient _service;
        private static Credentials _cred;

        public static WCFReservaVehiculosClient Service
        {
            get
            {
                if (_service == null)
                    _service = new WCFReservaVehiculosClient();
                return _service;
            }
        }

        public static Credentials Credential
        {
            get
            {
                if (_cred == null)
                {
                    _cred = new Credentials();
                    _cred.UserName = "grupo_nro7";
                    _cred.Password = "WSbRKVdf";
                }
                return _cred;
            }
        }
        
        private WService()
        {

        }
    }
}