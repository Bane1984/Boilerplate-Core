using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using BoilerplateCore.DTO;

namespace BoilerplateCore.Interfaces
{
    public interface IKancelarija : IApplicationService
    {
        ListaKancelarijaDTO GetAll();
        KancelarijaDTO GetById(int id);
        void Create(KancelarijaDTO entitet);
        void Update(KancelarijaDTO entitet);
        void Delete(int id);
    }
}
