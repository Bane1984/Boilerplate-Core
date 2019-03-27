using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using BoilerplateCore.Models;

namespace BoilerplateCore.DTO
{
    public class KancelarijaDTO:EntityDto
    {
        public string Opis { get; set; }
    }
}
