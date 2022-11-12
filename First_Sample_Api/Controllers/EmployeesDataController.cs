using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace First_Sample_Api.Controllers
{
    public class EmployeesDataController : ApiController
    {
        public string[] name = { "ishan", "pooja", "sujal", "suraj" };
        [HttpGet]
        public string[] GetEmployee()
        {
            return name;
        }

        [HttpGet]
        public string GetEmployeeById(int id)
        {
            return name[id];
        }

    }
}
