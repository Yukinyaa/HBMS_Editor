namespace Editor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.NoteTypeSelector = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimingNum = new System.Windows.Forms.NumericUpDown();
            this.TimingText = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GuideLineText = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.patternviewer = new BeatmapViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimingNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteTypeSelector
            // 
            this.NoteTypeSelector.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.NoteTypeSelector.FormattingEnabled = true;
            this.NoteTypeSelector.Location = new System.Drawing.Point(818, 87);
            this.NoteTypeSelector.Name = "NoteTypeSelector";
            this.NoteTypeSelector.Size = new System.Drawing.Size(140, 180);
            this.NoteTypeSelector.TabIndex = 1;
            this.NoteTypeSelector.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.NoteTypeSelector_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TimingNum);
            this.panel1.Controls.Add(this.TimingText);
            this.panel1.Location = new System.Drawing.Point(964, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 254);
            this.panel1.TabIndex = 2;
            // 
            // TimingNum
            // 
            this.TimingNum.Location = new System.Drawing.Point(47, 53);
            this.TimingNum.Name = "TimingNum";
            this.TimingNum.Size = new System.Drawing.Size(120, 21);
            this.TimingNum.TabIndex = 1;
            // 
            // TimingText
            // 
            this.TimingText.AutoSize = true;
            this.TimingText.Location = new System.Drawing.Point(3, 55);
            this.TimingText.Name = "TimingText";
            this.TimingText.Size = new System.Drawing.Size(44, 12);
            this.TimingText.TabIndex = 0;
            this.TimingText.Text = "Timing";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(770, 60);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 21);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // GuideLineText
            // 
            this.GuideLineText.AutoSize = true;
            this.GuideLineText.Location = new System.Drawing.Point(669, 60);
            this.GuideLineText.Name = "GuideLineText";
            this.GuideLineText.Size = new System.Drawing.Size(95, 12);
            this.GuideLineText.TabIndex = 4;
            this.GuideLineText.Text = "GuideLineCount";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(615, 58);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Scale";
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(5, 45);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(34, 34);
            this.Play.TabIndex = 8;
            this.Play.Text = "▶";
            this.Play.UseVisualStyleBackColor = true;
            // 
            // patternviewer
            // 
            this.patternviewer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.patternviewer.DoubleBuffered = true;
            this.patternviewer.Location = new System.Drawing.Point(5, 87);
            this.patternviewer.Name = "patternviewer";
            this.patternviewer.Size = new System.Drawing.Size(800, 600);
            this.patternviewer.TabIndex = 5;
            this.patternviewer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.patternviewer_Scroll);
            this.patternviewer.Paint += new System.Windows.Forms.PaintEventHandler(this.patternviewer_Paint);
            this.patternviewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.patternviewer_MouseDown);
            this.patternviewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.patternviewer_MouseMove);
            this.patternviewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.patternviewer_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 699);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.patternviewer);
            this.Controls.Add(this.GuideLineText);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NoteTypeSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimingNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox NoteTypeSelector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label GuideLineText;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TimingNum;
        private System.Windows.Forms.Label TimingText;
        private System.Windows.Forms.Button Play;
        private BeatmapViewer patternviewer;
    }
}

