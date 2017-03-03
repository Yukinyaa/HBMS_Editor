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
            this.patternviewer = new System.Windows.Forms.Panel();
            this.NoteTypeSelector = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GuideLineText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // patternviewer
            // 
            this.patternviewer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.patternviewer.Location = new System.Drawing.Point(33, 78);
            this.patternviewer.Name = "patternviewer";
            this.patternviewer.Size = new System.Drawing.Size(749, 563);
            this.patternviewer.TabIndex = 0;
            this.patternviewer.Paint += new System.Windows.Forms.PaintEventHandler(this.patternviewer_Paint);
            // 
            // NoteTypeSelector
            // 
            this.NoteTypeSelector.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.NoteTypeSelector.FormattingEnabled = true;
            this.NoteTypeSelector.Location = new System.Drawing.Point(800, 493);
            this.NoteTypeSelector.Name = "NoteTypeSelector";
            this.NoteTypeSelector.Size = new System.Drawing.Size(140, 148);
            this.NoteTypeSelector.TabIndex = 1;
            this.NoteTypeSelector.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.NoteTypeSelector_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(946, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 148);
            this.panel1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(141, 51);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 3;
            // 
            // GuideLineText
            // 
            this.GuideLineText.AutoSize = true;
            this.GuideLineText.Location = new System.Drawing.Point(40, 53);
            this.GuideLineText.Name = "GuideLineText";
            this.GuideLineText.Size = new System.Drawing.Size(95, 12);
            this.GuideLineText.TabIndex = 4;
            this.GuideLineText.Text = "GuideLineCount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 663);
            this.Controls.Add(this.GuideLineText);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NoteTypeSelector);
            this.Controls.Add(this.patternviewer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel patternviewer;
        private System.Windows.Forms.CheckedListBox NoteTypeSelector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label GuideLineText;
    }
}

