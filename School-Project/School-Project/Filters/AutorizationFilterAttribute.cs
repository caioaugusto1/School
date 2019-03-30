using System.Web.Mvc;
using System.Web.Routing;

namespace School_Project.Filters
{
    public class AutorizationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object userLogin = filterContext.HttpContext.Session["AccountLogin"];

            if (userLogin == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "login",
                    action = "Index"
                }));
            }
        }
    }
}