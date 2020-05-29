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
	public partial class clearholdsalescart
	{
		//Public lscitems1 As Double
		internal clearholdsalescart()
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
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				dtgetsales = getdatabase("Select* from holdsales");
				string strconnection = "";
				strconnection = "server= localhost;port=3306;database=businnessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				cn.Open();
				cm.CommandText = "Delete from holdsales where transactionid>0";
				cm.Connection = cn;
				cm.ExecuteNonQuery();
				holdsales v = new holdsales();
				v.txttotal.Text = "";
				v.txtcash.Text = "";
				v.txtreceiptnumber.Text = "";
				v.txtdiscount.Text = "";
				v.txtgrandtotal.Text = "";
				sales x = new sales();
				x.discount = 0;
				this.Close();
				v.lsvitems.Clear();
				v.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void clearholdsalescart_Load(object sender, EventArgs e)
        {

        }
    }
}