using System.Drawing;
using C4.GridBuilder.Interfaces;
using System.Windows.Forms;

namespace C4.Model
{
    public class Tile : Panel, IPlottable
    {
        public int RowNumber { get; set; }
        
        public int ColumnNumber { get; set; }
        
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

        public override string ToString()
        {
            return string.Format("[{0}] RowNumber:{1} ColumnNumber:{2} GameToken:{3}",
                GetType().Name, RowNumber, ColumnNumber, GameToken);
        }
    }
}
