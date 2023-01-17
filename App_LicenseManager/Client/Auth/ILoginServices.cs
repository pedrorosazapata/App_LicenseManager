using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_LicenseManager.Client.Auth
{
    public interface ILoginServices
    {
        Task Login(string token);
        Task Logout();
    }
}
