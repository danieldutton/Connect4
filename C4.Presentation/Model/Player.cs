namespace C4.Presentation.Model
{
    public class Player
    {
        public string Name { get; private set; }

        public bool HasCurrentTurn { get; set; }


        public Player(string name, bool hasCurrentTurn = false)
        {
            Name = name;
            HasCurrentTurn = hasCurrentTurn;
        }

        public override string ToString()
        {
            return string.Format("[{0}] Name:{1} HasCurrentTurn:{2}",
                GetType().Name, Name, HasCurrentTurn);
        }
    }
}
