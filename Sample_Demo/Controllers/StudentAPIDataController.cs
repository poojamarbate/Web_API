using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample_Demo.Controllers
{
    public class StudentAPIDataController : ApiController
    {
        public string[] names = { "pooja", "ishu", "Shubh", "sujuu", "nick" };
        [HttpGet]
        public string[] GetAllNames()
        {
            return names;
        }
        public string GetNamesBYId(int id)
        {
            return names[id];
        }
    }
}
