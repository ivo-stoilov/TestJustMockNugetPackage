using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using MyClassLibrary;

namespace MyClassLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock.Arrange(() => Class1.StaticMethod(Arg.AnyInt))
                .DoNothing()
                .MustBeCalled();
            
            Class1.StaticMethod(10);

            Mock.Assert<Class1>();
        }
    }
}
