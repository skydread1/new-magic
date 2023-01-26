// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;
using System.Reflection;

namespace Magic
{
    public class CallsiteStaticMethod07
    {
        Type Target;
        string MemberName;
        CallSiteCache07 cache;

        public CallsiteStaticMethod07(Type target, string memberName)
        {
            Target = target;
            MemberName = memberName;
            cache = new CallSiteCache07();
        }

        public object Invoke(object arg0,object arg1,object arg2,object arg3,object arg4,object arg5,object arg6)
        {
            if(cache.TryGet(arg0,arg1,arg2,arg3,arg4,arg5,arg6, out var result))
                return result(arg0,arg1,arg2,arg3,arg4,arg5,arg6);

            var method = Dispatch.BindToMethod(BindingFlags.Public | BindingFlags.Instance, Target, MemberName, new [] { arg0,arg1,arg2,arg3,arg4,arg5,arg6 });
            if (method != null)
            {
                var f = DelegateHelpers.GetMethodDelegate07(method);
                cache.CacheMethod(arg0,arg1,arg2,arg3,arg4,arg5,arg6, f);
                return f(arg0,arg1,arg2,arg3,arg4,arg5,arg6);
            }
            throw new ArgumentException($"Could not invoke static method `{MemberName}` on type {Target} with argument types {arg0.GetType()}, {arg1.GetType()}, {arg2.GetType()}, {arg3.GetType()}, {arg4.GetType()}, {arg5.GetType()}, {arg6.GetType()}.");
        }
    }
}