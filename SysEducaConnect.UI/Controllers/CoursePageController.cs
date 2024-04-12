using Microsoft.AspNetCore.Mvc;

namespace SysEducaConnect.UI.Controllers
{
    public class CoursePageController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }

    }
}
