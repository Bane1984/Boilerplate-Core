using BoilerplateCore.DTO;
using BoilerplateCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public IActionResult NovaOsoba(OsobaCreateDto osobaNew)
        {
            _osobe.Create(osobaNew);

            //RedrectToAction(imeAkcija, imeKontrolera)
            return RedirectToAction("OsobeGetAll", "Osobe");
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

        //public SelectList Osobeee()
        //{
        //    var osobe = _osobe.GetAll();
        //    SelectList listaOsoba = new SelectList(osobe, "id", "opis");
        //    return listaOsoba;
        //}
    }
}