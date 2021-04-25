
namespace TextRedactor
{
    partial class RedactorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenButton = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.Replace_Button = new System.Windows.Forms.Button();
            this.Coding_Button = new System.Windows.Forms.Button();
            this.Decoding_Button = new System.Windows.Forms.Button();
            this.SaveAs_Button = new System.Windows.Forms.Button();
            this.Archive_Button = new System.Windows.Forms.Button();
            this.Setting_button = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButton.BackColor = System.Drawing.Color.White;
            this.OpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenButton.Location = new System.Drawing.Point(12, 47);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(94, 26);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Save_button
            // 
            this.Save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_button.BackColor = System.Drawing.Color.White;
            this.Save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_button.Location = new System.Drawing.Point(13, 79);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(94, 26);
            this.Save_button.TabIndex = 2;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_button.BackColor = System.Drawing.Color.White;
            this.Search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search_button.Location = new System.Drawing.Point(12, 175);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(94, 26);
            this.Search_button.TabIndex = 3;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Replace_Button
            // 
            this.Replace_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Replace_Button.BackColor = System.Drawing.Color.White;
            this.Replace_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Replace_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Replace_Button.Location = new System.Drawing.Point(12, 143);
            this.Replace_Button.Name = "Replace_Button";
            this.Replace_Button.Size = new System.Drawing.Size(94, 26);
            this.Replace_Button.TabIndex = 4;
            this.Replace_Button.Text = "Replace";
            this.Replace_Button.UseVisualStyleBackColor = false;
            this.Replace_Button.Click += new System.EventHandler(this.Replace_Button_Click);
            // 
            // Coding_Button
            // 
            this.Coding_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Coding_Button.BackColor = System.Drawing.Color.White;
            this.Coding_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Coding_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Coding_Button.Location = new System.Drawing.Point(12, 207);
            this.Coding_Button.Name = "Coding_Button";
            this.Coding_Button.Size = new System.Drawing.Size(94, 26);
            this.Coding_Button.TabIndex = 5;
            this.Coding_Button.Text = "Coding";
            this.Coding_Button.UseVisualStyleBackColor = false;
            this.Coding_Button.Click += new System.EventHandler(this.Coding_Button_Click);
            // 
            // Decoding_Button
            // 
            this.Decoding_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Decoding_Button.BackColor = System.Drawing.Color.White;
            this.Decoding_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decoding_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Decoding_Button.Location = new System.Drawing.Point(12, 239);
            this.Decoding_Button.Name = "Decoding_Button";
            this.Decoding_Button.Size = new System.Drawing.Size(94, 26);
            this.Decoding_Button.TabIndex = 6;
            this.Decoding_Button.Text = "Decoding";
            this.Decoding_Button.UseVisualStyleBackColor = false;
            this.Decoding_Button.Click += new System.EventHandler(this.Decoding_Button_Click);
            // 
            // SaveAs_Button
            // 
            this.SaveAs_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAs_Button.BackColor = System.Drawing.Color.White;
            this.SaveAs_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAs_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveAs_Button.Location = new System.Drawing.Point(13, 111);
            this.SaveAs_Button.Name = "SaveAs_Button";
            this.SaveAs_Button.Size = new System.Drawing.Size(94, 26);
            this.SaveAs_Button.TabIndex = 7;
            this.SaveAs_Button.Text = "Save as";
            this.SaveAs_Button.UseVisualStyleBackColor = false;
            this.SaveAs_Button.Click += new System.EventHandler(this.SaveAs_Button_Click);
            // 
            // Archive_Button
            // 
            this.Archive_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Archive_Button.BackColor = System.Drawing.Color.White;
            this.Archive_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Archive_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Archive_Button.Location = new System.Drawing.Point(12, 271);
            this.Archive_Button.Name = "Archive_Button";
            this.Archive_Button.Size = new System.Drawing.Size(94, 26);
            this.Archive_Button.TabIndex = 8;
            this.Archive_Button.Text = "Archive";
            this.Archive_Button.UseVisualStyleBackColor = false;
            this.Archive_Button.Click += new System.EventHandler(this.Archive_Button_Click);
            // 
            // Setting_button
            // 
            this.Setting_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Setting_button.BackColor = System.Drawing.Color.White;
            this.Setting_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Setting_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Setting_button.Location = new System.Drawing.Point(12, 303);
            this.Setting_button.Name = "Setting_button";
            this.Setting_button.Size = new System.Drawing.Size(94, 26);
            this.Setting_button.TabIndex = 10;
            this.Setting_button.Text = "Setting";
            this.Setting_button.UseVisualStyleBackColor = false;
            this.Setting_button.Click += new System.EventHandler(this.Setting_button_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.Location = new System.Drawing.Point(114, 46);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(487, 392);
            this.richTextBox.TabIndex = 9;
            this.richTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 41);
            this.panel1.TabIndex = 11;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(577, -4);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(36, 41);
            this.label_close.TabIndex = 1;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "TextRedactorX";
            // 
            // folderBrowserDialog1
            // 
            // 
            // RedactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Setting_button);
            this.Controls.Add(this.Archive_Button);
            this.Controls.Add(this.SaveAs_Button);
            this.Controls.Add(this.Decoding_Button);
            this.Controls.Add(this.Coding_Button);
            this.Controls.Add(this.Replace_Button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.richTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "RedactorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Redactor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Replace_Button;
        private System.Windows.Forms.Button Coding_Button;
        private System.Windows.Forms.Button Decoding_Button;
        private System.Windows.Forms.Button SaveAs_Button;
        private System.Windows.Forms.Button Archive_Button;
        private System.Windows.Forms.Button Setting_button;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

