using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace Castle.Facilities.WcfIntegration.Tests.Components
{
    public class CacheInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.ReturnValue = Result;
            //invocation.Proceed();
        }

        public static object Result { get; set; }
    }
}
