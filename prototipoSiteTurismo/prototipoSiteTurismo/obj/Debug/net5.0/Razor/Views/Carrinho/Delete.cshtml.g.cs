#pragma checksum "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93ab498a065c6e77ac0f10b723afa1b7c8043c3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Delete), @"mvc.1.0.view", @"/Views/Carrinho/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93ab498a065c6e77ac0f10b723afa1b7c8043c3e", @"/Views/Carrinho/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"301b75a803ab449d219f11ea86d42103877a61dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<prototipoSiteTurismo.Entidades.Passagem>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"" style=""padding: 0px 80px"">
    <h1>Remover do carrinho</h1>

    <h3>Você quer mesmo remover esse item do seu carrinho?</h3>
    <div>
        <h4>Passagem</h4>
        <hr />
        <dl class=""row"">
            <dt class=""col-sm-2"">
                ");
#nullable restore
#line 16 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.CidadeSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 19 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayFor(model => model.CidadeSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 22 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.CidadeChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 25 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayFor(model => model.CidadeChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 28 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.DataSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 31 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayFor(model => model.DataSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 34 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.DataChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 37 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayFor(model => model.DataChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 40 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 43 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 46 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Detalhes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 49 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Detalhes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93ab498a065c6e77ac0f10b723afa1b7c8043c3e9753", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "93ab498a065c6e77ac0f10b723afa1b7c8043c3e10023", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 54 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Carrinho\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Remover\" class=\"btn btn-danger\" /> |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93ab498a065c6e77ac0f10b723afa1b7c8043c3e11867", async() => {
                    WriteLiteral("Retornar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<prototipoSiteTurismo.Entidades.Passagem> Html { get; private set; }
    }
}
#pragma warning restore 1591
