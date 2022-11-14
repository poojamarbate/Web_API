using consuming_Data_ASP_DOTNET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace consuming_Data_ASP_DOTNET_MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<StudentTable> std = new List<StudentTable>();
            client.BaseAddress = new Uri("http://localhost:49684/api/ApiData");
            var response = client.GetAsync("ApiData");
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<StudentTable>>();
                display.Wait();
                std = display.Result;
            }

            return View(std);
        }
    }
}