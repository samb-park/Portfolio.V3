#pragma checksum "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00e541a9ca815da18f2b80bd3a3c70810fdff3d6"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio_Server.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\_Imports.razor"
using Portfolio_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\_Imports.razor"
using Portfolio_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavLink>(2);
                __builder2.AddAttribute(3, "Href", "/work");
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(5, "Work List");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(7);
                __builder2.AddAttribute(8, "Href", "/project");
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Project List");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(12);
                __builder2.AddAttribute(13, "Href", "/aboutme");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(15, "About Me");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
