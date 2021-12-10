using System.Web;
using System.Web.Mvc;

namespace T2009M_NGUYENHAIDANG_TEST
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
