namespace Editor
{
    partial class MainEditor
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
            this.NoteInfoPanel = new System.Windows.Forms.Panel();
            this.width_pos_text = new System.Windows.Forms.Label();
            this.Posnum = new System.Windows.Forms.NumericUpDown();
            this.Widthnum = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hitSound_text = new System.Windows.Forms.Label();
            this.TimingNum = new System.Windows.Forms.NumericUpDown();
            this.TimingText = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GuideLineText = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.DeleteLock = new System.Windows.Forms.CheckBox();
            this.DeleteNote = new System.Windows.Forms.Button();
            this.patternviewer = new BeatmapViewer();
            this.NoteInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Posnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Widthnum)).BeginInit();
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
            // NoteInfoPanel
            // 
            this.NoteInfoPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NoteInfoPanel.Controls.Add(this.DeleteNote);
            this.NoteInfoPanel.Controls.Add(this.DeleteLock);
            this.NoteInfoPanel.Controls.Add(this.width_pos_text);
            this.NoteInfoPanel.Controls.Add(this.Posnum);
            this.NoteInfoPanel.Controls.Add(this.Widthnum);
            this.NoteInfoPanel.Controls.Add(this.comboBox1);
            this.NoteInfoPanel.Controls.Add(this.hitSound_text);
            this.NoteInfoPanel.Controls.Add(this.TimingNum);
            this.NoteInfoPanel.Controls.Add(this.TimingText);
            this.NoteInfoPanel.Location = new System.Drawing.Point(964, 87);
            this.NoteInfoPanel.Name = "NoteInfoPanel";
            this.NoteInfoPanel.Size = new System.Drawing.Size(274, 254);
            this.NoteInfoPanel.TabIndex = 2;
            // 
            // width_pos_text
            // 
            this.width_pos_text.AutoSize = true;
            this.width_pos_text.Location = new System.Drawing.Point(37, 73);
            this.width_pos_text.Name = "width_pos_text";
            this.width_pos_text.Size = new System.Drawing.Size(62, 12);
            this.width_pos_text.TabIndex = 6;
            this.width_pos_text.Text = "width/pos";
            // 
            // Posnum
            // 
            this.Posnum.DecimalPlaces = 3;
            this.Posnum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Posnum.Location = new System.Drawing.Point(183, 73);
            this.Posnum.Name = "Posnum";
            this.Posnum.Size = new System.Drawing.Size(55, 21);
            this.Posnum.TabIndex = 5;
            this.Posnum.ValueChanged += new System.EventHandler(this.Posnum_ValueChanged);
            // 
            // Widthnum
            // 
            this.Widthnum.DecimalPlaces = 3;
            this.Widthnum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Widthnum.Location = new System.Drawing.Point(117, 73);
            this.Widthnum.Name = "Widthnum";
            this.Widthnum.Size = new System.Drawing.Size(55, 21);
            this.Widthnum.TabIndex = 4;
            this.Widthnum.ValueChanged += new System.EventHandler(this.Widthnum_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // hitSound_text
            // 
            this.hitSound_text.AutoSize = true;
            this.hitSound_text.Location = new System.Drawing.Point(37, 48);
            this.hitSound_text.Name = "hitSound_text";
            this.hitSound_text.Size = new System.Drawing.Size(54, 12);
            this.hitSound_text.TabIndex = 2;
            this.hitSound_text.Text = "hitSound";
            // 
            // TimingNum
            // 
            this.TimingNum.DecimalPlaces = 3;
            this.TimingNum.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.TimingNum.Location = new System.Drawing.Point(117, 19);
            this.TimingNum.Name = "TimingNum";
            this.TimingNum.Size = new System.Drawing.Size(120, 21);
            this.TimingNum.TabIndex = 1;
            this.TimingNum.ValueChanged += new System.EventHandler(this.TimingNum_ValueChanged);
            // 
            // TimingText
            // 
            this.TimingText.AutoSize = true;
            this.TimingText.Location = new System.Drawing.Point(37, 21);
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
            5,
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
            // DeleteLock
            // 
            this.DeleteLock.AutoSize = true;
            this.DeleteLock.Location = new System.Drawing.Point(173, 223);
            this.DeleteLock.Name = "DeleteLock";
            this.DeleteLock.Size = new System.Drawing.Size(15, 14);
            this.DeleteLock.TabIndex = 7;
            this.DeleteLock.UseVisualStyleBackColor = true;
            this.DeleteLock.CheckedChanged += new System.EventHandler(this.DeleteLock_CheckedChanged);
            // 
            // DeleteNote
            // 
            this.DeleteNote.Enabled = false;
            this.DeleteNote.Location = new System.Drawing.Point(194, 223);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(75, 23);
            this.DeleteNote.TabIndex = 8;
            this.DeleteNote.Text = "Delete";
            this.DeleteNote.UseVisualStyleBackColor = true;
            this.DeleteNote.Click += new System.EventHandler(this.DeleteNote_Click);
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
            // MainEditor
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
            this.Controls.Add(this.NoteInfoPanel);
            this.Controls.Add(this.NoteTypeSelector);
            this.Name = "MainEditor";
            this.Text = "Form1";
            this.NoteInfoPanel.ResumeLayout(false);
            this.NoteInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Posnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Widthnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimingNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox NoteTypeSelector;
        private System.Windows.Forms.Panel NoteInfoPanel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label GuideLineText;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TimingNum;
        private System.Windows.Forms.Label TimingText;
        private System.Windows.Forms.Button Play;
        private BeatmapViewer patternviewer;
        private System.Windows.Forms.Label width_pos_text;
        private System.Windows.Forms.NumericUpDown Posnum;
        private System.Windows.Forms.NumericUpDown Widthnum;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label hitSound_text;
        private System.Windows.Forms.Button DeleteNote;
        private System.Windows.Forms.CheckBox DeleteLock;
    }
}

