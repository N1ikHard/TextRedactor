
namespace TextRedactor
{
    partial class FormForReplace
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
            this.ThisTextBox = new System.Windows.Forms.TextBox();
            this.ThatTextBox = new System.Windows.Forms.TextBox();
            this.Button_Replace = new System.Windows.Forms.Button();
            this.label_this = new System.Windows.Forms.Label();
            this.that_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThisTextBox
            // 
            this.ThisTextBox.Location = new System.Drawing.Point(13, 77);
            this.ThisTextBox.Multiline = true;
            this.ThisTextBox.Name = "ThisTextBox";
            this.ThisTextBox.Size = new System.Drawing.Size(125, 34);
            this.ThisTextBox.TabIndex = 0;
            // 
            // ThatTextBox
            // 
            this.ThatTextBox.Location = new System.Drawing.Point(163, 77);
            this.ThatTextBox.Multiline = true;
            this.ThatTextBox.Name = "ThatTextBox";
            this.ThatTextBox.Size = new System.Drawing.Size(125, 34);
            this.ThatTextBox.TabIndex = 1;
            // 
            // Button_Replace
            // 
            this.Button_Replace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Replace.Location = new System.Drawing.Point(103, 129);
            this.Button_Replace.Name = "Button_Replace";
            this.Button_Replace.Size = new System.Drawing.Size(94, 29);
            this.Button_Replace.TabIndex = 2;
            this.Button_Replace.Text = "Replace!";
            this.Button_Replace.UseVisualStyleBackColor = true;
            this.Button_Replace.Click += new System.EventHandler(this.Button_Replace_Click);
            // 
            // label_this
            // 
            this.label_this.AutoSize = true;
            this.label_this.Location = new System.Drawing.Point(49, 49);
            this.label_this.Name = "label_this";
            this.label_this.Size = new System.Drawing.Size(35, 20);
            this.label_this.TabIndex = 3;
            this.label_this.Text = "This";
            // 
            // that_label
            // 
            this.that_label.AutoSize = true;
            this.that_label.Location = new System.Drawing.Point(210, 49);
            this.that_label.Name = "that_label";
            this.that_label.Size = new System.Drawing.Size(38, 20);
            this.that_label.TabIndex = 4;
            this.that_label.Text = "That";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 37);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TextRedactorX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormForReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(299, 164);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.that_label);
            this.Controls.Add(this.label_this);
            this.Controls.Add(this.Button_Replace);
            this.Controls.Add(this.ThatTextBox);
            this.Controls.Add(this.ThisTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormForReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFromReplace";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ThisTextBox;
        private System.Windows.Forms.TextBox ThatTextBox;
        private System.Windows.Forms.Button Button_Replace;
        private System.Windows.Forms.Label label_this;
        private System.Windows.Forms.Label that_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}