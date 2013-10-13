using C4.Model;
using C4.Presentation.EventArg;
using System;
using System.Linq;
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

        private void ConfirmPlayers_Click(object sender, EventArgs e)
        {
            var yellowPlayer = new Player
                {
                    Name = FormatPlayerName(_txtBoxYellowPlayer.Text), 
                    HasCurrentTurn = _rdoButtonYellowStart.Checked
                };
            
            var redPlayer = new Player
                {
                    Name = FormatPlayerName(_txtBoxRedPlayer.Text), 
                    HasCurrentTurn = _rdoButtonRedStart.Checked
                };

            OnPlayersConfirmed(new PlayersConfirmedEventArgs(yellowPlayer, redPlayer));

            Dispose();
        }

        private string FormatPlayerName(string name)
        {
            if (name == string.Empty) return "Unknown";
            
            if (name.Length > 10)
                name = name.Substring(0, 10);
            return name;
        }

        protected virtual void OnPlayersConfirmed(PlayersConfirmedEventArgs e)
        {
            EventHandler<PlayersConfirmedEventArgs> handler = PlayersConfirmed;
            if (handler != null) handler(this, e);
        }
    }
}
