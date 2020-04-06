using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzerovani.Tests.Utils
{
    class AutoDataDryIocAttribute : AutoFixture.Xunit2.AutoDataAttribute
    {
       
        public AutoDataDryIocAttribute() : base(new Fixture()
            .Customize(new DryIocCustomization())
            )
        {

        }
    }
}
