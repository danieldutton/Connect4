using C4.Model.Interfaces;
using System.Windows.Forms;

namespace C4.Model
{
    public class Tile : PictureBox, IPlottable
    {
        public int XPosition { get; set; }
        
        public int YPosition { get; set; }
        
        public GameToken GameToken { get; set; }

        public Tile()
        {
            
        }
    }
}
