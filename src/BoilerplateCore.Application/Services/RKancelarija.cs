using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using BoilerplateCore.DTO;
using BoilerplateCore.Interfaces;
using BoilerplateCore.Models;
using System.Collections.Generic;

namespace BoilerplateCore.Services
{
    public class RKancelarija:BoilerplateCoreAppServiceBase, IKancelarija
    {
        private readonly IRepository<Kancelarija> _repositoryKancelarija;
        private readonly IObjectMapper _objectMapper;

        public RKancelarija(IRepository<Kancelarija> repositoryKancelarija, IObjectMapper objectMapper)
        {
            _repositoryKancelarija = repositoryKancelarija;
            _objectMapper = objectMapper;
        }


        
        //List<T> GetAll();
        public ListaKancelarijaDTO GetAll()
        {
            var kancelarija = _repositoryKancelarija.GetAll();
            var kancelarijaDto = new ListaKancelarijaDTO(_objectMapper.Map<List<KancelarijaDTO>>(kancelarija));
            return kancelarijaDto;
        }


        //T GetById(int id);
        public KancelarijaDTO GetById(int id)
        {
            var kancelarija = _repositoryKancelarija.Get(id);
            var kancelarijaDto = _objectMapper.Map<KancelarijaDTO>(kancelarija);
            return kancelarijaDto;
        }


        //void Create(T entitet);
        public void Create(KancelarijaDTO entitet)
        {
            var kancelarija = _objectMapper.Map<Kancelarija>(entitet);
            _repositoryKancelarija.Insert(kancelarija);
        }

        //void Update(T entitet);
        public void Update(KancelarijaDTO entitet)
        {
            var kancelarijaById = _repositoryKancelarija.Get(entitet.Id);
            _objectMapper.Map(entitet, kancelarijaById);
        }



        //void Delete(int id);
        public void Delete(int id)
        {
            var kancelarijaId = _repositoryKancelarija.Get(id);
            _repositoryKancelarija.Delete(kancelarijaId);
        }
    }
}
