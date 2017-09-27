using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova.Models;

namespace Prova.Controllers
{
    public class FaixaController : Controller
    {
        private ApplicationDbContext _context;

        public FaixaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var faixa = _context.Faixa.ToList();
            return View(faixa);
        }
        public ActionResult Detalhes(int id)
        {
            
            foreach (var faixa in _context.Faixa.ToList())
            {
                if (faixa.Id == id)
                {
                    return View(faixa);
                }
            }
            return HttpNotFound();
        }
    }
}