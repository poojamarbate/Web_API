﻿using System.Web;
using System.Web.Mvc;

namespace WebAPI_With_Sql_Server
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
