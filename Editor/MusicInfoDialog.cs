using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class MusicInfoDialog : Form
    {
        HBMSData hb;
        public MusicInfoDialog(HBMSData hbms)
        {
            InitializeComponent();
            hb = hbms;

        }

        private void MusicInfoDialog_Load(object sender, EventArgs e)
        {
            Title.Text = hb.title;
            Genre.Text = hb.genre;
            BPM.Value = (decimal)hb.bpm;
            //audioDir.Text = hb.audioDir;
            Rank.Value = (decimal)hb.rank;
            RankText.Text = hb.rankText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hb.title = Title.Text;
            hb.artist = ArtistText.Text;
            //hb.preset = (double)PresetUpDown.Value;
            hb.genre = Genre.Text;
            hb.bpm = (double)BPM.Value;
            hb.rank = (double)Rank.Value;
            hb.rankText = RankText.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning!\nThis action will NOT save your file and change beatmap you are working on");
            while (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("nope");
            }
            hb.title_ = Title.Text;
            hb.artist_ = ArtistText.Text;
            Directory.CreateDirectory(hb.mapdir);
            
            File.Copy(openFileDialog1.FileName, hb.mapdir + "/"+ Path.GetFileName(openFileDialog1.FileName));
            
            
        }
    }
}
