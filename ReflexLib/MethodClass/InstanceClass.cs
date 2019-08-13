using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexLib.MethodClass
{
    public class InstanceClass
    {
        private string _name { get; set; }

        public InstanceClass(string name)
        {
            _name = name;
        }

        public RetClass InstanceNoParamsRet()
        {
            return new RetClass()
            {
                Id = 1,
                Name = _name
            };
        }

        public List<RetClass> InstanceWithParamsRet(int counts)
        {
            var ret = new List<RetClass>();
            int i = 0;
            while (i < counts)
            {
                ret.Add(new RetClass()
                {
                    Id = i,
                    Name = $"{_name}TestName{i}",
                });
                i++;
            }
            return ret;
        }

        public List<RetClass> InstanceWithParamsRet(int counts, string name)
        {
            var ret = new List<RetClass>();
            int i = 0;
            while (i < counts)
            {
                ret.Add(new RetClass()
                {
                    Id = i,
                    Name = $"{_name}{name}{i}",
                });
                i++;
            }
            return ret;
        }
    }
}
