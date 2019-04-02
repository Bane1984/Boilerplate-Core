using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerplateCore.Models;

namespace BoilerplateCore.DTO
{
    [AutoMap(typeof(Kancelarija))]
    public class OsobaKancelarijaDTO:EntityDto
    {
        public string Opis { get; set; }
        public List<OsobaDTO> Employees { get; set; } = new List<OsobaDTO>();
    }
}
