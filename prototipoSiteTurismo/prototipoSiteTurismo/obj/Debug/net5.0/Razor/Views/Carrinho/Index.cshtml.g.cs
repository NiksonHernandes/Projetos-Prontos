#pragma checksum "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d900a3ea97ae626e3d2d80580cc301b0d0af30eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Index), @"mvc.1.0.view", @"/Views/Carrinho/Index.cshtml")]
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
#line 1 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\_ViewImports.cshtml"
using prototipoSiteTurismo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\_ViewImports.cshtml"
using prototipoSiteTurismo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d900a3ea97ae626e3d2d80580cc301b0d0af30eb", @"/Views/Carrinho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"301b75a803ab449d219f11ea86d42103877a61dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prototipoSiteTurismo.Entidades.Passagem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logoff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Passagem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PesquisarPassagem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 10px 12px; margin-bottom: 20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    body {\r\n        background-color: var(--cor2);\r\n    }\r\n</style>\r\n\r\n<div class=\"container-fluid\" style=\"padding: 0px 80px\">\r\n\r\n    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d900a3ea97ae626e3d2d80580cc301b0d0af30eb7314", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d900a3ea97ae626e3d2d80580cc301b0d0af30eb8481", async() => {
                WriteLiteral("Sair do login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            WriteLiteral("\r\n\r\n\r\n    </p>\r\n    <div class=\"text-center\" >\r\n");
#nullable restore
#line 21 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
         if (TempData["erro"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n            <div class=\"alert alert-success\" style=\"margin: auto;\">\r\n                ");
#nullable restore
#line 25 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
           Write(TempData["erro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <div class=""col-12"" style=""margin: 40px 0px"">
        <div class=""card"" style=""border-radius: 17px; text-shadow: 0px 0px 3px white; background-color: white"">
            <div class=""card-body"">
                <p class=""card-text text-left font-italic font-weight-bold""
                   style=""color: black; padding-right: 70px;font-size: 25px;"">
                    Seu Carrinho | Quantidade de Passagens:  ");
#nullable restore
#line 34 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                                                        Write(TempData["Carrinho"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d900a3ea97ae626e3d2d80580cc301b0d0af30eb11675", async() => {
                WriteLiteral("Adicionar mais passagem");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                <table class=\"table\">\r\n\r\n                    <thead>\r\n\r\n                        <tr>\r\n                            <th>\r\n                                <span ");
#nullable restore
#line 45 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                                 Write(Html.DisplayNameFor(model => model.CidadeSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("> SAÍDA </span>\r\n                            </th>\r\n                            <th>\r\n                                \r\n                                <span ");
#nullable restore
#line 49 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                                 Write(Html.DisplayNameFor(model => model.CidadeChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("> DESTINO</span>\r\n                            </th>\r\n                            <th>\r\n                                \r\n                                <span ");
#nullable restore
#line 53 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                                 Write(Html.DisplayNameFor(model => model.DataSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("> DATA DE SAÍDA</span>\r\n                            </th>\r\n                            <th>\r\n                                \r\n                                <span ");
#nullable restore
#line 57 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                                 Write(Html.DisplayNameFor(model => model.DataChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("> DATA DE RETORNO </span>\r\n                            </th>\r\n                            <th>\r\n                                \r\n                                <span ");
#nullable restore
#line 61 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                                 Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral(">VALOR DA PASSAGEM/<i>PESSOA</i></span>\r\n                            </th>\r\n                            <th>\r\n                                \r\n                                <span ");
#nullable restore
#line 65 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                                 Write(Html.DisplayNameFor(model => model.Detalhes));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"> DETALHES</span>
                            </th>
                            <th>
                                <span> - </span>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 73 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 77 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CidadeSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 80 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CidadeChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 83 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DataSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 86 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DataChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                   <span>R$ </span> ");
#nullable restore
#line 89 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    \r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 93 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Detalhes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                   \r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d900a3ea97ae626e3d2d80580cc301b0d0af30eb19816", async() => {
                WriteLiteral("\r\n                                        Deletar\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                                                                                                               WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 102 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prototipoSiteTurismo.Entidades.Passagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
