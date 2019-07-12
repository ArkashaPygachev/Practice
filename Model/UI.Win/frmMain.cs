using System;
using System.Configuration;
using System.Windows.Forms;

using Model;

namespace UI.Win {
    public partial class frmMain : Form {
        Localizer localizer;
        public frmMain() {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e) {
            string alphabetFileName = ConfigurationManager.AppSettings["AlphabetFileName"];
            Localizer localizer = new Localizer();
            bool loadedSuccessfully = localizer.LoadAlphabetFromFile(alphabetFileName);
            if (!loadedSuccessfully) {
                MessageBox.Show("Alphabet was not loaded", "UI.Win", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetControlsEnabled(false);
            } else {
                this.localizer = localizer;
            }
        }
        private void btnLocalize_Click(object sender, EventArgs e) {
            string originalText = txtInputText.Text.Trim();
            string localizedText = localizer.Localize(originalText);
            rtbOutputText.AppendText($"{localizedText}{Environment.NewLine}");
            txtInputText.Text = string.Empty;
        }
        private void SetControlsEnabled(bool enabled) {
            txtInputText.Enabled = btnLocalize.Enabled = rtbOutputText.Enabled = enabled;
        }
        private void btnClearOutput_Click(object sender, EventArgs e) {
            rtbOutputText.Text = null;
        }
    }
}
