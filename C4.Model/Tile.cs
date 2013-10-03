using C4.Model.Interfaces;

namespace C4.Model
{
    public class Tile : IPlottable
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public Token Token { get; set; }
    }
}
