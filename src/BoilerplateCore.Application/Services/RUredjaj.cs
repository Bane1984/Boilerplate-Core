using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using BoilerplateCore.DTO;
using BoilerplateCore.Interfaces;
using BoilerplateCore.Models;

namespace BoilerplateCore.Services
{
    public class RUredjaj:BoilerplateCoreAppServiceBase, IUredjaj
    {
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
            var uredjaj = _repositoryUredjaj.Get(id);
            var uredjajDto = _objectMapper.Map<UredjajDTO>(uredjaj);
            return uredjajDto;
        }


        //void Create(T entitet);
        public void Create(UredjajDTO entitet)
        {
            var kancelarija = _objectMapper.Map<Uredjaj>(entitet);
            _repositoryUredjaj.Insert(kancelarija);
        }

        //void Update(T entitet);
        public void Update(UredjajDTO entitet)
        {
            var uredjajById = _repositoryUredjaj.Get(entitet.Id);
            _objectMapper.Map(entitet, uredjajById);
        }



        //void Delete(int id);
        public void Delete(int id)
        {
            var uredjajId = _repositoryUredjaj.Get(id);
            _repositoryUredjaj.Delete(uredjajId);
        }
    }
}
