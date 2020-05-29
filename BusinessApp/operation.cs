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
	public partial class operation
	{

		internal operation()
		{
			InitializeComponent();
		}

		private void btnoperationadd_Click(object sender, System.EventArgs e)
		{
			drugs x = new drugs();
			x.ShowDialog();
		}

		private void operation_Load(object sender, System.EventArgs e)
		{

		}
	}
}