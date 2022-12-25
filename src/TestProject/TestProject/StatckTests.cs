using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Ninja.UnitTest
{
    [TestFixture]
    public class StatckTests
    {
        private Stck<object> _stack;
        [SetUp]
        public void InitializedObjct()
        {
            _stack = new Stck<object>();
        }

        [Test]
        public void Push_objectArguent_throughNullorException()
        {
            Assert.That(() => _stack.Push(null),Throws.ArgumentNullException);
        }
    }
}
