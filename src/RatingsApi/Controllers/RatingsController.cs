using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Fabric;

namespace RatingsApi.Controllers
{
    [Route("api/[controller]")]
    public class RatingsController : Controller
    {
        // GET api/ratings
        [HttpGet]
        public string Get()
        {
            string ratingsApiVersion = FabricRuntime.GetActivationContext().CodePackageVersion;
            return $"Exécution de RatingsApi en version {ratingsApiVersion}. \r\n Context : {FabricRuntime.GetNodeContext().IPAddressOrFQDN} - {FabricRuntime.GetNodeContext().NodeName} - {FabricRuntime.GetNodeContext().NodeId} - {FabricRuntime.GetNodeContext().NodeInstanceId}";
        }
    }
}
