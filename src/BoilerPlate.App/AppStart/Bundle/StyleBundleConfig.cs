using System.Web.Optimization;

namespace BoilerPlate.App.AppStart.Bundle
{
    public class StyleBundleConfig : StyleBundle
    {
        public StyleBundleConfig()
            : base("~/Styles/app-css")
        {
            IncludeDirectory("~/Content/css/app", "*.css", true);
        }
    }
}