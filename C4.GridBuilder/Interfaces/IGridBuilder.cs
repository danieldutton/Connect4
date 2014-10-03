namespace C4.GridBuilder.Interfaces
{
    public interface IGridBuilder<out T>
    {
        T[,] GetGrid(int rows, int columns);
    }
}
