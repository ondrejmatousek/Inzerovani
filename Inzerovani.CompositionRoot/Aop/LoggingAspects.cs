using Castle.DynamicProxy;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzerovani.CompositionRoot.Aop
{
    public class LoggingAspects : IInterceptor
    {
        [Obsolete]
        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }

            //catch (KisException)
            //{
            //    //pouze přeposíláme výš, zpracuje až někdo, kdo reprezentuje data (GUI,WS)
            //    throw;
            //}
            //catch (DBConcurrencyException exception)
            //{
            //    throw exception;
            //}
            //catch (SqlException e)
            //{
            //    switch (e.Number)
            //    {
            //        case 2627:
            //            throw new UniqueEvidencniCisloPesException(e.Message);
            //        case 547:
            //            throw new ExistujeVzdalenyKlicException("Položka je součásti jiného záznamu");

            //        default:
            //            throw e;
            //    }
            //}
            catch (Exception exception)
            {
                //jedine misto, kde se překlápí Exception do KontrolaException
                //ZalogujVyjimku(invocation, exception);
                //throw new KisException("Došlo k chybě");
            }


        }

        //[Obsolete]
        //private void ZalogujVyjimku(IInvocation invocation, Exception exception)
        //{
        //    string parametry = $"[{String.Join(",", invocation.Arguments.Select(arg => arg.ToString()))}]";
        //    Logger.Error("Hodnoty parametru pred chybou: " + parametry, exception);
        //}

    }
}
