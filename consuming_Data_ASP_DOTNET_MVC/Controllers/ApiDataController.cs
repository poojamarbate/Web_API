using consuming_Data_ASP_DOTNET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace consuming_Data_ASP_DOTNET_MVC.Controllers
{
    public class ApiDataController : ApiController
    {
        ADO_DbEntities db = new ADO_DbEntities();
       [HttpGet]
        public IHttpActionResult Action()
        {
            List<StudentTable> st = db.StudentTables.ToList();
            return Ok(st);
        }
        [HttpGet]
        public IHttpActionResult Index(int id)
        {
            var st = db.StudentTables.Where(model => model.UserId == id).FirstOrDefault();
            return Ok(st);
        }

    }
}
