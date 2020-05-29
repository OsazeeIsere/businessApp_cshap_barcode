//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace BusinessApp
{
	public partial class saleslog
	{

		internal saleslog()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			drugslog x = new drugslog();
			x.txtpassword1.Text = txtpassword.Text;
			x.Show();
		}

		private void btnbackup_Click(object sender, System.EventArgs e)
		{
			//Dim x As New drinkslog
			//x.txtpassword1.Text = txtpassword.Text
			//x.ShowDialog()
		}

		private void btnaddproduct_Click(object sender, System.EventArgs e)
		{
			//cosmeticslog x = new cosmeticslog();
			//x.txtpassword1.Text = txtpassword.Text;
			//x.Show();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			generalsaleslog v = new generalsaleslog();
			v.txtpassword1.Text = txtpassword.Text;
			v.Show();
		}

        private void saleslog_Load(object sender, EventArgs e)
        {

        }
    }
}