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
#line 2 "D:\dotNetProjects\AssigmentOne\Assigment01\Pages\ViewAll.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetProjects\AssigmentOne\Assigment01\Pages\ViewAll.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotNetProjects\AssigmentOne\Assigment01\Pages\ViewAll.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotNetProjects\AssigmentOne\Assigment01\Pages\ViewAll.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAll")]
    public partial class ViewAll : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 130 "D:\dotNetProjects\AssigmentOne\Assigment01\Pages\ViewAll.razor"
       
    private IList<Family> families;
    private IList<Family> showFamilies;


    protected override async Task OnInitializedAsync()
    {
        families = FileContext.Families;
        showFamilies = families;
    }


    private void RemoveAdult(int familyId, int adultId)
    {
        FileContext.RemoveAdult(familyId, adultId);
    }

    private void FilterByID(ChangeEventArgs changeEventArgs)
    {
        int? filterByID = null;

        try
        {
            filterByID = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        if (filterByID != null)
        {
            foreach (var temp in families)
            {
                if (temp.Adults != null)
                {
                    foreach (var adultTemp in temp.Adults)
                    {
                        if (!adultTemp.Id.Equals(filterByID))
                        {
                            showFamilies[families.IndexOf(temp)].Adults.Remove(adultTemp);
                        }
                    }
                }
                if (temp.Children != null)
                {
                    foreach (var childTemp in temp.Children)
                    {
                        if (!childTemp.Id.Equals(filterByID))
                        {
                            showFamilies[families.IndexOf(temp)].Children.Remove(childTemp);
                        }
                    }
                }
            }
        }
        else
        {
            showFamilies = families;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext FileContext { get; set; }
    }
}
#pragma warning restore 1591
