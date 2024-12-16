using System.Web;
using System.Web.Mvc;

namespace _2021604440_HoangXuanQuy_OntapTuan13
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
