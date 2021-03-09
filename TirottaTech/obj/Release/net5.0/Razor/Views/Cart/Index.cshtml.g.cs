#pragma checksum "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a502044508ade02b2fb60a8fa4a4ab71ddbdb09d"
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
#line 1 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\_ViewImports.cshtml"
using TirottaTech;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\_ViewImports.cshtml"
using TirottaTech.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a502044508ade02b2fb60a8fa4a4ab71ddbdb09d", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8da7de2a52d8f31abff1a16dbb180184c8ad491c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"cart-container\">\r\n    <div class=\"item-container\">\r\n");
#nullable restore
#line 4 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
         if (Model.Any())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"cart-item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 247, "\"", 275, 1);
#nullable restore
#line 9 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
WriteAttributeValue("", 253, item.Product.ImageUrl, 253, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"item-info\">\r\n");
#nullable restore
#line 11 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
                         if (item.Product.Name.Length > 20)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h1>");
#nullable restore
#line 13 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
                           Write(item.Product.Name.Substring(0, 20));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</h1>\r\n");
#nullable restore
#line 14 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h1>");
#nullable restore
#line 17 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 18 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Quantity: ");
#nullable restore
#line 19 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
                                Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Price: €");
#nullable restore
#line 20 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
                              Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a502044508ade02b2fb60a8fa4a4ab71ddbdb09d6361", async() => {
                WriteLiteral("Remove");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
                                                  WriteLiteral(item.ProductId);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Cart is empty.</p>\r\n");
#nullable restore
#line 29 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"cart-summary\">\r\n        <h1>Order Summary</h1>\r\n");
#nullable restore
#line 33 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"item-row\">\r\n                <h4>");
#nullable restore
#line 36 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
               Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 36 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
                                    Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p>&euro;");
#nullable restore
#line 37 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
                     Write(item.Product.Price*@item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"item-row\">\r\n                <h4>Total</h4>\r\n                <p>&euro;");
#nullable restore
#line 42 "C:\Users\Cristian\source\repos\TirottaTech\TirottaTech\Views\Cart\Index.cshtml"
                    Write(Model.Sum(x=>x.Product.Price * x.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <input class=\"btn-add\" type=\"submit\" value=\"Checkout\" />\r\n    </div>\r\n</div>\r\n<style>\r\n    ");
            WriteLiteral(@"@media screen and (max-width: 980px) {
        .cart-container {
            flex-flow:column;
            align-items:center;
            border: none;
            margin-bottom: 5%;
        }
        .cart-item h1{
            white-space:unset
        }
        .cart-summary{
            width: 90%;
            margin: 1% auto;
        }
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591