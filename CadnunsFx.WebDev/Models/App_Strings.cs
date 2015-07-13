using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CadnunsFx.WebDev
{
    public class App_Strings
    {
        public static string ConnString = ConfigurationManager.ConnectionStrings["CadnunsDev"].ConnectionString;

    }
}