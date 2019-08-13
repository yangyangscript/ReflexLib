using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflexLib.MethodClass
{
    public static class InstanceClassReflex
    {
        private static Type instanceClassType = Assembly.Load("ReflexLib").GetType("ReflexLib.MethodClass.InstanceClass");

        public static object InstanceInvokeMethod(string methodName, Type[] types, object[] obParams)
        {
            if (types == null) types = new Type[] { };
            MethodInfo method = instanceClassType.GetMethod(methodName, types);            
            if (method == null) return null;
            object instance = Activator.CreateInstance(instanceClassType, new[] { "instanceClass" });
            return method.Invoke(instance, obParams);
        }


    }
}
