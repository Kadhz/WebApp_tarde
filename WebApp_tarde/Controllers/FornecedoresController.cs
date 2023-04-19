using Microsoft.AspNetCore.Mvc;

namespace WebApp_tarde.Controllers
{
    public class FornecedoresController : Controller
    {
        public IActionResult ListaFornecedores()
        {
            return View();
        }
        public IActionResult CadastroFornecedores()
        {
            return View();

        }
    }
}
