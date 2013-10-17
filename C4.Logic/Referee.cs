using C4.Logic.EventArg;
using C4.Logic.Interfaces;
using C4.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace C4.Logic
{
    public class Referee 
    {
        public event EventHandler<GameStatusEventArgs> GameWon;

        public event EventHandler<EventArgs> GameNotWon;

        public event EventHandler<GameStatusEventArgs> GameDrawn;

        public IGameBoard GameBoard { get; set; }


        public Referee(IGameBoard gameBoard)
        {
            GameBoard = gameBoard;
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
            if (HasDrawnGame()) { OnGameDrawn(new GameStatusEventArgs(GameToken.Undefined)); return; }

            GameToken gameTokenRow = Has4InARowHorizintal();
            if (gameTokenRow != GameToken.Undefined) { OnGameWon(new GameStatusEventArgs(gameTokenRow)); return; }

            GameToken gameTokenColumn = Has4InARowVertical();
            if (gameTokenColumn != GameToken.Undefined) { OnGameWon(new GameStatusEventArgs(gameTokenColumn)); return; }

            //GameToken gameTokenDiagonal = CheckDiagonalRowsForWin();
            //if (gameTokenDiagonal != GameToken.Undefined) { OnGameWon(new GameStatusEventArgs(gameTokenDiagonal)); return; }
            
            OnGameNotWon();
        }

        public GameToken Has4InARowHorizintal()
        {
            int redCounter = 0;
            int yellowCounter = 0;

            for (int i = 0; i < GameBoard.Grid.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.Grid.GetLength(1); j++)
                {
                    if (GameBoard.GameTokenIsRed(i, j))
                    {
                        redCounter++;
                        yellowCounter = 0;
                    }

                    if (GameBoard.GameTokenIsYellow(i, j))
                    {
                        yellowCounter++;
                        redCounter = 0;
                    }

                    if (GameBoard.GameTokenIsUndefined(i, j))
                    {
                        redCounter = 0;
                        yellowCounter = 0;
                    }

                    if (redCounter == 4)
                    {
                        return GameToken.Red;    
                    }
                        

                    if (yellowCounter == 4)
                    {
                        return GameToken.Yellow;    
                    }
                        
                }
            }
            return GameToken.Undefined;
        }

        public GameToken Has4InARowVertical()
        {
            int yellowCounter = 0;
            int redCounter = 0;

            for (int i = 0; i < GameBoard.Grid.GetLength(1); ++i)
            {
                for (int j = 0; j < GameBoard.Grid.GetLength(0); ++j)
                {
                    if (GameBoard.GameTokenIsRed(j, i))
                    {
                        yellowCounter++;
                        redCounter = 0;
                    }

                    if (GameBoard.GameTokenIsYellow(j, i))
                    {
                        redCounter++;
                        yellowCounter = 0;
                    }

                    if (GameBoard.GameTokenIsUndefined(j, i))
                    {
                        yellowCounter = 0;
                        redCounter = 0;
                    }

                    if (yellowCounter == 4)
                    {
                        return GameToken.Red;
                    }
                    if (redCounter == 4)
                    {
                        return GameToken.Yellow;
                        
                    }
                }
            }
            return GameToken.Undefined;
        }

        public GameToken Has4InARowDiagonal(GameToken gameToken)
        {
            int redCounter = 0;
            int yellowCounter = 0;


            for (int i = 0; i < GameBoard.Grid.GetLength(1); i++)
            {
                for (int j = 0; j < GameBoard.Grid.GetLength(0); j++)
                {
                    if (GameBoard.GameTokenIsRed(j, i))
                    {
                        redCounter++;
                        yellowCounter = 0;
                    }

                    if (GameBoard.GameTokenIsYellow(j, i))
                    {
                        yellowCounter++;
                        redCounter = 0;
                    }

                    if (GameBoard.GameTokenIsUndefined(j, i))
                    {
                        redCounter = 0;
                        yellowCounter = 0;
                    }

                    if (redCounter == 4)
                    {
                        MessageBox.Show("Red Win");
                        return GameToken.Red;
                    }
                    if (yellowCounter == 4)
                    {
                        MessageBox.Show("Yello Wins");
                        return GameToken.Yellow;
                    }
                }
            }
            return GameToken.Undefined;
        }

        public bool HasDrawnGame()
        {
            Tile[] flattenedGrid = GameBoard.Grid.Cast<Tile>().ToArray();

            return flattenedGrid.All(x => x.GameToken != GameToken.Undefined);
        }

        protected virtual void OnGameWon(GameStatusEventArgs e)
        {
            EventHandler<GameStatusEventArgs> handler = GameWon;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnGameNotWon()
        {
            EventHandler<EventArgs> handler = GameNotWon;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnGameDrawn(GameStatusEventArgs e)
        {
            EventHandler<GameStatusEventArgs> handler = GameDrawn;
            if (handler != null) handler(this, e);
        }
    }
}
