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
	public partial class expenditure
	{

		internal expenditure()
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
        private void Label1_Click(object sender, System.EventArgs e)
		{

		}

        private void expenditure_Load(object sender, EventArgs e)
        {
             DataTable dtidentity = new DataTable();
            dtidentity = getdatabase("Select * from identity");
            
                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
           //     lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

        }
    }
}