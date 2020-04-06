using AutoFixture;
using AutoFixture.Xunit2;
using Inzerovani.DomainModel.Model;
using Xunit;

namespace Inzerovani.Tests.Model
{
    public class InzeratTest
    {
      
        [Theory, AutoData]
       
        public void EqualsTest(Inzerat inzerat)
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new NoIdSpecimenBuilder());
            var inzerat2 = fixture.Create<Inzerat>();
            Assert.Equal(inzerat, inzerat2);
        }
    }
}
