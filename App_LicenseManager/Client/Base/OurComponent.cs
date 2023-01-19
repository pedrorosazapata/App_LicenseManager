using App_LicenseManager.Client.Helpers;
using App_LicenseManager.Client.Repositorios;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;
using System.Threading.Tasks;

namespace App_LicenseManager.Client.Base
{
    public class OurComponentBase : ComponentBase
    {
        [Inject] public IJSRuntime js { get; set; }
        [Inject] public IRepositorio repositorio { get; set; }
        [Inject] public IMostrarMensajes mostrarMensajes { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }
        [Inject] public NotificationService NotificationService { get; set; }
        [Inject] protected DialogService DialogService { get; set; }
        protected override void OnInitialized()
        {
            //js.ConsoleDebug("OnInitialized");
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        protected override void OnParametersSet()
        {
            //js.ConsoleDebug("OnParametersSet");
        }

        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            //js.ConsoleDebug("OnAfterRender", firstRender);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
