using System.Web;
using System.Web.Mvc;

namespace NguyenHuuDuc_2021604120
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
