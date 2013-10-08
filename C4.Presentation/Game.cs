using C4.Logic;
using C4.Logic.Interfaces;
using System.Windows.Forms;

namespace C4.Presentation
{
    public partial class Game : Form
    {
        public GameBoard GameBoard { get; private set; }

        public Game(GameBoard gameBoard)
        {
            InitializeComponent();
            DrawGrid();
        }

        public void DrawGrid()
        {
            var grid = GameBoard.Grid;

            //now draw it
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; i++)
                {
                        
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
