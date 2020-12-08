using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SW2TP02.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult ViewProduto()
        {
            DAO.ProdutosDAO dao = new DAO.ProdutosDAO();
            IList<Models.Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }
    }
}