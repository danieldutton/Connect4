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
            GameToken = GameToken.Undefined; ;
        }

        public override string ToString()
        {
            return string.Format("[{0}] RowNumber:{1} ColumnNumber:{2} GameToken:{3}",
                GetType().Name, RowNumber, ColumnNumber, GameToken);
        }
    }
}
