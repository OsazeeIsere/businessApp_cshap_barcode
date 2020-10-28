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
	public partial class activity
	{
		// if u have problem with microsoft office.interop.excel, try to remove evry reference not needed from "solution explorer" right side of top bar  
		internal activity()
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
		private void Label4_Click(object sender, System.EventArgs e)
		{

		}

		private void btndrugs_Click(object sender, System.EventArgs e)
		{
			drugs x = new drugs();
			x.txtcashiername1.Text = txtcashiername1.Text;
			x.Show();
		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			sales x = new sales();
			x.txtcashiername1.Text = txtcashiername1.Text;
			x.Show();

		}

		private void activity_Load(object sender, System.EventArgs e)
		{
            DataTable dtidentity = new DataTable();
            dtidentity = getdatabase("Select * from identity");
            
                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

            
            BackColor = Color.Chocolate;

		}

		private void Button3_Click(object sender, System.EventArgs e)
		{

		}

		private void Button5_Click(object sender, System.EventArgs e)
		{
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			//Dim x As New drinks
			//x.txtcashiername1.Text = txtcashiername1.Text
			//x.ShowDialog()
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			//cosmetics x = new cosmetics();
			//x.txtcashiername1.Text = txtcashiername1.Text;
			//x.Show();
		}

		private void Label1_Click(object sender, System.EventArgs e)
		{

		}

		private void Button3_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetadmin = new System.Data.DataTable();
				dtgetadmin = getdatabase("Select * from administrator");
				if (dtgetadmin.Rows.Count > 0)
				{
					for (var i = 0; i < dtgetadmin.Rows.Count; i++)
					{
						if (txtadminpassword.Text == (dtgetadmin.Rows[i]["adminpassword"]).ToString())
						{
							adminsales x = new adminsales();
							x.txtcashiername1.Text = txtcashiername1.Text;
							x.Show();
						}
						else if (txtcashiername1.Text.ToUpper() == Convert.ToString(dtgetadmin.Rows[i]["adminname"]).ToUpper())
						{
							adminsales x = new adminsales();
							x.txtcashiername1.Text = txtcashiername1.Text;
							x.Show();
						}
						else
						{
							MessageBox.Show("Please Look For The Administrator");
							txtadminpassword.Focus();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}