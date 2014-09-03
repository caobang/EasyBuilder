using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace EasyBuilder
{
    public class BundleConfig
    {
        // 有关 Bundling 的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Scripts/easybuilder/css").Include(
                        "~/Scripts/easybuilder/jquery-easyui-1.3.5/themes/default/easyui.css",
                        "~/Scripts/easybuilder/jquery-easyui-1.3.5/themes/icon.css",
                        "~/Scripts/easybuilder/easybuilder.css"));

            bundles.Add(new ScriptBundle("~/Scripts/easybuilder/js").Include(
                        "~/Scripts/easybuilder/jquery-easyui-1.3.5/jquery.min.js",
                        "~/Scripts/easybuilder/jquery-easyui-1.3.5/jquery.easyui.min.js",
                        "~/Scripts/easybuilder/jquery-easyui-1.3.5/locale/easyui-lang-zh_CN.js",
                        "~/Scripts/easybuilder/easybuilder.js"));

        }
    }
}