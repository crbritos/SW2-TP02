using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SW2TP02.DAO {
    public class EstoqueContext : DbContext {
        public DbSet<Models.Produto> Produtos { get; set; }

        public DbSet<Models.CategoriaDoProduto> Categorias { get; set; }
        public DbSet<Models.Usuario> Usuarios { get; set; }
    }
}