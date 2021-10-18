using System.Web.Optimization;

namespace Tenfold {
    public static class BundleConfig {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles
                .Add(new ScriptBundle("~/assets/scriptj")
                    .Include("~/node_modules/jquery/dist/jquery.js"));

            bundles
                .Add(new ScriptBundle("~/assests/scriptb")
                    .Include("~/node_modules/bootstrap/dist/js/bootstrap.js"));

            bundles
                .Add(new StyleBundle("~/assets/styleb")
                    .Include("~/node_modules/bootstrap/dist/css/bootstrap.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}