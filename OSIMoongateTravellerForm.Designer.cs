namespace OSIMoongateTravellerForm
{
    partial class OSIMoongateTravellerForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.Console_richTextBox = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Travel to";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Console_richTextBox
            // 
            this.Console_richTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Console_richTextBox.Location = new System.Drawing.Point(0, 108);
            this.Console_richTextBox.Name = "Console_richTextBox";
            this.Console_richTextBox.Size = new System.Drawing.Size(355, 261);
            this.Console_richTextBox.TabIndex = 1;
            this.Console_richTextBox.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "Where am i";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OSIMoongateTravellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 369);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Console_richTextBox);
            this.Controls.Add(this.button1);
            this.Name = "OSIMoongateTravellerForm";
            this.Text = "Moongate Traveller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Console_richTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}

