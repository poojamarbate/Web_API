using System.Web;
using System.Web.Mvc;

namespace Consume_ASPNET_WebAPIS_In_MVCapplication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
