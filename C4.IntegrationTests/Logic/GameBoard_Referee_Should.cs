using C4.Logic;
using NUnit.Framework;

namespace C4.Tests_Integration.Logic
{
    [TestFixture]
    public class GridGenerator_GameGrid_Should
    {
        [Test]
        public void ReturnOnlyASingletonInstance()
        {
            var gameBoard1 = GameBoard.GetGameInstance();
            var gameBoard2 = GameBoard.GetGameInstance();

            Assert.AreSame(gameBoard1, gameBoard2);
        }
    }
}
