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
using xlapp = Microsoft.Office.Interop.Excel;

namespace BusinessApp
{
	public partial class purchasehistory
	{
		internal purchasehistory()
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
		private void purchasehistory_Load(object sender, System.EventArgs e)
		{
			try
			{
				// Use TimeSpan and some date calculaton, this should work:

				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				dtgetproduct = getdatabase("Select * From purchasehistory order by productid");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var j = 0; j < dtgetproduct.Rows.Count; j++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetproduct.Rows[j]["productname"].ToString();
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["amountpaid"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					txttotal.Text = dtgetproduct.Rows.Count.ToString();
				}
			}
			catch (Exception ex)
			{
			}

		}

		private void check_Click(object sender, System.EventArgs e)
		{
			action v = new action();
			v.Show();
		}

		private void purchasehistory_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//txttotal.Text = ""
			//lsvitems.Clear()

		}

		private void txtsearch_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				dtgetproduct = getdatabase("Select * From purchasehistory Where productname Like '%" + txtsearch.Text + "%' Order By productname;");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var j = 0; j < dtgetproduct.Rows.Count; j++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetproduct.Rows[j]["productname"].ToString();
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["amountpaid"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					txttotal.Text = dtgetproduct.Rows.Count.ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}