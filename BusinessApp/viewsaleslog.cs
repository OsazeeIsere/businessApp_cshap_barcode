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
using xlapp = Microsoft.Office.Interop.Excel;

namespace BusinessApp
{
	public partial class viewsaleslog
	{


		internal viewsaleslog()
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
        private void Label5_Click(object sender, System.EventArgs e)
		{

		}

		private void TextBox2_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			try
			{
				saleslog v = new saleslog();
				System.Data.DataTable dtgetcashier = new System.Data.DataTable();
				dtgetcashier = getdatabase("select * from cashier");
				for (var i = 0; i < dtgetcashier.Rows.Count; i++)
				{
					if (txtcashierpassword.Text == dtgetcashier.Rows[i]["cashierpassword"].ToString())
					{
						v.txtpassword.Text = txtcashierpassword.Text;
						v.Show();
						txtcashierpassword.Text = "";
						goto brake1;
					}
				}
				MessageBox.Show("Your  Password No Correct. Abeg Enter Am Well");
				txtcashierpassword.Focus();
            brake1:;
            }
          
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetbackup = new System.Data.DataTable();
				dtgetbackup = getdatabase("select * from backup");
				for (var i = 0; i < dtgetbackup.Rows.Count; i++)
				{
					if (txtadminpassword.Text == (dtgetbackup.Rows[i]["backuppassword"]).ToString())
					{
						saleslog x = new saleslog();
						x.txtpassword.Text = txtadminpassword.Text;
						x.Show();
						goto brake1;
					}
				}
				System.Data.DataTable dtgetadmin = new System.Data.DataTable();
				dtgetadmin = getdatabase("select * from administrator");
				for (var i = 0; i < dtgetadmin.Rows.Count; i++)
				{
					if (txtadminpassword.Text == (dtgetadmin.Rows[i]["adminpassword"]).ToString())
					{
						saleslog x = new saleslog();
						x.txtpassword.Text = txtadminpassword.Text;
						x.Show();
						goto brake1;
					}
				}
				MessageBox.Show("Your  Password No Correct. Abeg Enter Am Well");
				brake1:;
			}
            
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());

			}
			txtadminpassword.Text = "";


		}

		private void viewsaleslog_Load(object sender, System.EventArgs e)
		{
            DataTable dtidentity = new DataTable();
            dtidentity = getdatabase("Select * from identity");

            lbname.Text = dtidentity.Rows[0]["businessName"].ToString();
            lbaddress.Text = dtidentity.Rows[0]["address"].ToString();
            //            lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
            this.ActiveControl = txtadminpassword;
           // txtadminpassword.Focus();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}