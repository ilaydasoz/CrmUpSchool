#pragma checksum "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01bbfa91dca7bc8cdedefaba207dbfe9562ac85a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01bbfa91dca7bc8cdedefaba207dbfe9562ac85a", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a3ebcd27e247c728a770f08d0f94207846c733d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CrmUpSchool.EntityLayer.Concrete.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "_CrmLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Employee List</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Employee</th>
        <th>Department</th>
        <th>Delete</th>
        <th>Update</th>
        <th>Duties</th>
        <th>Status</th>
    </tr>

");
#nullable restore
#line 18 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 21 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
   Write(item.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
   Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
                      Write(item.EmployeeSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 569, "\"", 617, 2);
            WriteAttributeValue("", 576, "/Employee/DeleteEmployee/", 576, 25, true);
#nullable restore
#line 24 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
WriteAttributeValue("", 601, item.EmployeeID, 601, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 677, "\"", 725, 2);
            WriteAttributeValue("", 684, "/Employee/UpdateEmployee/", 684, 25, true);
#nullable restore
#line 25 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
WriteAttributeValue("", 709, item.EmployeeID, 709, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Update</a></td>\r\n    <td><a href=\"#\" class=\"btn btn-outline-dark\">Duties</a></td>\r\n\r\n");
#nullable restore
#line 28 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
       if (item.EmployeeStatus == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td><a");
            BeginWriteAttribute("href", " href=\"", 902, "\"", 955, 2);
            WriteAttributeValue("", 909, "/Employee/ChangeStatusToFalse/", 909, 30, true);
#nullable restore
#line 30 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
WriteAttributeValue("", 939, item.EmployeeID, 939, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Passive</a></td>\r\n");
#nullable restore
#line 31 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
 }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<td><a");
            BeginWriteAttribute("href", " href=\"", 1026, "\"", 1078, 2);
            WriteAttributeValue("", 1033, "/Employee/ChangeStatusToTrue/", 1033, 29, true);
#nullable restore
#line 34 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
WriteAttributeValue("", 1062, item.EmployeeID, 1062, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Active</a></td>\r\n");
#nullable restore
#line 35 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
 } 

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>");
#nullable restore
#line 36 "/Users/ilaydasozyilmaz/Projects/CrmUpSchoolUILayer/CrmUpSchool.UILayer/Views/Employee/Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    }\r\n</table>\r\n<a href=\"#\" class=\"btn btn-primary\">New Employee</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CrmUpSchool.EntityLayer.Concrete.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
