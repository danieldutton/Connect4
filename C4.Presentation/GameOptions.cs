using C4.Model;
using C4.Presentation.EventArg;
using C4.Utilities.Interfaces;
using System;
using System.Windows.Forms;

namespace C4.Presentation
{
    public partial class GameOptions : Form
    {
        public event EventHandler<PlayersConfirmedEventArgs> PlayersConfirmed;

        private readonly INameFormatter _nameFormatter;
        

        public GameOptions(INameFormatter nameFormatter)
        {
            _nameFormatter = nameFormatter;
            InitializeComponent();
        }

        public void ConfirmPlayers_Click(object sender, EventArgs e)
        {
            var yellowPlayer = new Player
                {
                    Name = _nameFormatter.FormatName(_txtBoxYellowPlayer.Text), 
                    HasCurrentTurn = _rdoButtonYellowStart.Checked
                };
            
            var redPlayer = new Player
                {
                    Name = _nameFormatter.FormatName(_txtBoxRedPlayer.Text), 
                    HasCurrentTurn = _rdoButtonRedStart.Checked
                };

            OnPlayersConfirmed(new PlayersConfirmedEventArgs(yellowPlayer, redPlayer));

            Dispose();
        }

        protected virtual void OnPlayersConfirmed(PlayersConfirmedEventArgs e)
        {
            EventHandler<PlayersConfirmedEventArgs> handler = PlayersConfirmed;
            if (handler != null) handler(this, e);
        }

        private void GameOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
