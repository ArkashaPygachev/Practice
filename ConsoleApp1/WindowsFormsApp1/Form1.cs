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
        protected string inputFileName;
        protected LoadResult result = new LoadResult();
        public Form1() {
            InitializeComponent();
            inputFileName = ConfigurationManager.AppSettings["LoadFileName"];
            Loader loader = new XmlLoader(inputFileName);
            result = loader.GetFromConfig();
        }
        private void Form1_Load(object sender, EventArgs e) {
            DisplayDictionary();
        }
        private void DisplayDictionary() {
            if (result.Error == null) {
                txtBoxOutputDictionaryInfo.AppendText($"Dictionary loaded from {inputFileName}");
                List<string> row = new List<string>();
                foreach (var item in result.Data) {
                    listViewOutputDictionary.Columns.Add(item.Key);
                    row.Add(item.Value);
                }
                string[] resRow = row.ToArray();
                var listItem = new ListViewItem(resRow);
                listViewOutputDictionary.Items.Add(listItem);
            } else MessageBox.Show(result.Error.Message);
        }
        
        private void convertButton_Click(object sender, EventArgs e) {
            string content = txtBoxInputContent.Text;
            string convertedContent = Converter.Convert(content, result.Data);
            txtBoxOutputResult.Text = convertedContent;
        }
    }
}
