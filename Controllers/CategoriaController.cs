using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SW2TP02.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult ViewCategoria()
        {
            DAO.CategoriasDAO dao = new DAO.CategoriasDAO();
            IList<Models.CategoriaDoProduto> categorias = dao.Lista();
            ViewBag.Categorias = categorias;
            return View();
        }
    }
}