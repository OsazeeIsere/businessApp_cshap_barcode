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
	public partial class reorderleveltype
	{

		internal reorderleveltype()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			reorderlevel x = new reorderlevel();
			x.Show();
		}

		private void btnbackup_Click(object sender, System.EventArgs e)
		{
			//Dim x As New drinksreorderlevel
			//x.ShowDialog()
		}

		private void btnaddproduct_Click(object sender, System.EventArgs e)
		{
			//cosmeticsreorderlevel x = new cosmeticsreorderlevel();
			//x.Show();
		}

        private void reorderleveltype_Load(object sender, EventArgs e)
        {

        }
    }
}