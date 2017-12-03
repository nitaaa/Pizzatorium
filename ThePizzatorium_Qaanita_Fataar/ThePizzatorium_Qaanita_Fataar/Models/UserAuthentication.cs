using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThePizzatorium_Qaanita_Fataar.Models
{
    public class UserAuthentication : ActionFilterAttribute
    {
        public bool NeedsAdmin { get; set; }
        public bool NeedsLogin { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool needsAdmin = NeedsAdmin;
            bool needsLogin = NeedsLogin;

            User currentUser = filterContext.HttpContext.Session["User"] as User;
            bool IsLoggedIn = filterContext.HttpContext.Session["IsLoggedIn"] as bool? ?? false;

            if (!IsLoggedIn)
            {
                if (needsLogin || needsAdmin)
                {
                    filterContext.HttpContext.Session["RedirectURL"] = filterContext.HttpContext.Request.Url.AbsolutePath;
                    filterContext.Result = new RedirectResult("/Account/Login");
                }
            }
            else
            {
                if (needsAdmin && !currentUser.IsAdmin)
                {
                    filterContext.Result = new RedirectResult("/Home");
                }


            }
        }
    }
}