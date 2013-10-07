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

            _sut.TakeMove(0);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column0_FailsToFireAGameTokenPlacedEventWhenATokenIsInsertedInAFullRow()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(0);

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
        public void TakeMove_Column0_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
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
        public void TakeMove_Column0_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
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
        public void TakeMove_Column0_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
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
        public void TakeMove_Column0_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(0);

            var grid = _sut.Gameboard;

            Assert.IsTrue(wasCalled);
        }

        #endregion

        #region Column 1

        [Test]
        public void TakeMove_Column1_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(1);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column1_FailsToFireAGameTokenPlacedEventWhenATokenIsInsertedInAFullRow()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(1);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column1_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            _sut.TakeMove(1);

            GameToken gameToken = _sut.Gameboard[1, 5].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(1);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(5).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            GameToken gameToken = _sut.Gameboard[1, 4].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);

            GameToken gameToken = _sut.Gameboard[0, 3].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            GameToken gameToken = _sut.Gameboard[1, 2].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(2).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            GameToken gameToken = _sut.Gameboard[1, 1].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            GameToken gameToken = _sut.Gameboard[1, 0].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingZeroColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);


            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(1);

            var grid = _sut.Gameboard;

            Assert.IsTrue(wasCalled);
        }

        #endregion

        #region Column 2

        [Test]
        public void TakeMove_Column2_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(2);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column2_FailsToFireAGameTokenPlacedEventWhenATokenIsInsertedInAFullRow()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(2);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column2_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            _sut.TakeMove(2);

            GameToken gameToken = _sut.Gameboard[2, 5].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(2);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(5).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            GameToken gameToken = _sut.Gameboard[2, 4].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            GameToken gameToken = _sut.Gameboard[2, 3].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            GameToken gameToken = _sut.Gameboard[2, 2].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(2).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            GameToken gameToken = _sut.Gameboard[2, 1].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            GameToken gameToken = _sut.Gameboard[2, 0].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingZeroColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(2);

            var grid = _sut.Gameboard;

            Assert.IsTrue(wasCalled);
        }

        #endregion

        #region Column 3

        [Test]
        public void TakeMove_Column3_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(3);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column3_FailsToFireAGameTokenPlacedEventWhenATokenIsInsertedInAFullRow()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(3);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column3_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            _sut.TakeMove(3);

            GameToken gameToken = _sut.Gameboard[3, 5].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(3);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(5).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            GameToken gameToken = _sut.Gameboard[3, 4].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            GameToken gameToken = _sut.Gameboard[3, 3].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            GameToken gameToken = _sut.Gameboard[3, 2].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(2).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            GameToken gameToken = _sut.Gameboard[3, 1].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            GameToken gameToken = _sut.Gameboard[3, 0].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingZeroColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);


            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(3);

            var grid = _sut.Gameboard;

            Assert.IsTrue(wasCalled);
        }

        #endregion

        #region Column 4

        [Test]
        public void TakeMove_Column4_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(4);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column4_FailsToFireAGameTokenPlacedEventWhenATokenIsInsertedInAFullRow()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(4);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column4_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            _sut.TakeMove(4);

            GameToken gameToken = _sut.Gameboard[4, 5].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(4);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(5).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            GameToken gameToken = _sut.Gameboard[4, 4].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            GameToken gameToken = _sut.Gameboard[4, 3].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            GameToken gameToken = _sut.Gameboard[4, 2].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(2).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            GameToken gameToken = _sut.Gameboard[4, 1].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            GameToken gameToken = _sut.Gameboard[4, 0].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingZeroColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(4);

            var grid = _sut.Gameboard;

            Assert.IsTrue(wasCalled);
        }

        #endregion

        #region Column 5

        [Test]
        public void TakeMove_Column5_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(5);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column5_FailsToFireAGameTokenPlacedEventWhenATokenIsInsertedInAFullRow()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(5);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column5_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            _sut.TakeMove(5);

            GameToken gameToken = _sut.Gameboard[5, 5].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(5);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(5).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            GameToken gameToken = _sut.Gameboard[5, 4].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            GameToken gameToken = _sut.Gameboard[5, 3].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            GameToken gameToken = _sut.Gameboard[5, 2].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(2).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            GameToken gameToken = _sut.Gameboard[5, 1].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            GameToken gameToken = _sut.Gameboard[5, 0].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingZeroColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);


            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(5);

            var grid = _sut.Gameboard;

            Assert.IsTrue(wasCalled);
        }

        #endregion

        #region Column 6

        [Test]
        public void TakeMove_Column6_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(6);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column6_FailsToFireAGameTokenPlacedEventWhenATokenIsInsertedInAFullRow()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            _sut.TakeMove(6);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column6_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            _sut.TakeMove(6);

            GameToken gameToken = _sut.Gameboard[6, 5].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(6);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(5).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            GameToken gameToken = _sut.Gameboard[6, 4].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            GameToken gameToken = _sut.Gameboard[6, 3].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            GameToken gameToken = _sut.Gameboard[6, 2].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(2).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            GameToken gameToken = _sut.Gameboard[6, 1].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            GameToken gameToken = _sut.Gameboard[6, 0].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingZeroColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);


            var grid = _sut.Gameboard;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(6);

            var grid = _sut.Gameboard;

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
