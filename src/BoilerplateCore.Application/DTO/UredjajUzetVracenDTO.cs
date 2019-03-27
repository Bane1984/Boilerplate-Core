using System;
using Abp.Application.Services.Dto;

namespace BoilerplateCore.DTO
{
    public class UredjajUzetVracenDTO: EntityDto
    {
        public DateTime Uzet { get; set; }
        public DateTime? Vracen { get; set; }
    }
}
