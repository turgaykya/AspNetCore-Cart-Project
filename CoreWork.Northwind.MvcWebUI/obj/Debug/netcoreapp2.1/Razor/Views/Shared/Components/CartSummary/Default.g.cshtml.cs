#pragma checksum "C:\Users\Turgay\source\repos\CoreWork\CoreWork.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d507d6d85599fea4798a3b275018bf6fbff3c11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CartSummary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CartSummary_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d507d6d85599fea4798a3b275018bf6fbff3c11", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5449cda0b73cbb89ea87e24dee346f04d6853c8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreWork.Northwind.MvcWebUI.Models.CartSummaryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(64, 64, true);
            WriteLiteral("\r\n<div class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\">\r\n");
            EndContext();
#line 4 "C:\Users\Turgay\source\repos\CoreWork\CoreWork.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
     foreach (var product in Model.Cart.CartLines)
    {

#line default
#line hidden
            BeginContext(187, 42, true);
            WriteLiteral("        <a class=\"dropdown-item\" href=\"#\">");
            EndContext();
            BeginContext(230, 27, false);
#line 6 "C:\Users\Turgay\source\repos\CoreWork\CoreWork.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                     Write(product.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(257, 39, true);
            WriteLiteral(" - <span class=\"badge badge-secondary\">");
            EndContext();
            BeginContext(297, 16, false);
#line 6 "C:\Users\Turgay\source\repos\CoreWork\CoreWork.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                                                                                        Write(product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(313, 10, true);
            WriteLiteral("</span> - ");
            EndContext();
            BeginContext(324, 25, false);
#line 6 "C:\Users\Turgay\source\repos\CoreWork\CoreWork.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                                                                                                                   Write(product.Product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(349, 8, true);
            WriteLiteral(" ₺</a>\r\n");
            EndContext();
#line 7 "C:\Users\Turgay\source\repos\CoreWork\CoreWork.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(364, 119, true);
            WriteLiteral("\r\n    <div class=\"dropdown-divider\"></div>\r\n    <a class=\"dropdown-item\" href=\"#\"><i class=\"fa fa-shopping-cart\">\r\n</i>");
            EndContext();
            BeginContext(484, 16, false);
#line 11 "C:\Users\Turgay\source\repos\CoreWork\CoreWork.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
Write(Model.Cart.Total);

#line default
#line hidden
            EndContext();
            BeginContext(500, 54, true);
            WriteLiteral(" ₺</a>\r\n    <div class=\"dropdown-divider\"></div>\r\n    ");
            EndContext();
            BeginContext(554, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "897aca5dd3274409853afd57db71f40f", async() => {
                BeginContext(619, 18, true);
                WriteLiteral("Go to cart details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(641, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreWork.Northwind.MvcWebUI.Models.CartSummaryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
