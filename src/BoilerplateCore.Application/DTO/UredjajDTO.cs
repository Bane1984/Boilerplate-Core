using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerplateCore.Models;

namespace BoilerplateCore.DTO
{
    [AutoMapFrom(typeof(Uredjaj))]
    public class UredjajDTO: EntityDto
    {
        public string ImeUredjaja { get; set; }
    }
}
