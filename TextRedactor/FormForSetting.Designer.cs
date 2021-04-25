
namespace TextRedactor
{
    partial class FormForSetting
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
            this.textBox_example = new System.Windows.Forms.TextBox();
            this.comboBox_Style = new System.Windows.Forms.ComboBox();
            this.button_GrowSize = new System.Windows.Forms.Button();
            this.button_LowerSize = new System.Windows.Forms.Button();
            this.checkBox_italic = new System.Windows.Forms.CheckBox();
            this.checkBox_Bold = new System.Windows.Forms.CheckBox();
            this.checkBox_UnderLine = new System.Windows.Forms.CheckBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_example
            // 
            this.textBox_example.Location = new System.Drawing.Point(51, 142);
            this.textBox_example.Multiline = true;
            this.textBox_example.Name = "textBox_example";
            this.textBox_example.Size = new System.Drawing.Size(146, 34);
            this.textBox_example.TabIndex = 0;
            this.textBox_example.Text = "Example Text";
            this.textBox_example.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_Style
            // 
            this.comboBox_Style.FormattingEnabled = true;
            this.comboBox_Style.Location = new System.Drawing.Point(125, 53);
            this.comboBox_Style.Name = "comboBox_Style";
            this.comboBox_Style.Size = new System.Drawing.Size(115, 28);
            this.comboBox_Style.TabIndex = 1;
            this.comboBox_Style.SelectedIndexChanged += new System.EventHandler(this.comboBox_Style_SelectedIndexChanged);
            // 
            // button_GrowSize
            // 
            this.button_GrowSize.Location = new System.Drawing.Point(203, 142);
            this.button_GrowSize.Name = "button_GrowSize";
            this.button_GrowSize.Size = new System.Drawing.Size(35, 34);
            this.button_GrowSize.TabIndex = 2;
            this.button_GrowSize.Text = "+";
            this.button_GrowSize.UseVisualStyleBackColor = true;
            this.button_GrowSize.Click += new System.EventHandler(this.button_GrowSize_Click);
            // 
            // button_LowerSize
            // 
            this.button_LowerSize.Location = new System.Drawing.Point(10, 142);
            this.button_LowerSize.Name = "button_LowerSize";
            this.button_LowerSize.Size = new System.Drawing.Size(35, 34);
            this.button_LowerSize.TabIndex = 3;
            this.button_LowerSize.Text = "-";
            this.button_LowerSize.UseVisualStyleBackColor = true;
            this.button_LowerSize.Click += new System.EventHandler(this.button_LowerSize_Click);
            // 
            // checkBox_italic
            // 
            this.checkBox_italic.AutoSize = true;
            this.checkBox_italic.ForeColor = System.Drawing.Color.Black;
            this.checkBox_italic.Location = new System.Drawing.Point(10, 82);
            this.checkBox_italic.Name = "checkBox_italic";
            this.checkBox_italic.Size = new System.Drawing.Size(63, 24);
            this.checkBox_italic.TabIndex = 8;
            this.checkBox_italic.Text = "Italic";
            this.checkBox_italic.UseVisualStyleBackColor = true;
            this.checkBox_italic.CheckedChanged += new System.EventHandler(this.checkBox_italic_CheckedChanged);
            // 
            // checkBox_Bold
            // 
            this.checkBox_Bold.AutoSize = true;
            this.checkBox_Bold.ForeColor = System.Drawing.Color.Black;
            this.checkBox_Bold.Location = new System.Drawing.Point(10, 53);
            this.checkBox_Bold.Name = "checkBox_Bold";
            this.checkBox_Bold.Size = new System.Drawing.Size(62, 24);
            this.checkBox_Bold.TabIndex = 9;
            this.checkBox_Bold.Text = "Bold";
            this.checkBox_Bold.UseVisualStyleBackColor = true;
            this.checkBox_Bold.CheckedChanged += new System.EventHandler(this.checkBox_Bold_CheckedChanged);
            // 
            // checkBox_UnderLine
            // 
            this.checkBox_UnderLine.AutoSize = true;
            this.checkBox_UnderLine.ForeColor = System.Drawing.Color.Black;
            this.checkBox_UnderLine.Location = new System.Drawing.Point(10, 112);
            this.checkBox_UnderLine.Name = "checkBox_UnderLine";
            this.checkBox_UnderLine.Size = new System.Drawing.Size(98, 24);
            this.checkBox_UnderLine.TabIndex = 10;
            this.checkBox_UnderLine.Text = "UnderLine";
            this.checkBox_UnderLine.UseVisualStyleBackColor = true;
            this.checkBox_UnderLine.CheckedChanged += new System.EventHandler(this.checkBox_UnderLine_CheckedChanged);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(12, 184);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(94, 29);
            this.button_Apply.TabIndex = 11;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_clear
            // 
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.Location = new System.Drawing.Point(144, 184);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(94, 29);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "Cancel";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 45);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(223, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TextRedactorX";
            // 
            // FormForSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(253, 223);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.checkBox_UnderLine);
            this.Controls.Add(this.checkBox_Bold);
            this.Controls.Add(this.checkBox_italic);
            this.Controls.Add(this.button_LowerSize);
            this.Controls.Add(this.button_GrowSize);
            this.Controls.Add(this.comboBox_Style);
            this.Controls.Add(this.textBox_example);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regular";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_example;
        private System.Windows.Forms.ComboBox comboBox_Style;
        private System.Windows.Forms.Button button_GrowSize;
        private System.Windows.Forms.Button button_LowerSize;
        private System.Windows.Forms.CheckBox checkBox_italic;
        private System.Windows.Forms.CheckBox checkBox_Bold;
        private System.Windows.Forms.CheckBox checkBox_UnderLine;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}