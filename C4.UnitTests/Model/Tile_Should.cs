using C4.Model;
using NUnit.Framework;

namespace C4._UnitTests.Model
{
    [TestFixture]
    public class Tile_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectStringValue()
        {
            var sut = new Tile { YPosition = 0, XPosition = 1, GameToken = GameToken.Red};

            const string expected = "[Tile] XPosition:1 YPosition:0 GameToken:Red";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
