using Castle.DynamicProxy;
using DryIoc;

namespace CompositionRoot.Aop
{
    public static class DryIocInterception
    {
        public static void Intercept<TService, TInterceptor>(this IRegistrator registrator, object serviceKey = null) where TInterceptor : class, IInterceptor { }
    }
}
