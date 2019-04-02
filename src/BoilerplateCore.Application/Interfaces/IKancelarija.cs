using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using BoilerplateCore.DTO;

namespace BoilerplateCore.Interfaces
{
    public interface IKancelarija : IApplicationService
    {
        List<KancelarijaDTO> GetAll();
        KancelarijaDTO GetById(int id);
        void Create(KancelarijaDTO entitet);
        void Update(int id, KancelarijaDTO entitet);
        void Delete(int id);
    }
}
