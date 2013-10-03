namespace C4.Logic.Interfaces
{
    public interface IGridGenerator<out T>
    {
        T[,] GetGrid(int xDim, int yDim);
    }
}
