using AutoFixture.Kernel;
using DryIoc;
using System;

namespace Inzerovani.Tests
{
    //
    // Summary: Umožnuje AutoFixture vytáhnout požadováné instance z IoC kontejneru, pokud tam jsou.
    //
    public class DryIocAdapter : ISpecimenBuilder
    {
        private readonly IContainer iocContainer;

        public DryIocAdapter(IContainer iocContainer)
        {
            this.iocContainer = iocContainer;
        }

        public object Create(object request, ISpecimenContext context)
        {
            Type requestedType = request as Type;
            if (requestedType == null || !this.iocContainer.IsRegistered(requestedType))
                return new NoSpecimen();

            return iocContainer.Resolve(requestedType);
        }
    }
}
