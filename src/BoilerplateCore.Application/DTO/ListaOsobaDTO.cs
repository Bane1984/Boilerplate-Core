using System.Collections.Generic;

namespace BoilerplateCore.DTO
{
    public class ListaOsobaDto
    {
        public IReadOnlyList<OsobaDTO> Osobe { get; set; }
        //public List<OsobaDTO> Osobe { get; set; }

        public ListaOsobaDto(IReadOnlyList<OsobaDTO> osobe)
        {
            Osobe = osobe;
        }
    }
}
