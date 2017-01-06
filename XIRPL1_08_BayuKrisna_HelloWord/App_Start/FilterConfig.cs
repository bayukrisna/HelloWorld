using System.Web;
using System.Web.Mvc;

namespace XIRPL1_08_BayuKrisna_HelloWord
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
