#pragma checksum "D:\Projetos\Projeto Integrador\flowbox.web\flowbox.site\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11c26edd1b2ac9e60c2ecbf2c0a57e9684e2e401"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
#line 1 "D:\Projetos\Projeto Integrador\flowbox.web\flowbox.site\Views\_ViewImports.cshtml"
using flowbox.site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\Projeto Integrador\flowbox.web\flowbox.site\Views\_ViewImports.cshtml"
using flowbox.site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11c26edd1b2ac9e60c2ecbf2c0a57e9684e2e401", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca080844016d6f5662ed2a74a8f4bb757281090", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<flowbox.shared.Models.Produto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\ntable, th, td {\r\n  border:1px solid black;\r\n}\r\n</style>\r\n\r\n    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 139, "\"", 195, 3);
            WriteAttributeValue("", 149, "location.href=\'", 149, 15, true);
#nullable restore
#line 9 "D:\Projetos\Projeto Integrador\flowbox.web\flowbox.site\Views\Produto\Index.cshtml"
WriteAttributeValue("", 164, Url.Action("Post", "Produto"), 164, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 194, "\'", 194, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Adicionar Produto</button>\r\n    <table>\r\n        <thead>\r\n\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th>Preço</th>\r\n        </tr>\r\n    </thead>\r\n        <tbody>\r\n            <br>\r\n");
#nullable restore
#line 20 "D:\Projetos\Projeto Integrador\flowbox.web\flowbox.site\Views\Produto\Index.cshtml"
     foreach(var produto in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "D:\Projetos\Projeto Integrador\flowbox.web\flowbox.site\Views\Produto\Index.cshtml"
           Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\Projetos\Projeto Integrador\flowbox.web\flowbox.site\Views\Produto\Index.cshtml"
           Write(produto.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "D:\Projetos\Projeto Integrador\flowbox.web\flowbox.site\Views\Produto\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<flowbox.shared.Models.Produto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
