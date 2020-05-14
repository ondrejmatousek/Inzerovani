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
            var kopie = DeepCopier.DeepCopy(inzerat);
            Assert.Equal(inzerat, kopie);
        }

        [Theory]
        [AutoDataDryIoc]
        public void NotEquals(Inzerat inzerat)
        {
            var generator = new GeneratorUpravenychObjektu(true);
            var upravene = generator.VygenerujListUpravenychObjektu(inzerat);

            foreach (var upraveny in upravene)
                Assert.NotEqual(inzerat, upraveny);
        }

        [Theory]
        [AutoDataDryIoc]
        public void NotEquals_NepadneNaNull(Inzerat inzerat)
        {
            var generator = new GeneratorUpravenychObjektu(true, true);
            var upravene = generator.VygenerujListUpravenychObjektu(inzerat);

            foreach (var upraveny in upravene)
                inzerat.Equals(upraveny);
        }
    }
}
