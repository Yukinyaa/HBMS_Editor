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
            this.audioDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RankText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BPM = new System.Windows.Forms.NumericUpDown();
            this.Rank = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.BPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).BeginInit();
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
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(93, 43);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(100, 21);
            this.Genre.TabIndex = 3;
            this.Genre.TextChanged += new System.EventHandler(this.Genre_TextChanged);
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
            // audioDir
            // 
            this.audioDir.Location = new System.Drawing.Point(93, 97);
            this.audioDir.Name = "audioDir";
            this.audioDir.Size = new System.Drawing.Size(100, 21);
            this.audioDir.TabIndex = 7;
            this.audioDir.TextChanged += new System.EventHandler(this.audioDir_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "audioDir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rank";
            // 
            // RankText
            // 
            this.RankText.Location = new System.Drawing.Point(93, 151);
            this.RankText.Name = "RankText";
            this.RankText.Size = new System.Drawing.Size(100, 21);
            this.RankText.TabIndex = 11;
            this.RankText.TextChanged += new System.EventHandler(this.RankText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "RankText";
            // 
            // BPM
            // 
            this.BPM.DecimalPlaces = 2;
            this.BPM.Location = new System.Drawing.Point(93, 70);
            this.BPM.Name = "BPM";
            this.BPM.Size = new System.Drawing.Size(100, 21);
            this.BPM.TabIndex = 12;
            this.BPM.ValueChanged += new System.EventHandler(this.BPM_ValueChanged);
            // 
            // Rank
            // 
            this.Rank.DecimalPlaces = 1;
            this.Rank.Location = new System.Drawing.Point(93, 125);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(100, 21);
            this.Rank.TabIndex = 13;
            this.Rank.ValueChanged += new System.EventHandler(this.Rank_ValueChanged);
            // 
            // MusicInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 186);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.BPM);
            this.Controls.Add(this.RankText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.audioDir);
            this.Controls.Add(this.label4);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox audioDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RankText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown BPM;
        private System.Windows.Forms.NumericUpDown Rank;
    }
}