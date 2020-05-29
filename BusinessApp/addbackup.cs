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
using System.IO;
namespace BusinessApp
{
	public partial class addbackup
	{
		internal addbackup()
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
		private void btnoperation_Click(object sender, System.EventArgs e)
		{
			activity x = new activity();
			x.txtcashiername1.Text = lbadmin.Text;
			x.Show();
		}

		private void btnaddbackup_Click(object sender, System.EventArgs e)
		{
			try
			{
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				System.Data.DataTable dtgetbackup = new System.Data.DataTable();
				string strconnection = "";
				strconnection = "server= localhost;port=3306;database=businnessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				cn.Open();
				dtgetbackup = getdatabase("Select * From backup");
				if (string.IsNullOrEmpty(txtbackupname.Text))
				{
					MessageBox.Show("Please Enter Your User Name");
				}
				else if (string.IsNullOrEmpty(txtbackuppassword1.Text))
				{
					MessageBox.Show("Please Enter Your Password");
				}
				else if (txtbackuppassword1.Text != txtbackuppassword2.Text)
				{
					MessageBox.Show("Please there is PASSWORD MISMATCH");
					//the next code ensure that backup is not more than 2
				}
				else if (dtgetbackup.Rows.Count <= 2)
				{
					cm.CommandText = "Insert Into backup(backupname,backuppassword) Values('" + txtbackupname.Text + "','" + txtbackuppassword1.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("A BACKUP ADMINISTRATOR is Register");
					txtbackupname.Text = "";
					txtbackuppassword1.Text = "";
					txtbackuppassword2.Text = "";
				}
				else
				{
					MessageBox.Show("The Maximum BACKUP has been reached");
				}
				txtbackupname.Text = "";
				txtbackuppassword1.Text = "";
				txtbackuppassword2.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnaddcashier_Click(object sender, System.EventArgs e)
		{
			try
			{
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				System.Data.DataTable dtgetcashier = new System.Data.DataTable();
				string strconnection = "";
				string time1 = null;
				time1 =DateTime.Now.ToString ();
				strconnection = "server= localhost;port=3306;database=businnessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				cn.Open();
				dtgetcashier = getdatabase("Select * From cashier");
				if (string.IsNullOrEmpty(txtcashiername.Text))
				{
					MessageBox.Show("Please Enter Your User Name");
				}
				else if (string.IsNullOrEmpty(txtcashierpassword1.Text))
				{
					MessageBox.Show("Please Enter Your Password");
				}
				else if (txtcashierpassword1.Text != txtcashierpassword2.Text)
				{
					MessageBox.Show("Please there is PASSWORD MISMATCH");
				}
				else if (dtgetcashier.Rows.Count <= 10)
				{
					cm.CommandText = "Insert Into cashier(cashiername,cashierpassword) Values('" + txtcashiername.Text + "','" + txtcashierpassword1.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("A CASHIER is Registered");
					txtcashiername.Text = "";
					txtcashierpassword1.Text = "";
					txtcashierpassword2.Text = "";
				}
				else
				{
					MessageBox.Show("The Maximum CASHIER has been reached");
				}
				txtcashiername.Text = "";
				txtcashierpassword1.Text = "";
				txtcashierpassword2.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Label4_Click(object sender, System.EventArgs e)
		{

		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			assets x = new assets();
			x.Show();
		}

		private void addbackup_Load(object sender, System.EventArgs e)
		{

		}

		private void Button2_Click(object sender, System.EventArgs e)
		{

		}

		private void Button3_Click(object sender, System.EventArgs e)
		{

		}

		private void Button2_Click_1(object sender, System.EventArgs e)
		{
			//Dim v As New Patient_Electronic_Record
			//v.ShowDialog()
		}
	}
}