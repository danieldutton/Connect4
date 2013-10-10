using C4.Logic.Interfaces;
using C4.Model;
using System.Linq;
using System.Windows.Forms;

namespace C4.Logic
{
    public class RuleBook : IRuleBook
    {
        private readonly IGameBoard _gameBoard;

        public RuleBook(IGameBoard gameBoard)
        {
            _gameBoard = gameBoard;
        }

        public GameToken Has4InARowVertical(GameToken gameToken)
        {
            int redCounter = 0;
            int yellowCounter = 0;

            for (int rowIndex = 0; rowIndex < _gameBoard.Grid.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < _gameBoard.Grid.GetLength(1); columnIndex++)
                {
                    if (_gameBoard.Grid[rowIndex, columnIndex].GameToken == GameToken.Red)
                    {
                        redCounter++;
                        yellowCounter = 0;
                    }                       

                    if (_gameBoard.Grid[rowIndex, columnIndex].GameToken == GameToken.Yellow)
                    {
                        yellowCounter++;
                        redCounter = 0;   
                    }                        

                    if (_gameBoard.Grid[rowIndex, columnIndex].GameToken == GameToken.Undefined)
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

        public GameToken Has4InARowHorizontal(GameToken gameToken)
        {
            throw new System.NotImplementedException();
        }

        public GameToken Has4InARowDiagonal(GameToken gameToken)
        {
            throw new System.NotImplementedException();
        }

        public bool HasDrawnGame()
        {
            Tile[] flattenedGrid = _gameBoard.Grid.Cast<Tile>().ToArray();

            return flattenedGrid.All(x => x.GameToken != GameToken.Undefined);    
        }
    }
}
