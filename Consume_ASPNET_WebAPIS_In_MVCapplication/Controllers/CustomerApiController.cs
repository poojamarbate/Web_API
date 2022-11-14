using Consume_ASPNET_WebAPIS_In_MVCapplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Consume_ASPNET_WebAPIS_In_MVCapplication.Controllers
{
    public class CustomerApiController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();
       [HttpGet]
        public IHttpActionResult Action()
        {
            List<Customer> cust = db.Customers.ToList();
            return Ok(cust);
        }

        [HttpGet]
        public IHttpActionResult Index(string id)
        {
            var cust = db.Customers.Where(model => model.CustomerID.Equals(id)).FirstOrDefault();
            return Ok(cust);
        }
    }
}
