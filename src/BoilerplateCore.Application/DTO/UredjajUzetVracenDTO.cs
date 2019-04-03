using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerplateCore.Models;

namespace BoilerplateCore.DTO
{
    [AutoMap(typeof(UredjajUzetVracen))]
    public class UredjajUzetVracenDTO: EntityDto
    {
        public DateTime Uzet { get; set; }
        public DateTime? Vracen { get; set; }
    }
}
