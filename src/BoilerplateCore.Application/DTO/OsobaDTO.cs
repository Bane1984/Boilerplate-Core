﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace BoilerplateCore.DTO
{
    [AutoMapFrom(typeof(Models.Osoba))]
    public class OsobaDTO: EntityDto
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public KancelarijaDTO Kancelarija { get; set; }
    }
}
