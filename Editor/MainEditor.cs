using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class MainEditor : Form
    {
        HBMSData hbd;
        PlayingData pd = new PlayingData();
        public double now {
            get {
                return pd.now;
            }
            set {
                pd.now = value;
            }

        }


        //double scale = 5;
        static MainEditor instance;
        public bool loaded = false;
        
        public MainEditor()
        {
            InitializeComponent();


            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            hbd = new HBMSData("","");
            hbd.notes = new List<Note>();
            hbd.notes.Add(
                new ShortNote(){ timing = 0.25, startpos = 0.25, width = 0.25 }
            );
            //hbd.bpm = 121;
            //hbd.audioDir = "D:/lel/Festival.mp3";
            NoteTypeSelector.Items.Add("Short");
            NoteTypeSelector.Items.Add("Slide-Long");
            NoteTypeSelector.Items.Add("Track");
            NoteTypeSelector.Items.Add("Dynamic");
            NoteTypeSelector.SetItemChecked(0, true);

            //Application.Idle += HandleApplicationIdle;
            this.DoubleBuffered = true;
            now = -8;
            instance = this;
            //patternviewer.DoubleBuffered = true;
            pd.height = patternviewer.Height;
            pd.width = patternviewer.Width;
            pd.scale = 5;
            pd.bsnapcnt = 4;
            pd.hsnapcnt = 3;

            try
            {
                Directory.GetDirectories("./Songs");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Creating Songs Directory..!");
                Directory.CreateDirectory("./Songs");
            }
        }
        
        private void NoteTypeSelector_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < NoteTypeSelector.Items.Count; ++ix)
                if (ix != e.Index) NoteTypeSelector.SetItemChecked(ix, false);
        }

        //drawing functions
        private int GetNoteSelectedType()
        {
            return NoteTypeSelector.CheckedIndices[0];
        }

        private Note NewNote(int x, int y)
        {
            Note n;
            switch ((NoteType)(GetNoteSelectedType()+1))
            {
                case NoteType.ShortNote:
                    n = new ShortNote();
                    break;
                case NoteType.SlideLongNote:
                    n = new SlideLongNote();
                    break;
                default:
                    n = new Note();
                    break;
            }
            n.startpos = (double)x / patternviewer.Width - 0.1;
            n.width = 0.2;
            n.timing = MusicMath.YToTiming(y,pd);

            return n;
        }


        

        
        List<Note> notes;

        private void patternviewer_Paint(object sender, PaintEventArgs e)
        {
            loaded = true;
           
            //draw guideline

            notes = hbd.GetNote(now, pd.scale);
            
            Graphics g = e.Graphics;
            patternviewer.DrawGuideLine(g, pd);
            patternviewer.DrawLongNotes(g, pd, notes);
            patternviewer.DrawNotes(g, pd, notes);
            patternviewer.DrawImaginaryNote(g, pd, DraggingNote, SelectedNote, dragging, draggingDelta);
        }

        public void ReDraw()
        {
            
            patternviewer.Refresh();
        }
        public void MyUpdate()
        {
            if (instance.hbd.SeqPlayer.isPlaying)
            {
                now = BeatToTime(instance.hbd.SeqPlayer.playTime);
                UpdateBeatValue();
            }
            //todo: play hitsound
            
        }
        private void UpdateHitSound()
        {
            HitsoundCombo.Items.Clear();
            HitsoundCombo.Items.Add(HBMSData.hitsoundnone);
            foreach (String hitsound in hbd.hitsounds)
            {
                HitsoundCombo.Items.Add(hitsound);
            }     
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pd.hsnapcnt = (int)numericUpDown1.Value;
        }

        private void patternviewer_Scroll(object sender, ScrollEventArgs e)
        {
            switch(e.Type)
            {
                case ScrollEventType.SmallDecrement:
                case ScrollEventType.LargeDecrement:
                    now += pd.scale / 2;
                    break;
                case ScrollEventType.SmallIncrement:
                case ScrollEventType.LargeIncrement:
                    now -= pd.scale / 2;
                    break;
            }
        }
        
        //viewer : mouse hadling part

        Note DraggingNote;
        private Note SelectedNote_;
        private Note SelectedNote {
            get {
                return SelectedNote_;
            }
            set {
                SelectedNote_ = value;
                UpdateSelectedNoteToPanel();
            }
        }
        bool dragging = false;
        bool newnote = false;
        Point draggingDelta;
        Point clickstart;
        private void patternviewer_MouseDown(object sender, MouseEventArgs e)
        {
            patternviewer.Focus();
            if (e.Button == MouseButtons.Right)
            {
                dragging = false;
                newnote = false;
                DraggingNote = null;
                SelectedNote = null;
                return;
            }
            if (e.Button != MouseButtons.Left)
                return;
            clickstart = e.Location;
            foreach (Note n in notes)
            {
                if (MusicMath.RectFromNote(n,pd).Contains(clickstart))
                {
                    SelectedNote = n;
                    DraggingNote = n.Copy(n);
                    
                    return;
                }
            }
            newnote = true;
            dragging = true;
            DraggingNote = NewNote(e.X, e.Y);

        }

        private void patternviewer_MouseMove(object sender, MouseEventArgs e)
        {
            int dx = (e.Location.X - clickstart.X), dy = (e.Location.Y - clickstart.Y);
            if (!dragging && DraggingNote!=null)
            {
                int diff = Math.Abs(dx) + Math.Abs(dy);
                if (diff > 20)
                    dragging = true;
            }
            if (dragging)
            {
                draggingDelta = new Point(dx, dy);
            }
        }

        private void patternviewer_MouseUp(object sender, MouseEventArgs e)
        {
            
            
            if (DraggingNote == null)
                return;
            if (MusicMath.YToTiming(e.Location.Y,pd) < 0)
            {
                dragging = false;
                newnote = false;
                DraggingNote = null;
                SelectedNote = null;
                MessageBox.Show("Note cannot be outside of the map. \n (timing cannot be smaller then 0)");
                return;
            }
            int dx = (e.Location.X - clickstart.X), dy = (e.Location.Y - clickstart.Y);
            int diff = Math.Abs(dx) + Math.Abs(dy);
            if (newnote)
            {
                SelectedNote = DraggingNote;
                hbd.notes.Add(DraggingNote);
                newnote = false;
            }
            if (!dragging)//if dragging is just fraction of inch
            {
                DraggingNote = null;
                dragging = false;
                return;//do nothing
            }

            
            SelectedNote.startpos += (double)(dx) / patternviewer.Width;
            SelectedNote.timing = MusicMath.YToTiming(MusicMath.TimingToY(SelectedNote.timing,pd) +dy,pd);
            DraggingNote = null;
            dragging = false;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            pd.scale = (double)numericUpDown2.Value;
        }

        void UpdateSelectedNoteToPanel()
        {
            if (SelectedNote == null)
            {
                NoteInfoPanel.Enabled = false;
                return;
            }

            NoteInfoPanel.Enabled = true;
            TimingNum.Value = (decimal)SelectedNote.timing;
            Widthnum.Value = (decimal)SelectedNote.width;
            Posnum.Value = (decimal)SelectedNote.startpos;
            NoteInfoPanel.Refresh();
        }

        private void TimingNum_ValueChanged(object sender, EventArgs e)
        {
            SelectedNote.timing = (double)TimingNum.Value;
            ReDraw();
        }

        private void Widthnum_ValueChanged(object sender, EventArgs e)
        {
            SelectedNote.width = (double)Widthnum.Value;
        }

        private void Posnum_ValueChanged(object sender, EventArgs e)
        {
            SelectedNote.startpos = (double)Posnum.Value;
        }

        Thread LockTimer;
        private void DeleteLocker_Click(object sender, EventArgs e)
        {
            DeleteNote.Enabled = true;
            try { LockTimer.Abort(); }catch(Exception){ }

            LockTimer = new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                for (int time = 5; time >= 0; time--)
                {
                    DeleteLocker.Text = "" + time;
                    Thread.Sleep(1000);
                }
                DeleteLocker.Text = "🔒";
                DeleteNote.Enabled = false;
                NoteInfoPanel.Refresh();
            });
            LockTimer.Start();
            
        }
        private void DeleteNote_Click(object sender, EventArgs e)
        {
            hbd.notes.Remove(SelectedNote);
            dragging = false;
            newnote = false;
            DraggingNote = null;
            SelectedNote = null;    
        }

        private void patternviewer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && DeleteNote.Enabled == true)
            {
                hbd.notes.Remove(SelectedNote);
                dragging = false;
                newnote = false;
                DraggingNote = null;
                SelectedNote = null;
            }
            
        }

        private void MainEditor_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void SongInfo_Click(object sender, EventArgs e)
        {
            MusicInfoDialog mid = new MusicInfoDialog(hbd);
            mid.Show();
        }


        List<int> BSnapAmount = new List<int>()
        {
            1,2,3,4,6,8,12,16
        };
        //int bsnapcnt=4;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pd.bsnapcnt = BSnapAmount[BSnapTrackBar.Value];

            BSnapIndecator.Text = "1/" + pd.bsnapcnt;

        }

        bool lockupdate = false;
        private void LargeBeat_ValueChanged(object sender, EventArgs e)
        {
            if (lockupdate) return;

            now = (double)LargeBeat.Value * 4 + (double)SmallBeat.Value;
        }

        private void SmallBeat_ValueChanged(object sender, EventArgs e)
        {
            if (lockupdate) return;

            lockupdate = true;
            if (SmallBeat.Value >= 4)
            {
                SmallBeat.Value -= 4;
                LargeBeat.Value += 1;
            }
            else if (SmallBeat.Value < 0)
            {
                SmallBeat.Value += 4;
                LargeBeat.Value -= 1;
            }
            lockupdate = false;
            now = (double)LargeBeat.Value * 4 + (double)SmallBeat.Value;
        }

        private void UpdateBeatValue()
        {
            lockupdate = true;
            LargeBeat.Value = (int)(now / 4);
            SmallBeat.Value = (decimal)(now % 4);
            lockupdate = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "HBMS files (*.hbms)|*.hbms|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    String str = Encoder.encode(hbd);
                    Byte[] bt = Encoding.UTF8.GetBytes(str);
                    myStream.Write(bt, 0, bt.Length);
                    myStream.Close();
                }
            }
        }
        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "HBMS files (*.hbms)|*.hbms|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Select a HBMS File";
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                byte[] bytearr = ReadFully(openFileDialog1.OpenFile());
                string str = Encoding.Default.GetString(bytearr);

                hbd = Encoder.decode(str);
            }
        }


        double TimeToBeat(double time)
        {
            return time * 60 / hbd.bpm;
        }
        double BeatToTime(double beat)
        {
            return beat / 60 * hbd.bpm;
        }

        
        private void Play_Click(object sender, EventArgs e)
        {
            if (hbd.SeqPlayer.isPlaying)
            {
                hbd.SeqPlayer.Stop();
            }
            else
            {
                instance.hbd.SeqPlayer.Play();
            }
            
        }

        private void patternviewer_AutoSizeChanged(object sender, EventArgs e)
        {
            pd.height = patternviewer.Height;
            pd.width = patternviewer.Width;
        }
        //void HandleApplicationIdle(object sender, EventArgs e)
        //{
        //   ReDraw();
        //}
    }
}
