using BoilerplateCore.DTO;
using BoilerplateCore.Interfaces;
using BoilerplateCore.Web.SelectDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

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

        public IActionResult OsobeGetAll()
        {
            var osobe = _osobe.GetAll();
            return View(osobe);
        }



        [HttpGet]
        public IActionResult NovaOsoba()
        {
            ViewData["DropDown"] = KancelarijeSelect();
            return View(new OsobaCreateDto());

        }

        //[HttpPost]
        public IActionResult NovaOsoba(OsobaCreateDto osobaNew)
        {
            _osobe.Create(osobaNew);
            //RedrectToAction(imeAkcija, imeKontrolera)
            return RedirectToAction("OsobeGetAll");
        }

        //[HttpGet]
        //public IActionResult UpdateOsobe(int id)
        //{
        //    var osoba = _osobe.GetByIdKanc(id);
        //    var updateOsoba = new OsobaCreateDto
        //    {
        //        Ime = osoba.Ime,
        //        Prezime = osoba.Prezime,
        //        KancelarijaId = osoba.KancelarijaId
        //    };
        //    ViewData["DropDown"] = Osobeee();
        //    return View(updateOsoba);
        //}

        //var kancelarije = KancelarijaDropdown();
        //ViewData["DropDown"] = kancelarije;
        //return View(new OsobaInput());

        public SelectList KancelarijeSelect()
        {
            var kancelarijaSelect = new KancelarijaSelectDto(_kanclarija);
            var sveKancelarije = kancelarijaSelect.Kancelarija.ToList();
            SelectList listaKancelarija = new SelectList(sveKancelarije, "Id", "Opis");
            return listaKancelarija;
        }
    }
}