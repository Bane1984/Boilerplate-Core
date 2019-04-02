using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using BoilerplateCore.DTO;
using BoilerplateCore.Interfaces;
using BoilerplateCore.Models;
using System.Collections.Generic;
using Abp.UI;

namespace BoilerplateCore.Services
{
    public class RKancelarija:BoilerplateCoreAppServiceBase, IKancelarija
    {
        //dodao Eksepsne
        private readonly IRepository<Kancelarija> _repositoryKancelarija;
        private readonly IObjectMapper _objectMapper;

        public RKancelarija(IRepository<Kancelarija> repositoryKancelarija, IObjectMapper objectMapper)
        {
            _repositoryKancelarija = repositoryKancelarija;
            _objectMapper = objectMapper;
        }


        
        //List<T> GetAll();
        public List<KancelarijaDTO> GetAll()
        {
            var kancelarija = _repositoryKancelarija.GetAll();
            var kancelarijaDto = new List<KancelarijaDTO>(_objectMapper.Map<List<KancelarijaDTO>>(kancelarija));
            return kancelarijaDto;
        }


        //T GetById(int id);
        public KancelarijaDTO GetById(int id)
        {
            var kancelarija = _repositoryKancelarija.Get(id);
            //if (kancelarija==null)
            //{

            //    throw new UserFriendlyException("Unijeli ste kancelariju sa nepostojecim Id-em.");
            //}
            var kancelarijaDto = _objectMapper.Map<KancelarijaDTO>(kancelarija);
            return kancelarijaDto;
        }


        //void Create(T entitet);
        public void Create(KancelarijaDTO entitet)
        {
            //var kanc = _repositoryKancelarija.FirstOrDefault(c => c.Id == entitet.Id);
            //if (kanc!=null)
            //{
            //    throw new UserFriendlyException("Kanceelarija sa naznacenim Id vec posoji.");
            //}
            var kancelarija = _objectMapper.Map<Kancelarija>(entitet);
            _repositoryKancelarija.Insert(kancelarija);
        }

        //void Update(T entitet);
        public void Update(int id, KancelarijaDTO entitet)
        {
            var kancelarijaById = _repositoryKancelarija.FirstOrDefault(c => c.Id == id);
            if (kancelarijaById==null)
            {
                throw new UserFriendlyException("Unijeli ste nepostojeci Id.");
            }
            _objectMapper.Map(entitet, kancelarijaById);
        }



        //void Delete(int id);
        public void Delete(int id)
        {
            var kancelarijaId = _repositoryKancelarija.FirstOrDefault(c => c.Id == id);
            if (kancelarijaId==null)
            {
                throw new UserFriendlyException("Unijeli ste nepostojeci Id.");
            }
            _repositoryKancelarija.Delete(kancelarijaId);
        }
    }
}
