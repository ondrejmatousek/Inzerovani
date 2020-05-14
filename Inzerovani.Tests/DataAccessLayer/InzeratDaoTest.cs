using DataAccessLayer;
using Inzerovani.DomainModel.Model;
using Inzerovani.Tests.Utils;
using Xunit;

namespace Tests.DataAccessLayer
{

    public class InzeratDaoTest
    {
        [Theory]
        [AutoDataDryIoc]
        public void UlozANactiInzerat(Inzerat inzerat, IInzeratDao inzeratDao)
        {
            inzeratDao.Insert(inzerat);
            var inzeratZDB = inzeratDao.GetById(inzerat.IdInzerat);
            Assert.Equal(inzerat, inzeratZDB);
        }
    }
}
