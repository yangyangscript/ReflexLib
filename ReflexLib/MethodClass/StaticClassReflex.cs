using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ReflexLib.MethodClass;

namespace ReflexLib.MethodClass
{
    public static class StaticClassReflex
    {
        private static Type staticClassType = Assembly.Load("ReflexLib").GetType("ReflexLib.MethodClass.StaticClass");

        

        public static object StaticInvokeMethod(string methodName, Type[] types,object[] obParams)
        {
            if(types==null) types=new Type[]{};
            MethodInfo method = staticClassType.GetMethod(methodName, types);
            if (method == null) return null;
            return method.Invoke(null, obParams);
        }
    }
}
