namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputDictionaryTextBox = new System.Windows.Forms.RichTextBox();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputResultTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.outputDictionaryTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 93);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // outputDictionaryTextBox
            // 
            this.outputDictionaryTextBox.Location = new System.Drawing.Point(3, 3);
            this.outputDictionaryTextBox.Name = "outputDictionaryTextBox";
            this.outputDictionaryTextBox.Size = new System.Drawing.Size(317, 94);
            this.outputDictionaryTextBox.TabIndex = 0;
            this.outputDictionaryTextBox.Text = "";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 126);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(239, 30);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(257, 126);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 30);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputResultTextBox
            // 
            this.outputResultTextBox.Location = new System.Drawing.Point(15, 172);
            this.outputResultTextBox.Name = "outputResultTextBox";
            this.outputResultTextBox.Size = new System.Drawing.Size(317, 96);
            this.outputResultTextBox.TabIndex = 3;
            this.outputResultTextBox.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(347, 280);
            this.Controls.Add(this.outputResultTextBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox outputDictionaryTextBox;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.RichTextBox outputResultTextBox;
    }
}

