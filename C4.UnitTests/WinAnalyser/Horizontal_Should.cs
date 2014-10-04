using C4.GridBuilder;
using C4.GridBuilder.Model;
using C4.WinAnalyser;
using C4.WinAnalyser.Strategies;
using NUnit.Framework;

namespace C4.UnitTests.WinAnalyser
{
    [TestFixture]
    public class Horizontal_Should
    {
        private GridBuilder<Tile> _gridBuilder;

        private Tile[,] _grid;

        private Horizontal _sut;


        [SetUp]
        public void Init()
        {
            _gridBuilder = new GridBuilder<Tile>();
            _grid = _gridBuilder.GetGrid(6, 7);
            _sut = new Horizontal();
        }

        //row 1

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_0_0_To_0_3()
        {
            _grid[0, 0].GameToken = GameToken.Red;
            _grid[0, 1].GameToken = GameToken.Red;
            _grid[0, 2].GameToken = GameToken.Red;
            _grid[0, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_0_0_To_0_3()
        {
            _grid[0, 0].GameToken = GameToken.Yellow;
            _grid[0, 1].GameToken = GameToken.Yellow;
            _grid[0, 2].GameToken = GameToken.Yellow;
            _grid[0, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_0_1_To_0_4()
        {
            _grid[0, 1].GameToken = GameToken.Red;
            _grid[0, 2].GameToken = GameToken.Red;
            _grid[0, 3].GameToken = GameToken.Red;
            _grid[0, 4].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_0_1_To_0_4()
        {
            _grid[0, 1].GameToken = GameToken.Yellow;
            _grid[0, 2].GameToken = GameToken.Yellow;
            _grid[0, 3].GameToken = GameToken.Yellow;
            _grid[0, 4].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_0_2_To_0_5()
        {
            _grid[0, 2].GameToken = GameToken.Red;
            _grid[0, 3].GameToken = GameToken.Red;
            _grid[0, 4].GameToken = GameToken.Red;
            _grid[0, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_0_2_To_0_5()
        {
            _grid[0, 2].GameToken = GameToken.Yellow;
            _grid[0, 3].GameToken = GameToken.Yellow;
            _grid[0, 4].GameToken = GameToken.Yellow;
            _grid[0, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_0_3_To_0_6()
        {
            _grid[0, 3].GameToken = GameToken.Red;
            _grid[0, 4].GameToken = GameToken.Red;
            _grid[0, 5].GameToken = GameToken.Red;
            _grid[0, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_0_3_To_0_6()
        {
            _grid[0, 3].GameToken = GameToken.Yellow;
            _grid[0, 4].GameToken = GameToken.Yellow;
            _grid[0, 5].GameToken = GameToken.Yellow;
            _grid[0, 6].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //row 2

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_1_0_To_1_3()
        {
            _grid[1, 0].GameToken = GameToken.Red;
            _grid[1, 1].GameToken = GameToken.Red;
            _grid[1, 2].GameToken = GameToken.Red;
            _grid[1, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_1_0_To_1_3()
        {
            _grid[1, 0].GameToken = GameToken.Yellow;
            _grid[1, 1].GameToken = GameToken.Yellow;
            _grid[1, 2].GameToken = GameToken.Yellow;
            _grid[1, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_1_1_To_1_4()
        {
            _grid[1, 1].GameToken = GameToken.Red;
            _grid[1, 2].GameToken = GameToken.Red;
            _grid[1, 3].GameToken = GameToken.Red;
            _grid[1, 4].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_1_1_To_1_4()
        {
            _grid[1, 1].GameToken = GameToken.Yellow;
            _grid[1, 2].GameToken = GameToken.Yellow;
            _grid[1, 3].GameToken = GameToken.Yellow;
            _grid[1, 4].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_1_2_To_1_5()
        {
            _grid[1, 2].GameToken = GameToken.Red;
            _grid[1, 3].GameToken = GameToken.Red;
            _grid[1, 4].GameToken = GameToken.Red;
            _grid[1, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_1_2_To_1_5()
        {
            _grid[1, 2].GameToken = GameToken.Yellow;
            _grid[1, 3].GameToken = GameToken.Yellow;
            _grid[1, 4].GameToken = GameToken.Yellow;
            _grid[1, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_1_3_To_1_6()
        {
            _grid[1, 3].GameToken = GameToken.Red;
            _grid[1, 4].GameToken = GameToken.Red;
            _grid[1, 5].GameToken = GameToken.Red;
            _grid[1, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_1_3_To_1_6()
        {
            _grid[1, 3].GameToken = GameToken.Yellow;
            _grid[1, 4].GameToken = GameToken.Yellow;
            _grid[1, 5].GameToken = GameToken.Yellow;
            _grid[1, 6].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //row 3

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_2_0_To_2_3()
        {
            _grid[2, 0].GameToken = GameToken.Red;
            _grid[2, 1].GameToken = GameToken.Red;
            _grid[2, 2].GameToken = GameToken.Red;
            _grid[2, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_2_0_To_2_3()
        {
            _grid[2, 0].GameToken = GameToken.Yellow;
            _grid[2, 1].GameToken = GameToken.Yellow;
            _grid[2, 2].GameToken = GameToken.Yellow;
            _grid[2, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_2_1_To_2_4()
        {
            _grid[2, 1].GameToken = GameToken.Red;
            _grid[2, 2].GameToken = GameToken.Red;
            _grid[2, 3].GameToken = GameToken.Red;
            _grid[2, 4].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_2_1_To_2_4()
        {
            _grid[2, 1].GameToken = GameToken.Yellow;
            _grid[2, 2].GameToken = GameToken.Yellow;
            _grid[2, 3].GameToken = GameToken.Yellow;
            _grid[2, 4].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_2_2_To_2_5()
        {
            _grid[2, 2].GameToken = GameToken.Red;
            _grid[2, 3].GameToken = GameToken.Red;
            _grid[2, 4].GameToken = GameToken.Red;
            _grid[2, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_2_2_To_2_5()
        {
            _grid[2, 2].GameToken = GameToken.Yellow;
            _grid[2, 3].GameToken = GameToken.Yellow;
            _grid[2, 4].GameToken = GameToken.Yellow;
            _grid[2, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_2_3_To_2_6()
        {
            _grid[2, 3].GameToken = GameToken.Red;
            _grid[2, 4].GameToken = GameToken.Red;
            _grid[2, 5].GameToken = GameToken.Red;
            _grid[2, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_2_3_To_2_6()
        {
            _grid[2, 3].GameToken = GameToken.Yellow;
            _grid[2, 4].GameToken = GameToken.Yellow;
            _grid[2, 5].GameToken = GameToken.Yellow;
            _grid[2, 6].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //row 4

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_3_0_To_3_3()
        {
            _grid[3, 0].GameToken = GameToken.Red;
            _grid[3, 1].GameToken = GameToken.Red;
            _grid[3, 2].GameToken = GameToken.Red;
            _grid[3, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_3_0_To_3_3()
        {
            _grid[3, 0].GameToken = GameToken.Yellow;
            _grid[3, 1].GameToken = GameToken.Yellow;
            _grid[3, 2].GameToken = GameToken.Yellow;
            _grid[3, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_3_1_To_3_4()
        {
            _grid[3, 1].GameToken = GameToken.Red;
            _grid[3, 2].GameToken = GameToken.Red;
            _grid[3, 3].GameToken = GameToken.Red;
            _grid[3, 4].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_3_1_To_3_4()
        {
            _grid[3, 1].GameToken = GameToken.Yellow;
            _grid[3, 2].GameToken = GameToken.Yellow;
            _grid[3, 3].GameToken = GameToken.Yellow;
            _grid[3, 4].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_3_2_To_3_5()
        {
            _grid[3, 2].GameToken = GameToken.Red;
            _grid[3, 3].GameToken = GameToken.Red;
            _grid[3, 4].GameToken = GameToken.Red;
            _grid[3, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_3_2_To_3_5()
        {
            _grid[3, 2].GameToken = GameToken.Yellow;
            _grid[3, 3].GameToken = GameToken.Yellow;
            _grid[3, 4].GameToken = GameToken.Yellow;
            _grid[3, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_3_3_To_3_6()
        {
            _grid[3, 3].GameToken = GameToken.Red;
            _grid[3, 4].GameToken = GameToken.Red;
            _grid[3, 5].GameToken = GameToken.Red;
            _grid[3, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_3_3_To_3_6()
        {
            _grid[3, 3].GameToken = GameToken.Yellow;
            _grid[3, 4].GameToken = GameToken.Yellow;
            _grid[3, 5].GameToken = GameToken.Yellow;
            _grid[3, 6].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //row 5

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndexx_4_0_To_4_3()
        {
            _grid[4, 0].GameToken = GameToken.Red;
            _grid[4, 1].GameToken = GameToken.Red;
            _grid[4, 2].GameToken = GameToken.Red;
            _grid[4, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_4_0_To_4_3()
        {
            _grid[4, 0].GameToken = GameToken.Yellow;
            _grid[4, 1].GameToken = GameToken.Yellow;
            _grid[4, 2].GameToken = GameToken.Yellow;
            _grid[4, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_4_1_To_4_4()
        {
            _grid[4, 1].GameToken = GameToken.Red;
            _grid[4, 2].GameToken = GameToken.Red;
            _grid[4, 3].GameToken = GameToken.Red;
            _grid[4, 4].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_4_1_To_4_4()
        {
            _grid[4, 1].GameToken = GameToken.Yellow;
            _grid[4, 2].GameToken = GameToken.Yellow;
            _grid[4, 3].GameToken = GameToken.Yellow;
            _grid[4, 4].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_4_2_To_4_5()
        {
            _grid[4, 2].GameToken = GameToken.Red;
            _grid[4, 3].GameToken = GameToken.Red;
            _grid[4, 4].GameToken = GameToken.Red;
            _grid[4, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_4_2_To_4_5()
        {
            _grid[4, 2].GameToken = GameToken.Yellow;
            _grid[4, 3].GameToken = GameToken.Yellow;
            _grid[4, 4].GameToken = GameToken.Yellow;
            _grid[4, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_4_3_To_4_6()
        {
            _grid[4, 3].GameToken = GameToken.Red;
            _grid[4, 4].GameToken = GameToken.Red;
            _grid[4, 5].GameToken = GameToken.Red;
            _grid[4, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_4_3_To_4_6()
        {
            _grid[4, 3].GameToken = GameToken.Yellow;
            _grid[4, 4].GameToken = GameToken.Yellow;
            _grid[4, 5].GameToken = GameToken.Yellow;
            _grid[4, 6].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //row 6

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_5_0_To_5_3()
        {
            _grid[5, 0].GameToken = GameToken.Red;
            _grid[5, 1].GameToken = GameToken.Red;
            _grid[5, 2].GameToken = GameToken.Red;
            _grid[5, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_5_0_To_5_3()
        {
            _grid[5, 0].GameToken = GameToken.Yellow;
            _grid[5, 1].GameToken = GameToken.Yellow;
            _grid[5, 2].GameToken = GameToken.Yellow;
            _grid[5, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_5_1_To_5_4()
        {
            _grid[5, 1].GameToken = GameToken.Red;
            _grid[5, 2].GameToken = GameToken.Red;
            _grid[5, 3].GameToken = GameToken.Red;
            _grid[5, 4].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_5_1_To_5_4()
        {
            _grid[5, 1].GameToken = GameToken.Yellow;
            _grid[5, 2].GameToken = GameToken.Yellow;
            _grid[5, 3].GameToken = GameToken.Yellow;
            _grid[5, 4].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_5_2_To_5_5()
        {
            _grid[5, 2].GameToken = GameToken.Red;
            _grid[5, 3].GameToken = GameToken.Red;
            _grid[5, 4].GameToken = GameToken.Red;
            _grid[5, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_5_2_To_5_5()
        {
            _grid[5, 2].GameToken = GameToken.Yellow;
            _grid[5, 3].GameToken = GameToken.Yellow;
            _grid[5, 4].GameToken = GameToken.Yellow;
            _grid[5, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_5_3_To_5_6()
        {
            _grid[5, 3].GameToken = GameToken.Red;
            _grid[5, 4].GameToken = GameToken.Red;
            _grid[5, 5].GameToken = GameToken.Red;
            _grid[5, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_5_3_To_5_6()
        {
            _grid[5, 3].GameToken = GameToken.Yellow;
            _grid[5, 4].GameToken = GameToken.Yellow;
            _grid[5, 5].GameToken = GameToken.Yellow;
            _grid[5, 6].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [TearDown]
        public void TearDown()
        {
            _gridBuilder = null;
            _grid = null;
            _sut = null;
        }
    }
}