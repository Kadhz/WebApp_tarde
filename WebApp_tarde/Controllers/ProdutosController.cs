using Microsoft.AspNetCore.Mvc;

namespace WebApp_tarde.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly Contexto db;
        public ProdutosController(Contexto opt)
        {
            db = opt;
        }
        public IActionResult ListaProduto()
        {
            return View( db.Produtos.ToList() );
        }
        public IActionResult CadastroProduto()
        {
            return View();
        }
        
        
    }
}
