using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerplateCore.DTO;
using BoilerplateCore.Interfaces;

namespace BoilerplateCore.Web.SelectDTO
{
    public class KancelarijaSelectDto
    {
        public List<KancelarijaDTO> Kancelarija { get; set; }

        public KancelarijaSelectDto(IKancelarija _kancelarija)
        {
            Kancelarija = _kancelarija.GetAll();
        }
    }
}
