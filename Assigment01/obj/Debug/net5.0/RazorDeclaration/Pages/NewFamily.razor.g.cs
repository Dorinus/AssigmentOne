// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assigment01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dotNetProjects\AssigmentOne\Assigment01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotNetProjects\AssigmentOne\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetProjects\AssigmentOne\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotNetProjects\AssigmentOne\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotNetProjects\AssigmentOne\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotNetProjects\AssigmentOne\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotNetProjects\AssigmentOne\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dotNetProjects\AssigmentOne\Assigment01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dotNetProjects\AssigmentOne\Assigment01\_Imports.razor"
using Assigment01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dotNetProjects\AssigmentOne\Assigment01\_Imports.razor"
using Assigment01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotNetProjects\AssigmentOne\Assigment01\Pages\NewFamily.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetProjects\AssigmentOne\Assigment01\Pages\NewFamily.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotNetProjects\AssigmentOne\Assigment01\Pages\NewFamily.razor"
           [Authorize(Policy = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newfamily")]
    public partial class NewFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\dotNetProjects\AssigmentOne\Assigment01\Pages\NewFamily.razor"
       
    private Family newFamily = new();

    private void AddNewFamily()
    {
        Console.WriteLine("Add new family method started");
        FileContext.AddNewFamily(newFamily);
        Console.WriteLine("Add new family finished");
        //NavigationManager.NavigateTo("/ViewAll");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext FileContext { get; set; }
    }
}
#pragma warning restore 1591
