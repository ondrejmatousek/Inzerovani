using AutoFixture;
using System.Configuration;
using DryIoc;

namespace Inzerovani.Tests.Utils
{
    public class DryIocCustomization : ICustomization
    {
        protected readonly Inzerovani.CompositionRoot.CompositionRoot compositionRoot;

        public DryIocCustomization()
        {
            compositionRoot = new Inzerovani.CompositionRoot.CompositionRoot();
            compositionRoot.Compose();


            ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["ConnectionStringLocal"];
            compositionRoot.IocContainer.UseInstance(connString);
        }
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new NoIdSpecimenBuilder(compositionRoot.IocContainer));
        }
    }
}
