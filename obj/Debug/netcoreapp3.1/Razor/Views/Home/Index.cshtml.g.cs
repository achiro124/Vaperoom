#pragma checksum "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "621248b4b9dcead61d1470b6f4e937865cb898b3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"621248b4b9dcead61d1470b6f4e937865cb898b3", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vaperoom.Storage.Entity.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/images/VapeShopLogo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!DOCTYPE html>\r\n    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "621248b4b9dcead61d1470b6f4e937865cb898b34657", async() => {
                WriteLiteral("\r\n        <meta charset=\"UTF-8\">\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n        <title>Вейп Шоп | Vape shop</title>\r\n");
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "621248b4b9dcead61d1470b6f4e937865cb898b35127", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
                WriteLiteral("\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "621248b4b9dcead61d1470b6f4e937865cb898b37053", async() => {
                WriteLiteral("\r\n        <div class=\"header-margin\"></div>\r\n        <div class=\"header\">\r\n            <div class=\"wrapper\">\r\n                <div class=\"logo\">\r\n                    <a href=\"index.html\" class=\"ref-block\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "621248b4b9dcead61d1470b6f4e937865cb898b37562", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </a>
                </div>
                <div class=""list"">
                    <ul class=""list-catalog"">
                        <li>
                            <a class=""ref-block"" href=""#"">Каталог</a>
                            <ul class=""ul-none-block"">
                                <div class=""right-column"">
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">НОВИНКИ</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">Атомайзеры</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">Девайсы</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">");
                WriteLiteral(@"Жидкости</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">Разное</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">ТОП-ЦЕНЫ</a>
                                    </li>

                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">ЖИДКОСТИ</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">Атомайзеры</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">ДЕВАЙСЫ</a>
                                    </li>
                                    <li>
           ");
                WriteLiteral(@"                             <a class=""ref-block sub-category"" href=""#"">Атомайзеры</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">АКСЕСУАРЫ</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">Атомайзеры</a>
                                    </li>
                                </div>
                                <div class=""right-column"">
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">НОВИНКИ</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">Атомайзеры</a>
                                    </li>
                                    <li>
                 ");
                WriteLiteral(@"                       <a class=""ref-block sub-category"" href=""#"">Девайсы</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">Жидкости</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">Разное</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">ТОП-ЦЕНЫ</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">ЖИДКОСТИ</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">ДЕВАЙСЫ</a>
                                   ");
                WriteLiteral(@" </li>
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">АКСЕСУАРЫ</a>
                                    </li>
                                </div>
                                <div class=""right-column"">
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">НОВИНКИ</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">Атомайзеры</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">Девайсы</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block sub-category"" href=""#"">Жидкости</a>
                                    </li>
   ");
                WriteLiteral(@"                                 <li>
                                        <a class=""ref-block sub-category"" href=""#"">Разное</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">ТОП-ЦЕНЫ</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">ЖИДКОСТИ</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">ДЕВАЙСЫ</a>
                                    </li>
                                    <li>
                                        <a class=""ref-block name-category"" href=""#"">АКСЕСУАРЫ</a>
                                    </li>
                                </div>
                                <div class=""clearfix""></div>
             ");
                WriteLiteral("               </ul>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n\r\n                <div class=\"search\">\r\n                    <form");
                BeginWriteAttribute("action", " action=\"", 7031, "\"", 7040, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\" name=\"search\" class=\"input-search\" placeholder=\"Поиск товара...\">\r\n                        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 7198, "\"", 7206, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""button-search"">
                    </form>
                </div>

                <div class=""social"">
                    <a href=""tel:+79250854505"" class=""social-tel"">+7 (925) 085 45 05</a>
                    <div class=""social-icons"">
                        <a href=""#"" class=""ref-icons ref-icons-1""></a>
                        <a href=""#"" class=""ref-icons ref-icons-2""></a>
                        <a href=""#"" class=""ref-icons ref-icons-3""></a>
                    </div>
                </div>
                <div class=""basket"">
                    <a href=""#"" class=""ref-block ref-basket"">
                        <div class=""counter"">0</div>
                    </a>

                </div>
            </div>
        </div>
        <div class=""content"">
            <div class=""wrapper"">
                <div class=""nav"">
                    <div class=""menu-heading"">
                        menu
                    </div>
                    <ul>
                        ");
                WriteLiteral(@"<li><a href=""index.html"">Покупка билетов</a></li>
                        <li><a href=""#"">Новости</a></li>
                        <li class=""li_hober"">
                            <a href=""#"">Новости</a>
                            <ul>
                                <li><a href=""#"">ewwfewfewfwe</a></li>
                                <li><a href=""#"">ewwfewfewfwe</a></li>
                                <li><a href=""#"">ewwfewfewfwe</a></li>
                                <li><a href=""#"">ewwfewfewfwe</a></li>
                            </ul>
                        </li>
                        <li><a href=""account - enter.html"">Личный кабинет</a></li>

                        <li><a href=""search_hotels.html"">Отели</a></li>
                        <li><a href=""cars.html"">аренда авто</a></li>
                        <li><a href=""support.html"">Служба поддержки</a></li>
                        <li><a href=""forCompany.html"">Для компаний*</a></li>
                    </ul>
                </d");
                WriteLiteral("iv>\r\n\r\n\r\n\r\n\r\n                <div class=\"newproducts\">\r\n                    <h1 class=\"product-title\">Жидкости</h1>\r\n");
#nullable restore
#line 183 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                     foreach (var Product in Model.Where(st => st.Category.Category_Name == "Жидкости для POD и MTL"))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a href=\"#\" style=\"display: block;\">\r\n                            <div class=\"new\">\r\n                                <div class=\"previev\">\r\n                                    <img");
                BeginWriteAttribute("src", " src=", 9719, "", 9736, 1);
#nullable restore
#line 188 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
WriteAttributeValue("", 9724, Product.Img, 9724, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 9736, "\"", 9742, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"250\" height=\"235\">\r\n                                </div>\r\n                                <p class=\"nameprod\">");
#nullable restore
#line 190 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                                               Write(Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"price\">");
#nullable restore
#line 191 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                                            Write(Product.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₽</p>\r\n                            </div>\r\n                        </a>\r\n");
#nullable restore
#line 194 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n\r\n                <div class=\"newproducts\">\r\n                    <h1 class=\"product-title\">POD-системы и комплектующие</h1>\r\n");
#nullable restore
#line 199 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                     foreach (var Product in Model.Where(st => st.Category.Category_Name == "POD-системы и комплектующие"))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a href=\"#\" style=\"display: block;\">\r\n                            <div class=\"new\">\r\n                                <div class=\"previev\">\r\n                                    <img");
                BeginWriteAttribute("src", " src=", 10543, "", 10560, 1);
#nullable restore
#line 204 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
WriteAttributeValue("", 10548, Product.Img, 10548, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 10560, "\"", 10566, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"250\" height=\"235\">\r\n                                </div>\r\n                                <p class=\"nameprod\">");
#nullable restore
#line 206 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                                               Write(Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"price\">");
#nullable restore
#line 207 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                                            Write(Product.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₽</p>\r\n                            </div>\r\n                        </a>\r\n");
#nullable restore
#line 210 "C:\Users\navfa\source\repos\Vaperoom\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"footer\">\r\n            <div class=\"wrapper\">\r\n\r\n            </div>\r\n        </div>\r\n    ");
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