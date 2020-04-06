using DataAccessLayer;
using Inzerovani.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzerovani.ServiceLayer.Implementace
{
    public class InzeratService : IInzeratService
    {
        private readonly IInzeratDao inzeratDao;
        public InzeratService(IInzeratDao inzeratDao)
        {
            this.inzeratDao = inzeratDao;
        }

        public List<Inzerat> GetAll()
        {
            return inzeratDao.GetAll();
        }

        public Inzerat GetById(int? Id)
        {
            return inzeratDao.GetById(Id);
        }

        public void Insert(Inzerat insertee)
        {
            inzeratDao.Insert(insertee);
        }

        public void Update(Inzerat insertee)
        {
            inzeratDao.Update(insertee);
        }

        public void Delete(Inzerat inzerat)
        {
            inzeratDao.Delete(inzerat);
        }
    }
}
