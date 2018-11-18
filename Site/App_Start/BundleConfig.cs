using System.Web.Optimization;

namespace Site.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/*.css",
                "~/Content/css/theme-color/default-theme.css"
                ));
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                "~/Content/js/*.js"
                ));

            bundles.Add(new StyleBundle("~/Areas/Restrito/Content/css").Include(
                "~/Areas/Restrito/Content/css/*.css",
                "~/Areas/Restrito/Content/css/bootstrap.min.css"
                ));
            bundles.Add(new ScriptBundle("~/Areas/Restrito/Content/js").Include(
                "~/Areas/Restrito/Content/js/*.js",
                "~/Areas/Restrito/Content/js/core/bootstrap.min.js",
                "~/Areas/Restrito/Content/js/core/jquery.3.2.1.min.js",
                "~/Areas/Restrito/Content/js/core/popper.min.js",
                "~/Areas/Restrito/Content/js/plugins/*.js",
                "~/Areas/Restrito/Content/js/plugins/chartist.min.js",
                "~/Areas/Restrito/Content/js/plugins/nouislider.min.js"
                ));

            BundleTable.EnableOptimizations = false;
        }
    }
}