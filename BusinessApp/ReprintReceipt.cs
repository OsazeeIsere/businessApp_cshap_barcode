using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApp
{
    public partial class ReprintReceipt : Form
    {
        public ReprintReceipt()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            receiptmidip x = new receiptmidip();
            x.txtrepeatreceipt.Text = txtrepeatreceipt.Text;
            x.Show();

        }
    }
}
