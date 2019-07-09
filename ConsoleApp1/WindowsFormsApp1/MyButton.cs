using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public class MyButton : Button {
        public override Color BackColor {
            get {
                Color color = Color.FromArgb(base.BackColor.A-100 , base.BackColor);
                return color;
            }
            set { base.BackColor = value; }
        }
        public override Font Font {
            get { return base.Font; }
            set { base.Font = value; }
        }
        public override Cursor Cursor {
            get { return Cursors.Cross; }
            set { base.Cursor = value; }
        }
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.X = 100;
                cp.Y = 100;
                cp.Width = 75;
                cp.Height = 75;
                return cp;
            }
        }
    }
}
