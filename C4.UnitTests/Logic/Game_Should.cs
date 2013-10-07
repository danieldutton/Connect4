using C4.Logic;
using C4.Model;
using NUnit.Framework;
using System.Linq;

namespace C4.UnitTests.Logic
{
    [TestFixture]
    public class Game_Should
    {
        private Game _sut;

        [SetUp]
        public void Init()
        {
            _sut = Game.GetGameInstance(new GridGenerator<Tile>());
        }
        

        #region Column 0
        
        [Test]
        public void TakeMove_Column0_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column0_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            _sut.TakeMove(0);

            GameToken gameToken = _sut.Gameboard[0, 5].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
           _sut.TakeMove(0);

            var grid =_sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            GameToken gameToken =_sut.Gameboard[0, 4].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            var grid =_sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            GameToken gameToken =_sut.Gameboard[0, 3].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            var grid =_sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_AddAGameTokenToColumn_0_2()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            GameToken gameToken =_sut.Gameboard[0, 2].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            var grid =_sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(2).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_AddAGameTokenToColumn_0_1()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            GameToken gameToken =_sut.Gameboard[0, 1].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            var grid =_sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_AddAGameTokenToColumn_0_0()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            GameToken gameToken =_sut.Gameboard[0, 0].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingZeroColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_FireAColumnFullEventUponTokenInsert()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            Assert.IsTrue(wasCalled);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _sut = null;
            //singleton so always reset instance to null before each test
            Game.GameInstance = null;
        }
    }
}
