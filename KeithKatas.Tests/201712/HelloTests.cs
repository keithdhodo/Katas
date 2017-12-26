using KeithKatas.December2017;
using NUnit.Framework;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class HelloTests
    {
        [Test]
        public void Hello_Greet_MyTest()
        {
            Assert.AreEqual(Hello.Greet("Niks"), "hello Niks!");
            Assert.AreEqual(Hello.Greet(""), null);
            Assert.AreEqual(Hello.Greet(null), null);
            Assert.AreEqual(Hello.Greet("Frank Underwood"), "hello Frank Underwood!");
            Assert.AreEqual(Hello.Greet(" "), "hello  !");
            Assert.AreEqual(Hello.Greet("!!"), "hello !!!");
            Assert.AreEqual(Hello.Greet("asdawidsaiodfwiodaosdp[awfodskawdsoafkwad@"), "hello asdawidsaiodfwiodaosdp[awfodskawdsoafkwad@!");
        }
    }
}
