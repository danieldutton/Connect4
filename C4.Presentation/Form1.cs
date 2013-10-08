using C4.Logic;
using C4.Logic.Interfaces;
using C4.Model;
using System.Windows.Forms;

namespace C4.Presentation
{
    public partial class Form1 : Form
    {
        private GameBoard GameBoard { get; set; }

        private readonly IReferee _referee;

        public Form1(GameBoard gameBoard)
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
            var game = GameBoard.GetGameInstance(new GridGenerator<Tile>(), _referee);
            game.TakeMove(3);
        }
    }
}
