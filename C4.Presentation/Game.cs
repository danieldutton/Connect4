using C4.Logic;
using C4.Presentation.EventArg;
using System.Drawing;
using System.Windows.Forms;

namespace C4.Presentation
{
    public partial class Game : Form
    {
        public GameBoard GameBoard { get; private set; }

        public Game(GameBoard gameBoard)
        {
            GameBoard = gameBoard; //inject possibly
            InitializeComponent();
            DrawGameBoard();
        }

        private void Game_Load(object sender, System.EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void DrawGameBoard()
        {
            var grid = GameBoard.Grid;

            int x = 0, y = 0;

            for (int i = 0; i < grid.GetLength(1); i++)
            {
                for (int j = 0; j < grid.GetLength(0); j++)
                {
                    GameBoard.Grid[j,i].BackColor = Color.Gray;
                    GameBoard.Grid[j, i].BorderStyle = BorderStyle.FixedSingle;
                    GameBoard.Grid[j, i].Width = 32;
                    GameBoard.Grid[j, i].Height = 32;
                    GameBoard.Grid[j, i].Location = new Point(x, y);
                    panelGrid.Controls.Add(GameBoard.Grid[j, i]);
                    
                    x += 35;
                    
                    if (x > panelGrid.Width)
                    {
                        y += 35;
                        x = 0;
                    }
                }
            }
        }

        public void RegisterForPlayersConfirmedEvent(GameOptions gameOptions)
        {
            gameOptions.PlayersConfirmed += RegisterPlayersToGameboard;
        }

        private void RegisterPlayersToGameboard(object sender, PlayersConfirmedEventArgs e)
        {
            _lblPlayerRed.Text = e.RedPlayer.Name;
            _lblPlayerYellow.Text = e.YellowPlayer.Name;

            GameBoard.YellowPlayer = e.YellowPlayer;
            GameBoard.RedPlayer = e.RedPlayer;
        }

        private void GameTokenToSlot_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(typeof(Label)) ? DragDropEffects.Move : DragDropEffects.None;

            var panel = sender as Panel;

            int column;

            int.TryParse(panel.Tag.ToString(), out column);

            GameBoard.TakeMove(column);
        }

        private void DropRedGameToken_MouseDown(object sender, MouseEventArgs e)
        {
            if (GameBoard.RedPlayer.HasCurrentTurn)
                DoDragDrop(sender, DragDropEffects.Move);
        }

        private void DropYellowGameToken_MouseDown(object sender, MouseEventArgs e)
        {
            if (GameBoard.YellowPlayer.HasCurrentTurn)
                DoDragDrop(sender, DragDropEffects.Move);
        }
    }
}
