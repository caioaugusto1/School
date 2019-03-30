using School_Project.Entities;
using System.Web;

namespace School_Project.Filters
{
    public class SessionManager
    {
        public static Login AccountLogin
        {
            set
            {

                HttpContext.Current.Session.Add("AccountLogin", value);
            }
            get
            {
                return (Login)HttpContext.Current.Session["AccountLogin"];
            }

        }

        public static bool IsAuthenticated
        {
            get
            {
                return ((Login)HttpContext.Current.Session["AccountLogin"]) != null;
            }
        }
    }
}