﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
    
    #line 1 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
    using BetterCms.Module.MediaManager.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MediaManager/Partial/MediaManagerFilterTemplate.cshtml")]
    public partial class _Views_MediaManager_Partial_MediaManagerFilterTemplate_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.MediaManager.ViewModels.MediaManager.MediaViewModel>
    {
        public _Views_MediaManager_Partial_MediaManagerFilterTemplate_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-filter-holder\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-grid-filtering\"");

WriteLiteral(" data-bind=\"css: { \'bcms-active-filter\': gridOptions().isFilterVisible() }\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-filterbox\"");

WriteLiteral(" data-bind=\"click: gridOptions().toggleFilter\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 8 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
       Write(RootGlobalization.Button_Filter);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-filter-modified\"");

WriteLiteral(" data-bind=\"style: { display: gridOptions().isEdited() ? \'inline-block\' : \'none\' " +
"}\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
                                                                                                                            Write(MediaGlobalization.SiteSettings_Media_FilterIsModified);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-filter-selection-block\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" data-bind=\"visible: gridOptions().isFilterVisible()\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-filter-controls\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-clearfix\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(" data-bind=\"with: gridOptions().tags\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
                                             Write(MediaGlobalization.SiteSettings_FilterByTags);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-field-holder\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-add-tags-field\"");

WriteLiteral(@" data-bind=""
                                    css: { 'bcms-tag-validation-error': newItem.hasError() },
                                    value: newItem,
                                    valueUpdate: 'afterkeydown',
                                    escPress: clearItem,
                                    autocompleteList: 'onlyExisting'""");

WriteLiteral(" />\r\n                        <!-- ko if: newItem.hasError() -->\r\n                " +
"        <span");

WriteLiteral(" class=\"bcms-tag-field-validation-error\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" data-bind=\"text: newItem.validationMessage()\"");

WriteLiteral("></span>\r\n                        </span>\r\n                        <!-- /ko -->\r\n" +
"                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(" data-bind=\"with: gridOptions().categories\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
                                             Write(MediaGlobalization.SiteSettings_FilterByCategory);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-field-holder\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-add-tags-field\"");

WriteLiteral(@" data-bind=""
                                    css: { 'bcms-tag-validation-error': newItem.hasError() },
                                    value: newItem,
                                    valueUpdate: 'afterkeydown',
                                    escPress: clearItem,
                                    autocompleteList: 'onlyExisting'""");

WriteLiteral(" />\r\n                        <!-- ko if: newItem.hasError() -->\r\n                " +
"        <span");

WriteLiteral(" class=\"bcms-tag-field-validation-error\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" data-bind=\"text: newItem.validationMessage()\"");

WriteLiteral("></span>\r\n                        </span>\r\n                        <!-- /ko -->\r\n" +
"                    </div>\r\n                </div>\r\n            </div>\r\n\r\n      " +
"      <div");

WriteLiteral(" class=\"bcms-single-tag-holder\"");

WriteLiteral(" data-bind=\"foreach: gridOptions().tags.items()\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-single-tag\"");

WriteLiteral(" data-bind=\"css: { \'bcms-single-tag-active\': isActive() }\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-bind=\"text: name()\"");

WriteLiteral("></span><a");

WriteLiteral(" data-bind=\"    click: remove\"");

WriteLiteral(">");

            
            #line 53 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
                                                                                      Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </div>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getItemInputName($index()) + \'.Key\', value: id() }\"");

WriteLiteral(" />\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getItemInputName($index()) + \'.Value\', value: name() }\"" +
"");

WriteLiteral(" />\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-single-tag-holder\"");

WriteLiteral(" data-bind=\"foreach: gridOptions().categories.items()\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-single-tag\"");

WriteLiteral(" data-bind=\"css: { \'bcms-single-tag-active\': isActive() }\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-bind=\"text: name()\"");

WriteLiteral("></span><a");

WriteLiteral(" data-bind=\"    click: remove\"");

WriteLiteral(">");

            
            #line 61 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
                                                                                      Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </div>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: \'Categories[\' + $index() + \'].Key\', value: id() }\"");

WriteLiteral(" />\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: \'Categories[\' + $index() + \'].Value\', value: name() }\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-clearfix\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-check-field-holder\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-check-field\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-bind=\"checked: gridOptions().includeArchived\"");

WriteLiteral(" />\r\n                </div>\r\n                <span");

WriteLiteral(" class=\"bcms-pointer\"");

WriteLiteral(" data-bind=\"click: gridOptions().changeIncludeArchived\"");

WriteLiteral(">");

            
            #line 73 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
                                                                                             Write(MediaGlobalization.MediaManager_IncludeArchived_Message);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-check-field-holder\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-check-field\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-bind=\"checked: gridOptions().includeHistoryItems\"");

WriteLiteral(" />\r\n                </div>\r\n                <span");

WriteLiteral(" class=\"bcms-pointer\"");

WriteLiteral(" data-bind=\"click: gridOptions().changeIncludeHistoryItems\"");

WriteLiteral(">");

            
            #line 80 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
                                                                                                 Write(MediaGlobalization.MediaManager_SearchInHistoryItems_Message);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-btn-field-holder\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-btn-links-small\"");

WriteLiteral(" data-bind=\"click: clearFilter\"");

WriteLiteral(">");

            
            #line 84 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
                                                                            Write(RootGlobalization.Button_Filter_Clear);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-btn-small\"");

WriteLiteral(" data-bind=\"click: searchWithFilter\"");

WriteLiteral(">");

            
            #line 85 "..\..\Views\MediaManager\Partial\MediaManagerFilterTemplate.cshtml"
                                                                           Write(RootGlobalization.Button_Filter_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
