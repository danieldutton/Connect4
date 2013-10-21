using C4.GridBuilder;
using C4.GridBuilder.Interfaces;
using C4.Logic;
using C4.Model;
using C4.Model.Interfaces;
using NUnit.Framework;
using System.Linq;

namespace C4.Tests_Unit.Logic
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
            var grid = _gridGenerator.GetGrid(6, 7);
            
            _sut = GameBoard.GetGameInstance();
            _sut.Grid = grid;
            IPlayer yellowPlayer = new Player {HasCurrentTurn = true};
            IPlayer redPlayer = new Player();
            _sut.YellowPlayer = yellowPlayer;
            _sut.RedPlayer = redPlayer;
        }   


        [Test]
        public void getGameInstance_OnlyEverReturnTheOneSingletonInstanceOfGameBoard()
        {
            GameBoard gameBoard1 = GameBoard.GetGameInstance();
            GameBoard gameBoard2 = GameBoard.GetGameInstance();

            Assert.AreSame(gameBoard1, gameBoard2);
        }

        //column 0

        [Test]
        public void TakeMove_Column0_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 0, numOfMoves: 1);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column0_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            TakeMoves(columnNo: 0, numOfMoves: 1);

            GameToken gameToken = _sut.Grid[5, 0].GameToken;

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 0, numOfMoves: 1);

            var grid =_sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 5 && x.ColumnNumber == 0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            TakeMoves(columnNo: 0, numOfMoves: 2);

            GameToken gameToken =_sut.Grid[4, 0].GameToken;

            Assert.AreEqual(GameToken.Red, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 0, numOfMoves: 2);

            var grid =_sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 4 && x.ColumnNumber == 0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            TakeMoves(columnNo: 0, numOfMoves: 3);

            GameToken gameToken =_sut.Grid[3, 0].GameToken;

            Assert.AreEqual(GameToken.Yellow, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 0, numOfMoves: 3);

            var grid =_sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 3 && x.ColumnNumber == 0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            TakeMoves(columnNo: 0, numOfMoves: 4);

            GameToken gameToken =_sut.Grid[2, 0].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 0, numOfMoves: 4);

            var grid =_sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 2 && x.ColumnNumber == 0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            TakeMoves(columnNo: 0, numOfMoves: 5);

            GameToken gameToken =_sut.Grid[1, 0].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column0_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 0, numOfMoves: 5);

            var grid =_sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 1 && x.ColumnNumber == 0).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column0_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            TakeMoves(columnNo: 0, numOfMoves: 6);

            GameToken gameToken =_sut.Grid[0, 0].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column0_FireAColumnFullEventIfTheColumnIsFull()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 1, numOfMoves: 7);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column0_AlternateGameTokensByColour_Red()
        {
            TakeMoves(columnNo: 0, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 0).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Red));
        }

        [Test]
        public void TakeMove_Column0_AlternateGameTokensByColour_Yellow()
        {
            TakeMoves(columnNo: 0, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 0).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Yellow));
        }

        //Column 1

        [Test]
        public void TakeMove_Column1_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 1, numOfMoves: 1);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column1_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            TakeMoves(columnNo: 1, numOfMoves: 1);

            GameToken gameToken = _sut.Grid[5, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 1, numOfMoves: 1);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 5 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            TakeMoves(columnNo: 1, numOfMoves: 2);

            GameToken gameToken = _sut.Grid[4, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 1, numOfMoves: 2);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 4 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            TakeMoves(columnNo: 1, numOfMoves: 3);

            GameToken gameToken = _sut.Grid[3, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 1, numOfMoves: 3);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 3 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            TakeMoves(columnNo: 1, numOfMoves: 4);

            GameToken gameToken = _sut.Grid[2, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 1, numOfMoves: 4);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 2 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            TakeMoves(columnNo: 1, numOfMoves: 5);

            GameToken gameToken = _sut.Grid[1, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column1_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 1, numOfMoves: 5);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 1 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column1_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            TakeMoves(columnNo: 1, numOfMoves: 6);

            GameToken gameToken = _sut.Grid[0, 1].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column1_FireAColumnFullEventIfTheColumnIsFullAndAUserTriesToAddASeventhToken()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 1, numOfMoves: 7);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column1_AlternateGameTokensByColour_Red()
        {
            TakeMoves(columnNo: 1, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Red));
        }

        [Test]
        public void TakeMove_Column1_AlternateGameTokensByColour_Yellow()
        {
            TakeMoves(columnNo: 1, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Yellow));
        }

        //Column 2

        [Test]
        public void TakeMove_Column2_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 2, numOfMoves: 1);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column2_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            TakeMoves(columnNo: 2, numOfMoves: 1);

            GameToken gameToken = _sut.Grid[5, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 2, numOfMoves: 1);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 5 && x.ColumnNumber == 2).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            TakeMoves(columnNo: 2, numOfMoves: 2);

            GameToken gameToken = _sut.Grid[4, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 2, numOfMoves: 2);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 4 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            TakeMoves(columnNo: 2, numOfMoves: 3);

            GameToken gameToken = _sut.Grid[3, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 2, numOfMoves: 3);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 3 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            TakeMoves(columnNo: 2, numOfMoves: 4);

            GameToken gameToken = _sut.Grid[2, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 2, numOfMoves: 4);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 2 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            TakeMoves(columnNo: 2, numOfMoves: 5);

            GameToken gameToken = _sut.Grid[1, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column2_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 2, numOfMoves: 5);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 1 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column2_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            TakeMoves(columnNo: 2, numOfMoves: 6);

            GameToken gameToken = _sut.Grid[0, 2].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column2_FireAColumnFullEventIfTheColumnIsFullAndAUserTriesToAddASeventhToken()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 2, numOfMoves: 7);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column2_AlternateGameTokensByColour_Red()
        {
            TakeMoves(columnNo: 2, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 2).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Red));
        }

        [Test]
        public void TakeMove_Column2_AlternateGameTokensByColour_Yellow()
        {
            TakeMoves(columnNo: 2, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 2).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Yellow));
        }

        //Column 3

        [Test]
        public void TakeMove_Column3_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 3, numOfMoves: 1);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column3_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            TakeMoves(columnNo: 3, numOfMoves: 1);

            GameToken gameToken = _sut.Grid[5, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 3, numOfMoves: 1);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 5 && x.ColumnNumber == 3).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            TakeMoves(columnNo: 3, numOfMoves: 2);

            GameToken gameToken = _sut.Grid[4, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 3, numOfMoves: 2);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 4 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            TakeMoves(columnNo: 3, numOfMoves: 3);

            GameToken gameToken = _sut.Grid[3, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 3, numOfMoves: 3);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 3 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            TakeMoves(columnNo: 3, numOfMoves: 4);

            GameToken gameToken = _sut.Grid[2, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 3, numOfMoves: 4);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 2 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            TakeMoves(columnNo: 3, numOfMoves: 5);

            GameToken gameToken = _sut.Grid[1, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column3_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 3, numOfMoves: 5);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 1 && x.ColumnNumber == 1).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column3_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            TakeMoves(columnNo: 3, numOfMoves: 6);

            GameToken gameToken = _sut.Grid[0, 3].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column3_FireAColumnFullEventIfTheColumnIsFullAndAUserTriesToAddASeventhToken()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 3, numOfMoves: 7);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column3_AlternateGameTokensByColour_Red()
        {
            TakeMoves(columnNo: 3, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 3).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Red));
        }

        [Test]
        public void TakeMove_Column3_AlternateGameTokensByColour_Yellow()
        {
            TakeMoves(columnNo: 3, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 3).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Yellow));
        }

        //Column 4

        [Test]
        public void TakeMove_Column4_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 4, numOfMoves: 1);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column4_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            TakeMoves(columnNo: 4, numOfMoves: 1);

            GameToken gameToken = _sut.Grid[5, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 4, numOfMoves: 1);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 5 && x.ColumnNumber == 4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            TakeMoves(columnNo: 4, numOfMoves: 2);

            GameToken gameToken = _sut.Grid[4, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 4, numOfMoves: 2);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 4 && x.ColumnNumber == 4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            TakeMoves(columnNo: 4, numOfMoves: 3);

            GameToken gameToken = _sut.Grid[3, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 4, numOfMoves: 3);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 3 && x.ColumnNumber == 4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            TakeMoves(columnNo: 4, numOfMoves: 4);

            GameToken gameToken = _sut.Grid[2, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 4, numOfMoves: 4);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 2 && x.ColumnNumber == 4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            TakeMoves(columnNo: 4, numOfMoves: 5);

            GameToken gameToken = _sut.Grid[1, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column4_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 4, numOfMoves: 5);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 1 && x.ColumnNumber == 4).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column4_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            TakeMoves(columnNo: 4, numOfMoves: 6);

            GameToken gameToken = _sut.Grid[0, 4].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column4_FireAColumnFullEventIfTheColumnIsFullAndAUserTriesToAddASeventhToken()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 4, numOfMoves: 7);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column4_AlternateGameTokensByColour_Red()
        {
            TakeMoves(columnNo: 4, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 4).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Red));
        }

        [Test]
        public void TakeMove_Column4_AlternateGameTokensByColour_Yellow()
        {
            TakeMoves(columnNo: 4, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 4).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Yellow));
        }

        //Column 5

        [Test]
        public void TakeMove_Column5_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 5, numOfMoves: 1);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column5_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            TakeMoves(columnNo: 5, numOfMoves: 1);

            GameToken gameToken = _sut.Grid[5, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 5, numOfMoves: 1);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 5 && x.ColumnNumber == 5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            TakeMoves(columnNo: 5, numOfMoves: 2);

            GameToken gameToken = _sut.Grid[4, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 5, numOfMoves: 2);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 4 && x.ColumnNumber == 5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            TakeMoves(columnNo: 5, numOfMoves: 3);

            GameToken gameToken = _sut.Grid[3, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 5, numOfMoves: 3);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 3 && x.ColumnNumber == 5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            TakeMoves(columnNo: 5, numOfMoves: 4);

            GameToken gameToken = _sut.Grid[2, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 5, numOfMoves: 4);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 2 && x.ColumnNumber == 5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            TakeMoves(columnNo: 5, numOfMoves: 5);

            GameToken gameToken = _sut.Grid[1, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column5_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 5, numOfMoves: 5);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 1 && x.ColumnNumber == 5).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column5_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            TakeMoves(columnNo: 5, numOfMoves: 6);

            GameToken gameToken = _sut.Grid[0, 5].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column5_FireAColumnFullEventIfTheColumnIsFullAndAUserTriesToAddASeventhToken()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 5, numOfMoves: 7);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column5_AlternateGameTokensByColour_Red()
        {
            TakeMoves(columnNo: 5, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 5).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Red));
        }

        [Test]
        public void TakeMove_Column5_AlternateGameTokensByColour_Yellow()
        {
            TakeMoves(columnNo: 5, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 5).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Yellow));
        }

        //Column 6

        [Test]
        public void TakeMove_Column6_FireAGameTokenPlacedEventWhenATokenIsInserted()
        {
            bool wasCalled = false;
            _sut.GameTokenPlaced += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 6, numOfMoves: 1);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column6_DropAGameTokenToIndex5_IfTheColumnIsEmpty()
        {
            TakeMoves(columnNo: 6, numOfMoves: 1);

            GameToken gameToken = _sut.Grid[5, 6].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveTheRemainingFiveColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 6, numOfMoves: 1);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 5 && x.ColumnNumber == 6).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexFour_IfSlotFiveIsTaken()
        {
            TakeMoves(columnNo: 6, numOfMoves: 2);

            GameToken gameToken = _sut.Grid[4, 6].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingFourColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 6, numOfMoves: 2);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 4 && x.ColumnNumber == 6).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexThree_IfSlotFourIsTaken()
        {
            TakeMoves(columnNo: 6, numOfMoves: 3);

            GameToken gameToken = _sut.Grid[3, 6].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingThreeColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 6, numOfMoves: 3);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 3 && x.ColumnNumber == 6).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexTwo_IfSlotThreeIsTaken()
        {
            TakeMoves(columnNo: 6, numOfMoves: 4);

            GameToken gameToken = _sut.Grid[2, 6].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingTwoColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 6, numOfMoves: 4);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 2 && x.ColumnNumber == 6).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexOne_IfSlotTwoIsTaken()
        {
            TakeMoves(columnNo: 6, numOfMoves: 5);

            GameToken gameToken = _sut.Grid[1, 6].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column6_LeaveRemainingOneColumnTokensAsGameTokenUndefined()
        {
            TakeMoves(columnNo: 6, numOfMoves: 5);

            var grid = _sut.Grid;
            Tile[] undefinedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 1 && x.ColumnNumber == 6).ToArray();

            Assert.IsTrue(undefinedTiles.All(x => x.GameToken == GameToken.Undefined));
        }

        [Test]
        public void TakeMove_Column6_GameTokenDropsToIndexZero_IfSlotOneIsTaken()
        {
            TakeMoves(columnNo: 6, numOfMoves: 6);

            GameToken gameToken = _sut.Grid[0, 6].GameToken;

            Assert.AreNotEqual(GameToken.Undefined, gameToken);
        }

        [Test]
        public void TakeMove_Column6_FireAColumnFullEventIfTheColumnIsFullAndAUserTriesToAddASeventhToken()
        {
            bool wasCalled = false;
            _sut.ColumnFull += (o, e) => wasCalled = true;

            TakeMoves(columnNo: 6, numOfMoves: 7);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void TakeMove_Column6_AlternateGameTokensByColour_Red()
        {
            TakeMoves(columnNo: 6, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 == 0).All(x => x.GameToken == GameToken.Red));
        }

        [Test]
        public void TakeMove_Column6_AlternateGameTokensByColour_Yellow()
        {
            TakeMoves(columnNo: 6, numOfMoves: 6);

            var grid = _sut.Grid;
            Tile[] definedTiles = grid.Cast<Tile>().Where(x => x.RowNumber < 6 && x.ColumnNumber == 6).ToArray();

            Assert.IsTrue(definedTiles.Where((x, index) => index % 2 != 0).All(x => x.GameToken == GameToken.Yellow));
        }

        //utility methods

        private void TakeMoves(int columnNo, int numOfMoves)
        {
            for (int i = 0; i < numOfMoves; i++)
            {
                _sut.TakeMove(columnNo);
            }   
        }

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
