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
	public partial class expirydateinfotype
	{

		internal expirydateinfotype()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			expirydateinfo x = new expirydateinfo();
			x.Show();
		}

		private void Button2_Click(object sender, System.EventArgs e)
        {
            //	cosmeticsexpirydateinfo v = new cosmeticsexpirydateinfo();
            //	v.Show();
        }

		private void Button3_Click(object sender, System.EventArgs e)
		{
			//'Dim v As New drinksexpirydateinfo
			//'v.ShowDialog()
		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			purchasehistory x = new purchasehistory();
			x.Show();
		}

        private void expirydateinfotype_Load(object sender, EventArgs e)
        {

        }
    }
}