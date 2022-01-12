#pragma checksum "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd893c0aa47638caa4e1f6137574cfd1507de961"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\_ViewImports.cshtml"
using webUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\_ViewImports.cshtml"
using webUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\_ViewImports.cshtml"
using eCommercePizza.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\_ViewImports.cshtml"
using webUI.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd893c0aa47638caa4e1f6137574cfd1507de961", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc452da14a3f3e106efbc092be696bc9025b77b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : webUI.Helpers.BaseViewPage<eCommercePizza.Repositories.Models.CartModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-returnurl", "/Cart/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart | Fast Pizza";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section>\r\n");
#nullable restore
#line 7 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
     if (Model != null && Model.Items.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mt-3\">\r\n\r\n            <div class=\"col-lg-8\">\r\n                <div class=\"card mb-3\">\r\n                    <div class=\"col-sm-12\">\r\n                        <h5 class=\"mt-3\">Cart Items = ");
#nullable restore
#line 14 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                                                 Write(Model.Items.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                    <hr />\r\n                    <div class=\"card-body pt-0 pb-0\">\r\n");
#nullable restore
#line 18 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                         foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"">
                                <div class=""col-md-5 col-lg-3 col-xl-3"">
                                    <div class=""rounded mb-3 mb-md-0"">
                                        <img class=""rounded w-100""");
            BeginWriteAttribute("src", "\r\n                                     src=\"", 870, "\"", 928, 1);
#nullable restore
#line 24 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 914, item.ImageUrl, 914, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Sample"">
                                    </div>
                                </div>
                                <div class=""col-md-7 col-lg-9 col-xl-9"">
                                    <div class=""d-flex justify-content-between"">
                                        <div>
                                            <h5>");
#nullable restore
#line 30 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p class=\"mb-2 text-muted small\">Size: Regular</p>\r\n                                            <p class=\"mb-2 text-muted small\">\r\n                                                Unit Price: $");
#nullable restore
#line 33 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                                                        Write(item.UnitPrice.ToString("##.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <span class=\"pl-1\">\r\n                                                    <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1716, "\"", 1748, 3);
            WriteAttributeValue("", 1726, "deleteItem(\'", 1726, 12, true);
#nullable restore
#line 35 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1738, item.Id, 1738, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1746, "\')", 1746, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" title=""Remove"" class=""pt-0""><i class=""bi bi-trash text-danger""></i></a>
                                                </span>
                                            </p>
                                        </div>
                                        <div>
                                            <div class=""def-number-input number-input safari_only mb-0 w-100"">
                                                <div class=""input-group mb-3"">
                                                    <div class=""input-group-prepend"">
                                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2367, "\"", 2406, 3);
            WriteAttributeValue("", 2377, "updateQuantity(\'", 2377, 16, true);
#nullable restore
#line 43 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2393, item.Id, 2393, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2401, "\',-1)", 2401, 5, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary\" type=\"button\">-</button>\r\n                                                    </div>\r\n                                                    <input class=\"form-control sm-control\" size=\"1\" min=\"0\" name=\"quantity\"");
            BeginWriteAttribute("value", " value=\"", 2651, "\"", 2673, 1);
#nullable restore
#line 45 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2659, item.Quantity, 2659, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                                                    <div class=\"input-group-append\">\r\n                                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2837, "\"", 2875, 3);
            WriteAttributeValue("", 2847, "updateQuantity(\'", 2847, 16, true);
#nullable restore
#line 47 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2863, item.Id, 2863, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2871, "\',1)", 2871, 4, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-secondary"" type=""button"">+</button>
                                                    </div>
                                                </div>
                                            </div>
                                            <span id=""spanTotal"" class=""form-text text-muted text-center"">
                                                Total : $");
#nullable restore
#line 52 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                                                     Write((item.UnitPrice * @item.Quantity).ToString("##.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 58 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                             if (Model.Items.IndexOf(item) < Model.Items.Count - 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <hr class=\"mb-4\">\r\n");
#nullable restore
#line 61 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                <div class=""mb-3"">
                    <a href=""/"" class=""btn btn-outline-primary"">Continue Shopping</a>
                </div>
            </div>

            <div class=""col-lg-4"">
                <div class=""card mb-3"">
                    <div class=""col-sm-12"">
                        <h5 class=""mt-3"">Order Summary</h5>
                    </div>
                    <hr />
                    <div class=""card-body pt-0"">
                        <ul class=""list-group list-group-flush"">
                            <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0"">
                                Amount
                                <span>$");
#nullable restore
#line 80 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                                  Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li class=\"list-group-item d-flex justify-content-between align-items-center border-0 px-0\">\r\n                                Tax (5%)\r\n                                <span>+$");
#nullable restore
#line 84 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                                   Write(Model.Tax);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center  px-0 mb-3"">
                                <strong>Total Amount</strong>
                                <span><strong>$");
#nullable restore
#line 88 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                                          Write(Model.GrandTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n                            </li>\r\n                        </ul>\r\n");
#nullable restore
#line 91 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                         if (CurrentUser != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd893c0aa47638caa4e1f6137574cfd1507de96116059", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 94 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd893c0aa47638caa4e1f6137574cfd1507de96117802", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnurl"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 103 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-sm-12 mt-5"">
                <p style=""min-height:300px"">
                    Your cart is empty. Please add some items from the menu.! <br><br>
                    <a href=""/"" class=""btn btn-primary"">Browse Menu</a>
                </p>
            </div>
        </div>
");
#nullable restore
#line 114 "C:\Users\DELL\source\repos\eCommercePizza\webUI\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eCommercePizza.Repositories.Models.CartModel> Html { get; private set; }
    }
}
#pragma warning restore 1591