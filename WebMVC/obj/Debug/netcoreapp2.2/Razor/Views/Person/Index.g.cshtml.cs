#pragma checksum "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c951d77bfd7667f96b58df1e108366248f9cfb6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Index.cshtml", typeof(AspNetCore.Views_Person_Index))]
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
#line 1 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#line 2 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c951d77bfd7667f96b58df1e108366248f9cfb6d", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListPersonModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
  
    ViewData["Title"] = "Person Page";

#line default
#line hidden
            BeginContext(68, 45, true);
            WriteLiteral("\n<h2>***Person Page***</h2>\n\n\n <strong>\n     ");
            EndContext();
            BeginContext(114, 50, false);
#line 11 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
Write(Html.ActionLink("Create Person","Create","Person"));

#line default
#line hidden
            EndContext();
            BeginContext(164, 290, true);
            WriteLiteral(@"

</strong>

<table border = ""1"" style=""width:100%"">
<tr>
    <th>Id</th>
    <th>Nome</th>
    <th>Gênero</th>
    <th>RG</th>
    <th>CPF</th>
    <th>Nascimento</th>
    <th>Estado Civil</th>
    <th>Endereço</th>
    <th>Telefone</th>
    <th>Editar</th>
    <th>Excluir</th>

</tr>

 
");
            EndContext();
#line 32 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
 foreach (var person in Model.Lista)
{

#line default
#line hidden
            BeginContext(493, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(515, 9, false);
#line 35 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
       Write(person.Id);

#line default
#line hidden
            EndContext();
            BeginContext(524, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(543, 11, false);
#line 36 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
       Write(person.Name);

#line default
#line hidden
            EndContext();
            BeginContext(554, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(573, 13, false);
#line 37 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
       Write(person.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(586, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(605, 21, false);
#line 38 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
       Write(person.DocumentNumber);

#line default
#line hidden
            EndContext();
            BeginContext(626, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(645, 21, false);
#line 39 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
       Write(person.Identification);

#line default
#line hidden
            EndContext();
            BeginContext(666, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(685, 16, false);
#line 40 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
       Write(person.BirthDate);

#line default
#line hidden
            EndContext();
            BeginContext(701, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(720, 20, false);
#line 41 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
       Write(person.MaritalStatus);

#line default
#line hidden
            EndContext();
            BeginContext(740, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(759, 14, false);
#line 42 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
       Write(person.Address);

#line default
#line hidden
            EndContext();
            BeginContext(773, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(792, 12, false);
#line 43 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
       Write(person.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(804, 98, true);
            WriteLiteral("</td>\n         <td style = \"text-align: center; color:blue\">\n            <strong>\n                ");
            EndContext();
            BeginContext(903, 69, false);
#line 46 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
           Write(Html.ActionLink("Edit" ,"Edit","Person", new { personId = person.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(972, 127, true);
            WriteLiteral("\n            </strong>\n        </td>\n        <td style = \"text-align: center; color:red\">\n            <strong>\n                ");
            EndContext();
            BeginContext(1100, 79, false);
#line 51 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
           Write(Html.ActionLink("Delete" ,"DeletePerson","Person", new { personId = person.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 51, true);
            WriteLiteral("\n            </strong>\n        </td>\n    </tr>    \n");
            EndContext();
#line 55 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1232, 45, true);
            WriteLiteral("\n\n</tr>\n<table>\n<p><strong>Total de pessoas: ");
            EndContext();
            BeginContext(1278, 19, false);
#line 60 "/home/season/Documentos/projects/didactic-broccoli/WebMVC/Views/Person/Index.cshtml"
                        Write(Model.Lista.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1297, 14, true);
            WriteLiteral("</strong></p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListPersonModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
