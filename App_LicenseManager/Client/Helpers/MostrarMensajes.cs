using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_LicenseManager.Client.Helpers
{
    public class MostrarMensajes : IMostrarMensajes
    {
        private readonly IJSRuntime js;

        public MostrarMensajes(IJSRuntime js)
        {
            this.js = js;
        }
        public async Task<bool> MostrarMensajeSINO(string message, bool warning = false, params string[] parameters)
        {
            
            if (parameters.Length > 0)
                message = string.Format(message, parameters);
            //js.ConsoleDebug(message);
            if (message.Length < 50)
                return await js.InvokeAsync<bool>("confirm", message, "", warning ? "warning" : "question");
            else
                return await js.InvokeAsync<bool>("confirm", "", message, warning ? "warning" : "question");
        }

        public async Task MostrarMensajeError(string mensaje)
        {
            await MostrarMensaje("Error", mensaje, "error");
        }

        public async Task MostrarMensajeExitoso(string mensaje)
        {
            await MostrarMensaje("Exitoso", mensaje, "success");
        }

        private async ValueTask MostrarMensaje(string titulo, string mensaje, string tipoMensaje)
        {
            await js.InvokeVoidAsync("Swal.fire", titulo, mensaje, tipoMensaje);
        }
    }
}
