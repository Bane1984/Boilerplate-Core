using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;

namespace BoilerplateCore.Interfaces
{
    public interface IGeneric<T>:IApplicationService where T : class
    {
        T GetAll();
        T GetById(int id);
        void Create(T entitet);
        void Update(T entitet);
        void Delete(int id);
    }
}
