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
	public partial class delet
	{
		// if u have problem with microsoft office.interop.excel, try to remove evry reference not needed from "solution explorer" right side of top bar
		internal delet()
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
			strconnection = "Server=localhost;Port=3306;Database=businessdatabase;Uid=root;Pwd=prayer;";
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
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
				dtgetexpirydate = getdatabase("Select * From expirydate where productid=" + Convert.ToInt32(txtproductid.Text));
				string strconnection = "";
				strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				cn.Open();
				cm.CommandText = "Delete from product where productid=" + Convert.ToInt32(txtproductid.Text) + ";";
				//& intproductid & ";"
				cm.Connection = cn;
				cm.ExecuteNonQuery();
				cn.Close();
				cn.Open();
				cm.CommandText = "Delete from expirydate where productid=" + Convert.ToInt32(txtproductid.Text) + ";";
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

		private void txtproductid_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Label1_Click(object sender, System.EventArgs e)
		{

		}

		private void Label2_Click(object sender, System.EventArgs e)
		{

		}

		private void txtproductname_TextChanged(object sender, System.EventArgs e)
		{

		}

        private void delet_Load(object sender, EventArgs e)
        {

        }
    }
}