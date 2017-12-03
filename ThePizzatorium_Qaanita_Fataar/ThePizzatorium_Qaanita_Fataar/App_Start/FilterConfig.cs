using System.Web;
using System.Web.Mvc;

namespace ThePizzatorium_Qaanita_Fataar
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
