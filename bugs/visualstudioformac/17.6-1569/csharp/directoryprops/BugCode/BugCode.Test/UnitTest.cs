namespace BugCode.Test
{
    using NUnit.Framework;
    using BugCode;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            var bc = new BugCodeApi();

            Assert.IsTrue(bc.IsTrue(true));

            Assert.IsFalse(bc.IsTrue(false));
        }
    }
}