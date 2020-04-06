using AutoFixture.Kernel;
using DryIoc;

namespace Inzerovani.Tests
{
    //
    // Summary:
    //     Umožnuje AutoFixture vytáhnout požadováné instance z IoC kontejneru, pokud tam
    //     jsou.
    public class DryIocAdapter : ISpecimenBuilder
    {
        public extern DryIocAdapter(IContainer iocContainer);
        

        public extern object Create(object request, ISpecimenContext context);
    }
}
