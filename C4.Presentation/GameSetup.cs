using C4.GridBuilder.Interfaces;
using C4.GridBuilder.Model;
using C4.Presentation.ExtMethods;
using C4.Presentation.Model;
using C4.WinAnalyser;
using C4.WinAnalyser.Interfaces;
using System;
using System.Windows.Forms;

namespace C4.Presentation
{
    internal partial class GameSetup : Form
    {
        private readonly IGridBuilder<Tile> _gridBuilder;


        internal GameSetup(IGridBuilder<Tile> _gridbuilder)
        {
            _gridBuilder = _gridbuilder;
            
            InitializeComponent();
        }

        internal void ConfirmPlayers_Click(object sender, EventArgs e)
        {
            Player yellowPlayer = GetYellowPlayerDetails();
            Player redPlayer = GetRedPlayerDetails();

            LaunchGameForm(yellowPlayer, redPlayer);
        }

        private Player GetYellowPlayerDetails()
        {
            string yellowPlayerName = _txtBoxYellowPlayerName.Text.Truncate();
            bool yellowTakesFirstTurn = _rdoBtnYellow.Checked;

            var yellowPlayer = new Player(yellowPlayerName, yellowTakesFirstTurn);

            return yellowPlayer;
        }

        private Player GetRedPlayerDetails()
        {
            string redPlayerName = _txtBoxRedPlayerName.Text.Truncate();
            bool redTakesFirstTurn = _rdoBtnRed.Checked;

            var redPlayer = new Player(redPlayerName, redTakesFirstTurn);

            return redPlayer;
        }

        private void LaunchGameForm(Player yellowPlayer, Player redPlayer)
        {
            Tile[,] grid = _gridBuilder.GetGrid(rows:6, columns:7);

            IWinTypeFactory winTypeFactory = new WinTypeFactory();
            
            var gameGrid = new GameGrid(grid, yellowPlayer, redPlayer, winTypeFactory);
            gameGrid.ShowDialog();
            
            Dispose();   
        }

        private void FormCrossClicked_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
