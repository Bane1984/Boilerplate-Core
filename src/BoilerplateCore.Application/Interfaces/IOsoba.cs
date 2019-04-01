using Abp.Application.Services;
using BoilerplateCore.DTO;
using BoilerplateCore.Models;

namespace BoilerplateCore.Interfaces
{
    public interface IOsoba:IApplicationService
    {
        ListaOsobaDto GetAll();
        OsobaDTO GetById(int id);
        void Create(OsobaCreateDto entitet);
        void Update(OsobaCreateDto entitet);
        Osoba GetByIdKanc(int id);
        void Delete(int id);
    }
}
