using LibConverterAndDictionaryLoader;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            //OutputDictionary();
            //OutputResult();
            
            //MyButton b = new MyButton();
            //this.Controls.Add(b);
        }
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                //cp.Width = 600;
                //cp.Height = 300;
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
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Anchor = (AnchorStyles.Left | AnchorStyles.Top);

            outputDictionaryTextBox.Width = panel2.Width;
            outputDictionaryTextBox.Height = panel2.Height;
            OutputDictionary(outputDictionaryTextBox);
        }
        private void OutputDictionary (RichTextBox tb) {
            string inputFileName = ConfigurationManager.AppSettings["LoadFileName"];
            Loader loader = new XmlLoader(inputFileName);
            LoadResult result = loader.GetFromConfig(); ;
            if (result.Error == null) {
                tb.AppendText($"Dictionary loaded from {inputFileName}");
                tb.AppendText("\n\n");
                foreach (var item in result.Data) {
                    tb.AppendText($"{item.Key} ");
                }
                tb.AppendText("\n");
                foreach (var item in result.Data) {
                    tb.AppendText($"{item.Value} ");
                }
            } else MessageBox.Show(result.Error.Message);
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void convertButton_Click(object sender, EventArgs e) {
            List<string> content = new List<string> {inputTextBox.Text };
            string inputFileName = ConfigurationManager.AppSettings["LoadFileName"];
            Loader loader = new XmlLoader(inputFileName);
            LoadResult resultDictionary = loader.GetFromConfig();
            List<string> resultContent = Converter.Convert(content, resultDictionary.Data);
            outputResultTextBox.Text = resultContent[0];
        }
    }
}
