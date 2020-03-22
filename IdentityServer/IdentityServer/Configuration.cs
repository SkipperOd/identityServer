using IdentityModel;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public static class Configuration
    {
        public static IEnumerable<ApiResource> GetApis()
        {
            return new List<ApiResource> { 
                new ApiResource("ApiOne"),
                new ApiResource("Client"),
            };
        }

        public static IEnumerable<Client> GetCLients()
        {
            return new List<Client> { new Client {
                ClientId = "client_id",
                ClientSecrets = {new Secret("client_secret".ToSha256()) },
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                AllowedScopes = { "ApiOne"}
            } ,new Client {
                ClientId = "client_id_Api",
                ClientSecrets = {new Secret("client_secret_Api".ToSha256()) },
                AllowedGrantTypes = GrantTypes.Code,
                AllowedScopes = { "ApiOne", "Client" }
            } ,
            };
        }
    }
}
