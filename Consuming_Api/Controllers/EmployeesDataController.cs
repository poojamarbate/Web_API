using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Consuming_Api.Controllers
{
    public class EmployeesDataController : ApiController
    {
        public string[] names = { "pooja", "sujal", "ishan", "suraj" };
        public string[] GetEmployees()
        {
            return names;
        }
        public string GetEmployeeBbyIndex(int id)
        {
            return names[id];
        }
    }
}
