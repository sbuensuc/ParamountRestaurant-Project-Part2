﻿using System.Web;
using System.Web.Mvc;

namespace ParamountRestaurant_Project_Part2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
