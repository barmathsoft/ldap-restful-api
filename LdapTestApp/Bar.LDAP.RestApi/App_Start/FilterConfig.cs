﻿using System.Web;
using System.Web.Mvc;

namespace Bar.LDAP.RestApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
