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
	public partial class deletcosmetics
	{
		// if u have problem with microsoft office.interop.excel, try to remove evry reference not needed from "solution explorer" right side of top bar
		internal deletcosmetics()
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
		private void Button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				string strconnection = "";
				strconnection = "server= localhost;port=3306;database=businnessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				cn.Open();
				cm.CommandText = "Delete from cosmetics where cosmeticsid=" + Convert.ToInt32(txtproductid.Text) + ";";
				//& intproductid & ";"
				cm.Connection = cn;
				cm.ExecuteNonQuery();
				cn.Close();
				cn.Open();
				cm.CommandText = "Delete from cosmeticsexpirydate where cosmeticsid=" + Convert.ToInt32(txtproductid.Text) + ";";
				//& intproductid & ";"
				cm.Connection = cn;
				cm.ExecuteNonQuery();
				cn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			this.Close();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void deletcosmetics_Load(object sender, EventArgs e)
        {

        }
    }
}