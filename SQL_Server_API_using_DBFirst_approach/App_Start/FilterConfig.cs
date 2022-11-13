using System.Web;
using System.Web.Mvc;

namespace SQL_Server_API_using_DBFirst_approach
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
