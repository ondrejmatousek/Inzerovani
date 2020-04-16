using Castle.DynamicProxy;
using System;

namespace Inzerovani.CompositionRoot.Aop
{
    public class LoggingAspect : IInterceptor
    {
        [Obsolete]
        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }

            
            catch (Exception)
            {
                
                
                throw new Exception("Došlo k chybě");
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
