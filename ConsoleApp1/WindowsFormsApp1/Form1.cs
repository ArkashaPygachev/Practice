using DictionaryLoader;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() {
            this.Width = 255;
            this.Height = 347;
            InitializeComponent();
            MyButton b = new MyButton();
            this.Controls.Add(b);
        }

        private void button1_Click(object sender, EventArgs e) {
            XmlLoader loader = new XmlLoader(ConfigurationManager.AppSettings["LoadFileName"]);
            label1.Text = loader.GetFromConfig().ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
