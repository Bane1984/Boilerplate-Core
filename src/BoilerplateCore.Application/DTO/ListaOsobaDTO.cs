using System;
using System.Collections.Generic;
using System.Text;
using BoilerplateCore.Models;

namespace BoilerplateCore.DTO
{
    public class ListaOsobaDTO
    {
        //public IReadOnlyList<OsobaDTO> Osobe { get; set; }
        public List<OsobaDTO> Osobe { get; set; }
        public List<KancelarijaDTO> Kancelarije { get; set; }

        public ListaOsobaDTO(List<OsobaDTO> osobe, List<KancelarijaDTO> kancelarije)
        {
            Osobe = osobe;
            Kancelarije = kancelarije;
        }
    }
}
