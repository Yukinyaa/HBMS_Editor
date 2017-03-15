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
        public Form1()
        {
            InitializeComponent();
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

        


        private NoteType GetNoteSelectedType()
        {
            return (NoteType)NoteTypeSelector.CheckedIndices[0];
        }

        private void patternviewer_Paint(object sender, PaintEventArgs e)
        {
            Pen borderlinedrawer = new Pen(Color.White,1);
            Graphics g = e.Graphics;
            g.DrawLine(borderlinedrawer, 0, 0, 200, 200);
            g.Dispose();
        }
    }
}
