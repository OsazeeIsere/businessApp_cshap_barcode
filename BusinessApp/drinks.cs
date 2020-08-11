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
	public partial class drinks
	{
		// if u have problem with microsoft office.interop.excel, try to remove evry reference not needed from "solution explorer" right side of top bar
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

		private void drinks_Load(object sender, System.EventArgs e)
		{
            DataTable dtidentity = new DataTable();
            dtidentity = getdatabase("Select * from identity");

            lbname.Text = dtidentity.Rows[0]["businessName"].ToString();
            lbaddress.Text = dtidentity.Rows[0]["address"].ToString();
       //    lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

            System.Data.DataTable dtgetdrinks = new System.Data.DataTable();
			dtgetdrinks = getdatabase("Select * From drinks");
			dgvdrinks.DataSource = dtgetdrinks;
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				string strconnection = "";
				int intproductid = 0;
				if (string.IsNullOrEmpty(txtquantity.Text))
				{
					MessageBox.Show("Please enter the Quantity of drinks Purchased");
				}
				else if (string.IsNullOrEmpty(txtunitprice.Text))
				{
					MessageBox.Show("Please enter the Unit price of drinks Purchased");
				}
				else if (string.IsNullOrEmpty(txtunitcostprice.Text))
				{
					MessageBox.Show("Please enter the Unit Cost price of The drinks Purchased");
				}
				else if (Simulate.IsNumeric(txtquantity.Text) && string.IsNullOrEmpty(txtproductname.Text))
				{
					strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
					cn.ConnectionString = strconnection;
					int newquantity = 0;
					System.Data.DataTable dtgetdrinks = new System.Data.DataTable();
					if (!string.IsNullOrEmpty(dgvdrinks.SelectedCells[0].Value.ToString()))
					{
						if (Simulate.IsNumeric(dgvdrinks.SelectedCells[0].Value.ToString()))
						{
							intproductid = Convert.ToInt32(dgvdrinks.SelectedCells[0].Value);
							dtgetdrinks = getdatabase("Select * From drinks where drinksid=" + intproductid);
							cn.Open();
							newquantity = Convert.ToInt32(dtgetdrinks.Rows[0]["drinksquantity"]) + Convert.ToInt32(txtquantity.Text);
							cm.CommandText = "Update drinks Set drinksquantity =" + newquantity + ",drinksunitcostprice=" + txtunitcostprice.Text + ",drinksunitsalesprice=" + txtunitprice.Text + " Where drinksid=" + intproductid + ";";
							cm.Connection = cn;
							cm.ExecuteNonQuery();
							cn.Close();
							cn.Open();
							cm.CommandText = "Insert Into drinksexpirydate(drinksname,drinksquantity,drinksunitcostprice,drinksunitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + dtgetdrinks.Rows[0]["drinksname"] + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "'," + txtamountpaid.Text + ",'" + txtinvoicenumber.Text + "')";
							cm.Connection = cn;
							cm.ExecuteNonQuery();
							cn.Close();
							cn.Open();
							cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + dtgetdrinks.Rows[0]["drinksname"] + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "'," + txtamountpaid.Text + ",'" + txtinvoicenumber.Text + "')";
							cm.Connection = cn;
							cm.ExecuteNonQuery();
							cn.Close();

							dgvdrinks.DataSource = getdatabase("Select * From drinks");
							txtquantity.Text = "";
							txtunitprice.Text = "";
							txtunitcostprice.Text = "";
							txtsuppliername.Text = "";
							txtsupplierphonenumber.Text = "";
							txtexpirydate.Text = "";
							txtinvoicenumber.Text = "";
						}
						else
						{
							MessageBox.Show("please Select The drinks ID");
						}
					}
				}
				else
				{
					//Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
					strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
					cn.ConnectionString = strconnection;
					cn.Open();
					cm.CommandText = "Insert Into drinks(drinksname,drinksquantity,drinksunitcostprice,drinksunitsalesprice) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					cn.Open();
					cm.CommandText = "Insert Into drinksexpirydate(drinksname,drinksquantity,drinksunitcostprice,drinksunitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "'," + txtamountpaid.Text + ",'" + txtinvoicenumber.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					cn.Open();
					cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "'," + txtamountpaid.Text + ",'" + txtinvoicenumber.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();

					//computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
					dgvdrinks.DataSource = getdatabase("Select * From drinks");
					txtproductname.Text = "";
					txtquantity.Text = "";
					txtunitprice.Text = "";
					txtunitcostprice.Text = "";
					txtsuppliername.Text = "";
					txtsupplierphonenumber.Text = "";
					txtexpirydate.Text = "";
					txtinvoicenumber.Text = "";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			try
			{
				int intitems = 0;
				if (!string.IsNullOrEmpty(txtitems.Text))
				{
					if (Simulate.IsNumeric(txtitems.Text))
					{
						intitems = Convert.ToInt32(txtitems.Text);
					}
					else
					{
						MessageBox.Show("please enter the TOTAL number of items to be UPLOADED");
						txtitems.Focus();
					}
				}
				else
				{
					MessageBox.Show("please enter the TOTAL number of items to be UPLOADED");

				}
				txtitems.Focus();
				if (!string.IsNullOrEmpty(txtitems.Text))
				{
					xlapp.Application APP = new xlapp.Application();
					xlapp.Worksheet worksheet = null;
					xlapp.Workbook workbook = null;

					OpenFileDialog1.ShowDialog();

					workbook = APP.Workbooks.Open(txtfile.Text);
					worksheet = (xlapp.Worksheet)workbook.Worksheets["sheet3"];

					int intproductid = 0;
					string strproductname = "";
					int intquantity = 0;
					double dblcost = 0;
					double dblprice = 0;
					DateTime expirydate = default(DateTime);

					for (var i = 2; i < 2 + intitems; i++)
					{
						intproductid = 0;
						if (!((worksheet.Cells[i, 1].Value == null)))
						{
							if (!string.IsNullOrEmpty(worksheet.Cells[i, 1].Value.ToString()))
							{
								if (Simulate.IsNumeric(worksheet.Cells[i, 1].Value.ToString()))
								{
									intproductid = Convert.ToInt32(worksheet.Cells[i, 1].Value);
								}
							}
						}
						strproductname = worksheet.Cells[i, 2].Value;
						intquantity = Convert.ToInt32(worksheet.Cells[i, 3].Value);
						dblcost = Convert.ToDouble(worksheet.Cells[i, 4].Value);
						dblprice = Convert.ToDouble(worksheet.Cells[i, 5].Value);
						expirydate = Convert.ToDateTime(worksheet.Cells[i, 6].Value);
						if (intproductid > 0)
						{

							MySqlConnection cn = new MySqlConnection();
							MySqlDataAdapter ad = new MySqlDataAdapter();
							MySqlCommand cm = new MySqlCommand();
							string strconnection = "";
							strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
							cn.ConnectionString = strconnection;
							int newquantity = 0;
							System.Data.DataTable dtgetdrinks = new System.Data.DataTable();
							dtgetdrinks = getdatabase("Select * From drinks where drinksid=" + intproductid);
							cn.Open();
							newquantity = Convert.ToInt32(dtgetdrinks.Rows[0]["drinksquantity"]) + Convert.ToInt32(intquantity);
							cm.CommandText = "Update drinks Set drinksquantity =" + newquantity + ",drinksunitcostprice=" + dblcost + ",drinksunitsalesprice=" + dblprice + " Where drinksid=" + intproductid + ";";
							cm.Connection = cn;
							cm.ExecuteNonQuery();
							cn.Close();
							dgvdrinks.DataSource = getdatabase("Select * From drinks");

						}
						else
						{
							MySqlConnection cn = new MySqlConnection();
							MySqlDataAdapter ad = new MySqlDataAdapter();
							MySqlCommand cm = new MySqlCommand();

							//Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
							string strconnection = "";
							strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
							cn.ConnectionString = strconnection;
							cn.Open();
							cm.CommandText = "Insert Into drinks(drinksname,drinksquantity,drinksunitcostprice,drinksunitsalesprice,expirydate) Values('" + strproductname + "'," + intquantity + "," + dblcost + "," + dblprice + ",'" + expirydate + "')";
							cm.Connection = cn;
							cm.ExecuteNonQuery();
							cn.Close();
							//computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
							dgvdrinks.DataSource = getdatabase("Select * From drinks");
						}
					}
					MessageBox.Show(intitems + " Records Entered Successfully");
					workbook.Save();
					workbook.Close(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
					APP.Quit();
				}
			}
			catch (Exception ex)
			{

			}
		}

		private void txtsearch_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetdrinks = new System.Data.DataTable();
				dtgetdrinks = getdatabase("Select * From drinks Where drinksname Like '%" + txtsearch.Text + "%' Order By drinksname;");
				dgvdrinks.DataSource = dtgetdrinks;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void txtfile_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			sales x = new sales();
			x.txtcashiername1.Text = txtcashiername1.Text;
			x.ShowDialog();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			viewsaleslog x = new viewsaleslog();
			x.ShowDialog();

		}

		public drinks()
		{

			// This call is required by the designer.
			InitializeComponent();

			// Add any initialization after the InitializeComponent() call.

		}

		private void Button5_Click(object sender, System.EventArgs e)
		{

		}

		private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			txtfile.Text = OpenFileDialog1.FileName;

		}

		private void Button7_Click(object sender, System.EventArgs e)
		{
			reorderleveltype x = new reorderleveltype();
			x.ShowDialog();
		}

		private void FileToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void txtunitcostprice_Click(object sender, System.EventArgs e)
		{
			txtunitcostprice.Text = (Convert.ToDouble(txtamountpaid.Text) / Convert.ToDouble(txtquantity.Text)).ToString();
		}

		private void txtunitcostprice_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Button5_Click_1(object sender, System.EventArgs e)
		{
			expirydateinfotype x = new expirydateinfotype();
			x.ShowDialog();
		}
	}
}