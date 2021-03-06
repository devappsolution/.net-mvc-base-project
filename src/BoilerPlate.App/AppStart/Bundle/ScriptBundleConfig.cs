﻿using System.Web.Optimization;

namespace BoilerPlate.App.AppStart.Bundle
{
    public class ScriptBundleConfig : ScriptBundle
    {
        public ScriptBundleConfig()
            : base("~/Scripts/app-js")
        {
            IncludeDirectory("~/Scripts/Modules", "*.js", true);
            IncludeDirectory("~/Scripts/Services", "*.js", true);
            IncludeDirectory("~/Scripts/Locale", "*.js", true);
            IncludeDirectory("~/Scripts/Controllers", "*.js", true);
        }
    }
}