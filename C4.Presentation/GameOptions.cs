using C4.Model;
using C4.Presentation.EventArg;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace C4.Presentation
{
    public partial class GameOptions : Form
    {
        public event EventHandler<PlayersConfirmedEventArgs> PlayersConfirmed;

        public GameOptions()
        {
            InitializeComponent();
        }

        private void GameOptions_Load(object sender, EventArgs e)
        {
            StylePanels();
            SetFormProperties();
            StyleTextBoxes();
            StyleLabels();
            StyleStartButton();
        }

        private void StylePanels()
        {
            _panelYellowSquare.BackColor = Color.Yellow;
            _panelRedSquare.BackColor = Color.Red;    
        }

        private void SetFormProperties()
        {
            MaximumSize = new Size(300, 167);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = Color.SteelBlue;
        }

        private void StyleTextBoxes()
        {
            _txtBoxPlayer1.ForeColor = Color.Blue;

            _txtBoxPlayer1.Font = new Font("Courier", 8.0f);

            _txtBoxPlayer1.BackColor = Color.White;
            _txtBoxPlayer2.BackColor = Color.White;
        }

        private void StyleLabels()
        {
            _lblPlayer1.ForeColor = Color.PapayaWhip;
            _lblPlayer2.ForeColor = Color.PapayaWhip;

            _lblPlayer1.Font = new Font("Arial", 10.0f, FontStyle.Italic);
            _lblPlayer2.Font = new Font("Arial", 10.0f, FontStyle.Italic);
        }

        private void StyleStartButton()
        {
            _btnConfirm.Text = "Start";
        }

        private void ConfirmPlayers_Click(object sender, EventArgs e)
        {
            var yellowPlayer = new Player {Name = _txtBoxPlayer1.Text};
            var redPlayer = new Player { Name = _txtBoxPlayer2.Text };

            OnPlayersConfirmed(new PlayersConfirmedEventArgs(yellowPlayer, redPlayer));

            Dispose();
        }

        protected virtual void OnPlayersConfirmed(PlayersConfirmedEventArgs e)
        {
            EventHandler<PlayersConfirmedEventArgs> handler = PlayersConfirmed;
            if (handler != null) handler(this, e);
        }
    }
}
