using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTemp_Desktop
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            zadanaTempLabel.Text = "00" + "°C";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            wykresCO.Maximum = 100;
            wykresCO.Value = 50;
        }
    }
    public class VerticalProgressBar : System.Windows.Forms.ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }
}
