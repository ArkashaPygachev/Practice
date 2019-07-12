namespace UI.Win {
    partial class frmMain {
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
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.btnLocalize = new System.Windows.Forms.Button();
            this.rtbOutputText = new System.Windows.Forms.RichTextBox();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputText
            // 
            this.txtInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputText.Location = new System.Drawing.Point(12, 12);
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(479, 20);
            this.txtInputText.TabIndex = 0;
            // 
            // btnLocalize
            // 
            this.btnLocalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocalize.Location = new System.Drawing.Point(497, 10);
            this.btnLocalize.Name = "btnLocalize";
            this.btnLocalize.Size = new System.Drawing.Size(75, 23);
            this.btnLocalize.TabIndex = 1;
            this.btnLocalize.Text = "Localize";
            this.btnLocalize.UseVisualStyleBackColor = true;
            this.btnLocalize.Click += new System.EventHandler(this.btnLocalize_Click);
            // 
            // rtbOutputText
            // 
            this.rtbOutputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutputText.Location = new System.Drawing.Point(12, 38);
            this.rtbOutputText.Name = "rtbOutputText";
            this.rtbOutputText.Size = new System.Drawing.Size(560, 480);
            this.rtbOutputText.TabIndex = 2;
            this.rtbOutputText.Text = "";
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearOutput.Location = new System.Drawing.Point(497, 526);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(75, 23);
            this.btnClearOutput.TabIndex = 3;
            this.btnClearOutput.Text = "Clear";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.rtbOutputText);
            this.Controls.Add(this.btnLocalize);
            this.Controls.Add(this.txtInputText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.Button btnLocalize;
        private System.Windows.Forms.RichTextBox rtbOutputText;
        private System.Windows.Forms.Button btnClearOutput;
    }
}

