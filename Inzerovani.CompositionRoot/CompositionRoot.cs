using DataAccessLayer;
using DryIoc;
using Inzerovani.ServiceLayer;
using Inzerovani.ServiceLayer.Implementace;

namespace Inzerovani.CompositionRoot
{
    public class CompositionRoot
    {
        public IContainer IocContainer;
        public void Compose()
        {
            IocContainer = new Container();


            //DAO VRSTVA
            IocContainer.Register<IInzeratDao, InzeratDao>();

            //Servisní Vrstva
            IocContainer.Register<IInzeratService, InzeratService>();

            ////zaregistrovani vsech sluzeb, ktere maji mit intercptor spolu s patricnym interceptorem
            //IocContainer.Intercept<IPesService, LoggingAspect>();

            DalInitializer.Init();
        }
    }
}
