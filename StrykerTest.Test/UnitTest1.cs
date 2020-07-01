using NUnit.Framework;

namespace StrykerTest.Test
{
    [TestFixture]
    public class FooTests
    {
        [Test]
        public void Test1()
        {
            var foo = new Foo();

            Assert.IsTrue(foo.Bar(0));
        }
    }
}