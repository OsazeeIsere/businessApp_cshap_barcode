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
	public partial class cashier
	{
		internal cashier()
		{
			InitializeComponent();
		}

		public string str;
		public string txtcashiername1;
		public sales v = new sales();



        private System.Data.DataTable getdatabase(string strcommand)
        {
            System.Data.DataTable tempgetdatabase = null;
            tempgetdatabase = new System.Data.DataTable();
            MySqlConnection cn = new MySqlConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter();
            MySqlCommand cm = new MySqlCommand();
            string strconnection = "";
            strconnection = "Server=localhost;Port=3306;Database=snowbakedb;Uid=root;Pwd=prayer;";
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



        private void Button2_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtcashiername.Text))
				{
					MessageBox.Show("please Enter Your User Name");
				}
				else if (string.IsNullOrEmpty(txtcashierpassword.Text))
				{
					MessageBox.Show("please Enter Your Password");
				}
				else if (txtcashiername.Text == (txtcashiername.Text).ToString())
				{
					txtcashierpassword.Text = (txtcashierpassword.Text).ToString();
				MySqlConnection cn = new MySqlConnection();
					MySqlDataAdapter ad = new MySqlDataAdapter();
					MySqlCommand cm = new MySqlCommand();
					string strconnection = "";
					strconnection = "server= localhost;port=3306;database=businnessdatabase;uid=root;pwd=prayer";
					cn.ConnectionString = strconnection;
					cn.Open();
					cm.CommandText = "Insert Into cashier(cashiername,cashierpassword) Values('" + txtcashiername.Text + "','" + txtcashierpassword.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("You have been successfully added as a User");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());

			}


		}

		private void lblpassword_Click(object sender, System.EventArgs e)
		{

		}

		private void txtcashierpassword_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Button1_Click(object sender, System.EventArgs e)
		{

            try
            {

                System.Data.DataTable dtgetcashier = new System.Data.DataTable();
                dtgetcashier = getdatabase("select * from cashier");
                if (dtgetcashier.Rows.Count > 0)
                {
                    for (int i = 0; i < dtgetcashier.Rows.Count; i++)
                    {
                        if (txtcashiername.Text.ToUpper() == dtgetcashier.Rows[i]["cashiername"].ToString().ToUpper() && txtcashierpassword.Text == dtgetcashier.Rows[i]["cashierpassword"].ToString())
                        {

                            v.txtcashiername1.Text = txtcashiername.Text;
                            v.Show();
                            txtcashiername.Text = "";
                            txtcashierpassword.Text = "";
                            goto brake1;

                        }

                    }
                  
                        MessageBox.Show("You made a WRONG or INCOMPLET Entry");

                  

                    //for (var i = 0; i < dtgetcashier.Rows.Count; i++)
                    //{
                    //	if (txtcashiername.Text.ToUpper() == Convert.ToString(dtgetcashier.Rows[i]["cashiername"]).ToUpper() && txtcashierpassword.Text == (dtgetcashier.Rows[i]["cashierpassword"]).ToString())
                    //	{
                    //		//goto 95;
                    //		//dtgetresult.Rows(i).Item("subjectid").ToString()
                    //	}
                    //}

                }
            brake1:;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
			//strcashiername = txtcashiername.Text
			// txtcashiername.Text = ""
			//txtcashierpassword.Text = ""

		}

		private void cashier_Load(object Byder, System.EventArgs e)
		{


			//OpenFileDialog1.ShowDialog()
			//workbook = APP.Workbooks.Open(txtfile.Text)
			// worksheet = workbook.Worksheets("sheet2")
		}

		private void Timer1_Tick(object sender, System.EventArgs e)
		{

		}

		private void PictureBox1_Click(object sender, System.EventArgs e)
		{

		}

		private void Label1_Click(object sender, System.EventArgs e)
		{

		}

		private void txtcashiername_TextChanged(object sender, System.EventArgs e)
		{

		}
	}
}