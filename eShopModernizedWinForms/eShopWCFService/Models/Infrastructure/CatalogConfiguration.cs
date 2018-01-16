using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace eShopWCFService.Models.Infrastructure
{
    public class CatalogConfiguration
    {
        private static readonly string configConnectionName = "EntityModel";

        public static string ConnectionString
        {
            get
            {
								//var envConnectionString = Environment.GetEnvironmentVariable("ConnectionString");
								var envConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                return envConnectionString ?? $"name={configConnectionName}";
            }
        }
    }
}