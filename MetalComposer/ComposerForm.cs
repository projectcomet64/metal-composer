using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetalComposer
{
    public partial class ComposerForm : Form
    {
        public ComposerForm()
        {
            InitializeComponent();
        }

        public void UpdateCoreAddressText(long address)
        {
            label1.Text = "Core Address is: 0x" + address.ToString("X");
        }
    }
}
