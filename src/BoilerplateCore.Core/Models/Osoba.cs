using Abp.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoilerplateCore.Models
{
    public class Osoba:Entity
    {
        //ne nasledjuj klasu Entity ako hoces sam da definises sta je primarni kljuc i koje mu je ime
        //nasledjivanjem klase Entity dobili bi jos jedan property koji se zove Id
        public string Ime { get; set; }
        public string Prezime { get; set; }

        
        public int KancelarijaId { get; set; }
        [ForeignKey("KancelarijaId")]
        public Kancelarija Kancelarija { get; set; }

        public List<UredjajUzetVracen> UzetiUredjaji { get; set; }
    }
}
