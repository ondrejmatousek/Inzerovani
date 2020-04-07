using DryIoc;
using DryIoc.Mvc;
using Inzerovani.Mappers;
using Inzerovani.Mappers.Implementace;
using System;
using System.Configuration;

namespace Inzerovani
{
    public class CompositionRootWeb
    {
        private readonly ConnectionStringSettings connString;
        public CompositionRootWeb(ConnectionStringSettings connString)
        {
            this.connString = connString ?? throw new ArgumentNullException(nameof(connString));
        }

        public void Compose()
        {
            var compositionRoot = new Inzerovani.CompositionRoot.CompositionRoot();
            compositionRoot.Compose();
            var IocContainer = compositionRoot.IocContainer;

            IocContainer = IocContainer.WithMvc();
            IocContainer.Register<IMapperWeb, MapperWeb>();

            IocContainer.UseInstance(connString);



        }
    }
}