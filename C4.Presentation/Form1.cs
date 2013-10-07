using C4.Logic;
using C4.Logic.Interfaces;
using C4.Model;
using System.Windows.Forms;

namespace C4.Presentation
{
    public partial class Form1 : Form
    {
        private readonly IGridGenerator<Tile> _gridGeneratorl; 

        private Game Game { get; set; }

        private Panel panel = new Panel();

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            
        }

        private void _btnStartGame_Click(object sender, System.EventArgs e)
        {
            var game = Game.GetGameInstance(new GridGenerator<Tile>());
            game.TakeMove(3);
        }
    }
}
