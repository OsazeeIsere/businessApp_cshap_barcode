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

using MySql.Data.MySqlClient;
namespace BusinessApp
{
	public partial class welcome
	{
		internal welcome()
		{
			InitializeComponent();
		}

		private System.Data.DataTable getdatabase(string strcommand)
		{
			System.Data.DataTable tempgetdatabase = null;
			tempgetdatabase = new System.Data.DataTable();
			MySqlConnection cn = new MySqlConnection();
			MySqlDataAdapter ad = new MySqlDataAdapter();
			MySqlCommand cm = new MySqlCommand();
			string strconnection = "";
			strconnection = "Server=localhost;Port=3306;Database=businnessdatabase;Uid=root;Pwd=prayer;";
			cn.ConnectionString = strconnection;
			cn.Open();
			cm.CommandText = strcommand;
			ad.SelectCommand = cm;
			cm.Connection = cn;
			System.Data.DataTable dt = new System.Data.DataTable();
			ad.Fill(dt);
			tempgetdatabase = dt;
			cn.Close();
			return tempgetdatabase;
		}
		private void btnaddproduct_Click(object sender, System.EventArgs e)
		{
			cashier x = new cashier();
			x.Show();
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			admin x = new admin();

            
			x.Show();
		}

		private void welcome_Load(object sender, System.EventArgs e)
		{
			BackColor = Color.Orange;
		}

		private void btnbackup_Click(object sender, System.EventArgs e)
		{
			backup x = new backup();
			x.Show();
		}

		private void Label1_Click(object sender, System.EventArgs e)
		{

		}

		private static welcome _DefaultInstance;
		public static welcome DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null)
					_DefaultInstance = new welcome();

				return _DefaultInstance;
			}
		}
	}

}