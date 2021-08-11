// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Portfolio_Server.Pages.Work
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
#nullable restore
#line 3 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\Pages\Work\WorkUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\Pages\Work\WorkUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\Pages\Work\WorkUpsert.razor"
using Portfolio_Server.Helper;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/work/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/work/edit/{Id:int}")]
    public partial class WorkUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "\\Mac\Home\Documents\GitHub\Portfolio_Server\Portfolio_server\Pages\Work\WorkUpsert.razor"
      

    [Parameter]
    public int? Id { get; set; }
    private WorkDTO WorkModel { get; set; } = new WorkDTO();
    private string Title { get; set; } = "Create";
    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        var authenticationStae = await AuthenticationState;
        if (!authenticationStae.User.IsInRole(Common.SD.Role_Admin))
        {
            var uri = new Uri(NavigationManager.Uri);
            NavigationManager.NavigateTo($"/identity/account/login?returnUrl={uri.LocalPath}");
        }
        
        if (Id != null)
        {
            Title = "Update";
            WorkModel = await WorkRepository.GetWork(Id.Value);
        }
        else
        {
            WorkModel = new WorkDTO();
        }
    }

    private async Task HandleWorkUpsert()
    {
        try
        {
            var workDetailsByTitle = await WorkRepository.IsWorkUnique(WorkModel.Title, WorkModel.Id);
            if (workDetailsByTitle != null)
            {
                await JsRuntime.ToastrError("Work title already exists.");
                return;
            }

            if (WorkModel.Id != 0 && Title == "Update")
            {
                var updateRoomResult =
                    await WorkRepository.UpdateWork(WorkModel.Id, WorkModel);
                await JsRuntime.ToastrSuccess("Working Experience updated successfully.");
            }
            else
            {
                var createdResult =
                    await WorkRepository.CreateWork(WorkModel);
                await JsRuntime.ToastrSuccess("Working Experience created successfully.");
            }
        }
        catch (Exception e)
        {
            return;
        }

        NavigationManager.NavigateTo("work");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWorkRepository WorkRepository { get; set; }
    }
}
#pragma warning restore 1591
