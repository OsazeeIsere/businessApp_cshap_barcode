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
	public partial class drinksreorderlevel
	{
		internal drinksreorderlevel()
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
			System.Data.DataTable dtgetdrinks = new System.Data.DataTable();
			System.Data.DataTable dtgetproduct1 = new System.Data.DataTable();
			if (string.IsNullOrEmpty(ComboBox1.Text))
			{
				MessageBox.Show("Please Select the ReOrder Level");
				ComboBox1.Focus();
			}
			else if ((ComboBox1.Text) == "Products Less Than 10 units in Stock")
			{
				dtgetdrinks = getdatabase("select * from drinks where drinksquantity <" + 10 + "");
				if (dtgetdrinks.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetdrinks.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetdrinks.Rows[i]["drinksname"].ToString();
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksquantity"].ToString());
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksunitsalesprice"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Red;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
			else if ((ComboBox1.Text) == "Products Less Than 20 units in Stock")
			{
				dtgetdrinks = getdatabase("select * from drinks where drinksquantity <" + 20 + "");
				if (dtgetdrinks.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetdrinks.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetdrinks.Rows[i]["drinksname"].ToString();
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksquantity"].ToString());
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksunitsalesprice"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.DeepPink;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
			else if ((ComboBox1.Text) == "Products Less Than 50 units in Stock")
			{
				dtgetdrinks = getdatabase("select * from drinks where drinksquantity <" + 50 + "");
				if (dtgetdrinks.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetdrinks.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetdrinks.Rows[i]["drinksname"].ToString();
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksquantity"].ToString());
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksunitsalesprice"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Green;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
				txttotal.Text = lsvitems.Items.Count.ToString();
			}
			else if ((ComboBox1.Text) == "Products Above  50 units in Stock")
			{
				dtgetdrinks = getdatabase("select * from drinks where drinksquantity >" + 50 + "");
				if (dtgetdrinks.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetdrinks.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetdrinks.Rows[i]["drinksname"].ToString();
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksquantity"].ToString());
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksunitsalesprice"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Green;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}

			}
			else if ((ComboBox1.Text) == "Products Less Than 5 units in Stock")
			{
				dtgetdrinks = getdatabase("select * from drinks where drinksquantity <" + 5 + "");
				if (dtgetdrinks.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetdrinks.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetdrinks.Rows[i]["drinksname"].ToString();
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksquantity"].ToString());
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetdrinks.Rows[i]["drinksunitsalesprice"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Green;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
		}
		private void drinksreorderlevel_Load(object sender, System.EventArgs e)
		{
            DataTable dtidentity = new DataTable();
            dtidentity = getdatabase("Select * from identity");

            txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
            txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
          //  lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

        }

        private void DateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{

		}

		private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}

		private void lsvitems_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}

		private void Label6_Click(object sender, System.EventArgs e)
		{

		}

		private void Label1_Click(object sender, System.EventArgs e)
		{

		}

		private void Label5_Click(object sender, System.EventArgs e)
		{

		}
	}
}