using C4.Logic;
using C4.Logic.Interfaces;
using C4.Model;
using System.Windows.Forms;

namespace C4.Presentation
{
    public partial class Form1 : Form
    {
        private readonly IGridGenerator<Tile> _gridGeneratorl; 

        private GameGrid<Tile> GameGrid { get; set; }

        private Panel panel = new Panel();

        public Form1()
        {
            _gridGeneratorl = new GridGenerator<Tile>();
            var gameGrid = new GameGrid<Tile>(_gridGeneratorl);

            InitializeComponent();
            Init();
        }

        public void Init()
        {
            for (int i = 0; i < GameGrid.Grid.Length; i++)
            {
                for (int j = 0; j < GameGrid.Grid.Length; j++)
                {
                    panel1.Controls.Add(GameGrid.Grid[i, j]);
                }
            }
        }
    }
}
