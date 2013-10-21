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

        public void DrawGameBoard()
        {
            var grid = GameBoard.Grid;

            int x = 0, y = 0;

            int yDim = grid.GetLength(1); //6
            int xDim = grid.GetLength(0); //7

            for (int i = 0; i < xDim; i++)
            {
                for (int j = 0; j < yDim; j++)
                {
                    GameBoard.Grid[i, j].BackColor = Color.Gray;
                    GameBoard.Grid[i, j].BorderStyle = BorderStyle.FixedSingle;
                    GameBoard.Grid[i, j].Width = 32;
                    GameBoard.Grid[i, j].Height = 32;
                    GameBoard.Grid[i, j].Location = new Point(x, y);
                    var label = new Label { Text = "[" + i.ToString() + "," + j.ToString() + "]" };
                    GameBoard.Grid[i, j].Controls.Add(label);
                    panelGrid.Controls.Add(GameBoard.Grid[i, j]);
                    
                    x += 35;
                    
                    if (x > panelGrid.Width)
                    {
                        y += 35;
                        x = 0;
                    }
                }
            }
        }

        public void RegisterForPlayersConfirmedEvent(ConfirmPlayers confirmPlayers)
        {
            confirmPlayers.PlayersConfirmed += RegisterPlayersToGameboard;
        }

        private void RegisterPlayersToGameboard(object sender, PlayersConfirmedEventArgs e)
        {
            _lblPlayerRed.Text = e.RedPlayer.Name;
            _lblPlayerYellow.Text = e.YellowPlayer.Name;

            GameBoard.RedPlayer = e.RedPlayer;
            GameBoard.YellowPlayer = e.YellowPlayer;
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
