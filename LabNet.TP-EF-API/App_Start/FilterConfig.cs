﻿using System.Web;
using System.Web.Mvc;

namespace LabNet.TP_EF_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
