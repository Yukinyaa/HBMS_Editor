using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    enum NoteType
    {
        ShortNote =1,
        SlideLongNote,
        TrackNote,
        DynamicNote
    }
    public interface Note
    {  }
    class HBMSData
    {
        public class HitSound
        {
            public int num;
            public string wav;
        }
        public string title;
        public string genre;
        public double bpm;
        public double audioDir;
        public int rank;
        public string rankText;
        public List<HitSound> hitsounds;
        public List<Note> notes;
    }
    class MidProcessHBMSData
    {
        public class HitSound
        {
            public int num;
            public string wav;
        }
        public string title;
        public string genre;
        public double bpm;
        public double audioDir;
        public int rank;
        public string rankText;
        public List<HitSound> hitsounds;
        public List<string> notes;
    }
}
