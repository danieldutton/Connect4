using C4.GridBuilder;
using C4.GridBuilder.Interfaces;
using C4.Model;
using NUnit.Framework;
using System;
using System.Linq;

namespace C4.Tests_Unit.GridBuilder
{
    [TestFixture]
    public class GridGenerator_Should
    {
        private IGridGenerator<Tile> _sut;

        private const int ColumnIndex = 7;

        private const int RowIndex = 6;


        [SetUp]
        public void Init()
        {
            _sut = new GridGenerator<Tile>();
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowAnArgumentOutOfRangeExceptionIfANegativeXDimParamIsGiven()
        {
            _sut.GetGrid(-1, 2);
        }
        
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowAnArgumentOutOfRangeExceptionIfANegativeYDimParamIsGiven()
        {
            _sut.GetGrid(2, -1);
        }

        [Test]
        public void GetGrid_GenerateAGridWithAnXAxisIndexLengthOfSeven()
        {
            const int expected = 7;
            int actual = _sut.GetGrid(ColumnIndex, RowIndex).GetLength(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_GenerateAGridWithAYAxisIndexLengthOfSix()
        {
            const int expected = 6;
            int actual = _sut.GetGrid(ColumnIndex, RowIndex).GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_GenerateAGridWithATotalOfFortyTwoElements()
        {
            const int expected = 42;
            int actual = _sut.GetGrid(ColumnIndex, RowIndex).Length;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_GenerateAGridWithThatContainsNoNullElements()
        {
            Tile[] grid = _sut.GetGrid(RowIndex, ColumnIndex).Cast<Tile>().ToArray();
            
            Assert.IsTrue(grid.All(t => t != null));
        }

        [Test]
        public void GetGrid_GenerateAGridWhereEachElementIsOfTypeTile()
        {
            Tile[] grid = _sut.GetGrid(RowIndex, ColumnIndex).Cast<Tile>().ToArray();

            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof (Tile));
        }

        [Test]
        public void GetGrid_GenerateAGridWithGameTokenPropertyUndefined()
        {
            Tile[] grid = _sut.GetGrid(RowIndex, ColumnIndex).Cast<Tile>().ToArray();

            Assert.IsTrue(grid.All(t => t.GameToken == GameToken.Undefined));
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_0()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 0;
            const int expectedX = 0;

            int actualY = grid[0, 0].YPosition;
            int actualX = grid[0, 0].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_1()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 0;
            const int expectedX = 1;

            int actualY = grid[0, 1].YPosition;
            int actualX = grid[0, 1].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_2()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 0;
            const int expectedX = 2;

            int actualY = grid[0, 2].YPosition;
            int actualX = grid[0, 2].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_3()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 0;
            const int expectedX = 3;

            int actualY = grid[0, 3].YPosition;
            int actualX = grid[0, 3].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_4()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 0;
            const int expectedX = 4;

            int actualY = grid[0, 4].YPosition;
            int actualX = grid[0, 4].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_5()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 0;
            const int expectedX = 5;

            int actualY = grid[0, 5].YPosition;
            int actualX = grid[0, 5].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_0_6()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 0;
            const int expectedX = 6;

            int actualY = grid[0, 6].YPosition;
            int actualX = grid[0, 6].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_0()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 1;
            const int expectedX = 0;

            int actualY = grid[1, 0].YPosition;
            int actualX = grid[1, 0].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_1()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 1;
            const int expectedX = 1;

            int actualY = grid[1, 1].YPosition;
            int actualX = grid[1, 1].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_2()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 1;
            const int expectedX = 2;

            int actualY = grid[1, 2].YPosition;
            int actualX = grid[1, 2].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_3()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 1;
            const int expectedX = 3;

            int actualY = grid[1, 3].YPosition;
            int actualX = grid[1, 3].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_4()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 1;
            const int expectedX = 4;

            int actualY = grid[1, 4].YPosition;
            int actualX = grid[1, 4].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_5()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 1;
            const int expectedX = 5;

            int actualY = grid[1, 5].YPosition;
            int actualX = grid[1, 5].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_1_6()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 1;
            const int expectedX = 6;

            int actualY = grid[1, 6].YPosition;
            int actualX = grid[1, 6].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_0()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 2;
            const int expectedX = 0;

            int actualY = grid[2, 0].YPosition;
            int actualX = grid[2, 0].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_1()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 2;
            const int expectedX = 1;

            int actualY = grid[2, 1].YPosition;
            int actualX = grid[2, 1].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_2()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 2;
            const int expectedX = 2;

            int actualY = grid[2, 2].YPosition;
            int actualX = grid[2, 2].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_3()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 2;
            const int expectedX = 3;

            int actualY = grid[2, 3].YPosition;
            int actualX = grid[2, 3].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_4()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 2;
            const int expectedX = 4;

            int actualY = grid[2, 4].YPosition;
            int actualX = grid[2, 4].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_5()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 2;
            const int expectedX = 5;

            int actualY = grid[2, 5].YPosition;
            int actualX = grid[2, 5].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_2_6()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 2;
            const int expectedX = 6;

            int actualY = grid[2, 6].YPosition;
            int actualX = grid[2, 6].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_0()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 3;
            const int expectedX = 0;

            int actualY = grid[3, 0].YPosition;
            int actualX = grid[3, 0].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_1()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 3;
            const int expectedX = 1;

            int actualY = grid[3, 1].YPosition;
            int actualX = grid[3, 1].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_2()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 3;
            const int expectedX = 2;

            int actualY = grid[3, 2].YPosition;
            int actualX = grid[3, 2].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_3()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 3;
            const int expectedX = 3;

            int actualY = grid[3, 3].YPosition;
            int actualX = grid[3, 3].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_4()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 3;
            const int expectedX = 4;

            int actualY = grid[3, 4].YPosition;
            int actualX = grid[3, 4].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_5()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 3;
            const int expectedX = 5;

            int actualY = grid[3, 5].YPosition;
            int actualX = grid[3, 5].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_3_6()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 3;
            const int expectedX = 6;

            int actualY = grid[3, 6].YPosition;
            int actualX = grid[3, 6].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_0()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 4;
            const int expectedX = 0;

            int actualY = grid[4, 0].YPosition;
            int actualX = grid[4, 0].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_1()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 4;
            const int expectedX = 1;

            int actualY = grid[4, 1].YPosition;
            int actualX = grid[4, 1].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_2()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 4;
            const int expectedX = 2;

            int actualY = grid[4, 2].YPosition;
            int actualX = grid[4, 2].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_3()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 4;
            const int expectedX = 3;

            int actualY = grid[4, 3].YPosition;
            int actualX = grid[4, 3].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_4()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 4;
            const int expectedX = 4;

            int actualY = grid[4, 4].YPosition;
            int actualX = grid[4, 4].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_5()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 4;
            const int expectedX = 5;

            int actualY = grid[4, 5].YPosition;
            int actualX = grid[4, 5].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_4_6()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 4;
            const int expectedX = 6;

            int actualY = grid[4, 6].YPosition;
            int actualX = grid[4, 6].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_0()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 5;
            const int expectedX = 0;

            int actualY = grid[5, 0].YPosition;
            int actualX = grid[5, 0].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_1()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 5;
            const int expectedX = 1;

            int actualY = grid[5, 1].YPosition;
            int actualX = grid[5, 1].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_2()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 5;
            const int expectedX = 2;

            int actualY = grid[5, 2].YPosition;
            int actualX = grid[5, 2].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_3()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 5;
            const int expectedX = 3;

            int actualY = grid[5, 3].YPosition;
            int actualX = grid[5, 3].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_4()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 5;
            const int expectedX = 4;

            int actualY = grid[5, 4].YPosition;
            int actualX = grid[5, 4].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_5()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 5;
            const int expectedX = 5;

            int actualY = grid[5, 5].YPosition;
            int actualX = grid[5, 5].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [Test]
        public void GetGrid_InitialiseTileXYPositionPropertiesCorrectlyForGridPosition_5_6()
        {
            Tile[,] grid = _sut.GetGrid(RowIndex, ColumnIndex);

            const int expectedY = 5;
            const int expectedX = 6;

            int actualY = grid[5, 6].YPosition;
            int actualX = grid[5, 6].XPosition;

            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedX, actualX);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
