using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SW2TP02.DAO {
	public class ProdutosDAO {
		public void Adiciona(Models.Produto produto) {
			using (var context = new EstoqueContext()) {
				context.Produtos.Add(produto);
				context.SaveChanges();
			}
		}

		public IList<Models.Produto> Lista() {
			using (var contexto = new EstoqueContext()) {
				return contexto.Produtos.Include("Categoria").ToList();
			}
		}

		public Models.Produto BuscaPorId(int id) {

			using (var contexto = new EstoqueContext()) {

				return contexto.Produtos.Include("Categoria")
				.Where(p => p.Id == id)
				.FirstOrDefault();
			}
		}

		public void Atualiza(Models.Produto produto) {

			using (var contexto = new EstoqueContext()) {

				contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
				contexto.SaveChanges();
			}
		}
	}
}