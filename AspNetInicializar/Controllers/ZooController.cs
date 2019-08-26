using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetInicializar.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetInicializar.Controllers
{
    public class ZooController : Controller
    {
        private static IList<Zoo> _lista = new List<Zoo>();

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Cadastrar(Zoo zoo)
        {
            _lista.Add(zoo);
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_lista);
        }
    }
}