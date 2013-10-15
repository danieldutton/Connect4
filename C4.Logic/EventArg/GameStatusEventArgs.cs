using C4.Model;

namespace C4.Logic.EventArg
{
    public class GameStatusEventArgs
    {
        public GameToken WinningGameToken { get; private set; }

        public Player WinningPlayer { get; private set; }

        //ToDo add location of winning row to highlight on grid

        public GameStatusEventArgs(GameToken winningGameToken)
        {
            WinningGameToken = winningGameToken;
        }
    }
}
