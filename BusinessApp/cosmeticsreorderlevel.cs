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
	public partial class cosmeticsreorderlevel
	{
		internal cosmeticsreorderlevel()
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
		private void cardsreorderlevel_Load(object sender, System.EventArgs e)
		{
            DataTable dtidentity = new DataTable();
            dtidentity = getdatabase("Select * from identity");

            txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
            txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
          //  lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

        }

        private void Button1_Click(object sender, System.EventArgs e)
		{
			System.Data.DataTable dtgetcards = new System.Data.DataTable();
			System.Data.DataTable dtgetproduct1 = new System.Data.DataTable();
			if (string.IsNullOrEmpty(ComboBox1.Text))
			{
				MessageBox.Show("Please Select the ReOrder Level");
				ComboBox1.Focus();
			}
			else if ((ComboBox1.Text) == "Products Less Than 10 units in Stock")
			{
				dtgetcards = getdatabase("select * from cosmetics where cosmeticsquantity <" + 10 + "");
				if (dtgetcards.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetcards.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetcards.Rows[i]["cosmeticsname"].ToString();
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsquantity"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsunitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["expirydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Red;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
			else if ((ComboBox1.Text) == "Products Less Than 20 units in Stock")
			{
				dtgetcards = getdatabase("select * from cosmetics where cosmeticsquantity <" + 20 + "");
				if (dtgetcards.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetcards.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetcards.Rows[i]["cosmeticsname"].ToString();
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsquantity"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsunitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["expirydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.DeepPink;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
			else if ((ComboBox1.Text) == "Products Less Than 50 units in Stock")
			{
				dtgetcards = getdatabase("select * from cosmetics where cosmeticsquantity <" + 50 + "");
				if (dtgetcards.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetcards.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetcards.Rows[i]["cosmeticsname"].ToString();
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsquantity"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsunitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["expirydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Green;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
			else if ((ComboBox1.Text) == "Products Above  50 units in Stock")
			{
				dtgetcards = getdatabase("select * from cosmetics where cosmeticsquantity >" + 50 + "");
				if (dtgetcards.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetcards.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetcards.Rows[i]["cosmeticsname"].ToString();
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsquantity"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsunitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["expirydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Green;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
			else if ((ComboBox1.Text) == "Products Less Than 5 units in Stock")
			{
				dtgetcards = getdatabase("select * from cosmetics where cosmeticsquantity <" + 5 + "");
				if (dtgetcards.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetcards.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetcards.Rows[i]["cosmeticsname"].ToString();
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsquantity"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["cosmeticsunitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[i]["expirydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					lsvitems.ForeColor = Color.Green;
					txttotal.Text = lsvitems.Items.Count.ToString();
				}
			}
		}
	}
}