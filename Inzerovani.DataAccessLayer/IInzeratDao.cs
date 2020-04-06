using Inzerovani.DomainModel.Model;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IInzeratDao
    {
        List<Inzerat> GetAll();
        void Insert(Inzerat insertee);
        Inzerat GetById(int? IdInzerat);
        void Update(Inzerat insertee);
        void Delete(Inzerat inzerat);
    }
}
