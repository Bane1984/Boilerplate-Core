using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerplateCore.DTO
{
    public class ListaKancelarijaDTO
    {
        public List<KancelarijaDTO> Kancelarije { get; set; }

        public ListaKancelarijaDTO(List<KancelarijaDTO> kancelarije)
        {
            Kancelarije = kancelarije;
        }
    }
}
