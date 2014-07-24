﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Blog.Views.BlogML
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
    
    #line 1 "..\..\Views\BlogML\UploadImportFile.cshtml"
    using BetterCms.Module.Blog.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\BlogML\UploadImportFile.cshtml"
    using BetterCms.Module.Blog.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\BlogML\UploadImportFile.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\BlogML\UploadImportFile.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BlogML/UploadImportFile.cshtml")]
    public partial class UploadImportFile : System.Web.Mvc.WebViewPage<BetterCms.Module.Blog.ViewModels.Blog.UploadImportFileViewModel>
    {
        public UploadImportFile()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 10 "..\..\Views\BlogML\UploadImportFile.cshtml"
Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");

            
            #line 13 "..\..\Views\BlogML\UploadImportFile.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\BlogML\UploadImportFile.cshtml"
     using (Html.BeginForm<BlogMLController>(c => c.UploadImportFile(), FormMethod.Post, new { @enctype = "multipart/form-data", @id = "bcms-import-blog-posts", @target = "bcms-import-form-target", }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-padded-content\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n\r\n                <!-- ko if: uploaded() && !finished() -->\r\n                <" +
"h2>");

            
            #line 20 "..\..\Views\BlogML\UploadImportFile.cshtml"
               Write(BlogGlobalization.ImportBlogPosts_PleaseSelectPostsToImport_Message);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                <!-- /ko -->\r\n                <!-- ko if: finished() -->\r\n" +
"                <h2");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\BlogML\UploadImportFile.cshtml"
                                     Write(BlogGlobalization.ImportBlogPosts_ImportCompletedSuccessfully_Message);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                <!-- /ko -->\r\n                <!-- ko ifnot: uploaded() --" +
">\r\n                <div");

WriteLiteral(" id=\"bcms-files-dropzone\"");

WriteLiteral(" class=\"bcms-dropzone\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-dropzone-infotext\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\BlogML\UploadImportFile.cshtml"
                                                   Write(BlogGlobalization.ImportBlogPosts_File_Description);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-upload-files\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"uploadFile\"");

WriteLiteral(" class=\"bcms-btn-upload-files-text\"");

WriteLiteral(" data-bind=\"text: fixedFileName() || \'");

            
            #line 29 "..\..\Views\BlogML\UploadImportFile.cshtml"
                                                                                                                   Write(BlogGlobalization.ImportBlogPosts_File_ButtonTitle);

            
            #line default
            #line hidden
WriteLiteral("\'\"");

WriteLiteral("></label>\r\n                        <input");

WriteLiteral(" type=\"file\"");

WriteLiteral(" name=\"uploadFile\"");

WriteLiteral(" id=\"uploadFile\"");

WriteLiteral(" style=\"position: absolute; left: -999em; top: -999em;\"");

WriteLiteral(" data-bind=\"value: fileName\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"bcms-download-sample-file\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"/file/bcms-blog/Content/example.blog.post.import.xml\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 33 "..\..\Views\BlogML\UploadImportFile.cshtml"
                                                                                                  Write(BlogGlobalization.ImportBlogPosts_DownloadSampleFile_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n                <iframe" +
"");

WriteLiteral(" id=\"bcms-import-form-target\"");

WriteLiteral(" name=\"bcms-import-form-target\"");

WriteLiteral(" style=\"position: absolute; left: -999em; top: -999em;\"");

WriteLiteral("></iframe>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-bind=\"checked: createRedirects\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 41 "..\..\Views\BlogML\UploadImportFile.cshtml"
                                                Write(Html.Raw(BlogGlobalization.ImportBlogPosts_CreateRedirects_Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n                <!-- " +
"/ko -->\r\n            </div>\r\n\r\n        </div>\r\n");

            
            #line 48 "..\..\Views\BlogML\UploadImportFile.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <!-- ko if: uploaded() -->\r\n");

WriteLiteral("        <table");

WriteLiteral(" class=\"bcms-tables\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n                    <th");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(" style=\"padding-left: 10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-bind=\"visible: !finished(), checked: checkedAll\"");

WriteLiteral(" /></th>\r\n                    <th");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">");

            
            #line 54 "..\..\Views\BlogML\UploadImportFile.cshtml"
                                               Write(BlogGlobalization.ImportBlogPosts_Results_Title_Title);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                    <th");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\BlogML\UploadImportFile.cshtml"
                                               Write(BlogGlobalization.ImportBlogPosts_Results_Url_Title);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                    <th");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">&nbsp;</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n " +
"               <!-- ko foreach: results() -->\r\n                <tr");

WriteLiteral(" data-bind=\"css: {\'bcms-import-failed\' : !success, \'bcms-import-success\': success" +
" && $parent.finished() && !skipped}\"");

WriteLiteral(">\r\n                    <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-bind=\"visible: success && !$parent.finished(), checked: checked\"");

WriteLiteral(" />\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(" data-bind=\"html: title, attr: {title: title}\"");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">\r\n                        <!-- ko if: success && !$parent.finished() -->\r\n      " +
"                  <span");

WriteLiteral(" data-bind=\"text: url, attr: {title: url}\"");

WriteLiteral("></span>\r\n                        <!-- /ko -->\r\n                        <!-- ko i" +
"f: success && $parent.finished() && !skipped -->\r\n                        <a");

WriteLiteral(" data-bind=\"text: url, attr: {title: url, href: url}\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral("></a>\r\n                        <!-- /ko -->\r\n                        <!-- ko if: " +
"success && $parent.finished() && skipped -->\r\n");

WriteLiteral("                        ");

            
            #line 74 "..\..\Views\BlogML\UploadImportFile.cshtml"
                   Write(BlogGlobalization.ImportBlogPosts_Skipped_Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <!-- /ko -->\r\n                        <!-- ko if: !succ" +
"ess -->\r\n                        <span");

WriteLiteral(" class=\"bcms-import-error\"");

WriteLiteral(" data-bind=\"text: errorMessage, attr: {title: errorMessage}\"");

WriteLiteral("></span>\r\n                        <!-- /ko -->\r\n                    </td>\r\n      " +
"              <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(@" data-bind=""attr: { title: errorMessage || warnMessage || '' }, css: {
                            'bcms-icn-import-success': success && !warnMessage && !skipped,
                            'bcms-icn-import-warn': success && warnMessage && !skipped,
                            'bcms-icn-import-error': !success }""");

WriteLiteral("></div>\r\n                    </td>\r\n                </tr>\r\n                <!-- /" +
"ko -->\r\n                <!-- ko if: results().length == 0 -->\r\n                <" +
"tr>\r\n                    <td");

WriteLiteral(" colspan=\"4\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"bcms-table-no-data\"");

WriteLiteral(">");

            
            #line 91 "..\..\Views\BlogML\UploadImportFile.cshtml"
                                                    Write(BlogGlobalization.ImportBlogPosts_ImportFileHasNoBlogs_Message);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n                <!-- /" +
"ko -->\r\n            </tbody>\r\n        </table>\r\n");

WriteLiteral("        <!-- /ko -->\r\n");

            
            #line 98 "..\..\Views\BlogML\UploadImportFile.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591