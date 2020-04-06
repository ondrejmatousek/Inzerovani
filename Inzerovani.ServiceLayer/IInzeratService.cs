using Inzerovani.DomainModel.Model;
using System.Collections.Generic;

namespace Inzerovani.ServiceLayer
{
    public interface IInzeratService
    {
        List<Inzerat> GetAll();
        void Insert(Inzerat insertee);
        Inzerat GetById(int? IdInzerat);
        void Update(Inzerat insertee);
        void Delete(Inzerat inzerat);
    }
}
