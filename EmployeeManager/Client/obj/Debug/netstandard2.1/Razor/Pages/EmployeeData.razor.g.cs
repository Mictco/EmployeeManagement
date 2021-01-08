#pragma checksum "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9edb627b235c74235b406052efa1762a7511317e"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManager.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Experiment\EmployeeManager\EmployeeManager\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Experiment\EmployeeManager\EmployeeManager\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Experiment\EmployeeManager\EmployeeManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Experiment\EmployeeManager\EmployeeManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Experiment\EmployeeManager\EmployeeManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Experiment\EmployeeManager\EmployeeManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Experiment\EmployeeManager\EmployeeManager\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Experiment\EmployeeManager\EmployeeManager\Client\_Imports.razor"
using EmployeeManager.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Experiment\EmployeeManager\EmployeeManager\Client\_Imports.razor"
using EmployeeManager.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeerecords")]
    public partial class EmployeeData : EmployeeDataModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Employee Data</h1>\r\n");
            __builder.AddMarkupContent(1, "<p>CRUD operation using Blazor and Google Cloud Firestore</p>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "<div class=\"col-md-4\"><a href=\"/employee/add\" class=\"btn btn-primary\" role=\"button\"><i class=\"fa fa-user-plus\"></i> Add Employee</a></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "input-group col-md-4 offset-md-4");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "Search employee by name");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
                                                                                             SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "input-group-append");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-info");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
                                                   SearchEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "<i class=\"fa fa-search\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n<br>");
#nullable restore
#line 20 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
 if (empList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<p><em>Loading...</em></p>");
#nullable restore
#line 22 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
                           }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table");
            __builder.AddMarkupContent(24, "<thead><tr><th>Name</th>\r\n            <th>Gender</th>\r\n            <th>Designation</th>\r\n            <th>City</th>\r\n            <th>Actions</th></tr></thead>\r\n    ");
            __builder.OpenElement(25, "tbody");
#nullable restore
#line 36 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
         foreach (var emp in empList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 39 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
         emp.EmployeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 40 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
         emp.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 41 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
         emp.Designation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 42 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
         emp.CityName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "td");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "href", "/employee/edit/" + (
#nullable restore
#line 44 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
                                 emp.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "class", "btn btn-outline-dark");
            __builder.AddAttribute(43, "role", "button");
            __builder.AddMarkupContent(44, "<i class=\"fa fa-pencil-square-o\"></i> Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "a");
            __builder.AddAttribute(47, "href", "/employee/delete/" + (
#nullable restore
#line 45 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
                                   emp.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "class", "btn btn-outline-danger");
            __builder.AddAttribute(49, "role", "button");
            __builder.AddMarkupContent(50, "<i class=\"fa fa-pencil-square-o\"></i> Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "D:\Experiment\EmployeeManager\EmployeeManager\Client\Pages\EmployeeData.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
