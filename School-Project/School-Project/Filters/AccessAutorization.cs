using School_Project.Entities;
using System.Web;

namespace School_Project.Filters
{
    public class AccessAutorization
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