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
	public partial class backup
	{
		internal backup()
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
		private void Label3_Click(object sender, System.EventArgs e)
		{
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetbackup = new System.Data.DataTable();
				dtgetbackup = getdatabase("select * from backup");
				for (var i = 0; i < dtgetbackup.Rows.Count; i++)
				{
					if (txtbackupname.Text.ToUpper() == Convert.ToString(dtgetbackup.Rows[i]["backupname"]).ToUpper() && txtbackuppassword.Text == (dtgetbackup.Rows[i]["backuppassword"]).ToString())
					{
						activity x = new activity();
						x.txtcashiername1.Text = txtbackupname.Text;
						x.Show();
						goto brake1;
					}
				}
				//for (var i = 0; i < dtgetbackup.Rows.Count; i++)
				//{
				//	if (txtbackupname.Text.ToUpper() == Convert.ToString(dtgetbackup.Rows[i]["backupname"]).ToUpper() && txtbackuppassword.Text == (dtgetbackup.Rows[i]["backuppassword"]).ToString())
				//	{
				//		goto 51;
				//		//dtgetresult.Rows(i).Item("subjectid").ToString()
				//	}
				//}
				MessageBox.Show("You made a WRONG or INCOMPLETE Entry");
				brake1:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());

			}
			txtbackupname.Text = "";
			txtbackuppassword.Text = "";

		}

		private void backup_Load(object sender, System.EventArgs e)
		{

		}
	}
}