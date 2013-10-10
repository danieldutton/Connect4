namespace C4.GridBuilder.Interfaces
{
    public interface IGridGenerator<out T>
    {
        T[,] GetGrid(int xDim, int yDim);
    }
}
