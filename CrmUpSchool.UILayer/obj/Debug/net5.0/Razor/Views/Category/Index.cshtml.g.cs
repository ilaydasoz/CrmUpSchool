#pragma checksum "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Category/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e35126b0707cee1edcc2645037f02bfe10806e89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/_ViewImports.cshtml"
using CrmUpSchool.UILayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/_ViewImports.cshtml"
using CrmUpSchool.UILayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/_ViewImports.cshtml"
using CrmUpSchool.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e35126b0707cee1edcc2645037f02bfe10806e89", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a3ebcd27e247c728a770f08d0f94207846c733d", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CrmUpSchool.EntityLayer.Concrete.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Category/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_CrmLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Category List</h1>\r\n\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Category Name</th>\r\n            <th>Status</th>\r\n            <th>Delete</th>\r\n            <th>Update</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 18 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Category/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Category/Index.cshtml"
               Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Category/Index.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a href=\"#\" class=\"btn btn-warning\">Status</a></td>\r\n                <td><a href=\"#\" class=\"btn btn-danger\">Delete</a></td>\r\n                <td><a href=\"#\" class=\"btn btn-success\">Update</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Category/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CrmUpSchool.EntityLayer.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
