using System.Web;
using System.Web.Optimization;

namespace FitnessproWebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
            //template js files
            bundles.Add(new ScriptBundle("~/Theme/jquery").Include(
                      "~/Theme/app-assets/vendors/js/vendors.min.js",
                      "~/Theme/app-assets/js/core/app-menu.js",
                      "~/Theme/app-assets/js/core/app.js",
                      "~/Theme/app-assets/vendors/js/forms/icheck/icheck.min.js",
                      "~/Theme/app-assetsvendors/js/forms/validation/jqBootstrapValidation.js",
                      "~/Theme/app-assets/js/scripts/forms/form-login-register.js",
                      "~/Theme/app-assets/vendors/js/charts/raphael-min.js",
                      "~/Theme/app-assets/vendors/js/charts/morris.min.js",
                      "~/Theme/app-assets/vendors/js/extensions/unslider-min.js",
                      "~/Theme/app-assets/vendors/js/timeline/horizontal-timeline.js",
                      "~/Theme/app-assets/js/scripts/pages/dashboard-ecommerce.js",
                      "~/Theme/app-assets/vendors/js/tables/datatable/datatables.min.js",
                      "~/Theme/app-assets/vendors/js/tables/datatable/dataTables.fixedHeader.min.js",
                      "~/Theme/app-assets/vendors/js/tables/datatable/dataTables.keyTable.min.js",
                      "~/Theme/app-assets/js/scripts/tables/datatables-extensions/datatable-keytable.js",
                      "~/Theme/app-assets/js/scripts/forms/checkbox-radio.js",
                      "~/Theme/app-assets/vendors/js/pickers/dateTime/moment-with-locales.min.js",
                      "~/Theme/app-assets/vendors/js/pickers/dateTime/bootstrap-datetimepicker.min.js",
                      "~/Theme/app-assets/vendors/js/pickers/pickadate/picker.js",
                      "~/Theme/app-assets/vendors/js/pickers/pickadate/picker.date.js",
                      "~/Theme/app-assets/vendors/js/pickers/pickadate/picker.time.js",
                      "~/Theme/app-assets/vendors/js/pickers/pickadate/legacy.js",
                      "~/Theme/app-assets/vendors/js/pickers/daterange/daterangepicker.js",
                      "~/Theme/app-assets/js/scripts/pickers/dateTime/bootstrap-datetime.js",
                      "~/Theme/app-assets/js/scripts/pickers/dateTime/pick-a-datetime.js",
                      "~/Theme/app-assets/js/scripts/navs/navs.js",
                      "~/Theme/app-assets/vendors/js/forms/validation/jqBootstrapValidation.js",
                      "~/Theme/app-assets/js/scripts/forms/validation/form-validation.js"
                      )) ;
            
            //Template scripts and css
            bundles.Add(new StyleBundle("~/Theme/css").Include(
                      "~/Theme/app-assets/vendors/css/vendors.min.css",
                      "~/Theme/app-assets/css/bootstrap.css",
                      "~/Theme/app-assets/css/colors.css",
                      "~/Theme/app-assets/css/components.css",
                      "~/Theme/app-assets/css/core/menu/menu-types/vertical-menu.css",
                      "~/Theme/app-assets/css/core/colors/palette-gradient.css",
                      "~/Theme/assets/css/style.css",
                      "~/Theme/app-assets/css/bootstrap-extended.css",
                      "~/Theme/app-assets/vendors/css/forms/icheck/icheck.css",
                      "~/Theme/app-assets/vendors/css/forms/icheck/custom.css",
                      "~/Theme/app-assets/css/pages/login-register.css",
                      "~/Theme/app-assets/vendors/css/extensions/unslider.css",
                      "~/Theme/app-assets/vendors/css/weather-icons/climacons.min.css",
                      "~/Theme/app-assets/fonts/meteocons/style.css",
                      "~/Theme/app-assets/vendors/css/charts/morris.css",
                      "~/Theme/app-assets/fonts/simple-line-icons/style.css",
                      "~/Theme/app-assets/css/pages/timeline.css",
                      "~/Theme/app-assets/vendors/css/tables/datatable/datatables.min.css",
                      "~/Theme/app-assets/vendors/css/tables/datatable/select.dataTables.min.css",
                      "~/Theme/app-assets/vendors/css/tables/extensions/keyTable.dataTables.min.css",
                      "~/Theme/app-assets/css/plugins/forms/checkboxes-radios.css",
                      "~/Theme/app-assets/vendors/css/pickers/daterange/daterangepicker.css",
                      "~/Theme/app-assets/vendors/css/pickers/datetime/bootstrap-datetimepicker.css",
                      "~/Theme/app-assets/vendors/css/pickers/pickadate/pickadate.css",
                      "~/Theme/app-assets/css/plugins/pickers/daterange/daterange.css",
                      "~/Theme/app-assets/css/plugins/forms/validation/form-validation.css"
                      ));
        }
    }
}
