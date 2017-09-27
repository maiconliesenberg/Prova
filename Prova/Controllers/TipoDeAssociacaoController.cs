using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova.Models;

namespace Prova.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {
        private ApplicationDbContext _context;

        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var tipoDeAssociacao = _context.TipoDeAssociacao.ToList();
            return View(tipoDeAssociacao);
        }

        public ActionResult Detalhes(int id)
        {
            
            foreach (var associacao in _context.TipoDeAssociacao.ToList())
            {
                if (associacao.Id == id)
                {
                    return View(associacao);
                }
            }
            return HttpNotFound();
        }
    }
}