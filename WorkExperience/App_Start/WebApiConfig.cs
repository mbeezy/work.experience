﻿using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WorkExperience
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API Routes
            config.MapHttpAttributeRoutes();

            // Configure Json Formatter
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Enable CORS
            config.EnableCors();

            // Set Routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}