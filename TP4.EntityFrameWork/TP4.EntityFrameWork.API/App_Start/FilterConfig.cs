using System.Web;
using System.Web.Mvc;

namespace TP4.EntityFrameWork.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
