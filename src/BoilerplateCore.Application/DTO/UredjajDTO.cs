using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace BoilerplateCore.DTO
{
    public class UredjajDTO: EntityDto
    {
        public string ImeUredjaja { get; set; }
    }
}
