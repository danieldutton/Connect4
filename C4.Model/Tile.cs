using C4.GridBuilder.Interfaces;
using System.Windows.Forms;

namespace C4.Model
{
    public class Tile : Panel, IPlottable
    {
        public int XPosition { get; set; }
        
        public int YPosition { get; set; }
        
        public GameToken GameToken { get; set; }

        public Tile()
        {
            GameToken = GameToken.Undefined; ;
        }

        public override string ToString()
        {
            return "[" + GetType().Name + "]" + " XPosition:[" + XPosition + "]" + " YPositon:[" + YPosition + "]";
        }

    }
}
