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
            audioDir.Text = hb.audioDir;
            Rank.Value = (decimal)hb.rank;
            RankText.Text = hb.rankText;
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {
            hb.title = Title.Text;
        }

        private void Genre_TextChanged(object sender, EventArgs e)
        {
            hb.genre = Genre.Text;
        }

        private void BPM_ValueChanged(object sender, EventArgs e)
        {
            hb.bpm = (double)BPM.Value;
        }

        private void audioDir_TextChanged(object sender, EventArgs e)
        {
            hb.audioDir = audioDir.Text;
        }

        private void Rank_ValueChanged(object sender, EventArgs e)
        {
            hb.rank = (double)Rank.Value;
        }

        private void RankText_TextChanged(object sender, EventArgs e)
        {
            hb.rankText = RankText.Text;
        }
    }
}
