using C4.Logic;
using C4.Logic.EventArg;
using System;
using System.Windows.Forms;

namespace C4.Presentation
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        public void RegisterForRefereesGameWonEvent(Referee referee)
        {
            referee.GameWon += GameWon;
        }

        private void GameWon(object sender, GameStatusEventArgs e)
        {
            _lblWinner.Text = e.WinningGameToken.ToString();
            ShowDialog();
        }

        public void RegisterForRefereesGameDrawnEvent(Referee referee)
        {
            referee.GameWon += GameDrawn;
        }

        private void GameDrawn(object sender, GameStatusEventArgs e)
        {
            _lblWinner.Text = e.WinningGameToken.ToString();
            ShowDialog();
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _btnPlayAgain_Click(object sender, EventArgs e)
        {
            Dispose();
        }        
    }
}
