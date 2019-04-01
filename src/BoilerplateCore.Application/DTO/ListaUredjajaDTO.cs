using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerplateCore.DTO
{
    public class ListaUredjajaDTO
    {
        public IReadOnlyList<UredjajDTO> Uredjaji { get; set; }

        public ListaUredjajaDTO(IReadOnlyList<UredjajDTO> uredjaji)
        {
            Uredjaji = uredjaji;
        }
    }
}
