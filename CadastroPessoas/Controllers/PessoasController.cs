using CadastroPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroPessoas.Controllers
{
    public class PessoasController : Controller
    {
        // GET: Pessoas
        public ActionResult Index()
        {
            var context = new Context();
            var pessoas = context.Pessoas.ToList();

            return View(pessoas);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {

                var context = new Context();
                context.Pessoas.Add(pessoa);
                context.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(pessoa);
        }
    }
}