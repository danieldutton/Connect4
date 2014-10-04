using C4.GridBuilder.Model;
using C4.Presentation.ExtMethods;
using C4.Presentation.Model;
using C4.WinAnalyser.Interfaces;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace C4.Presentation
{
    internal partial class GameGrid : Form
    {
        private readonly Player _yellowPlayer;

        private readonly Player _redPlayer;
        
        private readonly IWinTypeFactory _winTypeFactory;

        private readonly Tile[,] _gameGrid;

        private readonly SoundPlayer _soundPlayer;


        public GameGrid(Tile[,] gameGrid, Player yellowPlayer, 
            Player redPlayer, IWinTypeFactory winTypeFactory)
        {
            _gameGrid = gameGrid;
            _yellowPlayer = yellowPlayer;
            _redPlayer = redPlayer;
            _winTypeFactory = winTypeFactory;
            _soundPlayer = new SoundPlayer();

            InitializeComponent();
            DrawGameBoard();
            DisplayPlayerNames();
            HighlightCurrentPlayer();
        }

        private void DrawGameBoard()
        {
            int xPos = 0, yPos = 0;

            const int tileOffSet = 35;

            for (int i = 0; i < _gameGrid.GetLength(0); i++)
            {
                for (int j = 0; j < _gameGrid.GetLength(1); j++)
                {
                    _gameGrid[i, j].Location = new Point(xPos, yPos);
                    _panelGameGrid.Controls.Add(_gameGrid[i, j]);

                    xPos += tileOffSet;

                    if (xPos > _panelGameGrid.Width)
                    {
                        yPos += tileOffSet;
                        xPos = 0;
                    }
                }
            }
        }

        private void DisplayPlayerNames()
        {
            _lblYellowPlayer.Text = _yellowPlayer.Name;
            _lblRedPlayer.Text = _redPlayer.Name;
        }

        private void HighlightCurrentPlayer()
        {
            if (_yellowPlayer.HasCurrentTurn)
                HighlightYellowPlayer();
            else
                HighlightRedPlayer();
        }

        private void HighlightYellowPlayer()
        {
            _panelYellowTurn.BackColor = Color.White;
            _panelRedTurn.BackColor = Color.Black;
        }

        private void HighlightRedPlayer()
        {
            _panelRedTurn.BackColor = Color.White;
            _panelYellowTurn.BackColor = Color.Black;
        }

        private void DropYellowToken_MouseDown(object sender, MouseEventArgs e)
        {
            if (_yellowPlayer.HasCurrentTurn)
                DoDragDrop(sender, DragDropEffects.Move);
        }

        private void DropRedToken_MouseDown(object sender, MouseEventArgs e)
        {
            if (_redPlayer.HasCurrentTurn)
                DoDragDrop(sender, DragDropEffects.Move);
        }

        private void GameToken_DragDrop(object sender, DragEventArgs e)
        {
            var columnSlot = sender as Panel;

            if (columnSlot != null)
            {
                int column = int.Parse(columnSlot.Tag.ToString());

                AcceptToken(column);
            }
            HighlightCurrentPlayer();
        }

        private void AcceptToken(int columnNo)
        {
            if (_gameGrid[0, columnNo].IsEmpty())
            {
                for (int rowNo = 5; rowNo < _gameGrid.GetLength(0); rowNo--)
                {
                    if (_gameGrid[rowNo, columnNo].IsEmpty())
                    {
                        if (_yellowPlayer.HasCurrentTurn)
                        {
                            DropToken(rowNo, columnNo, GameToken.Yellow, Color.Yellow);
                            AllowRedPlayersTurn();
                        }
                        else if (_redPlayer.HasCurrentTurn)
                        {
                            DropToken(rowNo, columnNo, GameToken.Red, Color.Red);
                            AllowYellowPlayersTurn();
                        }

                        break;
                    }
                }
            }
        }

        private void DropToken(int rowNo, int columnNo, GameToken gameToken, Color colour)
        {
            _gameGrid[rowNo, columnNo].GameToken = gameToken;
            _gameGrid[rowNo, columnNo].BackColor = colour;

            CheckForHorizontalWin();
            CheckForVerticalWin();
            CheckForDiagonalWin();
            HasDrawnGame();

            _soundPlayer.PlaySoundFX(Properties.Resources.disc_drop_in_frame);
        }

        private void AllowYellowPlayersTurn()
        {
            _yellowPlayer.HasCurrentTurn = true;
            _redPlayer.HasCurrentTurn = false;
        }

        private void AllowRedPlayersTurn()
        {
            _yellowPlayer.HasCurrentTurn = false;
            _redPlayer.HasCurrentTurn = true;
        }

        private void CheckForHorizontalWin()
        {
            IFourInARow result = _winTypeFactory.CreateInstance("Horizontal");
            
            bool yellowHorizontalWins = result.HasFourInARow(_gameGrid, GameToken.Yellow);
            bool redHorizontalWins = result.HasFourInARow(_gameGrid, GameToken.Red);

            if (yellowHorizontalWins)
                DisplayGameResults(GameToken.Yellow);

            else if (redHorizontalWins)
                DisplayGameResults(GameToken.Red);
        }

        private void CheckForVerticalWin()
        {
            IFourInARow result = _winTypeFactory.CreateInstance("Vertical");

            bool yellowVerticalWins = result.HasFourInARow(_gameGrid, GameToken.Yellow);
            bool redVerticalWins = result.HasFourInARow(_gameGrid, GameToken.Red);

            if (yellowVerticalWins)
                DisplayGameResults(GameToken.Yellow);

            else if (redVerticalWins)
                DisplayGameResults(GameToken.Red);
        }

        private void CheckForDiagonalWin()
        {
            IFourInARow result = _winTypeFactory.CreateInstance("Diagonal");

            bool yellowDiagonalWins = result.HasFourInARow(_gameGrid, GameToken.Yellow);
            bool redDiagonalWins = result.HasFourInARow(_gameGrid, GameToken.Red);

            if (yellowDiagonalWins)
                DisplayGameResults(GameToken.Yellow);    

            else if (redDiagonalWins)
                DisplayGameResults(GameToken.Red);   
        }

        private void DisplayGameResults(GameToken gameToken)
        {
            var gameOverForm = new GameOver(gameToken);
            gameOverForm.Show();    
        }

        //this probably needs extracting and placing elsewhere
        private void HasDrawnGame()
        {
            Tile[] flattenedGrid = _gameGrid.Cast<Tile>().ToArray();

            if (flattenedGrid.All(x => x.GameToken != GameToken.Undefined))
                MessageBox.Show("Game is drawn!");
        }
    }
}