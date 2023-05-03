using Microsoft.AspNetCore.Mvc;
using WebApp_tarde.Entidades;

namespace WebApp_tarde.Controllers
{
    public class PermissaoController : Controller
    {
        private Contexto contexto;

        public PermissaoController(Contexto db)
        {
            contexto = db;
        }

        public IActionResult Lista()
        {
            return View( contexto.permissao.ToList() );
        }
        public IActionResult Cadastro ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SalvarDados(PermissaoEntidade dados)
        {
            contexto.permissao.Add(dados);
            contexto.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
