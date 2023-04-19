using Microsoft.AspNetCore.Mvc;

namespace WebApp_tarde.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult ListaProduto()
        {
            return View();
        }
        public IActionResult CadastroProduto()
        {
            return View();
        }
        
        
    }
}
