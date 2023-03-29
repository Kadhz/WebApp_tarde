using Microsoft.AspNetCore.Mvc;

namespace WebApp_tarde.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
    }
}
