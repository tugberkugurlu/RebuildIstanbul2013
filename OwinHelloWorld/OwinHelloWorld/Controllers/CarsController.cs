using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OwinHelloWorld.Controllers
{
    public class CarsController : ApiController
    {
        public string[] Get()
        {
            return new[] 
            { 
                "Car 1",
                "Car 2",
                "Car 3"
            };
        }
    }
}