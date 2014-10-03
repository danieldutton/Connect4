using C4.GridBuilder.Model;
using C4.Presentation.ExtMethods;
using C4.Presentation.Model;
using C4.WinAnalyser;
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

        private readonly Tile[,] _gameGrid;

        private readonly SoundPlayer _soundPlayer;


        public GameGrid(Tile[,] gameGrid, Player yellowPlayer, Player redPlayer)
        {
            _gameGrid = gameGrid;
            _yellowPlayer = yellowPlayer;
            _redPlayer = redPlayer;
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

        public void AcceptToken(int columnNo)
        {
            if (_gameGrid[0, columnNo].IsEmpty())
            {
                for (int rowNo = 5; rowNo < _gameGrid.GetLength(0); rowNo--)
                {
                    if (_gameGrid[rowNo, columnNo].IsEmpty())
                    {
                        if (_yellowPlayer.HasCurrentTurn)
                        {
                            DropToken(rowNo, columnNo, GameToken.Red, Color.Yellow);
                            AllowRedPlayersTurn();
                        }
                        else if (_redPlayer.HasCurrentTurn)
                        {
                            DropToken(rowNo, columnNo, GameToken.Yellow, Color.Red);
                            AllowYellowPlayersTurn();
                        }

                        break;
                    }
                }
            }
        }

        public void DropToken(int rowNo, int columnNo, GameToken gameToken, Color colour)
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
            IFourInARow winAnalyser = new Horizontal();

            bool yellowHorizontalWins = winAnalyser.HasFourInARow(_gameGrid, GameToken.Yellow);
            bool redHorizontalWins = winAnalyser.HasFourInARow(_gameGrid, GameToken.Red);

            if (yellowHorizontalWins)
                MessageBox.Show(string.Format("{0} Wins Horizontal", GameToken.Yellow));

            else if (redHorizontalWins)
                MessageBox.Show(string.Format("{0} Wins Horizontal", GameToken.Red));
        }

        private void CheckForVerticalWin()
        {
            IFourInARow winAnalyser = new Vertical();

            bool yellowVerticalWins = winAnalyser.HasFourInARow(_gameGrid, GameToken.Yellow);
            bool redVerticalWins = winAnalyser.HasFourInARow(_gameGrid, GameToken.Red);

            if (yellowVerticalWins)
                MessageBox.Show(string.Format("{0} Wins Vertical", GameToken.Yellow));

            else if (redVerticalWins)
                MessageBox.Show(string.Format("{0} Wins Vertical", GameToken.Red));
        }

        private void CheckForDiagonalWin()
        {
            IFourInARow winAnalyser = new Diagonal();

            bool yellowDiagonalWins = winAnalyser.HasFourInARow(_gameGrid, GameToken.Yellow);
            bool redDiagonalWins = winAnalyser.HasFourInARow(_gameGrid, GameToken.Red);

            if (yellowDiagonalWins)
                MessageBox.Show(string.Format("{0} Wins Diagonal", GameToken.Yellow));

            else if (redDiagonalWins)
                MessageBox.Show(string.Format("{0} Wins Diagonal", GameToken.Red));
        }

        //this needs extracting and placing elsewhere
        public void HasDrawnGame()
        {
            Tile[] flattenedGrid = _gameGrid.Cast<Tile>().ToArray();

            if (flattenedGrid.All(x => x.GameToken != GameToken.Undefined))
                MessageBox.Show("Game is drawn!");
        }
    }
}