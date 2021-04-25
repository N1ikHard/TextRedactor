
namespace TextRedactor
{
    partial class FormForCoding
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
            this.TextBoxForKey = new System.Windows.Forms.TextBox();
            this.Button_Coding = new System.Windows.Forms.Button();
            this.Code_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxForKey
            // 
            this.TextBoxForKey.Location = new System.Drawing.Point(41, 92);
            this.TextBoxForKey.Name = "TextBoxForKey";
            this.TextBoxForKey.ShortcutsEnabled = false;
            this.TextBoxForKey.Size = new System.Drawing.Size(125, 27);
            this.TextBoxForKey.TabIndex = 0;
            this.TextBoxForKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxForKey_KeyPress);
            // 
            // Button_Coding
            // 
            this.Button_Coding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Coding.Location = new System.Drawing.Point(57, 125);
            this.Button_Coding.Name = "Button_Coding";
            this.Button_Coding.Size = new System.Drawing.Size(94, 29);
            this.Button_Coding.TabIndex = 1;
            this.Button_Coding.Text = "Coding";
            this.Button_Coding.UseVisualStyleBackColor = true;
            this.Button_Coding.Click += new System.EventHandler(this.Button_Coding_Click);
            // 
            // Code_label
            // 
            this.Code_label.AutoSize = true;
            this.Code_label.Location = new System.Drawing.Point(69, 60);
            this.Code_label.Name = "Code_label";
            this.Code_label.Size = new System.Drawing.Size(68, 20);
            this.Code_label.TabIndex = 2;
            this.Code_label.Text = "Press key";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 36);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 8);
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
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TextRedactorX";
            // 
            // FormForCoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(200, 181);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Code_label);
            this.Controls.Add(this.Button_Coding);
            this.Controls.Add(this.TextBoxForKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormForCoding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForCoding";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxForKey;
        private System.Windows.Forms.Button Button_Coding;
        private System.Windows.Forms.Label Code_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}