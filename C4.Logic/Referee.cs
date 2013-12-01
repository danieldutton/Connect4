using C4.Logic.EventArg;
using C4.Logic.Interfaces;
using C4.Model;
using System;
using System.Linq;

namespace C4.Logic
{
    public class Referee : IGameUpdater
    {
        public event EventHandler<GameStatusEventArgs> GameWon;

        public event EventHandler<EventArgs> GameContinues;

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
            if (HasDrawnGame()) { OnGameDrawn(new GameStatusEventArgs(GameToken.Undefined));
                return;
            }

            GameToken gameTokenRow = Has4InARowHorizintal();
            if (gameTokenRow != GameToken.Undefined) { OnGameWon(new GameStatusEventArgs(gameTokenRow));
                return;
            }

            GameToken gameTokenColumn = Has4InARowVertical();
            if (gameTokenColumn != GameToken.Undefined) { OnGameWon(new GameStatusEventArgs(gameTokenColumn)); 
                return; 
            }

            GameToken gameTokenDiag = Has4InARowDiagonal();
            if (gameTokenDiag != GameToken.Undefined){ OnGameWon(new GameStatusEventArgs(gameTokenDiag));
                return;
            }
  
            OnGameContinues();
        }

        public GameToken Has4InARowHorizintal()
        {
            for (int i = 0; i < GameBoard.Grid.GetLength(0); ++i)
            {
                int redCounter = 0;
                int yellowCounter = 0;

                for (int j = 0; j < GameBoard.Grid.GetLength(1); ++j)
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
                        return GameToken.Red;    
                        
                    if (yellowCounter == 4)
                        return GameToken.Yellow;    
                        
                }
            }
            return GameToken.Undefined;
        }

        public GameToken Has4InARowVertical()
        {
            for (int i = 0; i < GameBoard.Grid.GetLength(1); ++i)
            {
                int yellowCounter = 0;
                int redCounter = 0;

                for (int j = 0; j < GameBoard.Grid.GetLength(0); ++j)
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
                        yellowCounter = 0;
                        redCounter = 0;
                    }

                    if (yellowCounter == 4)
                        return GameToken.Yellow;

                    if (redCounter == 4)
                        return GameToken.Red;
                }
            }
            return GameToken.Undefined;
        }

        public GameToken Has4InARowDiagonal()
        {
            for (int y = 0; y < GameBoard.Grid.GetLength(0) - 3; y++)
            {
                for (int x = 0; x < GameBoard.Grid.GetLength(1)- 3; x++)
                {
                    if (GameBoard.Grid[y, x].GameToken == GameToken.Yellow
                        && GameBoard.Grid[y + 1, x + 1].GameToken == GameToken.Yellow
                        && GameBoard.Grid[y + 2, x + 2].GameToken == GameToken.Yellow
                        && GameBoard.Grid[y + 3, x + 3].GameToken == GameToken.Yellow
                    )
                    {
                        return GameToken.Yellow;
                    }
                }
            }

            for (int y = 0; y < GameBoard.Grid.GetLength(0) - 3; y++)
            {
                for (int x = 3; x < GameBoard.Grid.GetLength(1); x++)
                {
                    if (GameBoard.Grid[y,x].GameToken == GameToken.Yellow
                        && GameBoard.Grid[y + 1, x - 1].GameToken == GameToken.Yellow
                        && GameBoard.Grid[y + 2, x - 2].GameToken == GameToken.Yellow
                        && GameBoard.Grid[y + 3, x - 3].GameToken == GameToken.Yellow
                    )
                    {
                        return GameToken.Yellow;
                    }
                }
            }

            for (int y = 0; y < GameBoard.Grid.GetLength(0) - 3; y++)
            {
                for (int x = 0; x < GameBoard.Grid.GetLength(1) - 3; x++)
                {
                    if (GameBoard.Grid[y, x].GameToken == GameToken.Red
                        && GameBoard.Grid[y + 1, x + 1].GameToken == GameToken.Red
                        && GameBoard.Grid[y + 2, x + 2].GameToken == GameToken.Red
                        && GameBoard.Grid[y + 3, x + 3].GameToken == GameToken.Red
                    )
                    {
                        return GameToken.Red;
                    }
                }
            }

            for (int y = 0; y < GameBoard.Grid.GetLength(0) - 3; y++)
            {
                for (int x = 3; x < GameBoard.Grid.GetLength(1); x++)
                {
                    if (GameBoard.Grid[y, x].GameToken == GameToken.Red
                        && GameBoard.Grid[y + 1, x - 1].GameToken == GameToken.Red
                        && GameBoard.Grid[y + 2, x - 2].GameToken == GameToken.Red
                        && GameBoard.Grid[y + 3, x - 3].GameToken == GameToken.Red
                    )
                    {
                        return GameToken.Red;
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

        protected virtual void OnGameContinues()
        {
            EventHandler<EventArgs> handler = GameContinues;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnGameDrawn(GameStatusEventArgs e)
        {
            EventHandler<GameStatusEventArgs> handler = GameDrawn;
            if (handler != null) handler(this, e);
        }
    }
}
