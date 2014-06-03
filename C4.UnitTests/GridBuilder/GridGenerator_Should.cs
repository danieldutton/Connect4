using C4.GridBuilder;
using C4.GridBuilder.Interfaces;
using C4.Model;
using NUnit.Framework;
using System;
using System.Linq;

namespace C4._UnitTests.GridBuilder
{
    [TestFixture]
    public class GridGenerator_Should
    {
        private IGridGenerator<Tile> _sut;

        private const int Columns = 7;

        private const int Rows = 6;


        [SetUp]
        public void Init()
        {
            _sut = new GridGenerator<Tile>();
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetGrid_ThrowAnArgumentOutOfRangeExceptionIfANegativeRowsParamIsGiven()
        {
            _sut.GetGrid(-1, 2);
        }
        
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetGrid_ThrowAnArgumentOutOfRangeExceptionIfANegativeColumnsParamIsGiven()
        {
            _sut.GetGrid(2, -1);
        }

        [Test]
        public void GetGrid_GenerateAGridWith_SixRows()
        {
            const int expected = 6;
            int actual = _sut.GetGrid(Rows, Columns).GetLength(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_GenerateAGridWith_SevenColumns()
        {
            const int expected = 7;
            int actual = _sut.GetGrid(Rows, Columns).GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_GenerateAGridWith_FortyTwoElements()
        {
            const int expected = 42;
            int actual = _sut.GetGrid(Rows, Columns).Length;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_GenerateAGridWith_NoNullElements()
        {
            Tile[] grid = _sut.GetGrid(Rows, Columns).Cast<Tile>().ToArray();
            
            Assert.IsTrue(grid.All(t => t != null));
        }

        [Test]
        public void GetGrid_GenerateAGridWhereEachElementIsOfTypeTile()
        {
            Tile[] grid = _sut.GetGrid(Rows, Columns).Cast<Tile>().ToArray();

            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof (Tile));
        }

        [Test]
        public void GetGrid_GenerateAGridWhereEachTileElementHasGameTokenPropertyValueAsUndefined()
        {
            Tile[] grid = _sut.GetGrid(Rows, Columns).Cast<Tile>().ToArray();

            Assert.IsTrue(grid.All(t => t.GameToken == GameToken.Undefined));
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_0_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[0, 0].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_0_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[0, 0].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_0_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[0, 1].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_0_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[0, 1].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_0_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[0, 2].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_0_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[0, 2].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_0_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[0, 3].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_0_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[0, 3].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_0_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[0, 4].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_0_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[0, 4].YPosition;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_0_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[0, 5].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_0_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[0, 5].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_0_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[0, 6].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_0_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 6;
            int actual = grid[0, 6].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_1_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[1, 0].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_1_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[1, 0].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_1_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[1, 1].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_1_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[1, 1].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_1_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[1, 2].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_1_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[1, 2].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_1_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[1, 3].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_1_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[1, 3].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_1_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[1, 4].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_1_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[1, 4].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_1_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[1, 5].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_1_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[1, 5].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_1_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[1, 6].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_1_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 6;
            int actual = grid[1, 6].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_2_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[2, 0].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_2_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[2, 0].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_2_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[2, 1].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_2_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[2, 1].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_2_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[2, 2].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_2_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[2, 2].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_2_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[2, 3].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_2_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[2, 3].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_2_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[2, 4].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_2_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[2, 4].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_2_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[2, 5].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_2_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[2, 5].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_2_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[2, 6].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_2_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 6;
            int actual = grid[2, 6].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_3_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[3, 0].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_3_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[3, 0].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_3_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[3, 1].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_3_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[3, 1].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_3_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[3, 2].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_3_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[3, 3].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_3_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[3, 3].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_3_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[0, 0].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_3_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[3, 4].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_3_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[3, 4].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_3_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[3, 5].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_3_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[3, 5].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_3_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[3, 6].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_3_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 6;
            int actual = grid[3, 6].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_4_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[4, 0].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_4_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[4, 0].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_4_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[4, 1].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_4_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[4, 1].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_4_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[4, 2].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_4_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[4, 2].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_4_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[4, 3].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_4_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[4, 3].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_4_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[4, 4].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_4_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[4, 4].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_4_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[4, 5].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_4_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[4, 5].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_4_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[4, 6].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_4_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 6;
            int actual = grid[4, 6].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_5_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[5, 0].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_5_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 0;
            int actual = grid[5, 0].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_5_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[5, 1].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_5_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 1;
            int actual = grid[5, 1].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_5_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[5, 2].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_5_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 2;
            int actual = grid[5, 2].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_5_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[5, 3].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_5_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 3;
            int actual = grid[5, 3].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_5_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[5, 4].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_5_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 4;
            int actual = grid[5, 4].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_5_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[5, 5].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_5_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[5, 5].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileRowNumberPropertyCorrectlyForGridPosition_5_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 5;
            int actual = grid[5, 6].XPosition;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGrid_InitialiseTileColumnNumberPropertyCorrectlyForGridPosition_5_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            const int expected = 6;
            int actual = grid[5, 6].YPosition;

            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
