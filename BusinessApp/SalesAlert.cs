using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessApp
{
    public partial class SalesAlert : Form
    {
        public SalesAlert()
        {
            InitializeComponent();
        }

        private void SalesAlert_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
                                               
        private void SalesAlert_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
