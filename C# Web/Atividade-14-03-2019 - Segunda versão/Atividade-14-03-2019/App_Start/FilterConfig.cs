﻿using System.Web;
using System.Web.Mvc;

namespace Atividade_14_03_2019
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
