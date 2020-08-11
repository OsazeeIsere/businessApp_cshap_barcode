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
	public partial class reorderlevel
	{
		internal reorderlevel()
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
			System.Data.DataTable dtgetproduct = new System.Data.DataTable();
			System.Data.DataTable dtgetproduct1 = new System.Data.DataTable();
			if (string.IsNullOrEmpty(ComboBox1.Text))
			{
				MessageBox.Show("Please Select the ReOrder Level");
				ComboBox1.Focus();
			}
			else if ((ComboBox1.Text) == "Products Less Than 10 units in Stock")
			{
				dtgetproduct = getdatabase("select * from product where quantity <" + 10 + "");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetproduct.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetproduct.Rows[i]["productname"].ToString();
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Red;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
			else if ((ComboBox1.Text) == "Products Less Than 20 units in Stock")
			{
				dtgetproduct = getdatabase("select * from product where quantity <" + 20 + "");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetproduct.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetproduct.Rows[i]["productname"].ToString();
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.DeepPink;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
			else if ((ComboBox1.Text) == "Products Less Than 50 units in Stock")
			{
				dtgetproduct = getdatabase("select * from product where quantity <" + 50 + "");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetproduct.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetproduct.Rows[i]["productname"].ToString();
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Green;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
			else if ((ComboBox1.Text) == "Products Above  50 units in Stock")
			{
				dtgetproduct = getdatabase("select * from product where quantity >" + 50 + "");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetproduct.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetproduct.Rows[i]["productname"].ToString();
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Green;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}

			}
			else if ((ComboBox1.Text) == "Products Less Than 5 units in Stock")
			{
				dtgetproduct = getdatabase("select * from product where quantity <" + 5 + "");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetproduct.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetproduct.Rows[i]["productname"].ToString();
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Red;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
		}

		private void reorderlevel_Load(object sender, System.EventArgs e)
		{
            DataTable dtidentity = new DataTable();
            dtidentity = getdatabase("Select * from identity");

            lbname.Text = dtidentity.Rows[0]["businessName"].ToString();
            lbaddress.Text = dtidentity.Rows[0]["address"].ToString();
           //   lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
        }
    }
}