﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        double now=0;
        double scale = 0.5;

        public MainEditor()
        {
            InitializeComponent();


            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            hbd = new HBMSData();
            hbd.notes = new List<Note>();
            hbd.notes.Add(
                new ShortNote(){ timing = 0.25, startpos = 0.25, width = 0.25 }
            );
            hbd.bpm = 121;
            hbd.audioDir = "D:/lel/Festival.mp3";
            NoteTypeSelector.Items.Add("Short");
            NoteTypeSelector.Items.Add("Slide-Long");
            NoteTypeSelector.Items.Add("Track");
            NoteTypeSelector.Items.Add("Dynamic");
            NoteTypeSelector.SetItemChecked(0, true);

            this.DoubleBuffered = true;
            //patternviewer.DoubleBuffered = true;
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
            n.timing = YToTiming(y);

            return n;
        }


        private void DrawGuideLine(Graphics g)
        {
            Pen borderlinedrawer = new Pen(Color.White, 0.5f);
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                int x = patternviewer.Width * (i + 1) / ((int)numericUpDown1.Value + 1);
                g.DrawLine(borderlinedrawer, x, 0, x, patternviewer.Height);
            }
        }

        private void DrawLongNotes(Graphics g)
        {

        }

        private void DrawNotes(Graphics g, List<Note> notes)
        {
            foreach (Note n in notes)
            {
                DrawNote(g,n);
            }
        }

        private int TimingToY(double timing)
        {
            return patternviewer.Height - (int)((timing - now) * patternviewer.Height / scale);
        }

        private double YToTiming(int y)
        {
            return (patternviewer.Height - y) * scale / patternviewer.Height + now;
        }

        private Rectangle RectFromNote(Note n, int dx = 0, int dy = 0)
        {
            return new Rectangle(
                (int)(n.startpos * patternviewer.Width)+dx,
                TimingToY(n.timing) - 40+dy,
                (int)(n.width * patternviewer.Width),
                40
            );
        }

        private void DrawNote(Graphics g, Note n, object color = null, int dx = 0, int dy = 0)
        {
            Color c;
            if (color==null) switch (n.type)
            {//set color for default
                case NoteType.ShortNote:
                    c = Color.White;
                    break;
                case NoteType.SlideLongNote:
                    c = Color.GreenYellow;
                    break;
                    default:
                    c = Color.Red;
                    break;
            }
            else c = (Color)color;

            g.DrawRectangle(new Pen(c,2),RectFromNote(n,dx,dy));
        }

        private void DrawImaginaryNote(Graphics g)
        {
            //draw dragging note
            if (dragging)
                DrawNote(g, DraggingNote, Color.Gray, draggingDelta.X, draggingDelta.Y);
            //draw selected note
            if (SelectedNote != null)
                g.DrawRectangle(new Pen(Color.Yellow, 1), RectFromNote(SelectedNote));
        }
        
        List<Note> notes;

        private void patternviewer_Paint(object sender, PaintEventArgs e)
        {
            //draw guideline

            notes = hbd.GetNote(now, scale);

            //Bitmap buffer = new Bitmap(patternviewer.Width, patternviewer.Height);//set the size of the image
            //Graphics g = Graphics.FromImage(buffer);//set the graphics to draw on the image
            Graphics g = e.Graphics;
            DrawGuideLine(g);
            DrawLongNotes(g);
            DrawNotes(g, notes);
            DrawImaginaryNote(g);
            //.DrawImage(buffer,new Point(0,0));
        }

        private void ReDraw()
        {
            patternviewer.Refresh();
            patternviewer.Focus();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ReDraw();
        }

        private void patternviewer_Scroll(object sender, ScrollEventArgs e)
        {
            switch(e.Type)
            {
                case ScrollEventType.SmallDecrement:
                case ScrollEventType.LargeDecrement:
                    now+=scale/2;
                    break;
                case ScrollEventType.SmallIncrement:
                case ScrollEventType.LargeIncrement:
                    now -=scale/2;
                    break;
            }
            ReDraw();
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
            if (e.Button == MouseButtons.Right)
            {
                dragging = false;
                newnote = false;
                DraggingNote = null;
                SelectedNote = null;
                ReDraw();
                return;
            }
            if (e.Button != MouseButtons.Left)
                return;
            clickstart = e.Location;
            foreach (Note n in notes)
            {
                if (RectFromNote(n).Contains(clickstart))
                {
                    SelectedNote = n;
                    DraggingNote = n.Copy(n);

                    ReDraw();
                    return;
                }
            }
            newnote = true;
            dragging = true;
            DraggingNote = NewNote(e.X, e.Y);
            ReDraw();

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
                ReDraw();
            }
        }

        private void patternviewer_MouseUp(object sender, MouseEventArgs e)
        {
            
            
            if (DraggingNote == null)
                return;
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
            SelectedNote.timing = YToTiming(TimingToY(SelectedNote.timing) +dy);
            DraggingNote = null;
            dragging = false;
            ReDraw();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            scale = (double)numericUpDown2.Value;
            ReDraw();
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
            ReDraw();
        }

        private void Posnum_ValueChanged(object sender, EventArgs e)
        {
            SelectedNote.startpos = (double)Posnum.Value;
            ReDraw();
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
            ReDraw();
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
                ReDraw();
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
