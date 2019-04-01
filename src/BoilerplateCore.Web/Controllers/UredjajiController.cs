using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerplateCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateCore.Web.Controllers
{
    public class UredjajiController : BoilerplateCoreControllerBase
    {
        private readonly IUredjaj _uredjaji;

        public UredjajiController(IUredjaj uredjaji)
        {
            _uredjaji = uredjaji;
        }

        public IActionResult GetAllDevices()
        {
            var uredjaji = _uredjaji.GetAll();
            return View(uredjaji);
        }
    }
}