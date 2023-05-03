using Microsoft.AspNetCore.Mvc;
using WebApp_tarde.Entidades;

namespace WebApp_tarde.Controllers
{
    public class CategoriasController : Controller
    {
        private Contexto contexto;

        public CategoriasController(Contexto db)
        {
            contexto = db;
        }

        public IActionResult Lista()
        {
            return View(contexto.Categorias.ToList());
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SalvarDados(EntidadeCategoria dados)
        {
            contexto.Categorias.Add(dados);
            contexto.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
