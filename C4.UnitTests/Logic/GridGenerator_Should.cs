using C4.Logic;
using C4.Model;
using NUnit.Framework;
using System.Linq;

namespace C4.UnitTests.Logic
{
    [TestFixture]
    public class GridGenerator_Should
    {
        private GridGenerator<Tile> _sut;

        private const int XDimensionLength = 7;

        private const int YDimensionLength = 6;


        [SetUp]
        public void Init()
        {
            _sut = new GridGenerator<Tile>();
        }

        [Test]
        public void GetGrid_GenerateAGridOfIndexLengthSevenOnTheXAxis()
        {
            const int expected = 7;
            int actual = _sut.GetGrid(XDimensionLength, YDimensionLength).GetLength(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_GenerateAGridOfIndexLengthSixOnTheYAxis()
        {
            const int expected = 6;
            int actual = _sut.GetGrid(XDimensionLength, YDimensionLength).GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_GenerateAGridWithATotalOf42Indexes()
        {
            const int expected = 42;
            int actual = _sut.GetGrid(XDimensionLength, YDimensionLength).Length;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_GenerateAGridWithNoNullElements()
        {
            Tile[] grid = _sut.GetGrid(XDimensionLength, YDimensionLength).Cast<Tile>().ToArray();
            
            Assert.IsTrue(grid.All(t => t != null));
        }

        [Test]
        public void GetGrid_GenerateAGridWhereEachElementIsOfTypeTile()
        {
            Tile[] grid = _sut.GetGrid(XDimensionLength, YDimensionLength).Cast<Tile>().ToArray();

            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof (Tile));
        }

        [Test]
        public void GetGrid_GenerateAGridWhereEachTileElementsGameTokenPropertyIsUndefined()
        {
            Tile[] grid = _sut.GetGrid(XDimensionLength, YDimensionLength).Cast<Tile>().ToArray();

            Assert.IsTrue(grid.All(t => t.GameToken == GameToken.Undefined));
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_0()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 0;
            const int expectedY = 0;

            int actualX = grid[0, 0].XPosition;
            int actualY = grid[0, 0].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_1()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 0;
            const int expectedY = 1;

            int actualX = grid[0, 1].XPosition;
            int actualY = grid[0, 1].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_2()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 0;
            const int expectedY = 2;

            int actualX = grid[0, 2].XPosition;
            int actualY = grid[0, 2].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_3()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 0;
            const int expectedY = 3;

            int actualX = grid[0, 3].XPosition;
            int actualY = grid[0, 3].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_4()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 0;
            const int expectedY = 4;

            int actualX = grid[0, 4].XPosition;
            int actualY = grid[0, 4].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_5()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 0;
            const int expectedY = 5;

            int actualX = grid[0, 5].XPosition;
            int actualY = grid[0, 5].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_0()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 1;
            const int expectedY = 0;

            int actualX = grid[1, 0].XPosition;
            int actualY = grid[1, 0].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_1()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 1;
            const int expectedY = 1;

            int actualX = grid[1, 1].XPosition;
            int actualY = grid[1, 1].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_2()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 1;
            const int expectedY = 2;

            int actualX = grid[1, 2].XPosition;
            int actualY = grid[1, 2].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_3()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 1;
            const int expectedY = 3;

            int actualX = grid[1, 3].XPosition;
            int actualY = grid[1, 3].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_4()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 1;
            const int expectedY = 4;

            int actualX = grid[1, 4].XPosition;
            int actualY = grid[1, 4].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_5()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 1;
            const int expectedY = 5;

            int actualX = grid[1, 5].XPosition;
            int actualY = grid[1, 5].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_0()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 2;
            const int expectedY = 0;

            int actualX = grid[2, 0].XPosition;
            int actualY = grid[2, 0].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_1()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 2;
            const int expectedY = 1;

            int actualX = grid[2, 1].XPosition;
            int actualY = grid[2, 1].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_2()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 2;
            const int expectedY = 2;

            int actualX = grid[2, 2].XPosition;
            int actualY = grid[2, 2].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_3()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 2;
            const int expectedY = 3;

            int actualX = grid[2, 3].XPosition;
            int actualY = grid[2, 3].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_4()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 2;
            const int expectedY = 4;

            int actualX = grid[2, 4].XPosition;
            int actualY = grid[2, 4].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_5()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 2;
            const int expectedY = 5;

            int actualX = grid[2, 5].XPosition;
            int actualY = grid[2, 5].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_0()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 3;
            const int expectedY = 0;

            int actualX = grid[3, 0].XPosition;
            int actualY = grid[3, 0].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_1()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 3;
            const int expectedY = 1;

            int actualX = grid[3, 1].XPosition;
            int actualY = grid[3, 1].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_2()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 3;
            const int expectedY = 2;

            int actualX = grid[3, 2].XPosition;
            int actualY = grid[3, 2].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_3()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 3;
            const int expectedY = 3;

            int actualX = grid[3, 3].XPosition;
            int actualY = grid[3, 3].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_4()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 3;
            const int expectedY = 4;

            int actualX = grid[3, 4].XPosition;
            int actualY = grid[3, 4].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_5()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 3;
            const int expectedY = 5;

            int actualX = grid[3, 5].XPosition;
            int actualY = grid[3, 5].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_0()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 4;
            const int expectedY = 0;

            int actualX = grid[4, 0].XPosition;
            int actualY = grid[4, 0].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_1()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 4;
            const int expectedY = 1;

            int actualX = grid[4, 1].XPosition;
            int actualY = grid[4, 1].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_2()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 4;
            const int expectedY = 2;

            int actualX = grid[4, 2].XPosition;
            int actualY = grid[4, 2].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_3()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 4;
            const int expectedY = 3;

            int actualX = grid[4, 3].XPosition;
            int actualY = grid[4, 3].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_4()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 4;
            const int expectedY = 4;

            int actualX = grid[4, 4].XPosition;
            int actualY = grid[4, 4].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_5()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 4;
            const int expectedY = 5;

            int actualX = grid[4, 5].XPosition;
            int actualY = grid[4, 5].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_0()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 5;
            const int expectedY = 0;

            int actualX = grid[5, 0].XPosition;
            int actualY = grid[5, 0].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_1()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 5;
            const int expectedY = 1;

            int actualX = grid[5, 1].XPosition;
            int actualY = grid[5, 1].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_2()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 5;
            const int expectedY = 2;

            int actualX = grid[5, 2].XPosition;
            int actualY = grid[5, 2].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_3()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 5;
            const int expectedY = 3;

            int actualX = grid[5, 3].XPosition;
            int actualY = grid[5, 3].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_4()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 5;
            const int expectedY = 4;

            int actualX = grid[5, 4].XPosition;
            int actualY = grid[5, 4].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_5()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 5;
            const int expectedY = 5;

            int actualX = grid[5, 5].XPosition;
            int actualY = grid[5, 5].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_6_0()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 6;
            const int expectedY = 0;

            int actualX = grid[6, 0].XPosition;
            int actualY = grid[6, 0].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_6_1()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 6;
            const int expectedY = 1;

            int actualX = grid[6, 1].XPosition;
            int actualY = grid[6, 1].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_6_2()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 6;
            const int expectedY = 2;

            int actualX = grid[6, 2].XPosition;
            int actualY = grid[6, 2].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_6_3()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 6;
            const int expectedY = 3;

            int actualX = grid[6, 3].XPosition;
            int actualY = grid[6, 3].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_6_4()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 6;
            const int expectedY = 4;

            int actualX = grid[6, 4].XPosition;
            int actualY = grid[6, 4].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_6_5()
        {
            Tile[,] grid = _sut.GetGrid(XDimensionLength, YDimensionLength);

            const int expectedX = 6;
            const int expectedY = 5;

            int actualX = grid[6, 5].XPosition;
            int actualY = grid[6, 5].YPosition;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
