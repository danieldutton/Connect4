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
            GameBoard = gameBoard;
            InitializeComponent();
            DrawGrid();
        }

        public void DrawGrid()
        {
            var grid = GameBoard.Grid;

            int x = 0, y = 0;

            int xLength = grid.GetLength(0);  //this is seven
            int Ylength = grid.GetLength(1);  //this is six  

            //now draw it - currently drawing horizontal should be vertical
            for (int i = 0; i < Ylength; i++)
            {
                for (int j = 0; j < xLength; j++)
                {
                    GameBoard.Grid[j,i].BackColor = Color.Gray;
                    GameBoard.Grid[j, i].BorderStyle = BorderStyle.FixedSingle;
                    GameBoard.Grid[j, i].Width = 32;
                    GameBoard.Grid[j, i].Height = 32;
                    GameBoard.Grid[j, i].Text = "shit";
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

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if(GameBoard.PlayerRed.IsCurrentTurn)
            DoDragDrop(sender, DragDropEffects.Move);
        }

        private void panelDrop0_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Label)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

            var panel = sender as Panel;

            int column;
            
            int.TryParse(panel.Tag.ToString(), out column);

            GameBoard.TakeMove(column);

            int i = 10;
            //get the tag to determine colum index.  then take the move


        }

        public void RegisterForOptionsNotifiction(GameOptions gameOptions)
        {
            gameOptions.PlayersConfirmed += GameBoard_GameTokenPlaced;
        }

        private void GameBoard_GameTokenPlaced(object sender, PlayersConfirmedEventArgs e)
        {
            if (e.RedPlayer.Name != string.Empty && e.YellowPlayer.Name != string.Empty)
            {
                _lblPlayerRed.Text = e.RedPlayer.Name;
                _lblPlayerYellow.Text = e.YellowPlayer.Name;
            }
            else
            {
                _lblPlayerRed.Text = "Unknown";
                _lblPlayerYellow.Text = "Unknown";
            }
            
        }

        private void _lblYellowToken_MouseDown(object sender, MouseEventArgs e)
        {
            if (GameBoard.PlayerYellow.IsCurrentTurn)
                DoDragDrop(sender, DragDropEffects.Move);
        }

        private void Game_Load(object sender, System.EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
