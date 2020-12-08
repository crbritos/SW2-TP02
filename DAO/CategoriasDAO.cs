using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SW2TP02.DAO {
    public class CategoriasDAO {
        public void Adiciona(Models.CategoriaDoProduto categoria) {
            using (var context = new EstoqueContext()) {
                context.Categorias.Add(categoria);
                context.SaveChanges();
            }
        }

        public IList<Models.CategoriaDoProduto> Lista() {
            using (var contexto = new EstoqueContext()) {
                return contexto.Categorias.ToList();
            }
        }

        public Models.CategoriaDoProduto BuscaPorId(int id) {
            using (var contexto = new EstoqueContext()) {
                return contexto.Categorias
                .Where(p => p.Id == id)
                .FirstOrDefault();
            }
        }

        public void Atauliza(Models.CategoriaDoProduto categoria) {
            using (var contexto = new EstoqueContext()) {
                contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}