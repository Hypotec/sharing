#pragma checksum "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9770dec9ea045e66a56b423cdafc8246bcd7cf94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FindAndExpert_AgentSlotBooking), @"mvc.1.0.view", @"/Views/FindAndExpert/AgentSlotBooking.cshtml")]
namespace AspNetCore
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
#line 1 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\_ViewImports.cshtml"
using Hypotec.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\_ViewImports.cshtml"
using Hypotec.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9770dec9ea045e66a56b423cdafc8246bcd7cf94", @"/Views/FindAndExpert/AgentSlotBooking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e0cb572af3a04e862bb8624c174daedf36e861f", @"/Views/_ViewImports.cshtml")]
    public class Views_FindAndExpert_AgentSlotBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Hypotec.Web.Models.AgentSlotModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
  
    ViewData["Title"] = "AgentSlotBooking";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"agentbookingPage\">\r\n    <div class=\"container-fluid\">\r\n");
#nullable restore
#line 9 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
         if (ViewBag.Message != null && ViewBag.Message == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success  alert-dismissible fade show\">\r\n                <strong>Success!</strong>Slot booked successfully.\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n            </div>\r\n");
#nullable restore
#line 15 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
         if (ViewBag.Message == false)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger  alert-dismissible fade show\">\r\n                <strong>Failed!</strong>\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n            </div>\r\n");
#nullable restore
#line 22 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div class=\"all-caption termofuseText\">\r\n                    <h2");
            BeginWriteAttribute("class", " class=\"", 997, "\"", 1005, 0);
            EndWriteAttribute();
            WriteLiteral(">Please Select the Appointment <br /> Type to <span class=\"blue-text\">Make a Booking.</span></h2>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12 my-4\">\r\n                <div class=\"col-md-12\">\r\n");
            WriteLiteral("                </div>\r\n                <div class=\"table-responsive\">\r\n\r\n                    <table class=\"table table-bordered\">\r\n                        <tr>\r\n");
#nullable restore
#line 37 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
                              int NoDays = 0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
                             foreach (var quotes in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"text-center\">\r\n                                    <label");
            BeginWriteAttribute("id", " id=\"", 1729, "\"", 1749, 1);
#nullable restore
#line 42 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
WriteAttributeValue("", 1734, quotes.DayName, 1734, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong>");
#nullable restore
#line 42 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
                                                                   Write(DateTime.Today.AddDays(NoDays).ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> </label> <br />\r\n\r\n");
#nullable restore
#line 44 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
                                      NoDays = NoDays + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"d-block\">\r\n                                        ");
#nullable restore
#line 46 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
                                   Write(quotes.DayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <br />\r\n\r\n");
#nullable restore
#line 50 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
                                     for (var i = 0; i < quotes.Slots.Count; i++)
                                    {
                                        if (quotes.SlotStatus[i].SlotStatus.ToString() == "Active")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <input type=\"button\" class=\"form-control\" data-toggle=\"modal\" data-target=\"#gatrtrresr\" data-dismiss=\"modal\" onclick=\"setslotvalue(this)\" id=\'btn\'");
            BeginWriteAttribute("hdnSlotId", " hdnSlotId=\"", 2556, "\"", 2578, 1);
#nullable restore
#line 54 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
WriteAttributeValue("", 2568, quotes.Id, 2568, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("dayname", " dayname=\"", 2579, "\"", 2604, 1);
#nullable restore
#line 54 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
WriteAttributeValue("", 2589, quotes.DayName, 2589, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2605, "\"", 2634, 1);
#nullable restore
#line 54 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
WriteAttributeValue("", 2613, quotes.Slots[i].Slot, 2613, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 55 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <input type=\"button\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2857, "\"", 2886, 1);
#nullable restore
#line 58 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
WriteAttributeValue("", 2865, quotes.Slots[i].Slot, 2865, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  disabled=\"disabled\" />\r\n");
#nullable restore
#line 59 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <br />\r\n");
#nullable restore
#line 61 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n");
#nullable restore
#line 63 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\FindAndExpert\AgentSlotBooking.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tr>
                    </table>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""register-form-btn"">
                    <button id=""btnslotnext"" type=""button"" class=""btn w-100"" data-toggle=""modal"" data-target=""#gatrtrresr"" data-dismiss=""modal"" disabled>Next</button>
                </div>
            </div>
        </div>
    </div>
</section>
<div class=""applyModal reqclbk"">
    <div class=""modal fade"" id=""gatrtrresr"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""gatrtrresrLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header diffheading d-block text-center"">
                    <h5 class=""modal-title"" id=""gatrtrresrLabel"">
                        <label id=""lblSlot""> </label>
                    </h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=");
            WriteLiteral("\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9770dec9ea045e66a56b423cdafc8246bcd7cf9412803", async() => {
                WriteLiteral("\r\n\r\n\r\n                        <div class=\"col-md-12 px-0\">\r\n                            <div class=\"form-group\">\r\n                                <label");
                BeginWriteAttribute("for", " for=\"", 4501, "\"", 4507, 0);
                EndWriteAttribute();
                WriteLiteral(@">Name</label>
                                <input type=""text"" id=""name"" class=""form-control"" />
                                <span style=""color:red"" id=""errorName""></span>
                            </div>
                        </div>
                        <div class=""col-md-12 px-0"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("for", " for=\"", 4903, "\"", 4909, 0);
                EndWriteAttribute();
                WriteLiteral(">Phone</label>\r\n");
                WriteLiteral(@"                                <input type=""tel"" id=""phone"" name=""phone""
                                       pattern=""[0-9]{3}-[0-9]{3}-[0-9]{4}"" class=""form-control""
                                       required>
                                <span style=""color:red"" id=""errorPhone""></span>
                            </div>
                        </div>
                        <div class=""col-md-12 px-0"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("for", " for=\"", 5535, "\"", 5541, 0);
                EndWriteAttribute();
                WriteLiteral(@">Email</label>
                                <input type=""text"" id=""email"" class=""form-control"" />
                                <span style=""color:red"" id=""errorEmail""></span>
                            </div>
                        </div>

                        <div class=""col-md-6 px-0"">
                            <div class=""register-form-btn"">
                                <input type=""button"" onclick=""SendMailtest();"" class=""btn w-100"" value=""Send Message"" />
");
                WriteLiteral("                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <div");
                BeginWriteAttribute("class", " class=\"", 6305, "\"", 6313, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Hypotec.Web.Models.AgentSlotModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591