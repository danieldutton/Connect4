using C4.Model.Interfaces;

namespace C4.Model
{
    public class Player :IPlayer
    {
        public string Name { get; set; }

        public bool HasCurrentTurn { get; set; }
    }
}
