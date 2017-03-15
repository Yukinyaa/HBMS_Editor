namespace Editor
{
    partial class MusicInfoDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RankText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BPM = new System.Windows.Forms.NumericUpDown();
            this.Rank = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CreatorText = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ArtistText = new System.Windows.Forms.Label();
            this.PresetUpDown = new System.Windows.Forms.NumericUpDown();
            this.PresetText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresetUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(93, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 21);
            this.Title.TabIndex = 1;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(93, 43);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(100, 21);
            this.Genre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "BPM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rank";
            // 
            // RankText
            // 
            this.RankText.Location = new System.Drawing.Point(93, 124);
            this.RankText.Name = "RankText";
            this.RankText.Size = new System.Drawing.Size(100, 21);
            this.RankText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "RankText";
            // 
            // BPM
            // 
            this.BPM.DecimalPlaces = 2;
            this.BPM.Location = new System.Drawing.Point(93, 70);
            this.BPM.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.BPM.Name = "BPM";
            this.BPM.Size = new System.Drawing.Size(100, 21);
            this.BPM.TabIndex = 12;
            // 
            // Rank
            // 
            this.Rank.DecimalPlaces = 1;
            this.Rank.Location = new System.Drawing.Point(93, 97);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(100, 21);
            this.Rank.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "&OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Change Main Music";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(288, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 20;
            // 
            // CreatorText
            // 
            this.CreatorText.AutoSize = true;
            this.CreatorText.Location = new System.Drawing.Point(253, 46);
            this.CreatorText.Name = "CreatorText";
            this.CreatorText.Size = new System.Drawing.Size(29, 12);
            this.CreatorText.TabIndex = 19;
            this.CreatorText.Text = "TBD";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 18;
            // 
            // ArtistText
            // 
            this.ArtistText.AutoSize = true;
            this.ArtistText.Location = new System.Drawing.Point(253, 19);
            this.ArtistText.Name = "ArtistText";
            this.ArtistText.Size = new System.Drawing.Size(33, 12);
            this.ArtistText.TabIndex = 17;
            this.ArtistText.Text = "Artist";
            // 
            // PresetUpDown
            // 
            this.PresetUpDown.DecimalPlaces = 2;
            this.PresetUpDown.Location = new System.Drawing.Point(288, 70);
            this.PresetUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PresetUpDown.Name = "PresetUpDown";
            this.PresetUpDown.Size = new System.Drawing.Size(100, 21);
            this.PresetUpDown.TabIndex = 22;
            // 
            // PresetText
            // 
            this.PresetText.AutoSize = true;
            this.PresetText.Location = new System.Drawing.Point(241, 73);
            this.PresetText.Name = "PresetText";
            this.PresetText.Size = new System.Drawing.Size(41, 12);
            this.PresetText.TabIndex = 21;
            this.PresetText.Text = "Preset";
            // 
            // MusicInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 248);
            this.Controls.Add(this.PresetUpDown);
            this.Controls.Add(this.PresetText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CreatorText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ArtistText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.BPM);
            this.Controls.Add(this.RankText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label1);
            this.Name = "MusicInfoDialog";
            this.Text = "MusicInfoDialog";
            this.Load += new System.EventHandler(this.MusicInfoDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresetUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RankText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown BPM;
        private System.Windows.Forms.NumericUpDown Rank;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CreatorText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ArtistText;
        private System.Windows.Forms.NumericUpDown PresetUpDown;
        private System.Windows.Forms.Label PresetText;
    }
}