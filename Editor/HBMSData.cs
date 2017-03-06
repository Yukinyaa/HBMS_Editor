using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;




namespace Editor
{
    public enum NoteType
    {
        ShortNote = 1,
        SlideLongNote,
        TrackNote,
        SwipeNote,
        DynamicNote
    }
    public class Note
    {
        public NoteType type;
        public double timing;
        public int hitSound;
        public double startpos, width;

        public Note Copy(Note n)//copy note
        {
            Note newObject = new Note();

            newObject.timing = n.timing;
            newObject.startpos = n.startpos;
            newObject.width = n.width;


            return newObject;
        }
    }
    public class ShortNote : Note
    {
        public ShortNote()
        {
            type = NoteType.ShortNote;
        }
    }
    public class SlideLongNote : Note
    {
        public SlideLongNote()
        {
            type = NoteType.SlideLongNote;
        }
    }

    

    public class HBMSData
    {
        public class HitSound
        {
            public int num;
            public string wav;
        }
        public string title;
        public string genre;
        public double bpm;
        public string audioDir {
            get {
                return audioDir_;
            }
            set {
                SeqPlayer = new Player(value);
                audioDir_ = value;
            }

        }
        public string audioDir_;
        public double rank;
        public string rankText;
        public List<HitSound> hitsounds;
        public List<Note> notes;
        private class NoteComparer : Comparer<Note>
        {
            public override int Compare(Note x, Note y)
            {
                double diff = x.timing - y.timing;
                return 
                    diff==0?
                    0:
                    (int)diff;
            }
        }
        public void SortNote()
        {
            notes.Sort(new NoteComparer());
        }

        public List<Note> GetNote(double segment, double length)
        {
            List<Note> noteList = new List<Note>();
            foreach (Note note in notes)
            {
                if ((segment <= note.timing) || (note.timing <= segment+length))
                {
                    noteList.Add(note);
                }
            }
            return noteList;
        }
        public Player SeqPlayer;
        public class Player
        {
            MediaPlayer.MediaPlayerClass player;
            public Player(string dir)
            {
                player = new MediaPlayer.MediaPlayerClass();
                player.FileName = dir;
                player.Stop();
            }
            public void Play(double time=0)
            {
                player.CurrentPosition = time;
                if (player.PlayState != MediaPlayer.MPPlayStateConstants.mpPlaying)
                {
                    player.Play();
                }
            }
            public void Stop()
            {
                player.Stop();
            }
            public double playTime//in seconds
            {
                get { return player.CurrentPosition; }
            }
            public bool isPlaying
            {
                get { return player.PlayState == MediaPlayer.MPPlayStateConstants.mpPlaying; }
            }

        }
    }


    class Encoder
    {
        class MidProcessHBMSData
        {
            public string title;
            public string genre;
            public double bpm;
            public string audioDir;
            public double rank;
            public string rankText;
            public List<HBMSData.HitSound> hitsounds;
            public List<string> notes;
        }

        static public String encode(HBMSData data)
        {
            MidProcessHBMSData mpdata = new MidProcessHBMSData();
            mpdata.title = data.title;
            mpdata.genre = data.genre;
            mpdata.bpm = data.bpm;
            mpdata.audioDir = data.audioDir;
            mpdata.rank = data.rank;
            mpdata.rankText = data.rankText;
            mpdata.hitsounds = data.hitsounds;
            mpdata.notes = new List<string>();
            foreach (Note note in data.notes)
            {
                switch (note.type)
                {
                    case NoteType.ShortNote:
                        mpdata.notes.Add((int)note.type + JsonConvert.SerializeObject((ShortNote)note));
                        break;
                    case NoteType.SlideLongNote:
                        mpdata.notes.Add((int)note.type + JsonConvert.SerializeObject((SlideLongNote)note));
                        break;
                    /*case NoteType.TrackNote:
                        mpdata.notes.Add((int)note.type + JsonConvert.SerializeObject((TrackNote)note));
                        break;
                    case NoteType.DynamicNote:
                        mpdata.notes.Add((int)note.type + JsonConvert.SerializeObject((DynamicNote)note));
                        break;*/
                }
            }
            return JsonConvert.SerializeObject(mpdata);
        }
        static public HBMSData decode(String datastr)
        {
            MidProcessHBMSData mpdata = JsonConvert.DeserializeObject<MidProcessHBMSData>(datastr);
            HBMSData data = new HBMSData();
            data.title = mpdata.title;
            data.genre = mpdata.genre;
            data.bpm = mpdata.bpm;
            data.audioDir = mpdata.audioDir;
            data.rank = mpdata.rank;
            data.rankText = mpdata.rankText;
            data.hitsounds = mpdata.hitsounds;
            data.notes = new List<Note>();
            foreach (string note in mpdata.notes)
            {
                switch ((NoteType)(note.ToList()[0]-'0'))
                {
                    case NoteType.ShortNote:
                        data.notes.Add((Note)JsonConvert.DeserializeObject<ShortNote>(note.Substring(1)));
                        break;
                    case NoteType.SlideLongNote:
                        data.notes.Add((Note)JsonConvert.DeserializeObject<SlideLongNote>(note.Substring(1)));
                        break;
                    /*case NoteType.TrackNote:
                        data.notes.Add((Note)JsonConvert.DeserializeObject<TrackNote>(note));
                        break;
                    case NoteType.DynamicNote:
                        data.notes.Add((Note)JsonConvert.DeserializeObject<DynamicNote>(note));
                        break;*/
                }
            }
            return data;
        }
    }

    
}
