#pragma checksum "/home/rafael/Downloads/Projetos/Blog/Views/Home/_ListaComentario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fe708a74d7643d19288d45d784e2a139a8692c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ListaComentario), @"mvc.1.0.view", @"/Views/Home/_ListaComentario.cshtml")]
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
#line 1 "/home/rafael/Downloads/Projetos/Blog/Views/_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rafael/Downloads/Projetos/Blog/Views/_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe708a74d7643d19288d45d784e2a139a8692c9", @"/Views/Home/_ListaComentario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ListaComentario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Comentario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/rafael/Downloads/Projetos/Blog/Views/Home/_ListaComentario.cshtml"
   foreach (Comentario comment in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h5>");
#nullable restore
#line 5 "/home/rafael/Downloads/Projetos/Blog/Views/Home/_ListaComentario.cshtml"
     Write(comment.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 5 "/home/rafael/Downloads/Projetos/Blog/Views/Home/_ListaComentario.cshtml"
                      Write(comment.Data.ToString("dd/MM/yy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n      <p>");
#nullable restore
#line 6 "/home/rafael/Downloads/Projetos/Blog/Views/Home/_ListaComentario.cshtml"
    Write(comment.Conteudo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 7 "/home/rafael/Downloads/Projetos/Blog/Views/Home/_ListaComentario.cshtml"
  }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Comentario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
