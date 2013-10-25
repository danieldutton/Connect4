using C4.Model;
using C4.WinChecker.Strategies;

namespace C4.WinChecker
{
    public class FourInARowChecker
    {
        private readonly IFourInARowChecker _fourInARowChecker;

        public FourInARowChecker(IFourInARowChecker fourInARowChecker)
        {
            _fourInARowChecker = fourInARowChecker;
        }

        public GameToken HasFourInARow()
        {
            return _fourInARowChecker.HasFourInARow();
        } 
    }
}
