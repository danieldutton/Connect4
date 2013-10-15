using C4.Model;
using NUnit.Framework;

namespace C4.Tests_Unit.Model
{
    [TestFixture]
    public class Tile_Should
    {
        [Test]
        public void ToString_ShouldReturnTheCorrectStringValue()
        {
            var sut = new Tile {YPosition = 0, XPosition = 1, GameToken = GameToken.Red};

            const string expected = "[Tile] XPosition:0 YPosition:1 GameToken:Red";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
