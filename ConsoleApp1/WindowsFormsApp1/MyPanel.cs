using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    class OutputPanel : Panel {
        MyTextBox tb = new MyTextBox();
        public OutputPanel() {
            this.Controls.Add(tb);
        }
        public void OutputDictionary() {
            tb.BackColor = Color.White;
            tb.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Regular);
            tb.OutputDictionary();
        }
        public void OutputResult() {
            tb.BackColor = Color.LightGray;
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            tb.OutputResult();
        }
    }
}
