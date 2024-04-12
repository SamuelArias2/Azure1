using Microsoft.AspNetCore.Mvc;
using SysEducaConnect.DAL;
using SysEducaConnect.EN;

namespace SysEducaConnect.UI.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Registro model)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = new Usuario
                {
                    Nombre = model.Firstname,
                    Apellido = model.Lastname,
                    Login = model.Email,
                    Password = model.Password,
                    // Asumiendo que Estatus es un campo requerido, establecer un valor predeterminado
                    Estatus = 1 // Activo, por ejemplo
                };

                try
                {
                    int result = await UsuarioDAL.CrearAsync(usuario);
                    if (result > 0)
                    {
                        // Redirigir al usuario a la página de inicio de sesión o a donde sea apropiado
                        return RedirectToAction("Login", "SignUp");
                    }
                    else
                    {
                        ModelState.AddModelError("", "No se pudo registrar el usuario.");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"Error al registrar el usuario: {ex.Message}");
                }
            }

            // Si llegamos hasta aquí, algo falló, volver a mostrar el formulario
            return View(model);
        }
    }
}
