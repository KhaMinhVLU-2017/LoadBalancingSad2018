using System.Web;
using System.Web.Mvc;

namespace UI_Candidate_Second
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
