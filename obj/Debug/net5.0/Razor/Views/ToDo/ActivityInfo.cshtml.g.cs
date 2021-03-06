#pragma checksum "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d9e1ca458840ec49f46d5f2fb88345998bf999"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.ToDo.Views_ToDo_ActivityInfo), @"mvc.1.0.view", @"/Views/ToDo/ActivityInfo.cshtml")]
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
#line 1 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
using ToDoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d9e1ca458840ec49f46d5f2fb88345998bf999", @"/Views/ToDo/ActivityInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d1f85d539a9f203b6f9b0679e02aa35aff2cca", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDo_ActivityInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneActivityView>
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
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37d9e1ca458840ec49f46d5f2fb88345998bf9993257", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37d9e1ca458840ec49f46d5f2fb88345998bf9994628", async() => {
                WriteLiteral("\n    <div class=\"container pt-1\">\n        <div class=\"header d-flex justify-content-between\">\n            <h5 class=\"mr-auto p-2\">");
#nullable restore
#line 16 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
                               Write(Model.ScheduledActivity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
            <a href=""Home"" class=""p-2"">
                <button class=""btn btn-outline-secondary"">
                    Home
                </button>
            </a>
            <a href=""/logout"" class=""p-2"">
                <button class=""btn btn-outline-dark"">
                    Log Out
                </button>
            </a>
        </div>
        <table class=""table"">
            <tr>
                <th>Event Coordinator</th>
                <th>Date and Time</th>
                <th>Descripton</th>
                <th>People Joining</th>
            </tr>
            <tbody>
                <td>
                    ");
#nullable restore
#line 37 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
               Write(Model.ScheduledActivity.HostedBy.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 40 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
               Write(Model.ScheduledActivity.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 43 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
               Write(Model.ScheduledActivity.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 46 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
                     foreach (var guest in @Model.ScheduledActivity.PeopleAttending)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <ul>");
#nullable restore
#line 48 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
                       Write(guest.RSVPedBy.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 48 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
                                                 Write(guest.RSVPedBy.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</ul>\n");
#nullable restore
#line 49 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </td>\n            </tbody>\n        </table>\n        <div class=\"dynamic\">\n");
#nullable restore
#line 54 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
                  
                    if(@Model.ScheduledActivity.UserId == @Model.LoggedInUser)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 2036, "\"", 2091, 3);
                WriteAttributeValue("", 2043, "/ToDo/", 2043, 6, true);
#nullable restore
#line 57 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
WriteAttributeValue("", 2049, Model.ScheduledActivity.ActivityId, 2049, 35, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2084, "/delete", 2084, 7, true);
                EndWriteAttribute();
                WriteLiteral(">\n                            <button type=\"button\" class=\"btn btn-outline-danger\">\n                                Delete\n                            </button>\n                        </a>\n");
#nullable restore
#line 62 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
                    }
                    if(@Model.ScheduledActivity.UserId != @Model.LoggedInUser)
                    {
                        if(@Model.ScheduledActivity.PeopleAttending.Any(g => g.UserId == Model.LoggedInUser))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 2571, "\"", 2624, 2);
                WriteAttributeValue("", 2578, "/ToDo/RSVP/", 2578, 11, true);
#nullable restore
#line 67 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
WriteAttributeValue("", 2589, Model.ScheduledActivity.ActivityId, 2589, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                <button type=\"button\" class=\"btn btn-outline-warning\">\n                                    Decline\n                                </button>\n                            </a>\n");
#nullable restore
#line 72 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 2944, "\"", 2997, 2);
                WriteAttributeValue("", 2951, "/ToDo/RSVP/", 2951, 11, true);
#nullable restore
#line 75 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
WriteAttributeValue("", 2962, Model.ScheduledActivity.ActivityId, 2962, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                <button type=\"button\" class=\"btn btn-outline-success\">\n                                    Join\n                                </button>\n                            </a>\n");
#nullable restore
#line 80 "/Users/gilescardenas/Documents/C#Projects/ToDoList/Views/ToDo/ActivityInfo.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OneActivityView> Html { get; private set; }
    }
}
#pragma warning restore 1591
