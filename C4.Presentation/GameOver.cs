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

        public void RegisterForRefereeGameWonEvent(Referee referee)
        {
            referee.GameWon += DisplayGameWonNotification;
        }

        private void DisplayGameWonNotification(object sender, GameStatusEventArgs e)
        {
            _lblWinner.Text = e.WinningGameToken.ToString() + " Wins!";
            ShowDialog();
        }

        public void RegisterForRefereeGameDrawnEvent(Referee referee)
        {
            referee.GameWon += DisplayGameDrawnNotification;
        }

        private void DisplayGameDrawnNotification(object sender, GameStatusEventArgs e)
        {
            MessageBox.Show("Game is Drawn");
            ShowDialog();
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RestartApplication_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FormCrossClicked(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }        
    }
}
