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
	public partial class Patient_Electronic_Record
	{

		internal Patient_Electronic_Record()
		{
			InitializeComponent();
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			Patient_Database x = new Patient_Database();
			x.ShowDialog();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			PatientInfo x = new PatientInfo();
			x.ShowDialog();
		}

        private void Patient_Electronic_Record_Load(object sender, EventArgs e)
        {

        }
    }
}