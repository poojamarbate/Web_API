using SQL_Server_API_using_DBFirst_approach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SQL_Server_API_using_DBFirst_approach.Controllers
{
    public class EmployeesDataController : ApiController
    {
        ADO_DbEntities db = new ADO_DbEntities();

      [HttpGet]
        public IHttpActionResult Action()
        {
            List<employee> emp = db.employees.ToList();
            return Ok(emp);
        }

        [HttpGet]
        public IHttpActionResult Index(int id)
        {
            var emp = db.employees.Where(model=>model.EmpID == id).FirstOrDefault();
            return Ok(emp);
        }
    }
}
