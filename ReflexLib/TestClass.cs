using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflexLib.MethodClass;
using Xunit;

namespace ReflexLib
{

    public class TestClass
    {
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;

        public TestClass(Xunit.Abstractions.ITestOutputHelper iTestOutputHelper)
        {
            _testOutputHelper = iTestOutputHelper;
        }

        [Fact]
        public void TestStaticNoParamsRet()
        {
            var ret = (RetClass) MethodClass.StaticClassReflex.StaticInvokeMethod("StaticNoParamsRet", null, null);
            _testOutputHelper.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(ret));
        }

        [Fact]
        public void TestStaticWithParamsRet()
        {
            var firTypes = new Type[] {typeof(System.Int32)};
            var firParams = new object[] {10};
            var firRet =
                MethodClass.StaticClassReflex.StaticInvokeMethod("StaticWithParamsRet", firTypes,
                    firParams) as List<RetClass>;
            _testOutputHelper.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(firRet));

            _testOutputHelper.WriteLine("---分割线---");

            var secTypes = new Type[] {typeof(System.Int32), typeof(System.String)};
            var secParams = new object[] {10, "NewName"};
            var secRet =
                MethodClass.StaticClassReflex.StaticInvokeMethod("StaticWithParamsRet", secTypes,
                    secParams) as List<RetClass>;
            _testOutputHelper.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(secRet));
        }



        [Fact]
        public void TestInstanceNoParamsRet()
        {
            var ret = (RetClass) MethodClass.InstanceClassReflex.InstanceInvokeMethod("InstanceNoParamsRet", null, null);
            _testOutputHelper.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(ret));
        }

        [Fact]
        public void TestInstanceWithParamsRet()
        {
            var firTypes = new Type[] { typeof(System.Int32) };
            var firParams = new object[] { 10 };
            var firRet =
                MethodClass.InstanceClassReflex.InstanceInvokeMethod("InstanceWithParamsRet", firTypes,
                    firParams) as List<RetClass>;
            _testOutputHelper.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(firRet));

            _testOutputHelper.WriteLine("---分割线---");

            var secTypes = new Type[] { typeof(System.Int32), typeof(System.String) };
            var secParams = new object[] { 10, "NewName" };
            var secRet =
                MethodClass.InstanceClassReflex.InstanceInvokeMethod("InstanceWithParamsRet", secTypes,
                    secParams) as List<RetClass>;
            _testOutputHelper.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(secRet));
        }
    }
}
