using C4.GridBuilder;
using C4.Logic;
using C4.Model;
using NUnit.Framework;

namespace C4._UnitTests.Logic
{
    [TestFixture]
    public class Referee_Should
    {
        private GridGenerator<Tile> _gridGenerator;

        private Tile[,] _grid;

        private GameBoard _gameBoardStub;

        private Player _redPlayerStub;

        private Player _yellowPlayerStub;

        private Referee _sut;

        [SetUp]
        public void Init()
        {
            _gridGenerator = new GridGenerator<Tile>();
                                        //r //c
            _grid = _gridGenerator.GetGrid(6, 7);
            _gameBoardStub = GameBoard.GetGameInstance();
            _gameBoardStub.Grid = _grid;
            _redPlayerStub = new Player();
            _yellowPlayerStub = new Player {HasCurrentTurn = true};
            _gameBoardStub.RedPlayer = _redPlayerStub;
            _gameBoardStub.YellowPlayer = _yellowPlayerStub;
            _sut = new Referee(_gameBoardStub);
        }

        #region CheckForWinner

        [Test]
        public void CheckForWinner_CallEventInvocatorOnGameDrawnIfTheGameGridIsFullAndGameIsDrawn()
        {
            bool wasCalled = false;
            _sut.GameDrawn += (o, e) => wasCalled = true;

            Tile[,] fullGrid = Mother.GetGridOneTokenFromFull();
            
            //add last token to make full
            fullGrid[6,0] = new Tile{GameToken = GameToken.Red};
            var fakeGameBoard = GameBoard.GetGameInstance();
            fakeGameBoard.Grid = fullGrid;

            _sut.CheckForWinner();

            Assert.IsTrue(wasCalled);
        }

        #endregion

        #region Has4InARowVertical

        //col 0

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_0_0_To_3_0()
        {
            PushTokenInSlot(0, 0, GameToken.Red);
            PushTokenInSlot(1, 0, GameToken.Red);
            PushTokenInSlot(2, 0, GameToken.Red);
            PushTokenInSlot(3, 0, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_0_0_To_3_0()
        {
            PushTokenInSlot(0, 0, GameToken.Yellow);
            PushTokenInSlot(1, 0, GameToken.Yellow);
            PushTokenInSlot(2, 0, GameToken.Yellow);
            PushTokenInSlot(3, 0, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_1_0_To_4_0()
        {
            PushTokenInSlot(1, 0, GameToken.Red);
            PushTokenInSlot(2, 0, GameToken.Red);
            PushTokenInSlot(3, 0, GameToken.Red);
            PushTokenInSlot(4, 0, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_1_0_To_4_0()
        {
            PushTokenInSlot(1, 0, GameToken.Yellow);
            PushTokenInSlot(2, 0, GameToken.Yellow);
            PushTokenInSlot(3, 0, GameToken.Yellow);
            PushTokenInSlot(4, 0, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_2_0_To_5_0()
        {
            PushTokenInSlot(2, 0, GameToken.Red);
            PushTokenInSlot(3, 0, GameToken.Red);
            PushTokenInSlot(4, 0, GameToken.Red);
            PushTokenInSlot(5, 0, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_2_0_To_5_0()
        {
            PushTokenInSlot(2, 0, GameToken.Yellow);
            PushTokenInSlot(3, 0, GameToken.Yellow);
            PushTokenInSlot(4, 0, GameToken.Yellow);
            PushTokenInSlot(5, 0, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        //col 1

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_0_1_To_3_1()
        {
            PushTokenInSlot(0, 1, GameToken.Red);
            PushTokenInSlot(1, 1, GameToken.Red);
            PushTokenInSlot(2, 1, GameToken.Red);
            PushTokenInSlot(3, 1, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_0_1_To_3_1()
        {
            PushTokenInSlot(0, 1, GameToken.Yellow);
            PushTokenInSlot(1, 1, GameToken.Yellow);
            PushTokenInSlot(2, 1, GameToken.Yellow);
            PushTokenInSlot(3, 1, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_1_1_To_4_1()
        {
            PushTokenInSlot(1, 1, GameToken.Red);
            PushTokenInSlot(2, 1, GameToken.Red);
            PushTokenInSlot(3, 1, GameToken.Red);
            PushTokenInSlot(4, 1, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_1_1_To_4_1()
        {
            PushTokenInSlot(1, 1, GameToken.Yellow);
            PushTokenInSlot(2, 1, GameToken.Yellow);
            PushTokenInSlot(3, 1, GameToken.Yellow);
            PushTokenInSlot(4, 1, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_2_1_To_5_1()
        {
            PushTokenInSlot(2, 1, GameToken.Red);
            PushTokenInSlot(3, 1, GameToken.Red);
            PushTokenInSlot(4, 1, GameToken.Red);
            PushTokenInSlot(5, 1, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_2_1_To_5_1()
        {
            PushTokenInSlot(2, 1, GameToken.Yellow);
            PushTokenInSlot(3, 1, GameToken.Yellow);
            PushTokenInSlot(4, 1, GameToken.Yellow);
            PushTokenInSlot(5, 1, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        //col 2

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_0_2_To_3_2()
        {
            PushTokenInSlot(0, 2, GameToken.Red);
            PushTokenInSlot(1, 2, GameToken.Red);
            PushTokenInSlot(2, 2, GameToken.Red);
            PushTokenInSlot(3, 2, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_0_2_To_3_2()
        {
            PushTokenInSlot(0, 2, GameToken.Yellow);
            PushTokenInSlot(1, 2, GameToken.Yellow);
            PushTokenInSlot(2, 2, GameToken.Yellow);
            PushTokenInSlot(3, 2, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_1_2_To_4_2()
        {
            PushTokenInSlot(1, 2, GameToken.Red);
            PushTokenInSlot(2, 2, GameToken.Red);
            PushTokenInSlot(3, 2, GameToken.Red);
            PushTokenInSlot(4, 2, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_1_2_To_4_2()
        {
            PushTokenInSlot(1, 2, GameToken.Yellow);
            PushTokenInSlot(2, 2, GameToken.Yellow);
            PushTokenInSlot(3, 2, GameToken.Yellow);
            PushTokenInSlot(4, 2, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_2_2_To_5_2()
        {
            PushTokenInSlot(2, 2, GameToken.Red);
            PushTokenInSlot(3, 2, GameToken.Red);
            PushTokenInSlot(4, 2, GameToken.Red);
            PushTokenInSlot(5, 2, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_2_2_To_5_2()
        {
            PushTokenInSlot(2, 2, GameToken.Yellow);
            PushTokenInSlot(3, 2, GameToken.Yellow);
            PushTokenInSlot(4, 2, GameToken.Yellow);
            PushTokenInSlot(5, 2, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        //col 3

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_0_3_To_3_3()
        {
            PushTokenInSlot(0, 3, GameToken.Red);
            PushTokenInSlot(1, 3, GameToken.Red);
            PushTokenInSlot(2, 3, GameToken.Red);
            PushTokenInSlot(3, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_0_3_To_3_3()
        {
            PushTokenInSlot(0, 3, GameToken.Yellow);
            PushTokenInSlot(1, 3, GameToken.Yellow);
            PushTokenInSlot(2, 3, GameToken.Yellow);
            PushTokenInSlot(3, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_1_3_To_4_3()
        {
            PushTokenInSlot(1, 3, GameToken.Red);
            PushTokenInSlot(2, 3, GameToken.Red);
            PushTokenInSlot(3, 3, GameToken.Red);
            PushTokenInSlot(4, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_1_3_To_4_3()
        {
            PushTokenInSlot(1, 3, GameToken.Yellow);
            PushTokenInSlot(2, 3, GameToken.Yellow);
            PushTokenInSlot(3, 3, GameToken.Yellow);
            PushTokenInSlot(4, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_2_3_To_5_3()
        {
            PushTokenInSlot(2, 3, GameToken.Red);
            PushTokenInSlot(3, 3, GameToken.Red);
            PushTokenInSlot(4, 3, GameToken.Red);
            PushTokenInSlot(5, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_2_3_To_5_3()
        {
            PushTokenInSlot(2, 3, GameToken.Yellow);
            PushTokenInSlot(3, 3, GameToken.Yellow);
            PushTokenInSlot(4, 3, GameToken.Yellow);
            PushTokenInSlot(5, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        //col 4

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_0_4_To_3_4()
        {
            PushTokenInSlot(0, 4, GameToken.Red);
            PushTokenInSlot(1, 4, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_0_4_To_3_4()
        {
            PushTokenInSlot(0, 4, GameToken.Red);
            PushTokenInSlot(1, 4, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_1_4_To_4_4()
        {
            PushTokenInSlot(1, 4, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);
            PushTokenInSlot(4, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_1_4_To_4_4()
        {
            PushTokenInSlot(1, 4, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);
            PushTokenInSlot(4, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_2_4_To_5_4()
        {
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);
            PushTokenInSlot(4, 4, GameToken.Red);
            PushTokenInSlot(5, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_2_4_To_5_4()
        {
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);
            PushTokenInSlot(4, 4, GameToken.Red);
            PushTokenInSlot(5, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        //col 5

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_0_5_To_3_5()
        {
            PushTokenInSlot(0, 5, GameToken.Red);
            PushTokenInSlot(1, 5, GameToken.Red);
            PushTokenInSlot(2, 5, GameToken.Red);
            PushTokenInSlot(3, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_0_5_To_3_5()
        {
            PushTokenInSlot(0, 5, GameToken.Yellow);
            PushTokenInSlot(1, 5, GameToken.Yellow);
            PushTokenInSlot(2, 5, GameToken.Yellow);
            PushTokenInSlot(3, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_1_5_To_4_5()
        {
            PushTokenInSlot(1, 5, GameToken.Red);
            PushTokenInSlot(2, 5, GameToken.Red);
            PushTokenInSlot(3, 5, GameToken.Red);
            PushTokenInSlot(4, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_1_5_To_4_5()
        {
            PushTokenInSlot(1, 5, GameToken.Yellow);
            PushTokenInSlot(2, 5, GameToken.Yellow);
            PushTokenInSlot(3, 5, GameToken.Yellow);
            PushTokenInSlot(4, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_2_5_To_5_5()
        {
            PushTokenInSlot(2, 5, GameToken.Red);
            PushTokenInSlot(3, 5, GameToken.Red);
            PushTokenInSlot(4, 5, GameToken.Red);
            PushTokenInSlot(5, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_2_5_To_5_5()
        {
            PushTokenInSlot(2, 5, GameToken.Yellow);
            PushTokenInSlot(3, 5, GameToken.Yellow);
            PushTokenInSlot(4, 5, GameToken.Yellow);
            PushTokenInSlot(5, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        //col 6

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_0_6_To_3_6()
        {
            PushTokenInSlot(0, 6, GameToken.Red);
            PushTokenInSlot(1, 6, GameToken.Red);
            PushTokenInSlot(2, 6, GameToken.Red);
            PushTokenInSlot(3, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_0_6_To_3_6()
        {
            PushTokenInSlot(0, 6, GameToken.Yellow);
            PushTokenInSlot(1, 6, GameToken.Yellow);
            PushTokenInSlot(2, 6, GameToken.Yellow);
            PushTokenInSlot(3, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_1_6_To_4_6()
        {
            PushTokenInSlot(1, 6, GameToken.Red);
            PushTokenInSlot(2, 6, GameToken.Red);
            PushTokenInSlot(3, 6, GameToken.Red);
            PushTokenInSlot(4, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_1_6_To_4_6()
        {
            PushTokenInSlot(1, 6, GameToken.Yellow);
            PushTokenInSlot(2, 6, GameToken.Yellow);
            PushTokenInSlot(3, 6, GameToken.Yellow);
            PushTokenInSlot(4, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourRedTokensSpanningIndex_2_3_To_5_6()
        {
            PushTokenInSlot(2, 6, GameToken.Red);
            PushTokenInSlot(3, 6, GameToken.Red);
            PushTokenInSlot(4, 6, GameToken.Red);
            PushTokenInSlot(5, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void Has4InARowVertical_IdentifyFourYellowTokensSpanningIndex_2_6_To_5_6()
        {
            PushTokenInSlot(2, 6, GameToken.Yellow);
            PushTokenInSlot(3, 6, GameToken.Yellow);
            PushTokenInSlot(4, 6, GameToken.Yellow);
            PushTokenInSlot(5, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowVertical();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        #endregion

        #region Has4InARowHorizontal

        //row 1

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_0_0_To_0_3()
        {                           
            PushTokenInSlot(0, 0, GameToken.Red);
            PushTokenInSlot(0, 1, GameToken.Red);
            PushTokenInSlot(0, 2, GameToken.Red);
            PushTokenInSlot(0, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_0_0_To_0_3()
        {
            PushTokenInSlot(0, 0, GameToken.Yellow);
            PushTokenInSlot(0, 1, GameToken.Yellow);
            PushTokenInSlot(0, 2, GameToken.Yellow);
            PushTokenInSlot(0, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_0_1_To_0_4()
        {
            PushTokenInSlot(0, 1, GameToken.Red);
            PushTokenInSlot(0, 2, GameToken.Red);
            PushTokenInSlot(0, 3, GameToken.Red);
            PushTokenInSlot(0, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_0_1_To_0_4()
        {
            PushTokenInSlot(0, 1, GameToken.Yellow);
            PushTokenInSlot(0, 2, GameToken.Yellow);
            PushTokenInSlot(0, 3, GameToken.Yellow);
            PushTokenInSlot(0, 4, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_0_2_To_0_5()
        {
            PushTokenInSlot(0, 2, GameToken.Red);
            PushTokenInSlot(0, 3, GameToken.Red);
            PushTokenInSlot(0, 4, GameToken.Red);
            PushTokenInSlot(0, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_0_2_To_0_5()  
        {
            PushTokenInSlot(0, 2, GameToken.Yellow);
            PushTokenInSlot(0, 3, GameToken.Yellow);
            PushTokenInSlot(0, 4, GameToken.Yellow);
            PushTokenInSlot(0, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_0_3_To_0_6()
        {
            PushTokenInSlot(0, 3, GameToken.Red);
            PushTokenInSlot(0, 4, GameToken.Red);
            PushTokenInSlot(0, 5, GameToken.Red);
            PushTokenInSlot(0, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_0_3_To_0_6() 
        {
            PushTokenInSlot(0, 3, GameToken.Yellow);
            PushTokenInSlot(0, 4, GameToken.Yellow);
            PushTokenInSlot(0, 5, GameToken.Yellow);
            PushTokenInSlot(0, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        //row 2

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_1_0_To_1_3()
        {
            PushTokenInSlot(1, 0, GameToken.Red);
            PushTokenInSlot(1, 1, GameToken.Red);
            PushTokenInSlot(1, 2, GameToken.Red);
            PushTokenInSlot(1, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_1_0_To_1_3()
        {
            PushTokenInSlot(1, 0, GameToken.Yellow);
            PushTokenInSlot(1, 1, GameToken.Yellow);
            PushTokenInSlot(1, 2, GameToken.Yellow);
            PushTokenInSlot(1, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_1_1_To_1_4()
        {
            PushTokenInSlot(1, 1, GameToken.Red);
            PushTokenInSlot(1, 2, GameToken.Red);
            PushTokenInSlot(1, 3, GameToken.Red);
            PushTokenInSlot(1, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_1_1_To_1_4()
        {
            PushTokenInSlot(1, 1, GameToken.Yellow);
            PushTokenInSlot(1, 2, GameToken.Yellow);
            PushTokenInSlot(1, 3, GameToken.Yellow);
            PushTokenInSlot(1, 4, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_1_2_To_1_5()
        {
            PushTokenInSlot(1, 2, GameToken.Red);
            PushTokenInSlot(1, 3, GameToken.Red);
            PushTokenInSlot(1, 4, GameToken.Red);
            PushTokenInSlot(1, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_1_2_To_1_5()
        {
            PushTokenInSlot(1, 2, GameToken.Yellow);
            PushTokenInSlot(1, 3, GameToken.Yellow);
            PushTokenInSlot(1, 4, GameToken.Yellow);
            PushTokenInSlot(1, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_1_3_To_1_6()
        {
            PushTokenInSlot(1, 3, GameToken.Red);
            PushTokenInSlot(1, 4, GameToken.Red);
            PushTokenInSlot(1, 5, GameToken.Red);
            PushTokenInSlot(1, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_1_3_To_1_6()
        {
            PushTokenInSlot(1, 3, GameToken.Yellow);
            PushTokenInSlot(1, 4, GameToken.Yellow);
            PushTokenInSlot(1, 5, GameToken.Yellow);
            PushTokenInSlot(1, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        //row 3

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_2_0_To_2_3()
        {
            PushTokenInSlot(2, 0, GameToken.Red);
            PushTokenInSlot(2, 1, GameToken.Red);
            PushTokenInSlot(2, 2, GameToken.Red);
            PushTokenInSlot(2, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_2_0_To_2_3()
        {
            PushTokenInSlot(2, 0, GameToken.Yellow);
            PushTokenInSlot(2, 1, GameToken.Yellow);
            PushTokenInSlot(2, 2, GameToken.Yellow);
            PushTokenInSlot(2, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_2_1_To_2_4()
        {
            PushTokenInSlot(2, 1, GameToken.Red);
            PushTokenInSlot(2, 2, GameToken.Red);
            PushTokenInSlot(2, 3, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_2_1_To_2_4()
        {
            PushTokenInSlot(2, 1, GameToken.Yellow);
            PushTokenInSlot(2, 2, GameToken.Yellow);
            PushTokenInSlot(2, 3, GameToken.Yellow);
            PushTokenInSlot(2, 4, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_2_2_To_2_5()
        {
            PushTokenInSlot(2, 2, GameToken.Red);
            PushTokenInSlot(2, 3, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(2, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_2_2_To_2_5()
        {
            PushTokenInSlot(2, 2, GameToken.Yellow);
            PushTokenInSlot(2, 3, GameToken.Yellow);
            PushTokenInSlot(2, 4, GameToken.Yellow);
            PushTokenInSlot(2, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_2_3_To_2_6()
        {
            PushTokenInSlot(2, 3, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(2, 5, GameToken.Red);
            PushTokenInSlot(2, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_2_3_To_2_6()
        {
            PushTokenInSlot(2, 3, GameToken.Yellow);
            PushTokenInSlot(2, 4, GameToken.Yellow);
            PushTokenInSlot(2, 5, GameToken.Yellow);
            PushTokenInSlot(2, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        //row 4

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_3_0_To_3_3()
        {
            PushTokenInSlot(3, 0, GameToken.Red);
            PushTokenInSlot(3, 1, GameToken.Red);
            PushTokenInSlot(3, 2, GameToken.Red);
            PushTokenInSlot(3, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_3_0_To_3_3()
        {
            PushTokenInSlot(3, 0, GameToken.Yellow);
            PushTokenInSlot(3, 1, GameToken.Yellow);
            PushTokenInSlot(3, 2, GameToken.Yellow);
            PushTokenInSlot(3, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_3_1_To_3_4()
        {
            PushTokenInSlot(3, 1, GameToken.Red);
            PushTokenInSlot(3, 2, GameToken.Red);
            PushTokenInSlot(3, 3, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_3_1_To_3_4()
        {
            PushTokenInSlot(3, 1, GameToken.Yellow);
            PushTokenInSlot(3, 2, GameToken.Yellow);
            PushTokenInSlot(3, 3, GameToken.Yellow);
            PushTokenInSlot(3, 4, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_3_2_To_3_5() 
        {
            PushTokenInSlot(3, 2, GameToken.Red);
            PushTokenInSlot(3, 3, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);
            PushTokenInSlot(3, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_3_2_To_3_5()
        {
            PushTokenInSlot(3, 2, GameToken.Yellow);
            PushTokenInSlot(3, 3, GameToken.Yellow);
            PushTokenInSlot(3, 4, GameToken.Yellow);
            PushTokenInSlot(3, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_3_3_To_3_6()
        {
            PushTokenInSlot(3, 3, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);
            PushTokenInSlot(3, 5, GameToken.Red);
            PushTokenInSlot(3, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_3_3_To_3_6()
        {
            PushTokenInSlot(3, 3, GameToken.Yellow);
            PushTokenInSlot(3, 4, GameToken.Yellow);
            PushTokenInSlot(3, 5, GameToken.Yellow);
            PushTokenInSlot(3, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        } 
   
        //row 5

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndexx_4_0_To_4_3() 
        {
            PushTokenInSlot(4, 0, GameToken.Red);
            PushTokenInSlot(4, 1, GameToken.Red);
            PushTokenInSlot(4, 2, GameToken.Red);
            PushTokenInSlot(4, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);            
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_4_0_To_4_3()
        {
            PushTokenInSlot(4, 0, GameToken.Yellow);
            PushTokenInSlot(4, 1, GameToken.Yellow);
            PushTokenInSlot(4, 2, GameToken.Yellow);
            PushTokenInSlot(4, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_4_1_To_4_4() 
        {
            PushTokenInSlot(4, 1, GameToken.Red);
            PushTokenInSlot(4, 2, GameToken.Red);
            PushTokenInSlot(4, 3, GameToken.Red);
            PushTokenInSlot(4, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_4_1_To_4_4()
        {
            PushTokenInSlot(4, 1, GameToken.Yellow);
            PushTokenInSlot(4, 2, GameToken.Yellow);
            PushTokenInSlot(4, 3, GameToken.Yellow);
            PushTokenInSlot(4, 4, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_4_2_To_4_5()
        {
            PushTokenInSlot(4, 2, GameToken.Red);
            PushTokenInSlot(4, 3, GameToken.Red);
            PushTokenInSlot(4, 4, GameToken.Red);
            PushTokenInSlot(4, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_4_2_To_4_5()
        {
            PushTokenInSlot(4, 2, GameToken.Yellow);
            PushTokenInSlot(4, 3, GameToken.Yellow);
            PushTokenInSlot(4, 4, GameToken.Yellow);
            PushTokenInSlot(4, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_4_3_To_4_6()
        {
            PushTokenInSlot(4, 3, GameToken.Red);
            PushTokenInSlot(4, 4, GameToken.Red);
            PushTokenInSlot(4, 5, GameToken.Red);
            PushTokenInSlot(4, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_4_3_To_4_6()
        {
            PushTokenInSlot(4, 3, GameToken.Yellow);
            PushTokenInSlot(4, 4, GameToken.Yellow);
            PushTokenInSlot(4, 5, GameToken.Yellow);
            PushTokenInSlot(4, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }
        
        //row 6

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_5_0_To_5_3()
        {
            PushTokenInSlot(5, 0, GameToken.Red);
            PushTokenInSlot(5, 1, GameToken.Red);
            PushTokenInSlot(5, 2, GameToken.Red);
            PushTokenInSlot(5, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_5_0_To_5_3()
        {
            PushTokenInSlot(5, 0, GameToken.Yellow);
            PushTokenInSlot(5, 1, GameToken.Yellow);
            PushTokenInSlot(5, 2, GameToken.Yellow);
            PushTokenInSlot(5, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_5_1_To_5_4() 
        {
            PushTokenInSlot(5, 1, GameToken.Red);
            PushTokenInSlot(5, 2, GameToken.Red);
            PushTokenInSlot(5, 3, GameToken.Red);
            PushTokenInSlot(5, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_5_1_To_5_4()
        {
            PushTokenInSlot(5, 1, GameToken.Yellow);
            PushTokenInSlot(5, 2, GameToken.Yellow);
            PushTokenInSlot(5, 3, GameToken.Yellow);
            PushTokenInSlot(5, 4, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_5_2_To_5_5() 
        {
            PushTokenInSlot(5, 2, GameToken.Red);
            PushTokenInSlot(5, 3, GameToken.Red);
            PushTokenInSlot(5, 4, GameToken.Red);
            PushTokenInSlot(5, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_5_2_To_5_5()
        {
            PushTokenInSlot(5, 2, GameToken.Yellow);
            PushTokenInSlot(5, 3, GameToken.Yellow);
            PushTokenInSlot(5, 4, GameToken.Yellow);
            PushTokenInSlot(5, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourRedTokensSpanningIndex_5_3_To_5_6() 
        {
            PushTokenInSlot(5, 3, GameToken.Red);
            PushTokenInSlot(5, 4, GameToken.Red);
            PushTokenInSlot(5, 5, GameToken.Red);
            PushTokenInSlot(5, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowHorizontal_IdentifyFourYellowTokensSpanningIndex_5_3_To_5_6()
        {
            PushTokenInSlot(5, 3, GameToken.Yellow);
            PushTokenInSlot(5, 4, GameToken.Yellow);
            PushTokenInSlot(5, 5, GameToken.Yellow);
            PushTokenInSlot(5, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowHorizintal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        #endregion

        #region Has4InARowDiagonal
        
        //left to right diagonal

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_0_To_0_3()
        {
            PushTokenInSlot(3, 0, GameToken.Red);
            PushTokenInSlot(2, 1, GameToken.Red);
            PushTokenInSlot(1, 2, GameToken.Red);
            PushTokenInSlot(0, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_0_To_0_3()
        {
            PushTokenInSlot(3, 0, GameToken.Yellow);
            PushTokenInSlot(2, 1, GameToken.Yellow);
            PushTokenInSlot(1, 2, GameToken.Yellow);
            PushTokenInSlot(0, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_0_To_1_3()
        {
            PushTokenInSlot(4, 0, GameToken.Yellow);
            PushTokenInSlot(3, 1, GameToken.Yellow);
            PushTokenInSlot(2, 2, GameToken.Yellow);
            PushTokenInSlot(1, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_0_To_1_3()
        {
            PushTokenInSlot(4, 0, GameToken.Red);
            PushTokenInSlot(3, 1, GameToken.Red);
            PushTokenInSlot(2, 2, GameToken.Red);
            PushTokenInSlot(1, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_1_To_0_4()
        {
            PushTokenInSlot(3, 1, GameToken.Yellow);
            PushTokenInSlot(2, 2, GameToken.Yellow);
            PushTokenInSlot(1, 3, GameToken.Yellow);
            PushTokenInSlot(0, 4, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_1_To_0_4()
        {
            PushTokenInSlot(3, 1, GameToken.Red);
            PushTokenInSlot(2, 2, GameToken.Red);
            PushTokenInSlot(1, 3, GameToken.Red);
            PushTokenInSlot(0, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_0_To_2_3()
        {
            PushTokenInSlot(5, 0, GameToken.Yellow);
            PushTokenInSlot(4, 1, GameToken.Yellow);
            PushTokenInSlot(3, 2, GameToken.Yellow);
            PushTokenInSlot(2, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_0_To_2_3()
        {
            PushTokenInSlot(5, 0, GameToken.Red);
            PushTokenInSlot(4, 1, GameToken.Red);
            PushTokenInSlot(3, 2, GameToken.Red);
            PushTokenInSlot(2, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_1_To_1_4()
        {
            PushTokenInSlot(4, 1, GameToken.Yellow);
            PushTokenInSlot(3, 2, GameToken.Yellow);
            PushTokenInSlot(2, 3, GameToken.Yellow);
            PushTokenInSlot(1, 4, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_1_To_1_4()
        {
            PushTokenInSlot(4, 1, GameToken.Red);
            PushTokenInSlot(3, 2, GameToken.Red);
            PushTokenInSlot(2, 3, GameToken.Red);
            PushTokenInSlot(1, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_2_To_0_5()
        {
            PushTokenInSlot(3, 2, GameToken.Yellow);
            PushTokenInSlot(2, 3, GameToken.Yellow);
            PushTokenInSlot(1, 4, GameToken.Yellow);
            PushTokenInSlot(0, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_2_To_0_5()
        {
            PushTokenInSlot(3, 2, GameToken.Red);
            PushTokenInSlot(2, 3, GameToken.Red);
            PushTokenInSlot(1, 4, GameToken.Red);
            PushTokenInSlot(0, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_1_To_2_4()
        {
            PushTokenInSlot(5, 1, GameToken.Yellow);
            PushTokenInSlot(4, 2, GameToken.Yellow);
            PushTokenInSlot(3, 3, GameToken.Yellow);
            PushTokenInSlot(2, 4, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_1_To_2_4()
        {
            PushTokenInSlot(5, 1, GameToken.Red);
            PushTokenInSlot(4, 2, GameToken.Red);
            PushTokenInSlot(3, 3, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_2_To_1_5()
        {
            PushTokenInSlot(4, 2, GameToken.Yellow);
            PushTokenInSlot(3, 3, GameToken.Yellow);
            PushTokenInSlot(2, 4, GameToken.Yellow);
            PushTokenInSlot(1, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_2_To_1_5()
        {
            PushTokenInSlot(4, 2, GameToken.Red);
            PushTokenInSlot(3, 3, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(1, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_3_To_0_6()
        {
            PushTokenInSlot(3, 3, GameToken.Yellow);
            PushTokenInSlot(2, 4, GameToken.Yellow);
            PushTokenInSlot(1, 5, GameToken.Yellow);
            PushTokenInSlot(0, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_3_To_0_6()
        {
            PushTokenInSlot(3, 3, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(1, 5, GameToken.Red);
            PushTokenInSlot(0, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_2_To_2_5()
        {
            PushTokenInSlot(5, 2, GameToken.Yellow);
            PushTokenInSlot(4, 3, GameToken.Yellow);
            PushTokenInSlot(3, 4, GameToken.Yellow);
            PushTokenInSlot(2, 5, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_2_To_2_5()
        {
            PushTokenInSlot(5, 2, GameToken.Red);
            PushTokenInSlot(4, 3, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);
            PushTokenInSlot(2, 5, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_3_To_1_6()
        {
            PushTokenInSlot(4, 3, GameToken.Yellow);
            PushTokenInSlot(3, 4, GameToken.Yellow);
            PushTokenInSlot(2, 5, GameToken.Yellow);
            PushTokenInSlot(1, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_3_To_1_6()
        {
            PushTokenInSlot(4, 3, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);
            PushTokenInSlot(2, 5, GameToken.Red);
            PushTokenInSlot(1, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_3_To_2_6()
        {
            PushTokenInSlot(5, 3, GameToken.Yellow);
            PushTokenInSlot(4, 4, GameToken.Yellow);
            PushTokenInSlot(3, 5, GameToken.Yellow);
            PushTokenInSlot(2, 6, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_3_To_2_6()
        {
            PushTokenInSlot(5, 3, GameToken.Red);
            PushTokenInSlot(4, 4, GameToken.Red);
            PushTokenInSlot(3, 5, GameToken.Red);
            PushTokenInSlot(2, 6, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        //right to left diagonal

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_6_To_0_3()
        {
            PushTokenInSlot(3, 6, GameToken.Red);
            PushTokenInSlot(2, 5, GameToken.Red);
            PushTokenInSlot(1, 4, GameToken.Red);
            PushTokenInSlot(0, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_6_To_0_3()
        {
            PushTokenInSlot(3, 6, GameToken.Yellow);
            PushTokenInSlot(2, 5, GameToken.Yellow);
            PushTokenInSlot(1, 4, GameToken.Yellow);
            PushTokenInSlot(0, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_6_To_1_3()
        {
            PushTokenInSlot(4, 6, GameToken.Yellow);
            PushTokenInSlot(3, 5, GameToken.Yellow);
            PushTokenInSlot(2, 4, GameToken.Yellow);
            PushTokenInSlot(1, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_6_To_1_3()
        {
            PushTokenInSlot(4, 6, GameToken.Red);
            PushTokenInSlot(3, 5, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(1, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_5_To_0_2()
        {
            PushTokenInSlot(3, 5, GameToken.Yellow);
            PushTokenInSlot(2, 4, GameToken.Yellow);
            PushTokenInSlot(1, 3, GameToken.Yellow);
            PushTokenInSlot(0, 2, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_5_To_0_2()
        {
            PushTokenInSlot(3, 5, GameToken.Red);
            PushTokenInSlot(2, 4, GameToken.Red);
            PushTokenInSlot(1, 3, GameToken.Red);
            PushTokenInSlot(0, 2, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_6_To_2_3()
        {
            PushTokenInSlot(5, 6, GameToken.Yellow);
            PushTokenInSlot(4, 5, GameToken.Yellow);
            PushTokenInSlot(3, 4, GameToken.Yellow);
            PushTokenInSlot(2, 3, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_6_To_2_3()
        {
            PushTokenInSlot(5, 6, GameToken.Red);
            PushTokenInSlot(4, 5, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);
            PushTokenInSlot(2, 3, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_5_To_1_2()
        {
            PushTokenInSlot(4, 5, GameToken.Yellow);
            PushTokenInSlot(3, 4, GameToken.Yellow);
            PushTokenInSlot(2, 3, GameToken.Yellow);
            PushTokenInSlot(1, 2, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_5_To_1_2()
        {
            PushTokenInSlot(4, 5, GameToken.Red);
            PushTokenInSlot(3, 4, GameToken.Red);
            PushTokenInSlot(2, 3, GameToken.Red);
            PushTokenInSlot(1, 2, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_4_To_0_1()
        {
            PushTokenInSlot(3, 4, GameToken.Yellow);
            PushTokenInSlot(2, 3, GameToken.Yellow);
            PushTokenInSlot(1, 2, GameToken.Yellow);
            PushTokenInSlot(0, 1, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_4_To_0_1()
        {
            PushTokenInSlot(3, 4, GameToken.Red);
            PushTokenInSlot(2, 3, GameToken.Red);
            PushTokenInSlot(1, 2, GameToken.Red);
            PushTokenInSlot(0, 1, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_5_To_2_2()
        {
            PushTokenInSlot(5, 5, GameToken.Yellow);
            PushTokenInSlot(4, 4, GameToken.Yellow);
            PushTokenInSlot(3, 3, GameToken.Yellow);
            PushTokenInSlot(2, 2, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_5_To_2_2()
        {
            PushTokenInSlot(5, 5, GameToken.Red);
            PushTokenInSlot(4, 4, GameToken.Red);
            PushTokenInSlot(3, 3, GameToken.Red);
            PushTokenInSlot(2, 2, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_4_To_1_1()
        {
            PushTokenInSlot(4, 4, GameToken.Yellow);
            PushTokenInSlot(3, 3, GameToken.Yellow);
            PushTokenInSlot(2, 2, GameToken.Yellow);
            PushTokenInSlot(1, 1, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_4_To_1_1()
        {
            PushTokenInSlot(4, 4, GameToken.Red);
            PushTokenInSlot(3, 3, GameToken.Red);
            PushTokenInSlot(2, 2, GameToken.Red);
            PushTokenInSlot(1, 1, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_3_3_To_0_0()
        {
            PushTokenInSlot(3, 3, GameToken.Yellow);
            PushTokenInSlot(2, 2, GameToken.Yellow);
            PushTokenInSlot(1, 1, GameToken.Yellow);
            PushTokenInSlot(0, 0, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_3_3_To_0_0()
        {
            PushTokenInSlot(3, 3, GameToken.Red);
            PushTokenInSlot(2, 2, GameToken.Red);
            PushTokenInSlot(1, 1, GameToken.Red);
            PushTokenInSlot(0, 0, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_4_To_2_1()
        {
            PushTokenInSlot(5, 4, GameToken.Yellow);
            PushTokenInSlot(4, 3, GameToken.Yellow);
            PushTokenInSlot(3, 2, GameToken.Yellow);
            PushTokenInSlot(2, 1, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_4_To_2_1()
        {
            PushTokenInSlot(5, 4, GameToken.Red);
            PushTokenInSlot(4, 3, GameToken.Red);
            PushTokenInSlot(3, 2, GameToken.Red);
            PushTokenInSlot(2, 1, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_4_3_To_1_0()
        {
            PushTokenInSlot(4, 3, GameToken.Yellow);
            PushTokenInSlot(3, 2, GameToken.Yellow);
            PushTokenInSlot(2, 1, GameToken.Yellow);
            PushTokenInSlot(1, 0, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_4_3_To_1_0()
        {
            PushTokenInSlot(4, 3, GameToken.Red);
            PushTokenInSlot(3, 2, GameToken.Red);
            PushTokenInSlot(2, 1, GameToken.Red);
            PushTokenInSlot(1, 0, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourRedTokensSpanningIndex_5_3_To_2_0()
        {
            PushTokenInSlot(5, 3, GameToken.Yellow);
            PushTokenInSlot(4, 2, GameToken.Yellow);
            PushTokenInSlot(3, 1, GameToken.Yellow);
            PushTokenInSlot(2, 0, GameToken.Yellow);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void HasFourInARowDiagonal_IdentifyFourYellowTokensSpanningIndex_5_3_To_2_0()
        {
            PushTokenInSlot(5, 3, GameToken.Red);
            PushTokenInSlot(4, 2, GameToken.Red);
            PushTokenInSlot(3, 1, GameToken.Red);
            PushTokenInSlot(2, 0, GameToken.Red);

            GameToken gameToken = _sut.Has4InARowDiagonal();

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        #endregion

        #region HasDrawnGame

        [Test]
        public void HasDrawnGame_ReturnTrueIfGridIsFull()
        {
            Tile[,] fullGrid = Mother.GetGridAllRedTokens();
            _gameBoardStub.Grid = fullGrid;

            bool actual = _sut.HasDrawnGame();

            Assert.IsTrue(actual);
        }

        [Test]
        public void HasDrawnGame_ReturnFalseIfGridIsPartiallyFull()
        {
            Tile[,] fullGrid = Mother.GetGridOneTokenFromFull();
            _gameBoardStub.Grid = fullGrid;

            bool actual = _sut.HasDrawnGame();

            Assert.IsFalse(actual);    
        }

        #endregion

        public void PushTokenInSlot(int rowNo, int columnNo, GameToken gameToken)
        {
            _grid[rowNo, columnNo].GameToken = gameToken;
        }

        [TearDown]
        public void TearDown()
        {
            _gridGenerator = null;
            _gameBoardStub = null;
            _redPlayerStub = null;
            _yellowPlayerStub = null;
            _sut = null;
            _grid = null;
        }
    }   
}
