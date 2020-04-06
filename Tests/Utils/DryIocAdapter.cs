using AutoFixture.Kernel;
using DryIoc;
using System.Reflection;

namespace Inzerovani.Tests
{
    //
    // Summary:
    //     Umožnuje AutoFixture vytáhnout požadováné instance z IoC kontejneru, pokud tam
    //     jsou.
    public class NoIdSpecimenBuilder : ISpecimenBuilder
    {
        public NoIdSpecimenBuilder()
        {
        }

        public extern NoIdSpecimenBuilder(IContainer iocContainer);


        public object Create(object request, ISpecimenContext context)
        {
            var propertyInfo = request as PropertyInfo;
            if (propertyInfo != null &&
                propertyInfo.Name.Equals("Id") &&
                propertyInfo.PropertyType == typeof(string))
            {
                return new OmitSpecimen();
            }

            return new NoSpecimen();
        }
    }
}
