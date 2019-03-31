using School_Project.Entities;
using System.Web;
using System.Web.Mvc;

namespace School_Project.Filters
{
    public class AccessAutorization : AuthorizeAttribute
    {
        public static bool IsPermission
        {
            get
            {
                return ((Login)HttpContext.Current.Session["AccountLogin"]) != null;
            }
        }
    }
}