using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoilerplateCore.Models
{
    public class UredjajUzetVracen:Entity
    {
        public DateTime Uzet { get; set; }
        public DateTime? Vracen { get; set; }

        public int OsobaId { get; set; }
        [ForeignKey("OsobaId")]
        public Osoba Osoba { get; set; }

        public int UredjajId { get; set; }
        [ForeignKey("UredjajId")]
        public Uredjaj Uredjaj { get; set; }
    }
}
