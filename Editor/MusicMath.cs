using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    public struct PlayingData
    {
        public int height, width;//player Height/Width
        public double now, scale;
        public int bsnapcnt, hsnapcnt;
    }
    static public class MusicMath
    {
        static public int TimingToY(double timing, PlayingData pd)
        {
            return pd.height - (int)((timing - pd.now) * pd.height / pd.scale);
        }

        static public double YToTiming(int y, PlayingData pd)
        {
            return (pd.height - y) * pd.scale / pd.height + pd.now;
        }

        static public Rectangle RectFromNote(Note n, PlayingData pd, int dx = 0, int dy = 0)
        {
            return new Rectangle(
                (int)(n.startpos * pd.width) + dx,
                TimingToY(n.timing, pd) - 40 + dy,
                (int)(n.width * pd.width),
                40
            );
        }

    }
}
