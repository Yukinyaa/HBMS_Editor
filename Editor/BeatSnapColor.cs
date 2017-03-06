using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    class BeatSnapColor
    {
        public static Color none = Color.FromArgb(0x00FFFF00);
        public static List<Color> col = new List<Color>{
            Color.White,          none,            none,
            Color.Green,          Color.Pink,      none,
            Color.Yellow,         none,            Color.Pink,
            Color.Green,          none,            none,
            Color.Blue,           none,            none,//14
            Color.Green,          Color.Pink,      none,//17
            Color.Yellow,         none,            Color.Pink,
            Color.Green,          none,            none,
            Color.Red,            none,            none,
            Color.Green,          Color.Pink,      none,
            Color.Yellow,         none,            Color.Pink,
            Color.Green,          none,            none,
            Color.Blue,           none,            none,
            Color.Green,          Color.Pink,      none,
            Color.Yellow,         none,            Color.Pink,
            Color.Green,          none,            none
        };
    }
}
