using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using BoilerplateCore.DTO;

namespace BoilerplateCore.Interfaces
{
    public interface IUredjaj:IApplicationService
    {
        ListaUredjajaDTO GetAll();
        UredjajDTO GetById(int id);
        void Create(UredjajDTO entitet);
        void Update(UredjajDTO entitet);
        void Delete(int id);
    }
}
