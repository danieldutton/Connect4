using C4.GridBuilder.Model;

namespace C4.WinAnalyser.Interfaces
{
    public interface IFourInARow
    {
        bool HasFourInARow(Tile[,] grid, GameToken tokenToCheckFor);
    }
}
