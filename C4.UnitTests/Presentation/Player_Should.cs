using C4.Presentation.Model;
using NUnit.Framework;

namespace C4.UnitTests.Presentation
{
    [TestFixture]
    public class Player_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectValue()
        {
            var sut = new Player("Daniel Dutton", hasCurrentTurn: false);

            const string expected = "[Player] Name:Daniel Dutton HasCurrentTurn:False";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
