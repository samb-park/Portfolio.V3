#pragma checksum "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "defa6890a0f2dbc5d983bbcb4dba7c61b46193be"
// <auto-generated/>
#pragma warning disable 1591
namespace WASM.V1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using WASM.V1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using WASM.V1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using WASM.V1.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/_Imports.razor"
using WASM.V1.Service.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"landing\"></div>\n");
            __builder.OpenComponent<WASM.V1.Pages.Landing>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n<div id=\"about\"></div>\n");
            __builder.OpenComponent<WASM.V1.Pages.About>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n<div id=\"project\"></div>\n");
            __builder.OpenComponent<WASM.V1.Pages.ProjectList>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n<div id=\"experience\"></div>\n");
            __builder.OpenComponent<WASM.V1.Pages.WorkExperience>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n<div id=\"contact\"></div>\n");
            __builder.OpenComponent<WASM.V1.Pages.Contact>(9);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/WASM.V1/Pages/Index.razor"
 
    [CascadingParameter(Name = "ColorMode")]
    public ColorMode COLOR { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
