using DataAccessLayer;
using DryIoc;
using Inzerovani.CompositionRoot.Aop;
using Inzerovani.ServiceLayer;
using Inzerovani.ServiceLayer.Implementace;

namespace Inzerovani.CompositionRoot
{
    public class CompositionRoot
    {
        public IContainer IocContainer;
        public Container Compose()
        {
            var IocContainer = new Container();


            //DAO VRSTVA
            IocContainer.Register<IInzeratDao, InzeratDao>();
           

            //Servisní Vrstva
            IocContainer.Register<IInzeratService, InzeratService>();
            

            DalInitializer.Init();
            return IocContainer;
        }
    }
}
