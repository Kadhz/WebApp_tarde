using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApp_tarde.Entidades;

namespace WebApp_tarde
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        {

        }
        public DbSet<ProdutoEntidade> Produtos { get; set; }
        public DbSet<PermissaoEntidade> permissao { get; set; }
        public DbSet<EntidadeCategoria> Categorias { get; set; }
    }
    
}
