#pragma checksum "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b037a2bf80a6a490c7fa640c89f49d72427e28c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Index.cshtml", typeof(AspNetCore.Views_Category_Index))]
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
#line 1 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\_ViewImports.cshtml"
using Lecture1_EntityFramework_Basics;

#line default
#line hidden
#line 2 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\_ViewImports.cshtml"
using Lecture1_EntityFramework_Basics.Models;

#line default
#line hidden
#line 1 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\Category\Index.cshtml"
using Lecture1_EntityFramework_Basics.Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b037a2bf80a6a490c7fa640c89f49d72427e28c", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa3786bd78e73b35f3a7e9dc5dc616b33e340863", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lecture1_EntityFramework_Basics.Domain.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\Category\Index.cshtml"
   
    ViewData["Title"] = "Category";
    string idCategoria = Model?.Id != null ? Model?.Id.ToString() : "";

#line default
#line hidden
            BeginContext(222, 8, true);
            WriteLiteral("\r\n<ul>\r\n");
            EndContext();
#line 9 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\Category\Index.cshtml"
     foreach(var item in ViewBag.Categories as List<Category>) 
    {

#line default
#line hidden
            BeginContext(302, 55, true);
            WriteLiteral("        <li style=\"cursor:pointer;\">\r\n            <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 357, "\"", 375, 2);
            WriteAttributeValue("", 362, "Name_", 362, 5, true);
#line 12 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\Category\Index.cshtml"
WriteAttributeValue("", 367, item.Id, 367, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(376, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(378, 9, false);
#line 12 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\Category\Index.cshtml"
                                Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(387, 23, true);
            WriteLiteral("</span>\r\n            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 410, "\"", 454, 3);
            WriteAttributeValue("", 420, "PreencherFormularioById(", 420, 24, true);
#line 13 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\Category\Index.cshtml"
WriteAttributeValue("", 444, item.Id, 444, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 452, ");", 452, 2, true);
            EndWriteAttribute();
            BeginContext(455, 45, true);
            WriteLiteral(">Editar</a>\r\n            <a id=\"DeleteButton\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 500, "\"", 570, 4);
            WriteAttributeValue("", 510, "PostDeleteCategory(\'DELETE\',", 510, 28, true);
            WriteAttributeValue(" ", 538, "\'/Category/Delete/\',", 539, 21, true);
#line 14 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\Category\Index.cshtml"
WriteAttributeValue(" ", 559, item.Id, 560, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 568, ");", 568, 2, true);
            EndWriteAttribute();
            BeginContext(571, 52, true);
            WriteLiteral(" class=\"btn btn-default\">Delete</a>\r\n        </li>\r\n");
            EndContext();
#line 16 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\Category\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(630, 75, true);
            WriteLiteral("</ul>\r\n\r\n<div class=\"form-group\">\r\n    <label for=\"Name\">Name</label>\r\n    ");
            EndContext();
            BeginContext(705, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "912e013c1f84414885d980ce0cace54e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 21 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\Category\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(762, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(768, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "44bcdd2210bf4cde9d1d5dbdb45471c6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 22 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module3\Lecture1_EntityFramework_Basics\Views\Category\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(825, 1535, true);
            WriteLiteral(@"
    
    <button onclick=""PostDeleteCategory('POST', '/Category/Register');"" class=""btn btn-default"">Salvar</button>
    <button id=""DeleteButton"" onclick=""PostDeleteCategory('DELETE', '/Category/Delete/');"" class=""btn btn-default"">Delete</button>
</div>

<script>
    IsIdExists();

    function IsIdExists(){
        document.getElementById('DeleteButton').style.visibility = 'hidden';
        if(document.getElementById('Id').value > 0 && document.getElementById('Name').value !== """"){
            document.getElementById('DeleteButton').style.visibility = 'visible';
        }
    }

    function PostDeleteCategory(method, rota, Id)
    {
        rota = PreencherRota(rota, Id);
        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {
                document.body.innerHTML = this.responseText;
                IsIdExists();
            }
        };
        xhttp.open(method, rota, true);
    ");
            WriteLiteral(@"    xhttp.send();
        IsIdExists();
    }

    function PreencherRota(rota, Id){
        if(Id == null || Id === 0)
            Id = document.getElementById('Id').value;

        return rota += ""?Id="" + Id + ""&Name="" + document.getElementById('Name').value;
    }

    function PreencherFormularioById(Id){
        document.getElementById('Id').value = Id;
        document.getElementById('Name').value = document.getElementById('Name_' + Id).innerHTML;
        IsIdExists();
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lecture1_EntityFramework_Basics.Domain.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
