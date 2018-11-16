using System.Web.Optimization;

namespace Site.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/*.css"
                ));
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                "~/Content/js/*.js"
                ));
            BundleTable.EnableOptimizations = false;
        }
    }
}