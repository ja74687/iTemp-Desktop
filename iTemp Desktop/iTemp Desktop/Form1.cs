using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace iTemp_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            start();
        }


        async void start() {
            await Task.Delay(2000);
            mainForm mainForm = new mainForm();
            this.Visible = false;
            mainForm.ShowDialog();
            this.Dispose();
        }
    }
    


}
