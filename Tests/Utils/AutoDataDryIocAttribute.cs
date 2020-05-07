using AutoFixture;

namespace Inzerovani.Tests.Utils
{
    class AutoDataDryIocAttribute : AutoFixture.Xunit2.AutoDataAttribute
    {

        public AutoDataDryIocAttribute() : base(new Fixture()
            //.Customize(new DryIocCustomization())
            )
        {

        }
    }
}
