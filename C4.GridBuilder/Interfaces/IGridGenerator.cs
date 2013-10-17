namespace C4.GridBuilder.Interfaces
{
    public interface IGridGenerator<out T>
    {
        T[,] GetGrid(int rows, int columns);
    }
}
