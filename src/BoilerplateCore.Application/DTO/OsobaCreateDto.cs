using Abp.Application.Services.Dto;

namespace BoilerplateCore.DTO
{
    public class OsobaCreateDto : EntityDto
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int KancelarijaId { get; set; }
    }
}
