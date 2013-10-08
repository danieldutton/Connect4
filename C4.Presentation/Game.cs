using C4.Logic;
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
            
            //now draw it
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    GameBoard.Grid[i, j].BackColor = Color.Gray;
                    GameBoard.Grid[i, j].BorderStyle = BorderStyle.FixedSingle;
                    GameBoard.Grid[i, j].Width = 32;
                    GameBoard.Grid[i, j].Height = 32;
                    GameBoard.Grid[i, j].Location = new Point(x, y);
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

        private void _btnStartGame_Click(object sender, System.EventArgs e)
        {
            GameBoard.TakeMove(0);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
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
    }
}
