using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_LicenseManager.Client.Helpers
{
    public interface IMostrarMensajes
    {
        Task MostrarMensajeError(string mensaje);
        Task MostrarMensajeExitoso(string mensaje);
        Task<bool> MostrarMensajeSINO(string message, bool warning = false, params string[] parameters);
    }
}
