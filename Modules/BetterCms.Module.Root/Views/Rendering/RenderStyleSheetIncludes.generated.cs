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

namespace BetterCms.Module.Root.Views.Rendering
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Rendering/RenderStyleSheetIncludes.cshtml")]
    public partial class RenderStyleSheetIncludes : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Rendering.RenderStyleSheetIncludesViewModel>
    {
        public RenderStyleSheetIncludes()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Rendering\RenderStyleSheetIncludes.cshtml"
 foreach(var file in Model.StyleSheetFiles)
{

            
            #line default
            #line hidden
WriteLiteral("    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteAttribute("href", Tuple.Create(" href=\"", 175), Tuple.Create("\"", 200)
            
            #line 4 "..\..\Views\Rendering\RenderStyleSheetIncludes.cshtml"
, Tuple.Create(Tuple.Create("", 182), Tuple.Create<System.Object, System.Int32>(Url.Content(file)
            
            #line default
            #line hidden
, 182), false)
);

WriteLiteral(" />\r\n");

            
            #line 5 "..\..\Views\Rendering\RenderStyleSheetIncludes.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
