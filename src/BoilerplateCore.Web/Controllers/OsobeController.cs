using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerplateCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BoilerplateCore.DTO;
using BoilerplateCore.Models;

namespace BoilerplateCore.Web.Controllers
{
    public class OsobeController : BoilerplateCoreControllerBase
    {
        private readonly IOsoba _osobe;
        private readonly IKancelarija _kanclarija;

        public OsobeController(IOsoba osobe, IKancelarija kanclarija)
        {
            _osobe = osobe;
            _kanclarija = kanclarija;
        }

        public IActionResult Osobe()
        {
            var osobe = _osobe.GetAll();
            var kancelarija = osobe.Select(c=>c.Kancelarijadto.Opis);
            var model = new ListaOsobaDTO(osobe, kancelarija);
            return View(model);
        }

        public IActionResult NovaOsoba()
        {
            return View();
        }
    }
}