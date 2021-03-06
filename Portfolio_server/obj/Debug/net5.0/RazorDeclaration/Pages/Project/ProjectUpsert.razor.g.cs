// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Portfolio_Server.Pages.Project
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/_Imports.razor"
using Portfolio_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/_Imports.razor"
using Portfolio_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/Pages/Project/ProjectUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/Pages/Project/ProjectUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/Pages/Project/ProjectUpsert.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/Pages/Project/ProjectUpsert.razor"
using Portfolio_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/Pages/Project/ProjectUpsert.razor"
using Service.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/project/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/project/edit/{Id:int}")]
    public partial class ProjectUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "/Users/sangbongpark/Documents/GitHub/Portfolio_Server/Portfolio_server/Pages/Project/ProjectUpsert.razor"
      

    [Parameter]
    public int? Id { get; set; }

    private ProjectDTO ProjectModel { get; set; } = new ProjectDTO();
    private ProjectImageDTO ProjectImage { get; set; } = new ProjectImageDTO();
    private string Title { get; set; } = "Create";
    private int FileNumber { get; set; } = 0;
    private List<string> DeleteImageNames { get; set; } = new List<string>();
    private bool IsImageUploadProcessStarted { get; set; }
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
            ProjectModel = await ProjectRepository.GetProject(Id.Value);
            if (ProjectModel?.ProjectImages != null)
            {
                ProjectModel.ImageUrls = ProjectModel.ProjectImages.Select(u => u.ProjectImageUrl).ToList();
            }
        }
        else
        {
            ProjectModel = new ProjectDTO();
        }
    }

    private async Task HandleProjectUpsert()
    {
        try
        {
            var projectDetailsByTitle = await ProjectRepository.IsProjectUnique(ProjectModel.Title, ProjectModel.Id);
            if (projectDetailsByTitle != null)
            {
                await JsRuntime.ToastrError("Project title already exists.");
                return;
            }

            if (ProjectModel.Id != 0 && Title == "Update")
            {
                var updateResult =
                    await ProjectRepository.UpdateProject(ProjectModel.Id, ProjectModel);
                if (ProjectModel.ImageUrls != null && ProjectModel.ImageUrls.Any()
                    || (DeleteImageNames != null && DeleteImageNames.Any()))
                {
                    foreach (var deletedImageName in DeleteImageNames)
                    {
                        var imageName = deletedImageName.Replace($"{NavigationManager.BaseUri}Images/", "");
                        var result = FileUpload.DeleteFile(imageName);
                        await ProjectImageRepository.DeletePojectImageByImageUrl(deletedImageName);
                    }

                    await AddProjectImage(updateResult);
                }
                await JsRuntime.ToastrSuccess("Project updated successfully.");
            }
            else
            {
                var createdResult =
                    await ProjectRepository.CreateProject(ProjectModel);
                await AddProjectImage(createdResult);
                await JsRuntime.ToastrSuccess("Project created successfully.");
            }
        }
        catch (Exception e)
        {
            return;
        }

        NavigationManager.NavigateTo("project");
    }

    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        IsImageUploadProcessStarted = true;
        try
        {
            var images = new List<string>();
            if (e.GetMultipleFiles().Count > 0)
            {
                foreach (var file in e.GetMultipleFiles())
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Name);
                    if (fileInfo.Extension.ToLower() == ".jpg" ||
                        fileInfo.Extension.ToLower() == ".png" ||
                        fileInfo.Extension.ToLower() == ".jpeg")
                    {
                        var uploadedImagePath = await FileUpload.UploadFile(file);
                        images.Add(uploadedImagePath);
                    }
                    else
                    {
                        await JsRuntime.ToastrError("Please select .jpg/ .jpeg/ .png file only");
                        return;
                    }
                }

                if (images.Any())
                {
                    if (ProjectModel.ImageUrls != null && ProjectModel.ImageUrls.Any())
                    {
                        ProjectModel.ImageUrls.AddRange(images);
                    }
                    else
                    {
                        ProjectModel.ImageUrls = new List<string>();
                        ProjectModel.ImageUrls.AddRange(images);
                    }
                }
                else
                {
                    await JsRuntime.ToastrError("Image uploading failed");
                }
                FileNumber = images.Count;
            }
            else
            {
                await JsRuntime.ToastrError("Image uploading failed");
            }
            IsImageUploadProcessStarted = false;
        }
        catch (Exception ex)
        {
            await JsRuntime.ToastrError(ex.Message);
        }
    }

    private async Task AddProjectImage(ProjectDTO projectDetail)
    {
        foreach (var imageUrl in ProjectModel.ImageUrls)
        {
            if (ProjectModel.ProjectImages == null || ProjectModel.ProjectImages.Where(x => x.ProjectImageUrl == imageUrl).Count() == 0)
            {
                ProjectImage = new ProjectImageDTO()
                {
                    ProjectId = projectDetail.Id,
                    ProjectImageUrl = imageUrl
                };

                await ProjectImageRepository.CreateProjectImage(ProjectImage);
            }
        }
    }

    internal async Task DeletePhoto(string imageUrl)
    {
        try
        {
            var imageIndex = ProjectModel.ImageUrls.FindIndex(x => x == imageUrl);
            var imageName = imageUrl.Replace($"{NavigationManager.BaseUri}Images/", "");

            if (ProjectModel.Id == 0 && Title == "Create")
            {
                var result = FileUpload.DeleteFile(imageName);
            }
            else
            {
                DeleteImageNames ??= new List<string>();
                DeleteImageNames.Add(imageUrl);
            }
            ProjectModel.ImageUrls.RemoveAt(imageIndex);
        }
        catch (Exception e)
        {
            await JsRuntime.ToastrError(e.Message);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectImageRepository ProjectImageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectRepository ProjectRepository { get; set; }
    }
}
#pragma warning restore 1591
