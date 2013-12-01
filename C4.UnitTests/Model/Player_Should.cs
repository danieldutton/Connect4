using C4.Model;
using NUnit.Framework;

namespace C4._UnitTests.Model
{
    [TestFixture]
    public class Player_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectValue()
        {
            var sut = new Player {Name = "Daniel Dutton", HasCurrentTurn = false};

            const string expected = "[Player] Name:Daniel Dutton HasCurrentTurn:False";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
