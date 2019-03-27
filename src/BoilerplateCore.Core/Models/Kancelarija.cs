using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;

namespace BoilerplateCore.Models
{
    public class Kancelarija:Entity
    {
        public string Opis { get; set; }

        public IList<Osoba> Osobe { get; set; }
    }
}
