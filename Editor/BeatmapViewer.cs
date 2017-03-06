using System.ComponentModel;
using System.Windows.Forms;

public class BeatmapViewer : Panel
{
    public BeatmapViewer() : base()
    {
        //this.key
        this.DoubleBuffered = true;
    }

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