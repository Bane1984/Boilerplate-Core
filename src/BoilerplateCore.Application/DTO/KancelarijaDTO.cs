using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerplateCore.Models;

namespace BoilerplateCore.DTO
{
    [AutoMapFrom(typeof(Kancelarija))]
    public class KancelarijaDTO:EntityDto
    {
        public string Opis { get; set; }
    }
}
