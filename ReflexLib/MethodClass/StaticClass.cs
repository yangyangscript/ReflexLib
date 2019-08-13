using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexLib.MethodClass
{
    public static class StaticClass
    {
        public static RetClass StaticNoParamsRet()
        {
            return new RetClass()
            {
                Id = 1,Name = "a test name"
            };
        }

        public static List<RetClass> StaticWithParamsRet(int counts)
        {
            var ret= new List<RetClass>();
            int i = 0;
            while (i<counts)
            {
                ret.Add(new RetClass()
                {
                    Id = i,
                    Name = $"TestName{i}",
                });
                i++;
            }
            return ret;
        }

        public static List<RetClass> StaticWithParamsRet(int counts,string name)
        {
            var ret = new List<RetClass>();
            int i = 0;
            while (i < counts)
            {
                ret.Add(new RetClass()
                {
                    Id = i,
                    Name = $"{name}{i}",
                });
                i++;
            }
            return ret;
        }
    }
}
