using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetInicializar.Models;
using AspNetInicializar.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetInicializar.Controllers
{
    public class ZooController : Controller
    {
        private static IList<Zoo> _lista = new List<Zoo>();

        private AllZooContext _context;

        public ZooController(AllZooContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Cadastrar(Zoo zoo)
        {
            _lista = new List<Zoo>();
            _context.Add(zoo);
            _lista = _context.Zoos.Select(x => x).ToList();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Atualizar(Zoo zoo)
        {
            _context.Attach(zoo).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado";
            return RedirectToAction("Listar");
        }

    

        [HttpPost]
        public IActionResult Remove(int id)
        {
            _context.Zoos.Remove(_context.Zoos.Find(id));
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            //Pesquisar o zoo no banco 
            var zoo = _context.Zoos.Find(id);
            //Retornar a view com o zoo
            return View(zoo);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_lista);
        }
    }
}