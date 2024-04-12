using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SysEducaConnect.EN;
using SysEducaConnect.DAL;
using System.Security.Claims;

namespace SysEducaConnect.UI.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult PaginaInicio()
        {
            return View();
        }


    }
}
