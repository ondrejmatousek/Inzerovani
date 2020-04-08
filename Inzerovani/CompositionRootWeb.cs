using DryIoc;
using DryIoc.Mvc;
using Inzerovani.Mappers;
using Inzerovani.Mappers.Implementace;
using compos = Inzerovani.CompositionRoot;
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

            compos.CompositionRoot compositionRoot = new compos.CompositionRoot();
            compositionRoot.Compose();


            var IocContainer = compositionRoot.IocContainer;
            IocContainer = IocContainer.WithMvc();
            IocContainer.Register<IMapperWeb, MapperWeb>();

            IocContainer.UseInstance(connString);
        }
    }
}