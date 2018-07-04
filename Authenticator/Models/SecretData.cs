using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authenticator.Models
{
    public class AuthData
    {

        private static string EndpointAuthorize;
        private static string AccessToken;
        private static string TokenInfo;
        private static string clienteID;
        private static string clientSecret;

        public static String AuthoUrl
        {
            get
            {
                EndpointAuthorize = "http://ec2-54-87-197-49.compute-1.amazonaws.com/web/authorize";
                return EndpointAuthorize;
            }
        }

        public static String Token
        {
            get
            {
                AccessToken = "http://ec2-54-87-197-49.compute-1.amazonaws.com/v1/oauth/tokens";
                return AccessToken;
            }
        }

        public static String TInfo
        {
            get
            {
                TokenInfo = "http://ec2-54-87-197-49.compute-1.amazonaws.com/v1/oauth/introspect"; 
                return TokenInfo;
            }
        }

        public static String ClientID
        {
            get
            {
                clienteID = "grupo_nro7_client";
                return clienteID;
            }
        }

        public static String ClienteSecret
        {
            get
            {
                clientSecret = "test_secret";
                return clientSecret;
            }
        }




        public class SecretData
        {
        }
    }
}