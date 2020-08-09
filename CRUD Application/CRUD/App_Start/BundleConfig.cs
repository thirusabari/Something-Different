using System.Web;
using System.Web.Optimization;

namespace CRUD
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/Jquery").Include(
						//"~/Scripts/Framework/jQuery/jquery-3.4.1.intellisense.js",
						"~/Scripts/Framework/jQuery/jquery-3.4.1.js",
						"~/Scripts/Framework/jQuery/jquery-3.4.1.min.js",
						"~/Scripts/Framework/jQuery/jquery-3.4.1.min.map",
						"~/Scripts/Framework/jQuery/jquery-3.4.1.slim.js",
						"~/Scripts/Framework/jQuery/jquery-3.4.1.slim.min.js",
						"~/Scripts/Framework/jQuery/jquery-3.4.1.slim.min.map",
						"~/Scripts/Framework/jQuery/jquery.validate-vsdoc.js",
						"~/Scripts/Framework/jQuery/jquery.validate.js",
						"~/Scripts/Framework/jQuery/jquery.validate.min.js",
						"~/Scripts/Framework/jQuery/jquery.validate.unobtrusive.js",
						"~/Scripts/Framework/jQuery/jquery.validate.unobtrusive.min.js"
						));

			bundles.Add(new ScriptBundle("~/bundles/Bootstrap").Include(
						"~/Scripts/Framework/Bootstrap/bootstrap.js",
						"~/Scripts/Framework/Bootstrap/bootstrap.min.js"
						));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/Framework").Include(
						"~/Scripts/Framework/knockout-3.5.1.js",
						"~/Scripts/Framework/modernizr-2.8.3.js"
						));
			bundles.Add(new StyleBundle("~/bundles/Application").Include(
				"~/Scripts/Application/*.js"
				));

			bundles.Add(new StyleBundle("~/bundles/Css").Include(
					  "~/Content/Bootstrap/bootstrap-theme.css",
					  "~/Content/Bootstrap/bootstrap-theme.css.map",
					  "~/Content/Bootstrap/bootstrap-theme.min.css",
					  "~/Content/Bootstrap/bootstrap-theme.min.css.map",
					  "~/Content/Bootstrap/bootstrap.css",
					  "~/Content/Bootstrap/bootstrap.css.map",
					  "~/Content/Bootstrap/bootstrap.min.css",
					  "~/Content/Bootstrap/bootstrap.min.css.map",
					  "~/Content/Site.css"
					  ));
		}
	}
}
