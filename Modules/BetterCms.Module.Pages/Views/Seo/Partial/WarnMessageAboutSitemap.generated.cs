﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Pages.Views.Seo.Partial
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Seo\Partial\WarnMessageAboutSitemap.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Seo/Partial/WarnMessageAboutSitemap.cshtml")]
    public partial class WarnMessageAboutSitemap : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Seo.EditSeoViewModel>
    {
        public WarnMessageAboutSitemap()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\Seo\Partial\WarnMessageAboutSitemap.cshtml"
 if (!Model.IsInSitemap)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-messages-type-1\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" class=\"bcms-success-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        </ul>\r\n        <ul");

WriteLiteral(" class=\"bcms-info-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        </ul>\r\n        <ul");

WriteLiteral(" class=\"bcms-warning-messages\"");

WriteLiteral(">\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 14 "..\..\Views\Seo\Partial\WarnMessageAboutSitemap.cshtml"
           Write(PagesGlobalization.EditSeo_Messages_NotInSitemapWarnMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n        </ul>\r\n        <ul");

WriteLiteral(" class=\"bcms-error-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        </ul>\r\n    </div>\r\n");

            
            #line 20 "..\..\Views\Seo\Partial\WarnMessageAboutSitemap.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
