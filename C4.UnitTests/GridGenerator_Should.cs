using C4.Logic;
using C4.Model;
using NUnit.Framework;
using System.Linq;

namespace C4.UnitTests
{
    [TestFixture]
    public class GridGenerator_Should
    {
        private GridGenerator<Tile> _sut;

        private const int GridXCount = 7;

        private const int GridYCount = 6;


        [SetUp]
        public void Init()
        {
            _sut = new GridGenerator<Tile>();
        }

        [Test]
        public void Generate_SevenElementsOnXDimension()
        {
            const int expected = 7;
            int actual = _sut.GetGrid(GridXCount, GridYCount).GetLength(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Generate_SixElementsOnYDimension()
        {
            const int expected = 6;
            int actual = _sut.GetGrid(GridXCount, GridYCount).GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Generate_FortyTwoElementsInCompleteArray()
        {
            const int expected = 42;
            int actual = _sut.GetGrid(GridXCount, GridYCount).Length;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AllTokenElementsInGridAreNotNull()
        {
            Tile[] grid = _sut.GetGrid(GridXCount, GridYCount).Cast<Tile>().ToArray();
            
            Assert.IsTrue(grid.All(t => t != null));
        }

        [Test]
        public void AllTokenElementsInGridAreofTypeTile()
        {
            Tile[] grid = _sut.GetGrid(GridXCount, GridYCount).Cast<Tile>().ToArray();

            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof (Tile));
        }

        #region X Index 0

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_0_0()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 0;
            const int expectedY = 0;

            int actualX = grid[0, 0].XPos;
            int actualY = grid[0, 0].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_0_1()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 0;
            const int expectedY = 1;

            int actualX = grid[0, 1].XPos;
            int actualY = grid[0, 1].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_0_2()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 0;
            const int expectedY = 2;

            int actualX = grid[0, 2].XPos;
            int actualY = grid[0, 2].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_0_3()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 0;
            const int expectedY = 3;

            int actualX = grid[0, 3].XPos;
            int actualY = grid[0, 3].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_0_4()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 0;
            const int expectedY = 4;

            int actualX = grid[0, 4].XPos;
            int actualY = grid[0, 4].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_0_5()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 0;
            const int expectedY = 5;

            int actualX = grid[0, 5].XPos;
            int actualY = grid[0, 5].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        #endregion

        #region X Index 1

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_1_0()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 1;
            const int expectedY = 0;

            int actualX = grid[1, 0].XPos;
            int actualY = grid[1, 0].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_1_1()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 1;
            const int expectedY = 1;

            int actualX = grid[1, 1].XPos;
            int actualY = grid[1, 1].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_1_2()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 1;
            const int expectedY = 2;

            int actualX = grid[1, 2].XPos;
            int actualY = grid[1, 2].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_1_3()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 1;
            const int expectedY = 3;

            int actualX = grid[1, 3].XPos;
            int actualY = grid[1, 3].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_1_4()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 1;
            const int expectedY = 4;

            int actualX = grid[1, 4].XPos;
            int actualY = grid[1, 4].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_1_5()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 1;
            const int expectedY = 5;

            int actualX = grid[1, 5].XPos;
            int actualY = grid[1, 5].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        #endregion

        #region X Index 2

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_2_0()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 2;
            const int expectedY = 0;

            int actualX = grid[2, 0].XPos;
            int actualY = grid[2, 0].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_2_1()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 2;
            const int expectedY = 1;

            int actualX = grid[2, 1].XPos;
            int actualY = grid[2, 1].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_2_2()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 2;
            const int expectedY = 2;

            int actualX = grid[2, 2].XPos;
            int actualY = grid[2, 2].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_2_3()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 2;
            const int expectedY = 3;

            int actualX = grid[2, 3].XPos;
            int actualY = grid[2, 3].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_2_4()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 2;
            const int expectedY = 4;

            int actualX = grid[2, 4].XPos;
            int actualY = grid[2, 4].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_2_5()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 2;
            const int expectedY = 5;

            int actualX = grid[2, 5].XPos;
            int actualY = grid[2, 5].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        #endregion

        #region X Index 3

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_3_0()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 3;
            const int expectedY = 0;

            int actualX = grid[3, 0].XPos;
            int actualY = grid[3, 0].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_3_1()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 3;
            const int expectedY = 1;

            int actualX = grid[3, 1].XPos;
            int actualY = grid[3, 1].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_3_2()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 3;
            const int expectedY = 2;

            int actualX = grid[3, 2].XPos;
            int actualY = grid[3, 2].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_3_3()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 3;
            const int expectedY = 3;

            int actualX = grid[3, 3].XPos;
            int actualY = grid[3, 3].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_3_4()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 3;
            const int expectedY = 4;

            int actualX = grid[3, 4].XPos;
            int actualY = grid[3, 4].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_3_5()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 3;
            const int expectedY = 5;

            int actualX = grid[3, 5].XPos;
            int actualY = grid[3, 5].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        #endregion

        #region X Index 4

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_4_0()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 4;
            const int expectedY = 0;

            int actualX = grid[4, 0].XPos;
            int actualY = grid[4, 0].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_4_1()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 4;
            const int expectedY = 1;

            int actualX = grid[4, 1].XPos;
            int actualY = grid[4, 1].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_4_2()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 4;
            const int expectedY = 2;

            int actualX = grid[4, 2].XPos;
            int actualY = grid[4, 2].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_4_3()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 4;
            const int expectedY = 3;

            int actualX = grid[4, 3].XPos;
            int actualY = grid[4, 3].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_4_4()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 4;
            const int expectedY = 4;

            int actualX = grid[4, 4].XPos;
            int actualY = grid[4, 4].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_4_5()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 4;
            const int expectedY = 5;

            int actualX = grid[4, 5].XPos;
            int actualY = grid[4, 5].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        #endregion

        #region X Index 5

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_5_0()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 5;
            const int expectedY = 0;

            int actualX = grid[5, 0].XPos;
            int actualY = grid[5, 0].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_5_1()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 5;
            const int expectedY = 1;

            int actualX = grid[5, 1].XPos;
            int actualY = grid[5, 1].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_5_2()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 5;
            const int expectedY = 2;

            int actualX = grid[5, 2].XPos;
            int actualY = grid[5, 2].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_5_3()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 5;
            const int expectedY = 3;

            int actualX = grid[5, 3].XPos;
            int actualY = grid[5, 3].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_5_4()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 5;
            const int expectedY = 4;

            int actualX = grid[5, 4].XPos;
            int actualY = grid[5, 4].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_5_5()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 5;
            const int expectedY = 5;

            int actualX = grid[5, 5].XPos;
            int actualY = grid[5, 5].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        #endregion

        #region X Index 6

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_6_0()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 6;
            const int expectedY = 0;

            int actualX = grid[6, 0].XPos;
            int actualY = grid[6, 0].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_6_1()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 6;
            const int expectedY = 1;

            int actualX = grid[6, 1].XPos;
            int actualY = grid[6, 1].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_6_2()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 6;
            const int expectedY = 2;

            int actualX = grid[6, 2].XPos;
            int actualY = grid[6, 2].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_6_3()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 6;
            const int expectedY = 3;

            int actualX = grid[6, 3].XPos;
            int actualY = grid[6, 3].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_6_4()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 6;
            const int expectedY = 4;

            int actualX = grid[6, 4].XPos;
            int actualY = grid[6, 4].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        [Test]
        public void InitIndexXYPositionPropertyCorrectlyFor_6_5()
        {
            Tile[,] grid = _sut.GetGrid(GridXCount, GridYCount);

            const int expectedX = 6;
            const int expectedY = 5;

            int actualX = grid[6, 5].XPos;
            int actualY = grid[6, 5].YPos;

            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
