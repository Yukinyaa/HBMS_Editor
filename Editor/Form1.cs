using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        HBMSData hbd;

        double now=0;
        double scale = 1;
        public Form1()
        {
            InitializeComponent();
            hbd = new HBMSData();
            hbd.notes = new List<Note>();
            hbd.notes.Add(
                new ShortNote(){ timing = 0, startpos = 0.25, width = 0.25 }
            );

            NoteTypeSelector.Items.Add("Short");
            NoteTypeSelector.Items.Add("Slide-Long");
            NoteTypeSelector.Items.Add("Track");
            NoteTypeSelector.Items.Add("Dynamic");
        }
        
        private void NoteTypeSelector_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < NoteTypeSelector.Items.Count; ++ix)
                if (ix != e.Index) NoteTypeSelector.SetItemChecked(ix, false);
        }

        


        private int GetNoteSelectedType()
        {
            return NoteTypeSelector.CheckedIndices[0];
        }

        private void DrawGuideLine(Graphics g)
        {
            Pen borderlinedrawer = new Pen(Color.White, 1);
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

        private Rectangle RectFromNote(Note n)
        {

            return new Rectangle(
                (int)(n.startpos * patternviewer.Width),
                TimingToY(n.timing) - 40,
                (int)(n.width * patternviewer.Width),
                40
            );
        }

        private void DrawNote(Graphics g, Note n)
        {
            Color c;
            switch (n.type)
            {
                case NoteType.ShortNote:
                    c = Color.White;
                    break;
                case NoteType.SlideLongNote:
                    return;
                default:
                    c = Color.Red;
                    break;
            }
            
            g.DrawRectangle(new Pen(c,2),RectFromNote(n));
        }
        private void DrawImaginaryNote(Graphics g)
        {
            //draw dragging note
            if (DraggingNote != null)
                g.DrawRectangle(new Pen(Color.Gray, 1), RectFromNote(DraggingNote));
            //draw selected note
            if (SelectedNote != null)
                g.DrawRectangle(new Pen(Color.Yellow, 1), RectFromNote(SelectedNote));
        }

        List<Note> notes;
        private void patternviewer_Paint(object sender, PaintEventArgs e)
        {
            //draw guideline

            notes = hbd.GetNote(now, scale);
            Graphics g = e.Graphics;
            DrawGuideLine(g);
            DrawLongNotes(g);
            DrawNotes(g, notes);
            DrawImaginaryNote(g);

            g.Dispose();
        }

        private void ReRender()
        {
            patternviewer.Refresh();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ReRender();
        }

        private void patternviewer_Scroll(object sender, ScrollEventArgs e)
        {
            switch(e.Type)
            {
                case ScrollEventType.SmallDecrement:
                    now++;
                    break;
                case ScrollEventType.SmallIncrement:
                    now--;
                    break;
            }
        }

        Note DraggingNote;
        Note SelectedNote;
        Point clickstart;
        private void patternviewer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            clickstart = e.Location;
            foreach (Note n in notes)
            {
                if (RectFromNote(n).Contains(clickstart))
                {
                    SelectedNote = n;
                    DraggingNote = n;
                    ReRender();
                }
            }
        }

        private void patternviewer_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void patternviewer_MouseUp(object sender, MouseEventArgs e)
        {
            if (DraggingNote == null)
                return;
            //if dragging is just fraction of inch
            int diff = Math.Abs((int)(clickstart.X - e.Location.X)) + Math.Abs((int)(clickstart.Y - e.Location.Y));
            //if ()

        }

        private void patternviewer_DragLeave(object sender, EventArgs e)
        {

        }

        
    }
}
