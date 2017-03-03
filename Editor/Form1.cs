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
        double scale=1;
        public Form1()
        {
            InitializeComponent();
            hbd = new HBMSData();
            hbd.notes = new List<Note>();
            hbd.notes.Add(
                new ShortNote(){ timing = 0.5, startpos = 0.1, endpos = 0.5 }
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
        private void DrawNotes(Graphics g)
        {
            List<Note> nownote = hbd.GetNote(now, 1);
            
            
            g.DrawRectangle(new Pen(Color.Blue))

        }
        private void DrawNote(Graphics g, Note n)
        {
            int x = (int)((n.timing - now) * patternviewer.Height / scale) - 40;
            int y = 
        }
        private void DrawImaginaryNote(Graphics g)
        {

        }


        private void patternviewer_Paint(object sender, PaintEventArgs e)
        {
            //draw guideline
            
            Graphics g = e.Graphics;
            DrawGuideLine(g);
            DrawLongNotes(g);
            DrawNotes(g);
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
    }
}
