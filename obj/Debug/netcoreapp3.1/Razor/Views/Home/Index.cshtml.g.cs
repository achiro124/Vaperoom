#pragma checksum "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fc4a446a28e441aca36e53a7d2d22c0a5b87793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fc4a446a28e441aca36e53a7d2d22c0a5b87793", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vaperoom.Storage.Entity.Product>>
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
            WriteLiteral("\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fc4a446a28e441aca36e53a7d2d22c0a5b877932715", async() => {
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fc4a446a28e441aca36e53a7d2d22c0a5b877933894", async() => {
                WriteLiteral(@"
    <div class=""content"">
        <div class=""wrapper"">
            <div class=""newproducts"">
                <h1 class=""product-title"">Жидкости</h1>
                <div class=""wrapper-slider"">
                    <div class=""slider-container"">
                        <div class=""slider-track"">
");
#nullable restore
#line 19 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                             foreach (var product1 in Model.Where(st => st.Category.Category_Name == "POD-системы и комплектующие"))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""slider-item"" style=""padding-left: 2px;"">
                                    <a href=""#"" style=""display: block;"">
                                        <div class=""new"">
                                            <div class=""previev"">
                                                <img");
                BeginWriteAttribute("src", " src=", 1091, "", 1109, 1);
#nullable restore
#line 25 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
WriteAttributeValue("", 1096, product1.Img, 1096, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1109, "\"", 1115, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"250\" height=\"235\">\r\n                                            </div>\r\n                                            <p class=\"nameprod\">");
#nullable restore
#line 27 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                                                           Write(product1.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                            <p class=\"price\">");
#nullable restore
#line 28 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                                                        Write(product1.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₽</p>\r\n                                        </div>\r\n                                    </a>\r\n                                </div>\r\n");
#nullable restore
#line 32 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""slider-buttons"">
                        <button class=""btn-prev""></button>
                        <button class=""btn-next""></button>
                        <a href=""#"" class=""all-btn"">ВСЁ</a>
                    </div>
                </div>

                <h1 class=""product-title"">Жидкости для POD и MTL</h1>
                <div class=""wrapper-slider"">
                    <div class=""slider-container slider-container2"">
                        <div class=""slider-track slider-track2"">
");
#nullable restore
#line 46 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                             foreach (var product2 in Model.Where(st => st.Category.Category_Name == "Жидкости для POD и MTL"))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""slider-item slider-item2"" style=""padding-left: 2px;"">
                                    <a href=""#"" style=""display: block;"">
                                        <div class=""new"">
                                            <div class=""previev"">
                                                <img");
                BeginWriteAttribute("src", " src=", 2634, "", 2652, 1);
#nullable restore
#line 52 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
WriteAttributeValue("", 2639, product2.Img, 2639, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2652, "\"", 2658, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"250\" height=\"235\">\r\n                                            </div>\r\n                                            <p class=\"nameprod\">");
#nullable restore
#line 54 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                                                           Write(product2.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                            <p class=\"price\">");
#nullable restore
#line 55 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                                                        Write(product2.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₽</p>\r\n                                        </div>\r\n                                    </a>\r\n                                </div>\r\n");
#nullable restore
#line 59 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""slider-buttons"">
                        <button class=""btn-prev btn-prev2""></button>
                        <button class=""btn-next btn-next2""></button>
                        <a href=""#"" class=""all-btn"">ВСЁ</a>
                    </div>
                </div>



                <h1 class=""product-title"">Готовые койлы</h1>
                <div class=""wrapper-slider"">
                    <div class=""slider-container slider-container2 slider-container3"">
                        <div class=""slider-track slider-track2 slider-track3"">
");
#nullable restore
#line 75 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                             foreach (var product3 in Model.Where(st => st.Category.Category_Name == "Готовые койлы"))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""slider-item slider-item2 slider-item3"" style=""padding-left: 2px;"">
                                    <a href=""#"" style=""display: block;"">
                                        <div class=""new"">
                                            <div class=""previev"">
                                                <img");
                BeginWriteAttribute("src", " src=", 4228, "", 4246, 1);
#nullable restore
#line 81 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
WriteAttributeValue("", 4233, product3.Img, 4233, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 4246, "\"", 4252, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"250\" height=\"235\">\r\n                                            </div>\r\n                                            <p class=\"nameprod\">");
#nullable restore
#line 83 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                                                           Write(product3.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                            <p class=\"price\">");
#nullable restore
#line 84 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                                                        Write(product3.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                        </div>\r\n                                    </a>\r\n                                </div>\r\n");
#nullable restore
#line 88 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""slider-buttons"">
                        <button class=""btn-prev btn-prev2 btn-prev3""></button>
                        <button class=""btn-next btn-next2 btn-next3""></button>
                        <a href=""#"" class=""all-btn"">ВСЁ</a>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <div class=""clearfix""></div>


    <script src=""script_slider3.js""></script>
    <script src=""script_slider3-2.js""></script>
    <script src=""script2.js""></script>
");
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
