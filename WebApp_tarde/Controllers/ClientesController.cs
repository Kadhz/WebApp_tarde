using Microsoft.AspNetCore.Mvc;
using WebApp_tarde.Models;

namespace WebApp_tarde.Controllers
{
    public class ClientesController : Controller
    {
        public static List<ClientesViewModel> db = new List<ClientesViewModel>();
        public IActionResult Lista()
        {
            return View(db);
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
