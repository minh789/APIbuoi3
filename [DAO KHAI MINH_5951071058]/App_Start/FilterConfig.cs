using System.Web;
using System.Web.Mvc;

namespace _DAO_KHAI_MINH_5951071058_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
