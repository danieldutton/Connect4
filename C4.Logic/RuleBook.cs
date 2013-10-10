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
            int counter = 0;

            for (int i = 0; i < _gameBoard.Grid.GetLength(0); i++)
            {
                for (int j = 0; j < _gameBoard.Grid.GetLength(1); j++)
                {
                    if (_gameBoard.Grid[i, j].GameToken == GameToken.Red)
                    {
                        counter++;
                    }
                    if (_gameBoard.Grid[i, j].GameToken == GameToken.Yellow)
                    {
                        counter = 0;
                    }
                    if (_gameBoard.Grid[i, j].GameToken == GameToken.Undefined)
                    {
                        counter = 0;
                    }

                    if (counter == 4)
                    {
                        MessageBox.Show("Red Win");
                        return GameToken.Red;
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

        public bool HasDrawn()
        {
            Tile[] flattenedGrid = _gameBoard.Grid.Cast<Tile>().ToArray();

            return flattenedGrid.All(x => x.GameToken != GameToken.Undefined);    
        }
    }
}
