using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using BoilerplateCore.DTO;
using BoilerplateCore.Interfaces;
using BoilerplateCore.Models;
using System.Collections.Generic;
using Abp.UI;

namespace BoilerplateCore.Services
{
    public class RUredjaj:BoilerplateCoreAppServiceBase, IUredjaj
    {
        //moram ukljuciti Osobe, KoristenjeUredjaja...
        private readonly IRepository<Uredjaj> _repositoryUredjaj;
        private readonly IObjectMapper _objectMapper;

        public RUredjaj(IRepository<Uredjaj> repositoryUredjaj, IObjectMapper objectMapper)
        {
            _repositoryUredjaj = repositoryUredjaj;
            _objectMapper = objectMapper;
        }


        //List<T> GetAll();
        public ListaUredjajaDTO GetAll()
        {
            var uredjaj = _repositoryUredjaj.GetAll();
            var uredjajDto = new ListaUredjajaDTO(_objectMapper.Map<List<UredjajDTO>>(uredjaj));
            return uredjajDto;
        }


        //T GetById(int id);
        public UredjajDTO GetById(int id)
        {
            var uredjaj = _repositoryUredjaj.FirstOrDefault(c => c.Id == id);
            if (uredjaj == null)
            {
                throw new UserFriendlyException("Unijeli ste uredjaj sa nepostojecim Id-em.");
            }
            var uredjajDto = _objectMapper.Map<UredjajDTO>(uredjaj);
            return uredjajDto;
        }


        //void Create(T entitet);
        public void Create(UredjajDTO entitet)
        {
            var provKancelarije = _repositoryUredjaj.FirstOrDefault(c => c.Id == entitet.Id);
            if (provKancelarije!=null)
            {
                throw new UserFriendlyException("Uredjaj sa naznacenim Id vec posoji.");
            }
            var kancelarija = _objectMapper.Map<Uredjaj>(entitet);
            _repositoryUredjaj.Insert(kancelarija);
        }

        //void Update(T entitet);
        public void Update(int id, UredjajDTO entitet)
        {
            var uredjajById = _repositoryUredjaj.FirstOrDefault(c => c.Id == entitet.Id);
            if (uredjajById==null)
            {
                throw new UserFriendlyException("Uredjaj sa naznacenim Id ne posoji.");
            }
            _objectMapper.Map(entitet, uredjajById);
        }



        //void Delete(int id);
        public void Delete(int id)
        {
            var uredjajId = _repositoryUredjaj.FirstOrDefault(c => c.Id == id);
            if (uredjajId == null)
            {
                throw new UserFriendlyException("Unijeli ste nepostojeci Id.");
            }
            _repositoryUredjaj.Delete(uredjajId);
        }
    }
}
