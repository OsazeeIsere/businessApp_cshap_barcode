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
	public partial class saleslog
	{

		internal saleslog()
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
            string strconnection1 = "";
            strconnection1 = "Server=localhost;Port=3306;Database=businessdatabase;Uid=root;Pwd=prayer;";
            cn.ConnectionString = strconnection1;
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
			drugslog x = new drugslog();
			x.txtpassword1.Text = txtpassword.Text;
			x.Show();
		}

		private void btnbackup_Click(object sender, System.EventArgs e)
		{
			//Dim x As New drinkslog
			//x.txtpassword1.Text = txtpassword.Text
			//x.ShowDialog()
		}

		private void btnaddproduct_Click(object sender, System.EventArgs e)
		{
			//cosmeticslog x = new cosmeticslog();
			//x.txtpassword1.Text = txtpassword.Text;
			//x.Show();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			generalsaleslog v = new generalsaleslog();
            v.txtpassword1.Text = txtpassword.Text;
            v.txtpassword1.Visible = false;
         	v.Show();
		}

        private void saleslog_Load(object sender, EventArgs e)
        {
            DataTable dtidentity = new DataTable();
            dtidentity = getdatabase("Select * from identity");

            txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
            txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
            txtpassword.Focus();
            Button2.Visible = false;

            //            lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
        }
    }
}