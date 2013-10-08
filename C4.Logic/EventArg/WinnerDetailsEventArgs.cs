using C4.Model;

namespace C4.Logic.EventArg
{
    public class WinnerDetailsEventArgs
    {
        public GameToken WinningGameToken { get; private set; }

        //ToDo add location of winning row to highlight on grid

        public WinnerDetailsEventArgs(GameToken winningGameToken)
        {
            WinningGameToken = winningGameToken;
        }
    }
}
