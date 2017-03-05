using System.ComponentModel;
using System.Windows.Forms;

public class BeatmapViewer : Panel
{
    
    public new bool DoubleBuffered
    {
        get
        {
            return base.DoubleBuffered;
        }
        set
        {
            base.DoubleBuffered = value;
        }
    }//*/
}