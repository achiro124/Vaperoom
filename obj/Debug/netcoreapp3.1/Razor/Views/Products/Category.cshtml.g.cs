#pragma checksum "C:\Users\navfa\source\repos\Vaperoom\Views\Products\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57c9b3385be9e1ff3e42ea6d151914ea90b5aa95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Category), @"mvc.1.0.view", @"/Views/Products/Category.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57c9b3385be9e1ff3e42ea6d151914ea90b5aa95", @"/Views/Products/Category.cshtml")]
    public class Views_Products_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vaperoom.Storage.Entity.Product>>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57c9b3385be9e1ff3e42ea6d151914ea90b5aa952765", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Вейп Шоп | Vape shop</title>\r\n    <link rel=\"stylesheet\" href=\"style.css\">\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57c9b3385be9e1ff3e42ea6d151914ea90b5aa953940", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    <div class=\"newproducts\">\r\n\r\n        <h1 class=\"product-title\">");
#nullable restore
#line 14 "C:\Users\navfa\source\repos\Vaperoom\Views\Products\Category.cshtml"
                             Write(ViewBag.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n");
#nullable restore
#line 15 "C:\Users\navfa\source\repos\Vaperoom\Views\Products\Category.cshtml"
         foreach (var Product in Model)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=", 495, "", 571, 1);
#nullable restore
#line 18 "C:\Users\navfa\source\repos\Vaperoom\Views\Products\Category.cshtml"
WriteAttributeValue("", 501, Url.Action("Product","Products",new { ProductId = Product.ProductID}), 501, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display: block;\">\r\n                <div class=\"new\">\r\n                    <div class=\"previev\">\r\n                        <img");
                BeginWriteAttribute("src", " src=", 704, "", 721, 1);
#nullable restore
#line 21 "C:\Users\navfa\source\repos\Vaperoom\Views\Products\Category.cshtml"
WriteAttributeValue("", 709, Product.Img, 709, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 721, "\"", 727, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"250\" height=\"235\">\r\n                    </div>\r\n                    <p class=\"nameprod\">");
#nullable restore
#line 23 "C:\Users\navfa\source\repos\Vaperoom\Views\Products\Category.cshtml"
                                   Write(Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p class=\"price\">");
#nullable restore
#line 24 "C:\Users\navfa\source\repos\Vaperoom\Views\Products\Category.cshtml"
                                Write(Product.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₽</p>\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 27 "C:\Users\navfa\source\repos\Vaperoom\Views\Products\Category.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vaperoom.Storage.Entity.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591