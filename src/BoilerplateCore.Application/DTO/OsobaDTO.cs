using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace BoilerplateCore.DTO
{
    public class OsobaDTO: EntityDto
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public  string ImeUredjaja { get; set; }
        public KancelarijaDTO Kancelarijadto { get; set; }
        public UredjajUzetVracenDTO UredjajUzetVracendto { get; set; }
    }
}
