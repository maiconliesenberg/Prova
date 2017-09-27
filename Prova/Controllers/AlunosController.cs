using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova.Models;
using System.Data.Entity;

namespace Prova.Controllers
{
    public class AlunosController : Controller
    {
        private ApplicationDbContext _context;

        private ApplicationDbContext db = new ApplicationDbContext();

        public AlunosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var alunos = db.Alunos.Include(c => c.Faixa).Include(c => c.TipoDeAssociacao);
            //_context.Alunos.ToList();

            // var asd = alunos.SingleOrDefault(c => c.Id == alunos);

            return View(alunos);
        }

        public ActionResult Detalhes(int id)
        {
            var alunos = db.Alunos.Include(c => c.Faixa).Include(c => c.TipoDeAssociacao).SingleOrDefault(c => c.Id == id);

            if (alunos == null)
            {
                return HttpNotFound();
            }
            
            return View(alunos);
        }

    }
}