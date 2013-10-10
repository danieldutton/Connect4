using C4.Model;

namespace C4.Logic.Interfaces
{
    public interface IGameBoard
    {
        Tile[,] Grid { get; set; }
    }
}
