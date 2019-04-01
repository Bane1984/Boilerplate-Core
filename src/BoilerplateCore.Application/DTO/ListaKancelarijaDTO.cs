using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerplateCore.DTO
{
    public class ListaKancelarijaDTO
    {
        public IReadOnlyList<KancelarijaDTO> Kancelarije { get; set; }

        public ListaKancelarijaDTO(IReadOnlyList<KancelarijaDTO> kancelarije)
        {
            Kancelarije = kancelarije;
        }
    }
}
