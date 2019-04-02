using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerplateCore.DTO;
using BoilerplateCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateCore.Web.Controllers
{
    public class KancelarijaController : BoilerplateCoreControllerBase
    {
        private readonly IKancelarija _kancelarija;

        public KancelarijaController(IKancelarija kancelarija)
        {
            _kancelarija = kancelarija;
        }

        public IActionResult KancelarijaGetAll()
        {
            var kancelarije = _kancelarija.GetAll();
            var model = new ListaKancelarijaDTO(kancelarije);
            return View(model);
        }

        [HttpGet]
        public IActionResult CreateKanc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateKanc(KancelarijaDTO kancelarija)
        {
            //_kancelarija.Create(new KancelarijaDTO
            //{
            //    Opis = kancelarija.Opis
            //});
            _kancelarija.Create(kancelarija);
            return RedirectToAction("KancelarijaGetAll");
        }

        [HttpGet]
        public IActionResult GetKancId(int id)
        {
            var kancelarija = _kancelarija.GetById(id);
            return View(kancelarija);
        }
        
    }
}