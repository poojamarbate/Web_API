using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_With_Sql_Server.Models;

namespace WebAPI_With_Sql_Server.Controllers
{
    public class StudentAPIController : ApiController
    {
        ADO_DbEntities db = new ADO_DbEntities();

       [HttpGet]
        public IHttpActionResult Action()
        {
            List<StudentTable> obj = db.StudentTables.ToList();
            return Ok(obj);
        }
        public IHttpActionResult Action(int id)
        {
           var obj = db.StudentTables.Where(model => model.UserId == id).FirstOrDefault();
            return Ok(obj);
        }
    }
}
