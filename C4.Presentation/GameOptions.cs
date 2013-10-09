using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C4.EventAggregator;
using C4.EventAggregator.Interfaces;
using C4.Model;
using C4.Presentation.EventArg;

namespace C4.Presentation
{
    public partial class GameOptions : Form
    {
        public event EventHandler<PlayersConfirmedEventArgs> PlayersConfirmed;

        private IEventAggregator _eventAggregator;

        public GameOptions()
        {
            InitializeComponent();
            _eventAggregator = new SimpleEventAggregator();
        }

        private void GameOptions_Load(object sender, EventArgs e)
        {
            _panelYellowSquare.BackColor = Color.Yellow;
            _panelRedSquare.BackColor = Color.Red;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
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
