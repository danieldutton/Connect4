using C4.Logic.Interfaces;
using C4.Model;
using C4.Presentation.EventArg;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace C4.Presentation
{
    internal partial class Game : Form
    {
        public IGameBoard GameBoard { get; private set; }

        public Game(IGameBoard gameBoard)
        {
            GameBoard = gameBoard;
            InitializeComponent();
            DrawGameBoard();
        }

        internal void DrawGameBoard()
        {
            Tile[,] grid = GameBoard.Grid;

            int x = 0, y = 0;
           
            const int tileOffSet = 35;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    GameBoard.Grid[i, j].Location = new Point(x, y);
                    panelGrid.Controls.Add(GameBoard.Grid[i, j]);
                    
                    x += tileOffSet;
                    
                    if (x > panelGrid.Width)
                    {
                        y += 35;
                        x = 0;
                    }
                }
            }
        }

        internal void RegisterForConfirmPlayers_PlayersConfirmedEvent(ConfirmGamePlayers confirmGamePlayers)
        {
            confirmGamePlayers.PlayersConfirmed += RegisterPlayersToGameboard;
        }

        private void RegisterPlayersToGameboard(object sender, PlayersConfirmedEventArgs e)
        {
            txtBoxPlayer1.Text = e.RedPlayer.Name;
            txtBoxPlayer2.Text = e.YellowPlayer.Name;

            GameBoard.RedPlayer = e.RedPlayer;
            GameBoard.YellowPlayer = e.YellowPlayer;
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

        private void GameToken_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(typeof(Label)) ? DragDropEffects.Move : DragDropEffects.All;

            var columnSlot = sender as Panel;

            int column = int.Parse(columnSlot.Tag.ToString());

            GameBoard.TakeMove(column);
            PlayTokenDropFx();
        }

        private void PlayTokenDropFx()
        {
            var soundPlayer = new SoundPlayer(Properties.Resources.disc_drop_in_frame);
            
            soundPlayer.Load();
            soundPlayer.Play();
        }
    }
}
