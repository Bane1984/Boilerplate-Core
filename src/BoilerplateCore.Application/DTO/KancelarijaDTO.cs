using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerplateCore.Models;

namespace BoilerplateCore.DTO
{
    //AutoMapFrom kopira sve iz entiteta
    [AutoMap(typeof(Kancelarija))]
    public class KancelarijaDTO:EntityDto
    {
        public string Opis { get; set; }
    }
}
