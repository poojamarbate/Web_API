using System.Web;
using System.Web.Mvc;

namespace consuming_Data_ASP_DOTNET_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
