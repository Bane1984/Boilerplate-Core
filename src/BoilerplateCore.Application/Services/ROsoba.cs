using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using BoilerplateCore.DTO;
using BoilerplateCore.Interfaces;
using BoilerplateCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Abp.UI;

namespace BoilerplateCore.Services
{
    public class ROsoba:BoilerplateCoreAppServiceBase,IOsoba
    {
        private readonly IRepository<Osoba> _osobaRepository;
        private readonly IObjectMapper _objectMapper;

        public ROsoba(IRepository<Osoba> osobaRepository, IObjectMapper objectMapper)
        {
            _osobaRepository = osobaRepository;
            _objectMapper = objectMapper;
        }

        public ListaOsobaDto GetAll()
        {

            var osobe = _osobaRepository.GetAll().Include(c => c.Kancelarija);
            //.Include(c => c.Kancelarija.Opis).ToList();
            //var osoba = _context.Osobe.Include(c => c.Kancelarija.Opis).ToList();
            //var ukljuci = osobe.Include(c => c.Kancelarija.Opis);
            var osobeDto = new ListaOsobaDto(_objectMapper.Map<List<OsobaDTO>>(osobe));
            return osobeDto;
        }

        public OsobaDTO GetById(int id)
        {
            Osoba osobeId = _osobaRepository.FirstOrDefault(c => c.Id == id);
            if (osobeId == null)
            {
                throw new UserFriendlyException("Osoba sa naznacenim Id ne posoji.");
            }
            OsobaDTO osobaDto = _objectMapper.Map<OsobaDTO>(osobeId);

            return osobaDto;
        }

        public void Create(OsobaCreateDto osoba)
        {
            var provOsobe = _osobaRepository.FirstOrDefault(c => c.Id == osoba.Id);
            if (provOsobe != null)
            {
                throw new UserFriendlyException("Osoba sa naznacenim Id vec posoji.");
            }
            var osobaC = _objectMapper.Map<Osoba>(osoba);
            _osobaRepository.Insert(osobaC);
        }

        public void Update(int id, OsobaCreateDto osoba)
        {
            var osobaId = _osobaRepository.FirstOrDefault(c => c.Id == osoba.Id);
            if (osobaId == null)
            {
                throw new UserFriendlyException("Osoba sa naznacenim Id ne posoji.");
            }
            _objectMapper.Map(osoba, osobaId);
        }

        public void Delete(int id)
        {
            var osobaId = _osobaRepository.FirstOrDefault(c => c.Id == id);
            if (osobaId==null)
            {
                throw new UserFriendlyException("Unijeli ste nepostojeci Id.");
            }
            _osobaRepository.Delete(osobaId);

        }

        public Osoba GetByIdKanc(int id)
        {
            var osoba = _osobaRepository.GetAll().Include(c => c.Kancelarija).FirstOrDefault(c => c.Id == id);
            if (osoba == null)
            {
                throw new UserFriendlyException("Osoba ne postoji.");
            }

            return osoba;
        }
    }
}
