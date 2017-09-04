using FiapNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiapNew.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //ViewData
            //ViewData["mensagem"] = $"agora são {DateTime.Now}";
            //ViewBag
            //ViewBag.mensagem = "teste da mensagem 2";

            //Model
            var pessoa = new Pessoa()
            {
                Id=1,
                Nome="Rodolfo",
                Nascimento = DateTime.Now.AddYears(-30),
                Sexo='m',
            };

            return View(pessoa);
        }

        public ActionResult Sobre()
        {

            return View();
        }



    }
}