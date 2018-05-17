using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_專案分層架構_Part._1_20180517
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
