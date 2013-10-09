using C4.Logic;
using C4.Logic.Interfaces;
using C4.Model;
using NUnit.Framework;
using System;
using System.Linq;

namespace C4.UnitTests.Logic
{
    [TestFixture]
    public class GameBoard_Should
    {
        private IGridGenerator<Tile> _gridGenerator;

        private GameBoard _sut;

        [SetUp]
        public void Init()
        {
            _gridGenerator = new GridGenerator<Tile>();
            var grid = _gridGenerator.GetGrid(7, 6);
            
            _sut = GameBoard.GetGameInstance(grid);
        }   
     
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetGameInstance_ThrowsAnArgumentNullExceptionIfGridParameterIsNull()
        {
            GameBoard.GetGameInstance(null);
        }

        #region Column 0 Tests

        [Test]
        public void TakeMove_Column0_FireAGameTokenPlacedEventWhenATokenIsInserted()
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

            GameToken gameToken = _sut.Grid[0, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
           _sut.TakeMove(0);

            var grid =_sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            GameToken gameToken =_sut.Grid[0, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            var grid =_sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            GameToken gameToken =_sut.Grid[0, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            var grid =_sut.Grid;
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

            GameToken gameToken =_sut.Grid[0, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            var grid =_sut.Grid;
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

            GameToken gameToken =_sut.Grid[0, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);
           _sut.TakeMove(0);

            var grid =_sut.Grid;
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

            GameToken gameToken =_sut.Grid[0, 0].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
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


            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column0_AlternateGameTokensByColour_Yellow()
        {
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Yellow));
        }

        [Test]
        public void TakeMove_Column0_AlternateGameTokensByColour_Red()
        {
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Red));
        }

        #endregion

        #region Column 1 Tests

        [Test]
        public void TakeMove_Column1_FireAGameTokenPlacedEventWhenATokenIsInserted()
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

            GameToken gameToken = _sut.Grid[1, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(1);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(6).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            GameToken gameToken = _sut.Grid[1, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(6).Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);

            GameToken gameToken = _sut.Grid[0, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(6).Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            GameToken gameToken = _sut.Grid[1, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(6).Take(2).ToArray();

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

            GameToken gameToken = _sut.Grid[1, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(6).Take(1).ToArray();

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

            GameToken gameToken = _sut.Grid[1, 0].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
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


            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(6).Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(1);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);
            _sut.TakeMove(0);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column1_AlternateGameTokensByColour_Yellow()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Skip(6).Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Yellow));
        }

        [Test]
        public void TakeMove_Column1_AlternateGameTokensByColour_Red()
        {
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);
            _sut.TakeMove(1);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Skip(6).Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Red));
        }

        #endregion

        #region Column 2 Tests

        [Test]
        public void TakeMove_Column2_FireAGameTokenPlacedEventWhenATokenIsInserted()
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

            GameToken gameToken = _sut.Grid[2, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(2);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(12).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            GameToken gameToken = _sut.Grid[2, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(12).Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            GameToken gameToken = _sut.Grid[2, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(12).Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            GameToken gameToken = _sut.Grid[2, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(12).Take(2).ToArray();

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

            GameToken gameToken = _sut.Grid[2, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(12).Take(1).ToArray();

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

            GameToken gameToken = _sut.Grid[2, 0].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
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

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(12).Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(2);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column2_AlternateGameTokensByColour_Yellow()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Skip(12).Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Yellow));
        }

        [Test]
        public void TakeMove_Column2_AlternateGameTokensByColour_Red()
        {
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);
            _sut.TakeMove(2);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Skip(12).Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Red));
        }

        #endregion

        #region Column 3 Tests

        [Test]
        public void TakeMove_Column3_FireAGameTokenPlacedEventWhenATokenIsInserted()
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

            GameToken gameToken = _sut.Grid[3, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(3);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(18).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            GameToken gameToken = _sut.Grid[3, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(18).Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            GameToken gameToken = _sut.Grid[3, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(18).Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            GameToken gameToken = _sut.Grid[3, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(18).Take(2).ToArray();

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

            GameToken gameToken = _sut.Grid[3, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(18).Take(1).ToArray();

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

            GameToken gameToken = _sut.Grid[3, 0].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
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


            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(18).Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(3);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column3_AlternateGameTokensByColour_Yellow()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Skip(18).Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Yellow));
        }

        [Test]
        public void TakeMove_Column3_AlternateGameTokensByColour_Red()
        {
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);
            _sut.TakeMove(3);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Skip(18).Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Red));
        }

        #endregion

        #region Column 4 Tests

        [Test]
        public void TakeMove_Column4_FireAGameTokenPlacedEventWhenATokenIsInserted()
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

            GameToken gameToken = _sut.Grid[4, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(4);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(24).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            GameToken gameToken = _sut.Grid[4, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(24).Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            GameToken gameToken = _sut.Grid[4, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(24).Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            GameToken gameToken = _sut.Grid[4, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(24).Take(2).ToArray();

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

            GameToken gameToken = _sut.Grid[4, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(24).Take(1).ToArray();

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

            GameToken gameToken = _sut.Grid[4, 0].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
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

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(24).Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(4);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column4_AlternateGameTokensByColour_Yellow()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Skip(24).Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Yellow));
        }

        [Test]
        public void TakeMove_Column4_AlternateGameTokensByColour_Red()
        {
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);
            _sut.TakeMove(4);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Skip(24).Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Red));
        }

        #endregion

        #region Column 5 Tests

        [Test]
        public void TakeMove_Column5_FireAGameTokenPlacedEventWhenATokenIsInserted()
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

            GameToken gameToken = _sut.Grid[5, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(5);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(30).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            GameToken gameToken = _sut.Grid[5, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(30).Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            GameToken gameToken = _sut.Grid[5, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(30).Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            GameToken gameToken = _sut.Grid[5, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(30).Take(2).ToArray();

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

            GameToken gameToken = _sut.Grid[5, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(30).Take(1).ToArray();

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

            GameToken gameToken = _sut.Grid[5, 0].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
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


            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(30).Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_FireAColumnFullEventIfTheColumnIsFullAndAUserTriesToAddASeventhToken()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column5_AlternateGameTokensByColour_Yellow()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Skip(30).Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Yellow));
        }

        [Test]
        public void TakeMove_Column5_AlternateGameTokensByColour_Red()
        {
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);
            _sut.TakeMove(5);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Skip(30).Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Red));
        }

        #endregion

        #region Column 6 Tests

        [Test]
        public void TakeMove_Column6_FireAGameTokenPlacedEventWhenATokenIsInserted()
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

            GameToken gameToken = _sut.Grid[6, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(6);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(36).Take(5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            GameToken gameToken = _sut.Grid[6, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(36).Take(4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            GameToken gameToken = _sut.Grid[6, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(36).Take(3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            GameToken gameToken = _sut.Grid[6, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(36).Take(2).ToArray();

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

            GameToken gameToken = _sut.Grid[6, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(36).Take(1).ToArray();

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

            GameToken gameToken = _sut.Grid[6, 0].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
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

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Skip(36).Take(0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_FireAColumnFullEventIfTheColumnIsFullAndAUserTriesToAddASeventhToken()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            _sut.TakeMove(6); _sut.TakeMove(6); _sut.TakeMove(6); 
            _sut.TakeMove(6); _sut.TakeMove(6); _sut.TakeMove(6);
            _sut.TakeMove(6);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column6_AlternateGameTokensByColour_Yellow()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Yellow));
        }

        [Test]
        public void TakeMove_Column6_AlternateGameTokensByColour_Red()
        {
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);
            _sut.TakeMove(6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Skip(36).Take(6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Red));
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _gridGenerator = null;
            _sut = null;

            //singleton so always reset instance to null before each test
            GameBoard.GameBoardInstance = null;
        }
    }
}
