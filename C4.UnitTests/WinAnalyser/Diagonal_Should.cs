using C4.GridBuilder;
using C4.GridBuilder.Model;
using C4.WinAnalyser;
using NUnit.Framework;

namespace C4.UnitTests.WinAnalyser
{
    [TestFixture]
    public class Diagonal_Should
    {
        private GridBuilder<Tile> _gridBuilder;

        private Tile[,] _grid;

        private Diagonal _sut;


        [SetUp]
        public void Init()
        {
            _gridBuilder = new GridBuilder<Tile>();
            _grid = _gridBuilder.GetGrid(6, 7);
            _sut = new Diagonal();
        }

        //left to right diagonal

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_0_To_0_3()
        {
            _grid[3, 0].GameToken = GameToken.Red;
            _grid[2, 1].GameToken = GameToken.Red;
            _grid[1, 2].GameToken = GameToken.Red;
            _grid[0, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_0_To_0_3()
        {
            _grid[3, 0].GameToken = GameToken.Yellow;
            _grid[2, 1].GameToken = GameToken.Yellow;
            _grid[1, 2].GameToken = GameToken.Yellow;
            _grid[0, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_0_To_1_3()
        {
            _grid[4, 0].GameToken = GameToken.Red;
            _grid[3, 1].GameToken = GameToken.Red;
            _grid[2, 2].GameToken = GameToken.Red;
            _grid[1, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));            
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_0_To_1_3()
        {
            _grid[4, 0].GameToken = GameToken.Yellow;
            _grid[3, 1].GameToken = GameToken.Yellow;
            _grid[2, 2].GameToken = GameToken.Yellow;
            _grid[1, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_1_To_0_4()
        {
            _grid[3, 1].GameToken = GameToken.Red;
            _grid[2, 2].GameToken = GameToken.Red;
            _grid[1, 3].GameToken = GameToken.Red;
            _grid[0, 4].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_1_To_0_4()
        {
            _grid[3, 1].GameToken = GameToken.Yellow;
            _grid[2, 2].GameToken = GameToken.Yellow;
            _grid[1, 3].GameToken = GameToken.Yellow;
            _grid[0, 4].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_0_To_2_3()
        {
            _grid[5, 0].GameToken = GameToken.Red;
            _grid[4, 1].GameToken = GameToken.Red;
            _grid[3, 2].GameToken = GameToken.Red;
            _grid[2, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_0_To_2_3()
        {
            _grid[5, 0].GameToken = GameToken.Yellow;
            _grid[4, 1].GameToken = GameToken.Yellow;
            _grid[3, 2].GameToken = GameToken.Yellow;
            _grid[2, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_1_To_1_4()
        {
            _grid[4, 1].GameToken = GameToken.Red;
            _grid[3, 2].GameToken = GameToken.Red;
            _grid[2, 3].GameToken = GameToken.Red;
            _grid[1, 4].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_1_To_1_4()
        {
            _grid[4, 1].GameToken = GameToken.Yellow;
            _grid[3, 2].GameToken = GameToken.Yellow;
            _grid[2, 3].GameToken = GameToken.Yellow;
            _grid[1, 4].GameToken = GameToken.Yellow;

           Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_2_To_0_5()
        {
            _grid[3, 2].GameToken = GameToken.Red;
            _grid[2, 3].GameToken = GameToken.Red;
            _grid[1, 4].GameToken = GameToken.Red;
            _grid[0, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_2_To_0_5()
        {
            _grid[3, 2].GameToken = GameToken.Yellow;
            _grid[2, 3].GameToken = GameToken.Yellow;
            _grid[1, 4].GameToken = GameToken.Yellow;
            _grid[0, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_1_To_2_4()
        {
            _grid[5, 1].GameToken = GameToken.Red;
            _grid[4, 2].GameToken = GameToken.Red;
            _grid[3, 3].GameToken = GameToken.Red;
            _grid[2, 4].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_1_To_2_4()
        {
            _grid[5, 1].GameToken = GameToken.Yellow;
            _grid[4, 2].GameToken = GameToken.Yellow;
            _grid[3, 3].GameToken = GameToken.Yellow;
            _grid[2, 4].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_2_To_1_5()
        {
            _grid[4, 2].GameToken = GameToken.Red;
            _grid[3, 3].GameToken = GameToken.Red;
            _grid[2, 4].GameToken = GameToken.Red;
            _grid[1, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_2_To_1_5()
        {
            _grid[4, 2].GameToken = GameToken.Yellow;
            _grid[3, 3].GameToken = GameToken.Yellow;
            _grid[2, 4].GameToken = GameToken.Yellow;
            _grid[1, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_3_To_0_6()
        {
            _grid[3, 3].GameToken = GameToken.Red;
            _grid[2, 4].GameToken = GameToken.Red;
            _grid[1, 5].GameToken = GameToken.Red;
            _grid[0, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_3_To_0_6()
        {
            _grid[3, 3].GameToken = GameToken.Yellow;
            _grid[2, 4].GameToken = GameToken.Yellow;
            _grid[1, 5].GameToken = GameToken.Yellow;
            _grid[0, 6].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_2_To_2_5()
        {
            _grid[5, 2].GameToken = GameToken.Red;
            _grid[4, 3].GameToken = GameToken.Red;
            _grid[3, 4].GameToken = GameToken.Red;
            _grid[2, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_2_To_2_5()
        {
            _grid[5, 2].GameToken = GameToken.Yellow;
            _grid[4, 3].GameToken = GameToken.Yellow;
            _grid[3, 4].GameToken = GameToken.Yellow;
            _grid[2, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_3_To_1_6()
        {
            _grid[4, 3].GameToken = GameToken.Red;
            _grid[3, 4].GameToken = GameToken.Red;
            _grid[2, 5].GameToken = GameToken.Red;
            _grid[1, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_3_To_1_6()
        {
            _grid[4, 3].GameToken = GameToken.Yellow;
            _grid[3, 4].GameToken = GameToken.Yellow;
            _grid[2, 5].GameToken = GameToken.Yellow;
            _grid[1, 6].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_3_To_2_6()
        {
            _grid[5, 3].GameToken = GameToken.Red;
            _grid[4, 4].GameToken = GameToken.Red;
            _grid[3, 5].GameToken = GameToken.Red;
            _grid[2, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_3_To_2_6()
        {
            _grid[5, 3].GameToken = GameToken.Yellow;
            _grid[4, 4].GameToken = GameToken.Yellow;
            _grid[3, 5].GameToken = GameToken.Yellow;
            _grid[2, 6].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //right to left diagonal

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_6_To_0_3()
        {
            _grid[3, 6].GameToken = GameToken.Red;
            _grid[2, 5].GameToken = GameToken.Red;
            _grid[1, 4].GameToken = GameToken.Red;
            _grid[0, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_6_To_0_3()
        {
            _grid[3, 6].GameToken = GameToken.Yellow;
            _grid[2, 5].GameToken = GameToken.Yellow;
            _grid[1, 4].GameToken = GameToken.Yellow;
            _grid[0, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_6_To_1_3()
        {
            _grid[4, 6].GameToken = GameToken.Red;
            _grid[3, 5].GameToken = GameToken.Red;
            _grid[2, 4].GameToken = GameToken.Red;
            _grid[1, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_6_To_1_3()
        {
            _grid[4, 6].GameToken = GameToken.Yellow;
            _grid[3, 5].GameToken = GameToken.Yellow;
            _grid[2, 4].GameToken = GameToken.Yellow;
            _grid[1, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_5_To_0_2()
        {
            _grid[3, 5].GameToken = GameToken.Red;
            _grid[2, 4].GameToken = GameToken.Red;
            _grid[1, 3].GameToken = GameToken.Red;
            _grid[0, 2].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_5_To_0_2()
        {
            _grid[3, 5].GameToken = GameToken.Yellow;
            _grid[2, 4].GameToken = GameToken.Yellow;
            _grid[1, 3].GameToken = GameToken.Yellow;
            _grid[0, 2].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_6_To_2_3()
        {
            _grid[5, 6].GameToken = GameToken.Red;
            _grid[4, 5].GameToken = GameToken.Red;
            _grid[3, 4].GameToken = GameToken.Red;
            _grid[2, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_6_To_2_3()
        {
            _grid[5, 6].GameToken = GameToken.Yellow;
            _grid[4, 5].GameToken = GameToken.Yellow;
            _grid[3, 4].GameToken = GameToken.Yellow;
            _grid[2, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_5_To_1_2()
        {
            _grid[4, 5].GameToken = GameToken.Red;
            _grid[3, 4].GameToken = GameToken.Red;
            _grid[2, 3].GameToken = GameToken.Red;
            _grid[1, 2].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_5_To_1_2()
        {
            _grid[4, 5].GameToken = GameToken.Yellow;
            _grid[3, 4].GameToken = GameToken.Yellow;
            _grid[2, 3].GameToken = GameToken.Yellow;
            _grid[1, 2].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_4_To_0_1()
        {
            _grid[3, 4].GameToken = GameToken.Red;
            _grid[2, 3].GameToken = GameToken.Red;
            _grid[1, 2].GameToken = GameToken.Red;
            _grid[0, 1].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_4_To_0_1()
        {
            _grid[3, 4].GameToken = GameToken.Yellow;
            _grid[2, 3].GameToken = GameToken.Yellow;
            _grid[1, 2].GameToken = GameToken.Yellow;
            _grid[0, 1].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_5_To_2_2()
        {
            _grid[5, 5].GameToken = GameToken.Red;
            _grid[4, 4].GameToken = GameToken.Red;
            _grid[3, 3].GameToken = GameToken.Red;
            _grid[2, 2].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_5_To_2_2()
        {
            _grid[5, 5].GameToken = GameToken.Yellow;
            _grid[4, 4].GameToken = GameToken.Yellow;
            _grid[3, 3].GameToken = GameToken.Yellow;
            _grid[2, 2].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_4_To_1_1()
        {
            _grid[4, 4].GameToken = GameToken.Red;
            _grid[3, 3].GameToken = GameToken.Red;
            _grid[2, 2].GameToken = GameToken.Red;
            _grid[1, 1].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_4_To_1_1()
        {
            _grid[4, 4].GameToken = GameToken.Yellow;
            _grid[3, 3].GameToken = GameToken.Yellow;
            _grid[2, 2].GameToken = GameToken.Yellow;
            _grid[1, 1].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_3_To_0_0()
        {
            _grid[3, 3].GameToken = GameToken.Red;
            _grid[2, 2].GameToken = GameToken.Red;
            _grid[1, 1].GameToken = GameToken.Red;
            _grid[0, 0].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_3_To_0_0()
        {
            _grid[3, 3].GameToken = GameToken.Yellow;
            _grid[2, 2].GameToken = GameToken.Yellow;
            _grid[1, 1].GameToken = GameToken.Yellow;
            _grid[0, 0].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_4_To_2_1()
        {
            _grid[5, 4].GameToken = GameToken.Red;
            _grid[4, 3].GameToken = GameToken.Red;
            _grid[3, 2].GameToken = GameToken.Red;
            _grid[2, 1].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_4_To_2_1()
        {
            _grid[5, 4].GameToken = GameToken.Yellow;
            _grid[4, 3].GameToken = GameToken.Yellow;
            _grid[3, 2].GameToken = GameToken.Yellow;
            _grid[2, 1].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_3_To_1_0()
        {
            _grid[4, 3].GameToken = GameToken.Red;
            _grid[3, 2].GameToken = GameToken.Red;
            _grid[2, 1].GameToken = GameToken.Red;
            _grid[1, 0].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_3_To_1_0()
        {
            _grid[4, 3].GameToken = GameToken.Yellow;
            _grid[3, 2].GameToken = GameToken.Yellow;
            _grid[2, 1].GameToken = GameToken.Yellow;
            _grid[1, 0].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_3_To_2_0()
        {
            _grid[5, 3].GameToken = GameToken.Red;
            _grid[4, 2].GameToken = GameToken.Red;
            _grid[3, 1].GameToken = GameToken.Red;
            _grid[2, 0].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_3_To_2_0()
        {
            _grid[5, 3].GameToken = GameToken.Yellow;
            _grid[4, 2].GameToken = GameToken.Yellow;
            _grid[3, 1].GameToken = GameToken.Yellow;
            _grid[2, 0].GameToken = GameToken.Yellow;

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
