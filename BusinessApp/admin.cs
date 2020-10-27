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


using System.Windows.Forms;

using MySql.Data.MySqlClient;
namespace BusinessApp
{
	public partial class admin
	{
		internal admin()
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
				System.Data.DataTable dtgetadmin = new System.Data.DataTable();
				string strconnection = "";
				strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				cn.Open();
				dtgetadmin = getdatabase("Select * From administrator");
				if (string.IsNullOrEmpty(txtadminname.Text))
				{
					MessageBox.Show("Please Enter Your User Name");
				}
				else if (string.IsNullOrEmpty(txtadminpassword.Text) && string.IsNullOrEmpty(txtadminpassword1.Text))
				{
					MessageBox.Show("Please Enter Your Password");
				}
				else if (txtadminpassword.Text != txtadminpassword1.Text)
				{
					MessageBox.Show("Please Password Does not Match. Enter Carefully.");
					// the following code helps to ensure that there is only one admin
				}
				else if (dtgetadmin.Rows.Count == 0)
				{
					cm.CommandText = "Insert Into administrator(adminname,adminpassword) Values('" + txtadminname.Text + "','" + txtadminpassword.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					txtadminpassword.Text = "";
					txtadminpassword1.Text = "";
					MessageBox.Show("ADMINISTRATOR is Register");
				}
				else
				{
					MessageBox.Show("Please will already have an ADMINISTRATOR");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnmanageuser_Click(object sender, System.EventArgs e)
		{
			try
			{

                if (string.IsNullOrEmpty(txtadminname.Text))
                {
                    MessageBox.Show("Please Enter Your User Name");
                }
                else if (string.IsNullOrEmpty(txtadminpassword.Text))
                {
                    MessageBox.Show("Please Enter Your Password");
                }
                else
                {
                    System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                    dtgetadmin = getdatabase("select * from administrator");
                    for (var i = 0; i < dtgetadmin.Rows.Count; i++)
                    {
                        if (txtadminname.Text.ToUpper() == Convert.ToString(dtgetadmin.Rows[i]["adminname"]).ToUpper() && txtadminpassword.Text == (dtgetadmin.Rows[i]["adminpassword"]).ToString())
                        {
                            addbackup x = new addbackup();
                            x.lbadmin .Text  = txtadminname.Text;
                            x.Show();
                            //goto breake1;
                        }
                        else
                        {
                            MessageBox.Show("Please Examine Your Entry carefully or look for the ADMINISTRATOR");
                        }
                    }
                }
            //breake1:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			txtadminname.Text = "";
			txtadminpassword.Text = "";
		}

		private void admin_Load(object sender, System.EventArgs e)
		{
            DataTable dtidentity = new DataTable();
            dtidentity = getdatabase("Select * from identity");

            lbname.Text = dtidentity.Rows[0]["businessName"].ToString();
            lbaddress.Text = dtidentity.Rows[0]["address"].ToString();
            lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

        }

        private void rtxtmap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadminpassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbname_Click(object sender, EventArgs e)
        {

        }
    }
    }
