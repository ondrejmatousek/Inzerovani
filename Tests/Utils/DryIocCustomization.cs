using AutoFixture;
using DryIoc;
using System.Configuration;

namespace Inzerovani.Tests.Utils
{
    public class DryIocCustomization : ICustomization
    {
        private readonly Inzerovani.CompositionRoot.CompositionRoot compositionRoot;

        public DryIocCustomization()
        {
            compositionRoot = new Inzerovani.CompositionRoot.CompositionRoot();
            compositionRoot.Compose();


            ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["ConnectionStringLocal"];
            compositionRoot.IocContainer.UseInstance(connString);
        }
        
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new DryIocAdapter(compositionRoot.IocContainer));
        }
    }
}
