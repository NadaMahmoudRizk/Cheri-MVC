#pragma checksum "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17add3511f66930811e95c4630c21259653c30ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\_ViewImports.cshtml"
using Cheri_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\_ViewImports.cshtml"
using Cheri_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17add3511f66930811e95c4630c21259653c30ca", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ac0e3a7c0a8f12c6d77cf419761f250c883680", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-25 h-75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""container"">
<div style=""border-bottom:1px solid red;text-align:center;box-shadow:red""class=""shadow-lg p-3 mb-5 bg-white rounded"" id=""index"">
    <h2 style=""text-align:center;margin:5px"">Products</h2>
</div>
<table class=""table text-center table-hover  mx-auto shadow-lg p-3 mb-5 bg-white rounded"" >
    <thead>
    <tr >
        <th class=""font-weight-bolder"" scope=""col"">Image</th>
        <th class=""font-weight-bolder"" scope=""col"">ProductName</th>
        <th class=""font-weight-bolder"" scope=""col"">Description</th>
        <th class=""font-weight-bolder"" scope=""col"">Price</th>
        <th class=""font-weight-bolder"" scope=""col"">CategoryName</th>
        <th class=""font-weight-bolder"" scope=""col"">SubCategoryName</th>
        <th class=""font-weight-bolder"" scope=""col"">Edit </th>
        <th class=""font-weight-bolder"" scope=""col"">Delete </th>

    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\Product\Index.cshtml"
  foreach(var std in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr >\r\n        <td class=\" text-center font-weight-bold\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "17add3511f66930811e95c4630c21259653c30ca4742", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1103, "~/ProductImages/", 1103, 16, true);
#nullable restore
#line 27 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1119, std.Image, 1119, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        <td class=\" text-center font-weight-bold\">");
#nullable restore
#line 28 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\Product\Index.cshtml"
                                             Write(std.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\" text-center font-weight-bold\">");
#nullable restore
#line 29 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\Product\Index.cshtml"
                                             Write(std.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\" text-center font-weight-bold\">");
#nullable restore
#line 30 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\Product\Index.cshtml"
                                             Write(std.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\" text-center font-weight-bold\">");
#nullable restore
#line 31 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\Product\Index.cshtml"
                                             Write(std.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\" text-center font-weight-bold\">");
#nullable restore
#line 32 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\Product\Index.cshtml"
                                             Write(std.SubCategory.SubCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\" text-center font-weight-bold\"><a class=\"text-danger\"");
            BeginWriteAttribute("href", " href=\"", 1629, "\"", 1657, 2);
            WriteAttributeValue("", 1636, "/Product/Edit/", 1636, 14, true);
#nullable restore
#line 33 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\Product\Index.cshtml"
WriteAttributeValue("", 1650, std.ID, 1650, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></td>\r\n        <td class=\" text-center font-weight-bold\">\r\n            <button class=\"btn btn-danger\" id=\"btn\"  >\r\n            <a style=\"text-decoration:none; color:white;\"");
            BeginWriteAttribute("href", " href=\"", 1839, "\"", 1869, 2);
            WriteAttributeValue("", 1846, "/Product/Delete/", 1846, 16, true);
#nullable restore
#line 36 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\Product\Index.cshtml"
WriteAttributeValue("", 1862, std.ID, 1862, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"Delete()\" >Delete</a>\r\n            </button>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 40 "D:\Lameees\ITI\Projects\Cheri Project\Cheri Project\Views\Product\Index.cshtml"
      }         

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
 </table>

 <button style=""border-radius:20px;"" class=""mt-3 btn btn-danger shadow-lg p-3 mb-5 rounded "">
    <a  href=""/Product/Add"" style=""text-decoration:none; color:white;"">Add New Product</a>
</button>

</div>


<script>
    function Delete()
    {
        console.log(""test"")
        var respond=confirm(""Do you want to Delete"");
        if(!respond)
        {
             event.preventDefault();
        }
    
    };
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
