using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzerovani.Tests.Utils
{
    public static class DeepCopier
    {

        //
        // Summary:
        //     Vytvoří kopii objektu (deepcopy). Kopírovaný objekt musí být serializovatelný.
        //
        // Parameters:
        //   obj:
        //     Serializovatelný objekt
        //
        // Type parameters:
        //   T:
        public extern static T DeepCopy<T>(T obj);
    }
}

