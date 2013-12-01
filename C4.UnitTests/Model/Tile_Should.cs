using C4.Model;
using NUnit.Framework;

namespace C4._UnitTests.Model
{
    [TestFixture]
    public class Tile_Should
    {
        [Test]
        public void ToString_ShouldReturnTheCorrectStringValue()
        {
            var sut = new Tile { ColumnNumber = 0, RowNumber = 1, GameToken = GameToken.Red};

            const string expected = "[Tile] RowNumber:1 ColumnNumber:0 GameToken:Red";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
