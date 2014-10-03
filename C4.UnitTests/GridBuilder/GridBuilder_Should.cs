using C4.GridBuilder;
using C4.GridBuilder.Interfaces;
using C4.GridBuilder.Model;
using NUnit.Framework;
using System;
using System.Linq;

namespace C4.UnitTests.GridBuilder
{
    [TestFixture]
    public class GridBuilder_Should
    {
        private IGridBuilder<Tile> _sut;

        private const int Columns = 7;

        private const int Rows = 6;


        [SetUp]
        public void Init()
        {
            _sut = new GridBuilder<Tile>();
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetGrid_ThrowArgumentOutOfRangeException_IfANegativeRowNoIsGiven()
        {
            _sut.GetGrid(-1, 2);
        }
        
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetGrid_ThrowArgumentOutOfRangeException_IfANegativeColNoIsGiven()
        {
            _sut.GetGrid(2, -1);
        }

        [Test]
        public void GetGrid_WithSixRows()
        {
            int actual = _sut.GetGrid(Rows, Columns).GetLength(0);

            Assert.AreEqual(6, actual);
        }

        [Test]
        public void GetGrid_WithSevenColumns()
        {
            int actual = _sut.GetGrid(Rows, Columns).GetLength(1);

            Assert.AreEqual(7, actual);
        }

        [Test]
        public void GetGrid_WithFortyTwoTiles()
        {
            int actual = _sut.GetGrid(Rows, Columns).Length;

            Assert.AreEqual(42, actual);
        }
        
        [Test]
        public void GetGrid_AllElementsAreNotNull()
        {
            Tile[] grid = _sut.GetGrid(Rows, Columns).Cast<Tile>().ToArray();
            
            Assert.IsTrue(grid.All(t => t != null));
        }

        [Test]
        public void GetGrid_AllElementsAreOfTypeTile()
        {
            Tile[] grid = _sut.GetGrid(Rows, Columns).Cast<Tile>().ToArray();

            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof (Tile));
        }

        [Test]
        public void GetGrid_EveryGameTokenProperty_IsUndefinedByDefault()
        {
            Tile[] grid = _sut.GetGrid(Rows, Columns).Cast<Tile>().ToArray();

            Assert.IsTrue(grid.All(t => t.GameToken == GameToken.Undefined));
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_0_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[0, 0].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_0_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[0, 0].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_0_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[0, 1].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_0_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[0, 1].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_0_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[0, 2].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_0_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[0, 2].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_0_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[0, 3].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_0_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[0, 3].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_0_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[0, 4].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_0_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[0, 4].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_0_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[0, 5].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_0_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[0, 5].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_0_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[0, 6].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_0_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(6, grid[0, 6].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_1_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[1, 0].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_1_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[1, 0].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_1_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[1, 1].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_1_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[1, 1].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_1_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[1, 2].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_1_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[1, 2].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_1_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[1, 3].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_1_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[1, 3].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_1_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[1, 4].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_1_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[1, 4].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_1_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[1, 5].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_1_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[1, 5].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_1_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[1, 6].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_1_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(6, grid[1, 6].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_2_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[2, 0].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_2_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[2, 0].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_2_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[2, 1].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_2_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[2, 1].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_2_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[2, 2].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_2_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[2, 2].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_2_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[2, 3].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_2_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[2, 3].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_2_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[2, 4].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_2_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[2, 4].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_2_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[2, 5].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_2_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[2, 5].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_2_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[2, 6].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_2_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(6, grid[2, 6].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_3_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[3, 0].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_3_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[3, 0].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_3_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[3, 1].XPosition);
        }

        [Test]
        public void GetGrid_InitTYPos_GridPosition_3_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[3, 1].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_3_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[3, 2].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_3_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[3, 3].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_3_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[3, 3].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_3_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[0, 0].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_3_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[3, 4].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_3_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[3, 4].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_3_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[3, 5].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_3_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[3, 5].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_3_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[3, 6].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_3_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(6, grid[3, 6].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_4_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[4, 0].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_4_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[4, 0].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_4_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[4, 1].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_4_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[4, 1].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_4_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[4, 2].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_4_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[4, 2].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_4_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[4, 3].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_4_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[4, 3].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_4_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[4, 4].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_4_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[4, 4].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_4_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[4, 5].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_4_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[4, 5].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_4_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[4, 6].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_4_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(6, grid[4, 6].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_5_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[5, 0].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_5_0()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(0, grid[5, 0].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_5_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[5, 1].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_5_1()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(1, grid[5, 1].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_5_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[5, 2].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_5_2()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(2, grid[5, 2].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_5_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[5, 3].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_5_3()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(3, grid[5, 3].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_5_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[5, 4].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_5_4()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(4, grid[5, 4].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_5_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[5, 5].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_5_5()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[5, 5].YPosition);
        }

        [Test]
        public void GetGrid_InitXPosCorrectlyFor_GridPosition_5_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(5, grid[5, 6].XPosition);
        }

        [Test]
        public void GetGrid_InitYPosCorrectlyFor_GridPosition_5_6()
        {
            Tile[,] grid = _sut.GetGrid(Rows, Columns);

            Assert.AreEqual(6, grid[5, 6].YPosition);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
