// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WASM.V1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using WASM.V1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using WASM.V1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using WASM.V1.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\_Imports.razor"
using WASM.V1.Service.IService;

#line default
#line hidden
#nullable disable
    public partial class ProjectList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "\\Mac\Home\Documents\GitHub\Portfolio_Server\WASM.V1\Pages\ProjectList.razor"
 
    [CascadingParameter(Name = "ColorMode")]
    public ColorMode COLOR { get; set; }

    private IEnumerable<ProjectDTO> Projects { get; set; } = new List<ProjectDTO>();

    protected override async Task OnInitializedAsync()
    {
        Projects = await ProjectService.GetAllProjects();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectService ProjectService { get; set; }
    }
}
#pragma warning restore 1591
