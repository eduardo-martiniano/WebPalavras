#pragma checksum "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc39b5f67d16fa6e84427659e7fb7502f73a168d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Palavra_Index), @"mvc.1.0.view", @"/Views/Palavra/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Palavra/Index.cshtml", typeof(AspNetCore.Views_Palavra_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc39b5f67d16fa6e84427659e7fb7502f73a168d", @"/Views/Palavra/Index.cshtml")]
    public class Views_Palavra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Site01.Models.Palavra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(68, 7, true);
            WriteLiteral("<hr/>\r\n");
            EndContext();
#line 6 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
            BeginContext(114, 60, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(175, 20, false);
#line 9 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(195, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 11 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
}

#line default
#line hidden
            BeginContext(212, 357, true);
            WriteLiteral(@"
<br />
<a href=""/palavra/cadastrar"" class=""btn btn-success"">Cadastrar</a>
<hr />

<table class=""table"">
    <thead class=""thead-light"">
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Palavra</th>
            <th scope=""col"">Nivel</th>
            <th scope=""col"">Ação</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
         foreach (var palavra in Model)
        {



#line default
#line hidden
            BeginContext(625, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(676, 10, false);
#line 32 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
                           Write(palavra.Id);

#line default
#line hidden
            EndContext();
            BeginContext(686, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(714, 12, false);
#line 33 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
               Write(palavra.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(726, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(754, 19, false);
#line 34 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
               Write(palavra.Dificuldade);

#line default
#line hidden
            EndContext();
            BeginContext(773, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 824, "\"", 861, 2);
            WriteAttributeValue("", 831, "/palavra/atualizar/", 831, 19, true);
#line 36 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 850, palavra.Id, 850, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(862, 59, true);
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 921, "\"", 956, 2);
            WriteAttributeValue("", 928, "/palavra/excluir/", 928, 17, true);
#line 37 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 945, palavra.Id, 945, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(957, 82, true);
            WriteLiteral(" class=\"btn btn-secondary\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 40 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1050, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Site01.Models.Palavra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
