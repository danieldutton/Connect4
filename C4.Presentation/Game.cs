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
                    GameBoard.Grid[i, j].BackColor = Color.Red;
                    GameBoard.Grid[i, j].BorderStyle = BorderStyle.FixedSingle;
                    GameBoard.Grid[i, j].Width = 32;
                    GameBoard.Grid[i, j].Height = 32;
                    GameBoard.Grid[i, j].Location = new Point(x, y);
                    panelGrid.Controls.Add(GameBoard.Grid[i, j]);
                    
                    x += 60;
                    
                    if (x > panelGrid.Width)
                    {
                        y += 45;
                        x = 0;
                    }
                }
            }
        }

        private void _btnStartGame_Click(object sender, System.EventArgs e)
        {
            //var game = GameBoard.GetGameInstance(new GridGenerator<Tile>(), _referee);
            //game.TakeMove(3);
        }
    }
}
