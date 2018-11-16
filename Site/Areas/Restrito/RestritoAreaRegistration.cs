using System.Web.Mvc;

namespace Site.Areas.Restrito
{
    public class RestritoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Restrito";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Restrito_default",
                "Restrito/{controller}/{action}/{id}",
                new { controller = "Inicio", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}