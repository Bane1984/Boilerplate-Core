using Abp.Domain.Repositories;
using BoilerplateCore.DTO;
using BoilerplateCore.Interfaces;
using BoilerplateCore.Models;
using System.Collections.Generic;
using System.Linq;
using Abp.ObjectMapping;

namespace BoilerplateCore.Services
{
    public class ROsoba:BoilerplateCoreAppServiceBase,IOsoba
    {
        private readonly IRepository<Osoba> _osobaRepository;
        private readonly IObjectMapper _objectMapper;
        //private readonly BoilerplateCoreDbContext _context;
        public ROsoba(IRepository<Osoba> osobaRepository, IObjectMapper objectMapper)
        {
            _osobaRepository = osobaRepository;
            _objectMapper = objectMapper;
        }

        public List<OsobaDTO> GetAll()
        {
            var osobe = _osobaRepository.GetAll();
            var osobeDto = new List<OsobaDTO>(_objectMapper.Map<List<OsobaDTO>>(osobe));
            return osobeDto;
        }

        public OsobaDTO GetById(int id)
        {
            Osoba osobeId = _osobaRepository.Get(id);
            OsobaDTO osobaDto = _objectMapper.Map<OsobaDTO>(osobeId);

            return osobaDto;
        }

        public void Create(OsobaDTO osoba)
        {
            var osobaC = _objectMapper.Map<Osoba>(osoba);
            _osobaRepository.Insert(osobaC);
        }

        public void Update(OsobaDTO osoba)
        {
            var osobaId = _osobaRepository.Get(osoba.Id);
            _objectMapper.Map(osoba, osobaId);
        }

        public void Delete(int id)
        {
            var osobaId = _osobaRepository.Get(id);
            _osobaRepository.Delete(osobaId);

        }
    }
}
