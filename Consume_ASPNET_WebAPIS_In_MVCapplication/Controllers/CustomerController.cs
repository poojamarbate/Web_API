using Consume_ASPNET_WebAPIS_In_MVCapplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Consume_ASPNET_WebAPIS_In_MVCapplication.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<Customer> cust = new List<Customer>();
            client.BaseAddress = new Uri("http://localhost:52835/api/CustomerApi");
            var response = client.GetAsync("CustomerApi");
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var disply = test.Content.ReadAsAsync<List<Customer>>();
                disply.Wait();
               cust = disply.Result;
            }
            return View(cust);
        }
    }
}