#pragma checksum "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec3e91010299da190dd02e52c856f9545d298f9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Passagem_PesquisarPassagem), @"mvc.1.0.view", @"/Views/Passagem/PesquisarPassagem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec3e91010299da190dd02e52c856f9545d298f9f", @"/Views/Passagem/PesquisarPassagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"301b75a803ab449d219f11ea86d42103877a61dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Passagem_PesquisarPassagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prototipoSiteTurismo.Entidades.Passagem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
  
    ViewData["Title"] = "PesquisarPassagem";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Passagens aéreas disponíveis</h1>\r\n<p>\r\n    <a href=\"/Passagem/Index\">Retornar</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
           Write(Html.DisplayNameFor(model => model.CidadeSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
           Write(Html.DisplayNameFor(model => model.CidadeChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
           Write(Html.DisplayNameFor(model => model.DataSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
           Write(Html.DisplayNameFor(model => model.DataChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
           Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
           Write(Html.DisplayNameFor(model => model.Detalhes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
               Write(Html.DisplayFor(modelItem => item.CidadeSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
               Write(Html.DisplayFor(modelItem => item.CidadeChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
               Write(Html.DisplayFor(modelItem => item.DataSaida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
               Write(Html.DisplayFor(modelItem => item.DataChegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
               Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
               Write(Html.DisplayFor(modelItem => item.Detalhes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Acer\OneDrive\Área de Trabalho\Projetos Prontos\prototipoSiteTurismo\prototipoSiteTurismo\Views\Passagem\PesquisarPassagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n    <style>\r\n        .card {\r\n            background-color: burlywood;\r\n        }\r\n    </style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prototipoSiteTurismo.Entidades.Passagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591