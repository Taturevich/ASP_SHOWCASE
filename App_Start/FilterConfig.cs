using System.Web;
using System.Web.Mvc;

namespace ASP_BUILD_SHOWCASE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
