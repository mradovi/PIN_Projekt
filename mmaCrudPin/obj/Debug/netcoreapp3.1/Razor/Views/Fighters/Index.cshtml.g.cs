#pragma checksum "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "576e0201516eacd609e3e6c59fd6e7aabcfae490"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fighters_Index), @"mvc.1.0.view", @"/Views/Fighters/Index.cshtml")]
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
#line 1 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\_ViewImports.cshtml"
using mmaCrudPin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\_ViewImports.cshtml"
using mmaCrudPin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"576e0201516eacd609e3e6c59fd6e7aabcfae490", @"/Views/Fighters/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c523a61c0592b345bbd0baf578e57d1049f64d", @"/Views/_ViewImports.cshtml")]
    public class Views_Fighters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<mmaCrudPin.Models.mmaFighter>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align:center;\">Lista MMA boraca</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "576e0201516eacd609e3e6c59fd6e7aabcfae4906262", async() => {
                WriteLiteral("Kreiraj novog MMA borca");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "576e0201516eacd609e3e6c59fd6e7aabcfae4907525", async() => {
                WriteLiteral("\r\n    <div class=\"input-group mb-2\">\r\n        <input class=\"form-control\" type=\"text\" name=\"name\" placeholder=\"Pretra??i\"");
                BeginWriteAttribute("value", " value=\"", 410, "\"", 438, 1);
#nullable restore
#line 14 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
WriteAttributeValue("", 418, ViewBag.fighterName, 418, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <span class=\"text-danger\" data-valmsg-for=\"name\" data-valmsg-replace=\"true\"></span>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Message) || ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\"><span>");
#nullable restore
#line 20 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
                                      Write(Html.Raw(ViewBag.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 21 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                <b>");
#nullable restore
#line 27 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
              Write(Html.DisplayNameFor(model => model.figtherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.modified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.worth_salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 1392, "\"", 1416, 2);
            WriteAttributeValue("", 1397, "row_", 1397, 4, true);
#nullable restore
#line 46 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
WriteAttributeValue("", 1401, item.fighterId, 1401, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    <strong>");
#nullable restore
#line 48 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.figtherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </td>\r\n                <td>\r\n                    <span class=\"badge badge-secondary\">");
#nullable restore
#line 51 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.category));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
               Write(item.created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
               Write(item.modified);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <h5><span class=\"badge badge-success\">");
#nullable restore
#line 60 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.worth_salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "576e0201516eacd609e3e6c59fd6e7aabcfae49014692", async() => {
                WriteLiteral("Uredi");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
                                                                                  WriteLiteral(item.fighterId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "576e0201516eacd609e3e6c59fd6e7aabcfae49016985", async() => {
                WriteLiteral("Detalji");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
                                                                                     WriteLiteral(item.fighterId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <a class=\"btn btn-outline-danger btn-sm\" role=\"button\" id=\"deletebutton\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2394, "\"", 2427, 3);
            WriteAttributeValue("", 2404, "Delete(", 2404, 7, true);
#nullable restore
#line 65 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
WriteAttributeValue("", 2411, item.fighterId, 2411, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2426, ")", 2426, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Izbri??i</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 68 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 71 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""modal fade"" id=""myModal"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                </div>
                <div class=""modal-body"">
                    <h4>Jeste li sigurni da ??elite obrisati ");
#nullable restore
#line 80 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
                                                       Write(x.figtherName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?</h4>
                </div>
                <div class=""modal-footer"">
                    <a href=""#"" class=""btn btn-default"" data-dismiss=""modal"">Odustani</a>
                    <input type=""submit"" class=""btn btn-outline-danger"" onclick=""DeleteFighter()"" value=""Da"" />
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 89 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<input type=\"hidden\" id=\"hiddenFighterId\" />\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\mario\OneDrive\Desktop\mmaCrudPin\Views\Fighters\Index.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");


#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <script>

            var Delete = (FighterId) => {

                $(""#hiddenFighterId"").val(FighterId);
                $(""#myModal"").modal('show');

            }

            var DeleteFighter = () => {

                var FighterId = $(""#hiddenFighterId"").val();

                $.ajax({

                    type: ""POST"",
                    url: ""/Fighters/Index"",
                    data: { Id: FighterId },
                    success: (result) => {
                        $(""#myModal"").modal(""hide"");
                        $(""#row_"" + FighterId).remove();
                    }

                })

            }

        </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<mmaCrudPin.Models.mmaFighter>> Html { get; private set; }
    }
}
#pragma warning restore 1591
