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
            this.panelDictionaryOutput = new System.Windows.Forms.Panel();
            this.txtBoxOutputDictionaryInfo = new System.Windows.Forms.RichTextBox();
            this.listViewOutputDictionary = new System.Windows.Forms.ListView();
            this.txtBoxInputContent = new System.Windows.Forms.RichTextBox();
            this.bConvert = new System.Windows.Forms.Button();
            this.txtBoxOutputResult = new System.Windows.Forms.RichTextBox();
            this.panelDictionaryOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDictionaryOutput
            // 
            this.panelDictionaryOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDictionaryOutput.BackColor = System.Drawing.SystemColors.Window;
            this.panelDictionaryOutput.Controls.Add(this.txtBoxOutputDictionaryInfo);
            this.panelDictionaryOutput.Controls.Add(this.listViewOutputDictionary);
            this.panelDictionaryOutput.Location = new System.Drawing.Point(1, 1);
            this.panelDictionaryOutput.Name = "panelDictionaryOutput";
            this.panelDictionaryOutput.Size = new System.Drawing.Size(345, 165);
            this.panelDictionaryOutput.TabIndex = 0;
            // 
            // txtBoxOutputDictionaryInfo
            // 
            this.txtBoxOutputDictionaryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxOutputDictionaryInfo.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxOutputDictionaryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOutputDictionaryInfo.Location = new System.Drawing.Point(11, 11);
            this.txtBoxOutputDictionaryInfo.Name = "txtBoxOutputDictionaryInfo";
            this.txtBoxOutputDictionaryInfo.ReadOnly = true;
            this.txtBoxOutputDictionaryInfo.Size = new System.Drawing.Size(317, 47);
            this.txtBoxOutputDictionaryInfo.TabIndex = 0;
            this.txtBoxOutputDictionaryInfo.Text = "";
            // 
            // listViewOutputDictionary
            // 
            this.listViewOutputDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOutputDictionary.HideSelection = false;
            this.listViewOutputDictionary.Location = new System.Drawing.Point(11, 81);
            this.listViewOutputDictionary.Name = "listViewOutputDictionary";
            this.listViewOutputDictionary.Size = new System.Drawing.Size(317, 69);
            this.listViewOutputDictionary.TabIndex = 4;
            this.listViewOutputDictionary.TileSize = new System.Drawing.Size(50, 30);
            this.listViewOutputDictionary.UseCompatibleStateImageBehavior = false;
            this.listViewOutputDictionary.View = System.Windows.Forms.View.Details;
            // 
            // txtBoxInputContent
            // 
            this.txtBoxInputContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxInputContent.Location = new System.Drawing.Point(15, 172);
            this.txtBoxInputContent.Name = "txtBoxInputContent";
            this.txtBoxInputContent.Size = new System.Drawing.Size(239, 30);
            this.txtBoxInputContent.TabIndex = 1;
            this.txtBoxInputContent.Text = "";
            // 
            // bConvert
            // 
            this.bConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bConvert.Location = new System.Drawing.Point(257, 172);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(75, 30);
            this.bConvert.TabIndex = 2;
            this.bConvert.Text = "convert";
            this.bConvert.UseVisualStyleBackColor = true;
            this.bConvert.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // txtBoxOutputResult
            // 
            this.txtBoxOutputResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxOutputResult.Location = new System.Drawing.Point(15, 224);
            this.txtBoxOutputResult.Name = "txtBoxOutputResult";
            this.txtBoxOutputResult.Size = new System.Drawing.Size(317, 96);
            this.txtBoxOutputResult.TabIndex = 3;
            this.txtBoxOutputResult.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(346, 331);
            this.Controls.Add(this.txtBoxOutputResult);
            this.Controls.Add(this.bConvert);
            this.Controls.Add(this.txtBoxInputContent);
            this.Controls.Add(this.panelDictionaryOutput);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDictionaryOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel panelDictionaryOutput;
        private System.Windows.Forms.RichTextBox txtBoxOutputDictionaryInfo;
        private System.Windows.Forms.RichTextBox txtBoxInputContent;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.RichTextBox txtBoxOutputResult;
        private System.Windows.Forms.ListView listViewOutputDictionary;
    }
}

