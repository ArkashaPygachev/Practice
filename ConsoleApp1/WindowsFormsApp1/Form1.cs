using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            OutputDictionary();
            OutputResult();
            
            //MyButton b = new MyButton();
            //this.Controls.Add(b);
        }
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.Width = 600;
                cp.Height = 300;
                return cp;
            }
        }
        private void OutputDictionary() {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            OutputPanel dictionaryPanel = new OutputPanel() {
                Height = 100,
                Width = 600
            };
            this.Controls.Add(dictionaryPanel);
            dictionaryPanel.OutputDictionary();
        }
        private void OutputResult() {
            OutputPanel convertPanel = new OutputPanel() {
                Height = 100,
                Width = 600,
                BackColor = Color.FromArgb(110, 120, 140),
                Location = new Point(0, 100)
            };
            this.Controls.Add(convertPanel);
            convertPanel.OutputResult();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
