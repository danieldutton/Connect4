using C4.Model.Interfaces;

namespace C4.Model
{
    public class Player :IPlayer
    {
        public string Name { get; set; }

        public bool HasCurrentTurn { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] Name:{1} HasCurrentTurn:{2}",
                GetType().Name, Name, HasCurrentTurn);
        }
    }
}
