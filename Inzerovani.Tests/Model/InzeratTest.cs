using Inzerovani.DomainModel.Model;
using Inzerovani.Tests.Utils;
using Xunit;

namespace Inzerovani.Tests.Model
{
    public class InzeratTest
    {
      
        [Theory]
        [AutoDataDryIoc]
        public void EqualsTest(Inzerat inzerat)
        {
            var inzerat2 = DeepCopier.DeepCopy(inzerat);
            Assert.Equal(inzerat, inzerat2);
        }
    }
}
