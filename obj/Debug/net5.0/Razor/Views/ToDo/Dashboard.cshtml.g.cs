#pragma checksum "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aff5ee206f7bd0eddc8b6aa2ba5dc621627b8ea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.ToDo.Views_ToDo_Dashboard), @"mvc.1.0.view", @"/Views/ToDo/Dashboard.cshtml")]
namespace MyApp.Namespace.ToDo
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/_ViewImports.cshtml"
using ToDoList.Models.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
using ToDoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aff5ee206f7bd0eddc8b6aa2ba5dc621627b8ea8", @"/Views/ToDo/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d1f85d539a9f203b6f9b0679e02aa35aff2cca", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDo_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardView>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff5ee206f7bd0eddc8b6aa2ba5dc621627b8ea83235", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <title>To Do List</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff5ee206f7bd0eddc8b6aa2ba5dc621627b8ea84606", async() => {
                WriteLiteral("\n    <div class=\"container\">\n        <div class=\"header d-flex justify-content-between\">\n            <div>\n                <h5>Welcome ");
#nullable restore
#line 16 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                       Write(Model.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@", here is your To-Do List</h5>
            </div>
            <div>
                <a href=""/logout"">
                    <button class=""btn btn-outline-dark"">
                        Log Out
                    </button>
                </a>
            </div>
        </div>
            <table class=""table"">
                <tr>
                    <th>Activity</th>
                    <th>Date and Time</th>
                    <th>Duration</th>
                    <th>Event Coordinator</th>
                    <th>Number Of Participants</th>
                    <th>Action</th>
                </tr>
            <tbody>
");
#nullable restore
#line 36 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                 foreach (Activity act in Model.AllActivities)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td>\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1450, "\"", 1478, 2);
                WriteAttributeValue("", 1457, "/ToDo/", 1457, 6, true);
#nullable restore
#line 40 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
WriteAttributeValue("", 1463, act.ActivityId, 1463, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                ");
#nullable restore
#line 41 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                           Write(act.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </a>\n                        </td>\n                        <td>");
#nullable restore
#line 44 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                       Write(act.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 44 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                                                     Write(act.Date.ToShortTimeString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 45 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                       Write(act.Duration);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 45 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                                     Write(act.DurationString);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 46 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                       Write(act.HostedBy.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 47 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                       Write(act.PeopleAttending.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 49 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                              
                                if(act.UserId == @Model.LoggedInUser)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a");
                BeginWriteAttribute("href", " href=\"", 2065, "\"", 2100, 3);
                WriteAttributeValue("", 2072, "/Todo/", 2072, 6, true);
#nullable restore
#line 52 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
WriteAttributeValue("", 2078, act.ActivityId, 2078, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2093, "/delete", 2093, 7, true);
                EndWriteAttribute();
                WriteLiteral(">\n                                    <button type=\"button\" class=\"btn btn-outline-danger\">\n                                        Delete\n                                    </button>\n                                    </a>\n");
#nullable restore
#line 57 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                                }
                                if(act.UserId != @Model.LoggedInUser)
                                {
                                    if(@act.PeopleAttending.Any(g => g.UserId == Model.LoggedInUser))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a");
                BeginWriteAttribute("href", " href=\"", 2647, "\"", 2680, 2);
                WriteAttributeValue("", 2654, "/ToDo/RSVP/", 2654, 11, true);
#nullable restore
#line 62 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
WriteAttributeValue("", 2665, act.ActivityId, 2665, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            <button type=""button"" class=""btn btn-outline-warning"">
                                                Decline
                                            </button>
                                        </a>
");
#nullable restore
#line 67 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a");
                BeginWriteAttribute("href", " href=\"", 3096, "\"", 3129, 2);
                WriteAttributeValue("", 3103, "/ToDo/RSVP/", 3103, 11, true);
#nullable restore
#line 70 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
WriteAttributeValue("", 3114, act.ActivityId, 3114, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                            <button type=\"button\" class=\"btn btn-outline-success\">\n                                                Join\n                                            </button>\n                                        </a>\n");
#nullable restore
#line 75 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\n                    </tr>\n");
#nullable restore
#line 80 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/Dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\n        </table>\n        <div>\n            <a href=\"/ToDo/new\">\n                <button class=\"btn btn-outline-primary\">\n                    New Activity\n                </button>\n            </a>\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardView> Html { get; private set; }
    }
}
#pragma warning restore 1591
