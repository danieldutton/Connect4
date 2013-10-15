namespace C4.Model.Interfaces
{
    public interface IPlayer
    {
        string Name { get; set; }

        bool HasCurrentTurn { get; set; }
    }
}
