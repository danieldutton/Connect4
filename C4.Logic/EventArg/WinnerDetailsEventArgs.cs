using C4.Model;

namespace C4.Logic.EventArg
{
    public class WinnerDetailsEventArgs
    {
        public Player WinningPlayer { get; private set; }

        //winning plot

        public WinnerDetailsEventArgs(Player winningPlayer)
        {
            winningPlayer = winningPlayer;
        }
    }
}
