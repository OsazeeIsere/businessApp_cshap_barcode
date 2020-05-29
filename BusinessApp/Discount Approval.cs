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
	public partial class Discount_Approval
	{
		//Public lscitems1 As Double
		internal Discount_Approval()
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
			//Try
			//    Dim dtgetadmin As New System.Data.DataTable
			//    dtgetadmin = getdatabase("Select * from administrator")
			//    If dtgetadmin.Rows.Count > 0 Then
			//        For i = 0 To dtgetadmin.Rows.Count - 1
			//            If txtadminpassword.Text = dtgetadmin.Rows(i).Item("adminpassword") Then
			//                Dim x As New sales
			//                x.txtdiscountapproval.Text = txtadminpassword.Text
			//                x.txtcashiername1.Text = txtcashierN.Text
			//                x.ShowDialog()
			//                txtcashierN.Text = ""
			//                txtadminpassword.Text = ""
			//                Me.Close()
			//            Else
			//                MessageBox.Show("Password Does not Match. Enter Correctly if You Are The Administrator")
			//            End If
			//            txtadminpassword.Focus()
			//        Next
			//    End If
			//Catch ex As Exception
			//    MessageBox.Show(ex.ToString)
			//End Try
		}

		private void Discount_Approval_Load(object sender, System.EventArgs e)
		{

		}
	}
}