using System.Web;
using System.Web.Mvc;

namespace Software_Requirement_System_Jashan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
