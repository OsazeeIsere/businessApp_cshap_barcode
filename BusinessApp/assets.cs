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
	public partial class assets
	{
		internal assets()
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

		 private void assets_Load(object sender, System.EventArgs e)
		 {
			try
			{
                pncosmetics.Visible = false;
                pndrinks.Visible = false;
                pngridview.Visible = false;
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");

                lbname.Text = dtidentity.Rows[0]["businessName"].ToString();
                lbaddress.Text = dtidentity.Rows[0]["address"].ToString();
              //  lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				dtgetproduct = getdatabase("Select * From product");
				dgvdrugs.DataSource = dtgetproduct;
				System.Data.DataTable dtgetdrinks = new System.Data.DataTable();
				dtgetdrinks = getdatabase("Select * From drinks");
				dgvdrinks.DataSource = dtgetdrinks;
				System.Data.DataTable dtgetcards = new System.Data.DataTable();
				dtgetcards = getdatabase("Select * From cosmetics");
				dgvcards.DataSource = dtgetcards;
				System.Data.DataTable dtgetproduct1 = new System.Data.DataTable();
				System.Data.DataTable dtgetdrinks1 = new System.Data.DataTable();
				System.Data.DataTable dtgetcards1 = new System.Data.DataTable();
				dtgetproduct1 = getdatabase("select quantity,unitcostprice from product");
				dtgetdrinks1 = getdatabase("select drinksquantity,drinksunitcostprice from drinks");
				dtgetcards1 = getdatabase("select cosmeticsquantity,cosmeticsunitcostprice from cosmetics");
				double temp = 0;
				double temp1 = 0;
				double temp2 = 0;
				double temp3 = 0;
				double temp4 = 0;
				double temp5 = 0;
				int c = 0;
				int a = 0;
				int b = 0;
				if (dtgetproduct1.Rows.Count > 0)
				{
					//to sum the 2 columns
					for (var k = 0; k < dtgetproduct1.Rows.Count; k++)
					{
						temp = temp + Convert.ToInt32(dtgetproduct1.Rows[k]["quantity"]);
						temp1 = temp1 + Convert.ToInt32(dtgetproduct1.Rows[k]["quantity"]) * Convert.ToDouble(dtgetproduct1.Rows[k]["unitcostprice"]);
					}
				}
				c = dtgetproduct1.Rows.Count;
				txtquantitycount.Text = c.ToString();
				txtquanity.Text = temp.ToString();
				txtproductamount.Text = temp1.ToString();
				if (dtgetdrinks1.Rows.Count > 0)
				{
					//to sum the 2 columns
					for (var k = 0; k < dtgetdrinks1.Rows.Count; k++)
					{
						temp2 = temp2 + Convert.ToInt32(dtgetdrinks1.Rows[k]["drinksquantity"]);
						temp3 = temp3 + Convert.ToInt32(dtgetdrinks1.Rows[k]["drinksquantity"]) * Convert.ToDouble(dtgetdrinks1.Rows[k]["drinksunitcostprice"]);
					}
				}
				a = dtgetdrinks1.Rows.Count;
				txtquantitycount1.Text = a.ToString();
				txtquanity1.Text = temp2.ToString();
				txtproductamount1.Text = temp3.ToString();

				if (dtgetcards1.Rows.Count > 0)
				{
					//to sum the 2 columns
					for (var k = 0; k < dtgetcards1.Rows.Count; k++)
					{
						temp4 = temp4 + Convert.ToInt32(dtgetcards1.Rows[k]["cosmeticsquantity"]);
						temp5 = temp5 + Convert.ToInt32(dtgetcards1.Rows[k]["cosmeticsquantity"]) * Convert.ToDouble(dtgetcards1.Rows[k]["cosmeticsunitcostprice"]);
					}
				}
				b = dtgetcards1.Rows.Count;
				txtquantitycount2.Text = b.ToString();
				txtquanity2.Text = temp4.ToString();
				txtproductamount2.Text = temp5.ToString();
				txtgrandtotal.Text = (temp1 + temp3 + temp5).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Label3_Click(object sender, System.EventArgs e)
		{
		}

        private void Label13_Click(object sender, EventArgs e)
        {

        }
    }
}