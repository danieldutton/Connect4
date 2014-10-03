using C4.GridBuilder.Model;
using NUnit.Framework;

namespace C4.UnitTests.GridBuilder
{
    [TestFixture]
    public class Tile_Should
    {        
        [Test]
        public void IsEmpty_ReturnTrue_IfTileHasAnUndefinedToken()
        {
            var sut = new Tile { GameToken = GameToken.Undefined };

            Assert.IsTrue(sut.IsEmpty());
        }

        [Test]
        public void IsEmpty_ReturnFalse_IfTileHasAYellowToken()
        {
            var sut = new Tile { GameToken = GameToken.Yellow };

            Assert.IsFalse(sut.IsEmpty());
        }

        [Test]
        public void IsEmpty_ReturnFalse_IfTileHasARedToken()
        {
            var sut = new Tile { GameToken = GameToken.Red };

            Assert.False(sut.IsEmpty());
        }

        [Test]
        public void ToString_ReturnTheCorrectStringValue()
        {
            var sut = new Tile { YPosition = 0, XPosition = 1, GameToken = GameToken.Red };

            const string expected = "[Tile] XPosition:1 YPosition:0 GameToken:Red";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }        
    }
}
