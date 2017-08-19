﻿using System;
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

            progressBar1.Maximum = 100;
            StartProgress();
           

        }

       

        async void StartProgress()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i >= 99)
                {
                    i = 0;
                }

                progressBar1.Value = i;
                await Task.Delay(2000);
                label1.Text = Convert.ToString(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i = 0;
            label1.Text += " Klik";

           
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
