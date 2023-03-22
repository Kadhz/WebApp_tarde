using Microsoft.AspNetCore.Mvc;

namespace WebApp_tarde.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cadastros()
        {
            return View();
        }

    }
}
