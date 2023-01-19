using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


using System.Threading;
using Microsoft.AspNetCore.Components.Authorization;
using App_LicenseManager.Client.Repositorios;
using App_LicenseManager.Client.Helpers;

namespace App_LicenseManager.Client.Base
{
    public class OurLauoutComponentBase : LayoutComponentBase
    {
        [Inject] public IJSRuntime js { get; set; }
        [Inject] public IRepositorio repositorio { get; set; }
        [Inject] public IMostrarMensajes mostrarMensajes { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] protected AuthenticationStateProvider authenticationStateProvider { get; set; }
        //[Inject] protected AnalyticsService analyticsService { get; set; }
        //[Inject] protected BehaviorService BehaviorService { get; set; }

        public OurLauoutComponentBase()
        {
            //LocalizerService.SetCulture();
        }

        protected override void OnInitialized()
        {
            //js.ConsoleDebug("OnInitialized");
        }

        protected override void OnParametersSet()
        {
            //js.ConsoleDebug("OnParametersSet");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            //js.ConsoleDebug("OnAfterRender", firstRender);
        }

        AuthenticationState authState = null;
        public async Task<AuthenticationState> AuthState()
        {
            if (authState == null)
                authState = await authenticationStateProvider.GetAuthenticationStateAsync();
            return authState;
        }
        public async Task<bool> IsAuthenticated() =>
            (await AuthState()).User.Identity.IsAuthenticated;

    }
}
