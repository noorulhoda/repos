using System.Web;
using System.Web.Mvc;

namespace mvcday777
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
           // filters.Add(new OutputCacheAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
