using C4.GridBuilder;
using C4.GridBuilder.Interfaces;
using C4.Logic;
using C4.Logic.Interfaces;
using C4.Model;
using NUnit.Framework;

namespace C4.Tests_Integration.Logic
{
    [TestFixture]
    public class GridGenerator_GameGrid_Should
    {
        [Test]
        public void ReturnOnlyASingletonInstance()
        {
            IGridGenerator<Tile> gridGenerator = new GridGenerator<Tile>();
            Tile[,] gameGrid = gridGenerator.GetGrid(7, 6);
            var gameBoard1 = GameBoard.GetGameInstance(gameGrid);
            var gameBoard2 = GameBoard.GetGameInstance(gameGrid);

            Assert.AreSame(gameBoard1, gameBoard2);
        }
    }
}
