#pragma checksum "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bb83bdbe24d7aaad570680ae7cc7218da0fdb09"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bb83bdbe24d7aaad570680ae7cc7218da0fdb09", @"/Views/Palavra/Index.cshtml")]
    public class Views_Palavra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Site01.Models.Palavra>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(63, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(92, 330, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4287d2387c5341ba9b3fa79f417de528", async() => {
                BeginContext(98, 317, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Palavra - Listagem</title>
");
                EndContext();
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
            EndContext();
            BeginContext(422, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(424, 1094, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0702d2b0d72f448f9843d4e7aba0fd48", async() => {
                BeginContext(430, 39, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        ");
                EndContext();
                BeginContext(470, 22, false);
#line 16 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
   Write(ViewBag.Palavras.Count);

#line default
#line hidden
                EndContext();
                BeginContext(492, 443, true);
                WriteLiteral(@"
        <a href=""/palavra/cadastrar"" class=""btn btn-success"">Cadastrar</a>
        <hr/>

        <table class=""table"">
            <thead class=""thead-dark"">
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
#line 30 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
                 foreach (var palavra in Model) {



#line default
#line hidden
                BeginContext(990, 58, true);
                WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
                EndContext();
                BeginContext(1049, 10, false);
#line 34 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
                               Write(palavra.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1059, 31, true);
                WriteLiteral("</th>\r\n                    <td>");
                EndContext();
                BeginContext(1091, 12, false);
#line 35 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
                   Write(palavra.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(1103, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1135, 19, false);
#line 36 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
                   Write(palavra.Dificuldade);

#line default
#line hidden
                EndContext();
                BeginContext(1154, 59, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1213, "\"", 1250, 2);
                WriteAttributeValue("", 1220, "/palavra/atualizar/", 1220, 19, true);
#line 38 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1239, palavra.Id, 1239, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1251, 63, true);
                WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1314, "\"", 1349, 2);
                WriteAttributeValue("", 1321, "/palavra/excluir/", 1321, 17, true);
#line 39 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1338, palavra.Id, 1338, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1350, 90, true);
                WriteLiteral(" class=\"btn btn-secondary\">Excluir</a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 42 "C:\Users\EDUARDO\Desktop\.NET MVC BASICO\Projeto 1\Projeto01\Site01\Views\Palavra\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1459, 52, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1518, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
