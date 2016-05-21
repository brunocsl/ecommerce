using ecommerce.DAO;
using ecommerce.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoDAO produtoDAO;

        public ProdutoController(ProdutoDAO produtoDAO)
        {
            this.produtoDAO = produtoDAO;
        }

        public ActionResult Index()
        {
            var produtos = produtoDAO.Lista();
            return View(produtos);
        }

        public ActionResult Adiciona()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adiciona(Produto produto)
        {
            if (ModelState.IsValid)
            {
                produtoDAO.Adiciona(produto);
                return RedirectToAction("Index");
            }
            else
            {
                return View(produto);
            }
        }

        public ActionResult Edita(int id)
        {
            var produto = produtoDAO.BuscaPorId(id);
            return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edita(Produto produto)
        {
            if (ModelState.IsValid)
            {
                var Produto = produtoDAO.BuscaPorId(produto.Id);
                Produto.Nome = produto.Nome;
                Produto.Preco = produto.Preco;
                produtoDAO.Edita();
                return RedirectToAction("Index");
            }
            else
            {
                return View(produto);
            }
        }

        public ActionResult Remove(int id)
        {
            var produto = produtoDAO.BuscaPorId(id);
            return View(produto);
        }
     
        public ActionResult ConfirmaRemove(int id)
        {
            var produto = produtoDAO.BuscaPorId(id);
            produtoDAO.Remove(produto);
            return RedirectToAction("Index");
        }
    }
}