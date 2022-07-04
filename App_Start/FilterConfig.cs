using System.Web;
using System.Web.Mvc;

namespace ApplicacionWebparaEva3TT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
