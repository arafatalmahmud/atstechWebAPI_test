using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using atstechWebAPI_test.Models;

namespace atstechWebAPI_test.Controllers
{
    public class DevelopersController : ApiController
    {
         Developer[] developers = new Developer[] 
        { 
            new Developer { Name = "Arafat"},
            new Developer { Name = "Tomal"},
            new Developer { Name = "Sharif"}
        };

        public IEnumerable<Developer> GetAllDevelopers()
        {
            return developers;
        }

    }
}
