using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerplateCore.Models;

namespace BoilerplateCore.DTO
{
    [AutoMapFrom(typeof(UredjajUzetVracen))]
    public class UredjajUzetVracenDTO: EntityDto
    {
        public DateTime Uzet { get; set; }
        public DateTime? Vracen { get; set; }
    }
}
