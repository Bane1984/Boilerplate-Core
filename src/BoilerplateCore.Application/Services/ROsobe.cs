using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using BoilerplateCore.DTO;
using BoilerplateCore.EntityFrameworkCore;
using BoilerplateCore.Interfaces;
using BoilerplateCore.Models;

namespace BoilerplateCore.Services
{
    public class ROsobe:BoilerplateCoreAppServiceBase,IOsobe
    {
        private readonly IRepository<Osoba> _osobaRepository;
        private readonly IObjectMapper _objectMapper;
        private readonly BoilerplateCoreDbContext _context;
        public ROsobe(IRepository<Osoba> osobaRepository, IObjectMapper objectMapper)
        {
            _osobaRepository = osobaRepository;
            _objectMapper = objectMapper;
        }

        //List<T> GetAll();
        //T GetById(int id);
        //void Create(T entitet);
        //void Update(int id, T entitet);
        //void Delete(int id);

        public List<OsobaDTO> GetAll()
        {
            var osobe = _osobaRepository.GetAll();
            var osobeDto = new List<OsobaDTO>(_objectMapper.Map<List<OsobaDTO>>(osobe));
            return osobeDto;
        }

        public OsobaDTO GetById(int id)
        {
            var osobeId = _osobaRepository.Get(id);
            var osobaDto = _objectMapper.Map<OsobaDTO>(osobeId);

            return osobaDto;
        }

        public void Create(OsobaDTO osoba)
        {
            var osobaC = new Osoba
            {
                Ime = osoba.Ime,
                Prezime = osoba.Prezime
            };

            _osobaRepository.Insert(osobaC);
        }

        public void Update(int id, OsobaDTO osoba)
        {
            var osobaId = _osobaRepository.Get(id);
            //var osobaU = _objectMapper.Map<OsobaDTO>(osobaId);
            _osobaRepository.MapTo(osobaId);
        }

        public void Delete(int id)
        {
            var osobaId = _osobaRepository.Get(id);
            _osobaRepository.Delete(osobaId);

        }
    }
}
