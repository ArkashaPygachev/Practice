using LibConverterAndDictionaryLoader;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    class MyTextBox:RichTextBox {
        string inputFileName = ConfigurationManager.AppSettings["LoadFileName"];
        LoadResult result = new LoadResult();
        public MyTextBox() {
            this.ReadOnly = true;
            Loader loader = new XmlLoader(inputFileName);
            result = loader.GetFromConfig();
            //this.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Regular);
        }
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.Width = 600;
                cp.Height = 100;
                return cp;
            }
        }
        //public override Color BackColor {
        //    get {
        //        Color color = Color.FromArgb(255, 255, 255);
        //        return color;
        //    }
        //    set => base.BackColor = value;
        //}
        public void OutputDictionary() {
            if (result.Error == null) {
                this.AppendText($"Dictionary loaded from {inputFileName}");
                this.AppendText("\n\n");
                foreach (var item in result.Data) {
                    this.AppendText($"{item.Key} ");
                }
                this.AppendText("\n");
                foreach (var item in result.Data) {
                    this.AppendText($"{item.Value} ");
                }
            } else MessageBox.Show(result.Error.Message);
        }
        public void OutputResult() {
            string inputFileNameContent = ConfigurationManager.AppSettings["Text"];
            List<string> content = Converter.GetFileContentAsString(inputFileNameContent);
            this.AppendText($"Text loaded from {inputFileNameContent} and converted\n\n");
            List<string> actualContent = Converter.Convert(content, result.Data);
            foreach (var line in actualContent) {
                this.AppendText($"{line}\n");
            }
        }
    }
}
