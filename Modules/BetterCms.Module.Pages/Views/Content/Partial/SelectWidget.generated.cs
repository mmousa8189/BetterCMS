﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
    
    #line 1 "..\..\Views\Content\Partial\SelectWidget.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Content\Partial\SelectWidget.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Content\Partial\SelectWidget.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Content\Partial\SelectWidget.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/Partial/SelectWidget.cshtml")]
    public partial class _Views_Content_Partial_SelectWidget_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Widgets.SelectWidgetViewModel>
    {
        public _Views_Content_Partial_SelectWidget_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-top-block-holder\"");

WriteLiteral(">\r\n");

            
            #line 9 "..\..\Views\Content\Partial\SelectWidget.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Content\Partial\SelectWidget.cshtml"
     if ((ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.Administration))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-btn-links-main\"");

WriteLiteral(" id=\"bcms-create-advanced-content-button\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Content\Partial\SelectWidget.cshtml"
                                                                             Write(PagesGlobalization.AddPageContent_WidgetTab_AddNewButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-btn-links-main\"");

WriteLiteral(" id=\"bcms-registeradvanced-content-button\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Content\Partial\SelectWidget.cshtml"
                                                                              Write(PagesGlobalization.AddPageContent_WidgetTab_RegisterButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 13 "..\..\Views\Content\Partial\SelectWidget.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"bcms-advanced-content-search\"");

WriteLiteral(" class=\"bcms-editor-field-box\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 844), Tuple.Create("\"", 893)
            
            #line 15 "..\..\Views\Content\Partial\SelectWidget.cshtml"
                         , Tuple.Create(Tuple.Create("", 858), Tuple.Create<System.Object, System.Int32>(RootGlobalization.WaterMark_Search
            
            #line default
            #line hidden
, 858), false)
);

WriteLiteral(" />\r\n        <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-advanced-content-search-btn\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\Content\Partial\SelectWidget.cshtml"
                                                                      Write(PagesGlobalization.AddPageContent_WidgetTab_SearchButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"bcms-content-sliders\"");

WriteLiteral(" id=\"bcms-advanced-contents-container\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 20 "..\..\Views\Content\Partial\SelectWidget.cshtml"
   Write(Html.Partial("~/Areas/bcms-pages/Views/Content/Partial/WidgetRecent.cshtml", Model.RecentWidgets));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 21 "..\..\Views\Content\Partial\SelectWidget.cshtml"
   Write(Html.Partial("~/Areas/bcms-pages/Views/Content/Partial/WidgetCategories.cshtml", Model.WidgetCategories));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
