using C4.GridBuilder.Model;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using C4.Presentation.ExtMethods;

namespace C4.Presentation
{
    internal partial class GameOver : Form
    {
        private readonly GameToken _winningColour;

        private readonly SoundPlayer _soundPlayer;


        public GameOver(GameToken winningColour)
        {
            _winningColour = winningColour;
            _soundPlayer = new SoundPlayer();
            
            InitializeComponent();
            DisplayWinner();
            PlaySoundFX();
        }

        public void DisplayWinner()
        {
            _lblWinner.Text = string.Format("{0} Wins!", _winningColour);

            switch (_winningColour)
            {
                case GameToken.Yellow:
                    _panelWinningColour.BackColor = Color.Yellow;
                    _lblWinner.Text = "Yellow Wins";
                    break;
                case GameToken.Red:
                    _panelWinningColour.BackColor = Color.Red;
                    _lblWinner.Text = "Red Wins";
                    break;
                default:
                    _lblWinner.Text = "Game Tied";
                    break;
            }               
        }

        public void PlaySoundFX()
        {
            _soundPlayer.PlaySoundFX(Properties.Resources.discs_drop_into_box);
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

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
