using C4.GridBuilder;
using C4.GridBuilder.Model;
using C4.WinAnalyser;
using NUnit.Framework;

namespace C4.UnitTests.WinAnalyser
{
    [TestFixture]
    public class Vertical_Should
    {
        private GridBuilder<Tile> _gridBuilder;

        private Tile[,] _grid;

        private Vertical _sut;


        [SetUp]
        public void Init()
        {
            _gridBuilder = new GridBuilder<Tile>();
            _grid = _gridBuilder.GetGrid(6, 7);         
            _sut = new Vertical();
        }

        //col 0

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_0_0_To_3_0()
        {
            _grid[0, 0].GameToken = GameToken.Red;
            _grid[1, 0].GameToken = GameToken.Red;
            _grid[2, 0].GameToken = GameToken.Red;
            _grid[3, 0].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_0_0_To_3_0()
        {
            _grid[0, 0].GameToken = GameToken.Yellow;
            _grid[1, 0].GameToken = GameToken.Yellow;
            _grid[2, 0].GameToken = GameToken.Yellow;
            _grid[3, 0].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_1_0_To_4_0()
        {
            _grid[1, 0].GameToken = GameToken.Red;
            _grid[2, 0].GameToken = GameToken.Red;
            _grid[3, 0].GameToken = GameToken.Red;
            _grid[4, 0].GameToken = GameToken.Red; 

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_1_0_To_4_0()
        {
            _grid[1, 0].GameToken = GameToken.Yellow;
            _grid[2, 0].GameToken = GameToken.Yellow;
            _grid[3, 0].GameToken = GameToken.Yellow;
            _grid[4, 0].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_2_0_To_5_0()
        {
            _grid[2, 0].GameToken = GameToken.Red;
            _grid[3, 0].GameToken = GameToken.Red;
            _grid[4, 0].GameToken = GameToken.Red;
            _grid[5, 0].GameToken = GameToken.Red; 

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_2_0_To_5_0()
        {
            _grid[2, 0].GameToken = GameToken.Yellow;
            _grid[3, 0].GameToken = GameToken.Yellow;
            _grid[4, 0].GameToken = GameToken.Yellow;
            _grid[5, 0].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //col 1

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_0_1_To_3_1()
        {
            _grid[0, 1].GameToken = GameToken.Red;
            _grid[1, 1].GameToken = GameToken.Red;
            _grid[2, 1].GameToken = GameToken.Red;
            _grid[3, 1].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_0_1_To_3_1()
        {
            _grid[0, 1].GameToken = GameToken.Yellow;
            _grid[1, 1].GameToken = GameToken.Yellow;
            _grid[2, 1].GameToken = GameToken.Yellow;
            _grid[3, 1].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_1_1_To_4_1()
        {
            _grid[1, 1].GameToken = GameToken.Red;
            _grid[2, 1].GameToken = GameToken.Red;
            _grid[3, 1].GameToken = GameToken.Red;
            _grid[4, 1].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_1_1_To_4_1()
        {
            _grid[1, 1].GameToken = GameToken.Yellow;
            _grid[2, 1].GameToken = GameToken.Yellow;
            _grid[3, 1].GameToken = GameToken.Yellow;
            _grid[4, 1].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_2_1_To_5_1()
        {
            _grid[2, 1].GameToken = GameToken.Red;
            _grid[3, 1].GameToken = GameToken.Red;
            _grid[4, 1].GameToken = GameToken.Red;
            _grid[5, 1].GameToken = GameToken.Red; 

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_2_1_To_5_1()
        {
            _grid[2, 1].GameToken = GameToken.Yellow;
            _grid[3, 1].GameToken = GameToken.Yellow;
            _grid[4, 1].GameToken = GameToken.Yellow;
            _grid[5, 1].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //col 2

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_0_2_To_3_2()
        {
            _grid[0, 2].GameToken = GameToken.Red;
            _grid[1, 2].GameToken = GameToken.Red;
            _grid[2, 2].GameToken = GameToken.Red;
            _grid[3, 2].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_0_2_To_3_2()
        {
            _grid[0, 2].GameToken = GameToken.Yellow;
            _grid[1, 2].GameToken = GameToken.Yellow;
            _grid[2, 2].GameToken = GameToken.Yellow;
            _grid[3, 2].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_1_2_To_4_2()
        {
            _grid[1, 2].GameToken = GameToken.Red;
            _grid[2, 2].GameToken = GameToken.Red;
            _grid[3, 2].GameToken = GameToken.Red;
            _grid[4, 2].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_1_2_To_4_2()
        {
            _grid[1, 2].GameToken = GameToken.Yellow;
            _grid[2, 2].GameToken = GameToken.Yellow;
            _grid[3, 2].GameToken = GameToken.Yellow;
            _grid[4, 2].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_2_2_To_5_2()
        {
            _grid[2, 2].GameToken = GameToken.Red;
            _grid[3, 2].GameToken = GameToken.Red;
            _grid[4, 2].GameToken = GameToken.Red;
            _grid[5, 2].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));;
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_2_2_To_5_2()
        {
            _grid[2, 2].GameToken = GameToken.Yellow;
            _grid[3, 2].GameToken = GameToken.Yellow;
            _grid[4, 2].GameToken = GameToken.Yellow;
            _grid[5, 2].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //col 3

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_0_3_To_3_3()
        {
            _grid[0, 3].GameToken = GameToken.Red;
            _grid[1, 3].GameToken = GameToken.Red;
            _grid[2, 3].GameToken = GameToken.Red;
            _grid[3, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_0_3_To_3_3()
        {
            _grid[0, 3].GameToken = GameToken.Yellow;
            _grid[1, 3].GameToken = GameToken.Yellow;
            _grid[2, 3].GameToken = GameToken.Yellow;
            _grid[3, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_1_3_To_4_3()
        {
            _grid[1, 3].GameToken = GameToken.Red;
            _grid[2, 3].GameToken = GameToken.Red;
            _grid[3, 3].GameToken = GameToken.Red;
            _grid[4, 3].GameToken = GameToken.Red;

           Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_1_3_To_4_3()
        {
            _grid[1, 3].GameToken = GameToken.Yellow;
            _grid[2, 3].GameToken = GameToken.Yellow;
            _grid[3, 3].GameToken = GameToken.Yellow;
            _grid[4, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_2_3_To_5_3()
        {
            _grid[2, 3].GameToken = GameToken.Red;
            _grid[3, 3].GameToken = GameToken.Red;
            _grid[4, 3].GameToken = GameToken.Red;
            _grid[5, 3].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_2_3_To_5_3()
        {
            _grid[2, 3].GameToken = GameToken.Yellow;
            _grid[3, 3].GameToken = GameToken.Yellow;
            _grid[4, 3].GameToken = GameToken.Yellow;
            _grid[5, 3].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //col 4

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_0_4_To_3_4()
        {
            _grid[0, 4].GameToken = GameToken.Red;
            _grid[1, 4].GameToken = GameToken.Red;
            _grid[2, 4].GameToken = GameToken.Red;
            _grid[3, 4].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_0_4_To_3_4()
        {
            _grid[0, 4].GameToken = GameToken.Yellow;
            _grid[1, 4].GameToken = GameToken.Yellow;
            _grid[2, 4].GameToken = GameToken.Yellow;
            _grid[3, 4].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_1_4_To_4_4()
        {
            _grid[1, 4].GameToken = GameToken.Red;
            _grid[2, 4].GameToken = GameToken.Red;
            _grid[3, 4].GameToken = GameToken.Red;
            _grid[4, 4].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_1_4_To_4_4()
        {
            _grid[1, 4].GameToken = GameToken.Yellow;
            _grid[2, 4].GameToken = GameToken.Yellow;
            _grid[3, 4].GameToken = GameToken.Yellow;
            _grid[4, 4].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_2_4_To_5_4()
        {
            _grid[2, 4].GameToken = GameToken.Red;
            _grid[3, 4].GameToken = GameToken.Red;
            _grid[4, 4].GameToken = GameToken.Red;
            _grid[5, 4].GameToken = GameToken.Red;

           Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_2_4_To_5_4()
        {
            _grid[2, 4].GameToken = GameToken.Yellow;
            _grid[3, 4].GameToken = GameToken.Yellow;
            _grid[4, 4].GameToken = GameToken.Yellow;
            _grid[5, 4].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //col 5

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_0_5_To_3_5()
        {
            _grid[0, 5].GameToken = GameToken.Red;
            _grid[1, 5].GameToken = GameToken.Red;
            _grid[2, 5].GameToken = GameToken.Red;
            _grid[3, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_0_5_To_3_5()
        {
            _grid[0, 5].GameToken = GameToken.Yellow;
            _grid[1, 5].GameToken = GameToken.Yellow;
            _grid[2, 5].GameToken = GameToken.Yellow;
            _grid[3, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_1_5_To_4_5()
        {
            _grid[1, 5].GameToken = GameToken.Red;
            _grid[2, 5].GameToken = GameToken.Red;
            _grid[3, 5].GameToken = GameToken.Red;
            _grid[4, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_1_5_To_4_5()
        {
            _grid[1, 5].GameToken = GameToken.Yellow;
            _grid[2, 5].GameToken = GameToken.Yellow;
            _grid[3, 5].GameToken = GameToken.Yellow;
            _grid[4, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_2_5_To_5_5()
        {
            _grid[2, 5].GameToken = GameToken.Red;
            _grid[3, 5].GameToken = GameToken.Red;
            _grid[4, 5].GameToken = GameToken.Red;
            _grid[5, 5].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_2_5_To_5_5()
        {
            _grid[2, 5].GameToken = GameToken.Yellow;
            _grid[3, 5].GameToken = GameToken.Yellow;
            _grid[4, 5].GameToken = GameToken.Yellow;
            _grid[5, 5].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        //col 6

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_0_6_To_3_6()
        {
            _grid[0, 6].GameToken = GameToken.Red;
            _grid[1, 6].GameToken = GameToken.Red;
            _grid[2, 6].GameToken = GameToken.Red;
            _grid[3, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_0_6_To_3_6()
        {
            _grid[0, 6].GameToken = GameToken.Yellow;
            _grid[1, 6].GameToken = GameToken.Yellow;
            _grid[2, 6].GameToken = GameToken.Yellow;
            _grid[3, 6].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_1_6_To_4_6()
        {
            _grid[1, 6].GameToken = GameToken.Red;
            _grid[2, 6].GameToken = GameToken.Red;
            _grid[3, 6].GameToken = GameToken.Red;
            _grid[4, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_1_6_To_4_6()
        {
            _grid[1, 6].GameToken = GameToken.Yellow;
            _grid[2, 6].GameToken = GameToken.Yellow;
            _grid[3, 6].GameToken = GameToken.Yellow;
            _grid[4, 6].GameToken = GameToken.Yellow;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Yellow));
        }

        [Test]
        public void HasFourInARow_IdentifyFourRedTokensSpanningIndex_2_3_To_5_6()
        {
            _grid[2, 6].GameToken = GameToken.Red;
            _grid[3, 6].GameToken = GameToken.Red;
            _grid[4, 6].GameToken = GameToken.Red;
            _grid[5, 6].GameToken = GameToken.Red;

            Assert.IsTrue(_sut.HasFourInARow(_grid, GameToken.Red));
        }

        [Test]
        public void HasFourInARow_IdentifyFourYellowTokensSpanningIndex_2_6_To_5_6()
        {
            _grid[2, 6].GameToken = GameToken.Yellow;
            _grid[3, 6].GameToken = GameToken.Yellow;
            _grid[4, 6].GameToken = GameToken.Yellow;
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
