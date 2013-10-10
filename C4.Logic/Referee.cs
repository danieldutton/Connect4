using C4.Logic.EventArg;
using C4.Logic.Interfaces;
using C4.Model;
using System;
using System.Windows.Forms;

namespace C4.Logic
{
    public class Referee 
    {
        public event EventHandler<WinnerDetailsEventArgs> GameWon;

        public event EventHandler<EventArgs> GameNotWon;

        public event EventHandler<EventArgs> GameDrawn;

        private readonly IRuleBook _ruleBook;

        public GameBoard GameBoard { get; set; }


        public Referee(GameBoard gameBoard)
        {
            GameBoard = gameBoard;
            _ruleBook = new RuleBook(gameBoard);
            SubScribeToGameBoardEvents();
        }

        private void SubScribeToGameBoardEvents()
        {
            GameBoard.GameTokenPlaced +=GameBoard_GameTokenPlaced;
        }

        private void GameBoard_GameTokenPlaced(object sender, TokenPlacedEventArgs e)
        {
            GameBoard.Grid = e.CurrentGrid;
            CheckForWinner();
        }

        public void CheckForWinner()
        {
            if (_ruleBook.HasDrawnGame()) { OnGameDrawn(); return; }

            GameToken gameTokenRow = _ruleBook.Has4InARowVertical(GameToken.Red);
            if (gameTokenRow != GameToken.Undefined) { OnGameWon(new WinnerDetailsEventArgs(gameTokenRow)); return; }

            //GameToken gameTokenColumn = CheckColumnsForWin();
            //if (gameTokenColumn != GameToken.Undefined) { OnGameWon(new WinnerDetailsEventArgs(gameTokenColumn)); return; }

            //GameToken gameTokenDiagonal = CheckDiagonalRowsForWin();
            //if (gameTokenDiagonal != GameToken.Undefined) { OnGameWon(new WinnerDetailsEventArgs(gameTokenDiagonal)); return; }
            
            OnGameNotWon();
        }

        public GameToken CheckForRedWinHorizontal()
        {
            int counter = 0;

            for (int i = 0; i < GameBoard.Grid.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.Grid.GetLength(1); j++)
                {
                    if (GameBoard.GameTokenIsRed(i, j))
                        counter++;

                    if (GameBoard.GameTokenIsYellow(i, j) || GameBoard.GameTokenIsUndefined(i, j))
                        counter = 0;

                    if (counter == 4)
                        return GameToken.Red;
                }
            }
            return GameToken.Undefined;
        }


        protected virtual void OnGameWon(WinnerDetailsEventArgs e)
        {
            EventHandler<WinnerDetailsEventArgs> handler = GameWon;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnGameNotWon()
        {
            EventHandler<EventArgs> handler = GameNotWon;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnGameDrawn()
        {
            MessageBox.Show("Game is drawn");
            EventHandler<EventArgs> handler = GameDrawn;
            if (handler != null) handler(this, EventArgs.Empty);
        }

    }
}
