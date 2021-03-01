using System.Web;
using System.Web.Mvc;

namespace N01432018_Assignment2_J1problem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
