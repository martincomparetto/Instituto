using InstWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstWeb.Controllers
{
    public class UsuariosController : Controller
    {
        public JsonResult AgregarUsuarioSession(string mail, string nombre)
        {
            Usuario newUsuario = new Usuario() {
                Mail = "usuario@gmail.com",
                Nombre = nombre
            };
            HttpContext.Session.Set<Usuario>("UsuarioLogueado", newUsuario);
            return Json(newUsuario);
        }

        public JsonResult ConsultarUsuario()
        {
            var usuario = HttpContext.Session.Get<Usuario>("UsuarioLogueado");
            if (usuario != null)
            {
                return Json(usuario);
            }
            else
            {
                return Json("No está el usuario");
            }
        }

        public string EliminarUsuarioDeSession()
        {
            HttpContext.Session.Remove("UsuarioLogueado");
            return "OK";
        }
    }
}