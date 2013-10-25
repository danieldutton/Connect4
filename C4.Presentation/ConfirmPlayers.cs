using C4.Model;
using C4.Presentation.EventArg;
using C4.Utilities.Interfaces;
using System;
using System.Windows.Forms;

namespace C4.Presentation
{
    public partial class ConfirmPlayers : Form
    {
        public event EventHandler<PlayersConfirmedEventArgs> PlayersConfirmed;

        private readonly INameFormatter _nameFormatter;
        

        public ConfirmPlayers(INameFormatter nameFormatter)
        {
            _nameFormatter = nameFormatter;
            InitializeComponent();
        }

        public void ConfirmPlayers_Click(object sender, EventArgs e)
        {
            var yellowPlayer = new Player
                {
                    Name = _nameFormatter.FormatName(_txtBoxYellowPlayerName.Text), 
                    HasCurrentTurn = _rdoBtnYellowPlayerStart.Checked
                };
            
            var redPlayer = new Player
                {
                    Name = _nameFormatter.FormatName(_txtBoxRedPlayerName.Text), 
                    HasCurrentTurn = _rdoBtnRedPlayerStart.Checked
                };

            OnPlayersConfirmed(new PlayersConfirmedEventArgs(yellowPlayer, redPlayer));

            Dispose();
        }

        protected virtual void OnPlayersConfirmed(PlayersConfirmedEventArgs e)
        {
            EventHandler<PlayersConfirmedEventArgs> handler = PlayersConfirmed;
            if (handler != null) handler(this, e);
        }

        private void FormCrossClicked_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
