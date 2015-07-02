using System.Web;
using System.Web.Mvc;

namespace TDTK.PlatForm.MVC4.WebUI.Portal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}