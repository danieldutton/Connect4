using C4.GridBuilder.Interfaces;
using System.Drawing;
using System.Windows.Forms;

namespace C4.GridBuilder.Model
{
    public class Tile : Panel, IPlottable
    {
        public int XPosition { get; set; }
        
        public int YPosition { get; set; }
        
        public GameToken GameToken { get; set; }

        public Tile()
        {
            InitTile();            
        }

        private void InitTile()
        {
            GameToken = GameToken.Undefined;
            BackColor = Color.Gray;
            BorderStyle = BorderStyle.FixedSingle;
            Width  = 32;
            Height = 32;
        }

        public bool IsEmpty()
        {
            return GameToken == GameToken.Undefined;
        }

        public override string ToString()
        {
            return string.Format("[{0}] XPosition:{1} YPosition:{2} GameToken:{3}",
                GetType().Name, XPosition, YPosition, GameToken);
        }
    }
}
