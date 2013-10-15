using C4.GridBuilder.Interfaces;
using System.Windows.Forms;

namespace C4.Model
{
    public class Tile : Panel, IPlottable
    {
        public int YPosition { get; set; }
        
        public int XPosition { get; set; }
        
        public GameToken GameToken { get; set; }

        public Tile()
        {
            GameToken = GameToken.Undefined; ;
        }

        public override string ToString()
        {
            return string.Format("[{0}] YPosition:{1} XPosition:{2} GameToken:{3}",
                GetType().Name, YPosition, XPosition, GameToken);
        }
    }
}
