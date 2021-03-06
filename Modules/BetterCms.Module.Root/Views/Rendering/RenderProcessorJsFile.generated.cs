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
    
    #line 28 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Rendering/RenderProcessorJsFile.cshtml")]
    public partial class _Views_Rendering_RenderProcessorJsFile_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Rendering.RenderProcessorJsViewModel>
    {
        public _Views_Rendering_RenderProcessorJsFile_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("/*jslint unparam: true, white: true, browser: true, devel: true */\r\n/*global bett" +
"ercms */\r\n\r\nbettercms.define(\'bcms.processor\', [");

            
            #line 34 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
                               Write(Model.JavaScriptModules.RenderCommaSeparatedNames());

            
            #line default
            #line hidden
WriteLiteral("], function (");

            
            #line 34 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
                                                                                                Write(Model.JavaScriptModules.RenderCommaSeparatedFriendlyNames());

            
            #line default
            #line hidden
WriteLiteral(") {\r\n    \'use strict\';\r\n    \r\n    var $ = bettercms.require(\'bcms.jquery\'),\r\n\r\n  " +
"      processor = {},\r\n\r\n        selectors = {\r\n            onClickModuleAction:" +
" \'.bcms-onclick-action\',\r\n            onChangeModuleAction: \'.bcms-onchange-acti" +
"on\'\r\n        },\r\n\r\n        externalModules  = [];\r\n    \r\n    processor.init = fu" +
"nction() {\r\n        initializeLinks();\r\n        initializeGlobalization();    \r\n" +
"        registerExternalModules();\r\n        initializeModuleActionHandlers();\r\n " +
"   };\r\n    \r\n    processor.executeModuleAction = function(moduleName, actionStri" +
"ng, sender) {\r\n        try\r\n        {\r\n            if (actionString.lastIndexOf(" +
"\'()\') < 0) {\r\n                actionString = actionString + \'(sender)\';\r\n       " +
"     }\r\n            var f = new Function(\"module\", \"sender\", \"module.\" + actionS" +
"tring);\r\n            f.call(this, externalModules[moduleName], sender);\r\n       " +
" }\r\n        catch (ex)\r\n        {\r\n            bcms.logger.error(\'Failed to exec" +
"ute action \' + moduleName + \'.\' + actionString + \'. \' + ex.message);\r\n        }\r" +
"\n    }\r\n\r\n    function initializeModuleActionHandlers() {\r\n          $(document)" +
".on(\'click.bcms.action\', selectors.onClickModuleAction, function (event) {\r\n    " +
"        event.stopPropagation();\r\n\r\n            var target = $(this),\r\n         " +
"       moduleName = target.data(\'bcms-module\'),\r\n                actionName = ta" +
"rget.data(\'bcms-action\');\r\n\r\n            if (target.hasClass(\'bcms-settings-link" +
"\')) {\r\n                target.parent().find(\'.bcms-settings-link-active\').remove" +
"Class(\'bcms-settings-link-active\');\r\n                target.addClass(\'bcms-setti" +
"ngs-link-active\');\r\n            }           \r\n            \r\n            processo" +
"r.executeModuleAction(moduleName, actionName, target);\r\n        });\r\n        \r\n " +
"       $(document).on(\'change.bcms.action\', selectors.onChangeModuleAction, func" +
"tion (event) {\r\n            event.stopPropagation();\r\n\r\n            var target =" +
" $(this),\r\n                moduleName = target.data(\'bcms-module\'),\r\n           " +
"     actionName = target.data(\'bcms-action\');\r\n\r\n            processor.executeMo" +
"duleAction(moduleName, actionName, target);\r\n        });\r\n    }        \r\n    \r\n " +
"   function registerExternalModules() {\r\n");

            
            #line 98 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
        
            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
         foreach(var module in Model.JavaScriptModules)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("\r\n                externalModules[\'");

            
            #line 101 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
                            Write(module.Name);

            
            #line default
            #line hidden
WriteLiteral("\'] = ");

            
            #line 101 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
                                             Write(module.FriendlyName);

            
            #line default
            #line hidden
WriteLiteral(";\r\n            ");

WriteLiteral("\r\n");

            
            #line 103 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    }\r\n\r\n    function initializeLinks() {\r\n");

            
            #line 107 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
        
            
            #line default
            #line hidden
            
            #line 107 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
         foreach(var module in Model.JavaScriptModules)
        {
            if (module.Links != null && module.Links.Projections != null && module.Links.Projections.Any())
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("\r\n                    /* Initialize ");

            
            #line 112 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
                             Write(module.Name);

            
            #line default
            #line hidden
WriteLiteral(" module links. */\r\n                    try\r\n                    {\r\n              " +
"  ");

WriteLiteral("\r\n");

            
            #line 116 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
                foreach (var item in module.Links.Projections)
                {
                    item.Render(Html);
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("\r\n                    }                    \r\n                    catch (ex)\r\n    " +
"                {\r\n                        bcms.logger.error(\"Failed to initiali" +
"ze ");

            
            #line 124 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
                                                           Write(module.Name);

            
            #line default
            #line hidden
WriteLiteral(" links. \", ex.message);\r\n                    }\r\n                ");

WriteLiteral("\r\n");

            
            #line 127 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    }\r\n    \r\n    function initializeGlobalization() {\r\n");

            
            #line 132 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
        
            
            #line default
            #line hidden
            
            #line 132 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
         foreach(var module in Model.JavaScriptModules)
        {
            if (module.Globalization != null && module.Globalization.Projections != null && module.Globalization.Projections.Any())
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("\r\n                    /* Initialize ");

            
            #line 137 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
                             Write(module.Name);

            
            #line default
            #line hidden
WriteLiteral(" module globalizations. */\r\n                    try\r\n                    {\r\n     " +
"           ");

WriteLiteral("\r\n");

            
            #line 141 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
                foreach (var item in module.Globalization.Projections)
                {
                    item.Render(Html);
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("\r\n                    }                    \r\n                    catch (ex)\r\n    " +
"                {\r\n                        bcms.logger.error(\"Failed to initiali" +
"ze ");

            
            #line 149 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
                                                           Write(module.Name);

            
            #line default
            #line hidden
WriteLiteral(" globalization. \", ex.message);\r\n                    }\r\n                ");

WriteLiteral("\r\n");

            
            #line 152 "..\..\Views\Rendering\RenderProcessorJsFile.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    }\r\n\r\n    return processor;\r\n});");

        }
    }
}
#pragma warning restore 1591
