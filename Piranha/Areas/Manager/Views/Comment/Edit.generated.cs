﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Comment
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
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Comment/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<Piranha.Areas.Manager.Models.CommentEditModel>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
  
    ViewBag.Title = @Piranha.Resources.Comment.EditTitleExisting ;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 6 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li><a");

WriteLiteral(" class=\"save submit\"");

WriteLiteral(">");

            
            #line 10 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 347), Tuple.Create("\"", 398)
            
            #line 11 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 354), Tuple.Create<System.Object, System.Int32>(Url.Action("delete", new { id = Model.Id })
            
            #line default
            #line hidden
, 354), false)
);

WriteLiteral(" class=\"delete\"");

WriteLiteral(">");

            
            #line 11 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                                                                                 Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 483), Tuple.Create("\"", 521)
            
            #line 12 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 490), Tuple.Create<System.Object, System.Int32>(Url.Action("index", "comment")
            
            #line default
            #line hidden
, 490), false)
);

WriteLiteral(" class=\"back\"");

WriteLiteral(">");

            
            #line 12 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                                                                  Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 602), Tuple.Create("\"", 651)
            
            #line 13 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 609), Tuple.Create<System.Object, System.Int32>(Url.Action("edit", new { id = Model.Id })
            
            #line default
            #line hidden
, 609), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 13 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                                                                                Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

            
            #line 19 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
   Html.BeginForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 20 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
Write(Html.HiddenFor(m => m.AuthorName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 22 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
Write(Html.HiddenFor(m => m.AuthorEmail));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"grid_9\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 25 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>");

            
            #line 28 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
               Write(Html.LabelFor(m => m.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 30 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 31 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>");

            
            #line 33 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
               Write(Html.LabelFor(m => m.Status));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 35 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                   Write(Html.DropDownListFor(m => m.Status, Model.Statuses));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n                <li>");

            
            #line 37 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
               Write(Html.LabelFor(m => m.Body));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 39 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                   Write(Html.TextAreaFor(m => m.Body, new { @rows = 10 }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</d" +
"iv>\r\n<div");

WriteLiteral(" class=\"grid_3\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 47 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                          Write(Piranha.Resources.Comment.Author);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>");

            
            #line 50 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
               Write(Html.LabelFor(m => m.AuthorName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 51 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 51 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                 if (Model.CreatedById.HasValue) {

            
            #line default
            #line hidden
WriteLiteral("                    <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2105), Tuple.Create("\"", 2182)
            
            #line 52 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2112), Tuple.Create<System.Object, System.Int32>(Url.Action("user", "settings", new { @id = Model.CreatedById.Value })
            
            #line default
            #line hidden
, 2112), false)
);

WriteLiteral(">");

            
            #line 52 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                                                                                                   Write(Model.AuthorName);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n");

            
            #line 53 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                } else {

            
            #line default
            #line hidden
WriteLiteral("                    <p>");

            
            #line 54 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                  Write(Model.AuthorName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 55 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                </li>\r\n                <li>");

            
            #line 57 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
               Write(Html.LabelFor(m => m.AuthorEmail));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2406), Tuple.Create("\"", 2438)
, Tuple.Create(Tuple.Create("", 2413), Tuple.Create("mailto:", 2413), true)
            
            #line 58 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2420), Tuple.Create<System.Object, System.Int32>(Model.AuthorEmail
            
            #line default
            #line hidden
, 2420), false)
);

WriteLiteral(">");

            
            #line 58 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
                                                      Write(Model.AuthorEmail);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n<" +
"/div>\r\n");

            
            #line 64 "..\..\Areas\Manager\Views\Comment\Edit.cshtml"
   Html.EndForm() ; 
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591