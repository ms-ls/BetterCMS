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

namespace BetterCms.Module.Pages.Views.Content
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
    
    #line 1 "..\..\Views\Content\EditPageHtmlContent.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Content\EditPageHtmlContent.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Content\EditPageHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Content\EditPageHtmlContent.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/EditPageHtmlContent.cshtml")]
    public partial class EditPageHtmlContent : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Content.PageContentViewModel>
    {
        public EditPageHtmlContent()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Content\EditPageHtmlContent.cshtml"
 if (Model == null)
{
    return;
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-tab-header\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" class=\"bcms-tab bcms-tab-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                           Write(PagesGlobalization.EditPageContent_RegularContentTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 16 "..\..\Views\Content\EditPageHtmlContent.cshtml"
Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 17 "..\..\Views\Content\EditPageHtmlContent.cshtml"
Write(Html.Partial("Partial/WarnMessageAboutDraft", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"bcms-padded-content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Views\Content\EditPageHtmlContent.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Content\EditPageHtmlContent.cshtml"
             using (Html.BeginForm<ContentController>(c => c.SavePageHtmlContent(null), FormMethod.Post, 
                new
                    {
                        @id = "bcms-content-form", 
                        @class = "bcms-ajax-form",
                        data_readonly = Model.IsReadOnly.ToString().ToLowerInvariant()
                    }))
            {  
                
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.Partial("Partial/EditHtmlContent", Model));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                               
                
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.Id, new { @id = "bcmsPageContentId"}));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                                                    
                
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.Version));

            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                       
                
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.ContentVersion, new { @id = "bcmsPageContentVersion"}));

            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                                                                     
                
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.ContentId, new { @id = "bcmsContentId"}));

            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                                                       
                
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.ParentPageContentId, new { @id = "bcmsParentPageContentId" }));

            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                                                                            
                
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.PageId));

            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                      
                
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.RegionId, new { @id = "bcmsContentToRegionId" }));

            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                                                                               
                
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(modal => modal.DesirableStatus, new { @class = "bcms-content-desirable-status" }));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                                                                                 
                
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(modal => modal.IsUserConfirmed, new { @id = "bcms-user-confirmed-region-deletion" }));

            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                                                                                    
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
