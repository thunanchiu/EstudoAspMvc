using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoqueEstudo.Controllers
{
    public class OperacaoController : Controller
    {
        // GET: Operacao
        public ActionResult EntradaEstoque()
        {
            return View();
        }
        public ActionResult SaidaEstoque()
        {
            return View();
        }
        public ActionResult IndLancPerdaProdutoex()
        {
            return View();
        }
        public ActionResult Inventario()
        {
            return View();
        }
    }
}