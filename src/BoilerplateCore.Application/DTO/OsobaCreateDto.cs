using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerplateCore.Models;

namespace BoilerplateCore.DTO
{
    [AutoMap(typeof(Osoba))]
    public class OsobaCreateDto : EntityDto
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int KancelarijaId { get; set; }
    }
}
