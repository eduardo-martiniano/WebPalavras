using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site01.Database;
using Site01.Models;

namespace Site01.Controllers
{
    public class PalavraController : Controller
    {
        private DatabaseContext _db;
        public PalavraController( DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var palavras = _db.Palavras.ToList();
            return View(palavras);
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Atualizar()
        {
            return View("Cadastrar");
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            return View("Cadastrar");
        }
        public IActionResult Excluir()
        {
            return View();
        }
        public IActionResult Excluir([FromForm] Palavra palavra)
        {
            return RedirectToAction("Index");
        }


    }
}
