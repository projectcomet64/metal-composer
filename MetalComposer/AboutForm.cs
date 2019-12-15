using System.Diagnostics;
using System.Windows.Forms;

namespace MetalComposer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            lbVersion.Text = "Version: " + ProductVersion + ", running on " + Application.ProductName + " v" + Application.ProductVersion; 
        }

        private void llSM64Decomp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/n64decomp/sm64");
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
