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
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BusinessApp
{
    
	public partial class drugs
	{
		internal drugs()
		{
			InitializeComponent();
		}

		public int intproductid;
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
		private void Button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				System.Data.DataTable dtgetproduct1 = new System.Data.DataTable();
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				string strconnection = "";
				int intproductid = 0;
				if (string.IsNullOrEmpty(txtquantity.Text))
				{
					MessageBox.Show("Please enter the Quantity of Product Purchased");
				}
				else if (string.IsNullOrEmpty(txtexpirydate.Text))
				{
					MessageBox.Show("Please enter the Expiry Date of the Drugs Purchased");
				}
				else if (string.IsNullOrEmpty(txtunitprice.Text))
				{
					MessageBox.Show("Please enter the Unit price of Product Purchased");

				}
                else if (string.IsNullOrEmpty(txtamountpaid.Text))
                {
                    MessageBox.Show("Please enter the Amount Paid for The Product Purchased");
                }
                
				else if (string.IsNullOrEmpty(txtunitcostprice.Text))
				{
					MessageBox.Show("Please enter the Unit Cost price of The Product Purchased");
				}
				else if (Simulate.IsNumeric(txtquantity.Text) && !string.IsNullOrEmpty(txtproductid.Text))
				{
					strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
					cn.ConnectionString = strconnection;
					int newquantity = 0;
					intproductid = Convert.ToInt32(txtproductid .Text );
					dtgetproduct = getdatabase("Select * From product where productid=" + intproductid);
					cn.Open();
					newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) + Convert.ToInt32(txtquantity.Text);
					cm.CommandText = "Update product Set productname='" + txtproductname.Text + "',quantity =" + newquantity + ",unitcostprice=" + txtunitcostprice.Text + ",unitsalesprice=" + txtunitprice.Text + ",barcode='"+ txtcode2.Text + "',expirydate='" + txtexpirydate.Text + "' Where productid=" + intproductid + ";";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					cn.Close();
					cn.Open();
					cm.CommandText = "Insert Into expirydate(productid,productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + dtgetproduct.Rows[0]["productid"] + "','" + dtgetproduct.Rows[0]["productname"] + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "','" + txtamountpaid.Text + "','" + txtinvoicenumber.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					cn.Open();
					cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + dtgetproduct.Rows[0]["productname"] + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "','" + txtamountpaid.Text + "','" + txtinvoicenumber.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
					if (dtgetproduct.Rows.Count > 0)
					{
						ListViewItem lstitem = new ListViewItem();
						lsvitems.Items.Clear();
						for (var j = 0; j < dtgetproduct.Rows.Count; j++)
						{
							lstitem = new ListViewItem();
							lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
							lsvitems.Items.Add(lstitem);
						}
					}
					txtquantity.Text = "";
					txtunitprice.Text = "";
					txtunitcostprice.Text = "";
					txtexpirydate.Text = "";
					txtsuppliername.Text = "";
					txtdatepurchased.Text = "";
					txtamountpaid.Text = "";
					txtinvoicenumber.Text = "";
					txtsupplierphonenumber.Text = "";
					txtproductid.Text = "";
					txtproductname .Text = "";
                    txtcode2.Text = "";
                    txtcode2.Focus();
				}
				else
				{
                    //Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
                    DataTable dtgetproduct2 = new DataTable();
					strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
					cn.ConnectionString = strconnection;
					cn.Open();
					cm.CommandText = "Insert Into product(productname,quantity,unitcostprice,unitsalesprice,barcode,expirydate) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','"+ txtcode2 .Text +"','" + txtexpirydate.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					//dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product")
					//dtgetproduct1 = getdatabase("Select productid from product");
					//dtgetproduct2 = getdatabase("Select productid From product where productid=" + dtgetproduct1.Rows.Count);
					//string productname = null;
					//productname = dtgetproduct.Rows[0]["productname"].ToString();
					//dtgetproduct1 = getdatabase("Select productid from product where productname=" + dtgetproduct.Rows[0]["productname"]);
					cn.Open();
					cm.CommandText = "Insert Into expirydate(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "'," + txtamountpaid.Text + ",'" + txtinvoicenumber.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					cn.Open();
					cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "'," + txtamountpaid.Text + ",'" + txtinvoicenumber.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();

					//computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
					dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
					if (dtgetproduct.Rows.Count > 0)
					{
						ListViewItem lstitem = new ListViewItem();
						lsvitems.Items.Clear();
						for (var j = 0; j < dtgetproduct.Rows.Count; j++)
						{
							lstitem = new ListViewItem();
							lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
							lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
							lsvitems.Items.Add(lstitem);
						}
						txttotal.Text = dtgetproduct.Rows.Count.ToString();
					}
					txtproductname.Text = "";
					txtquantity.Text = "";
					txtunitprice.Text = "";
					txtunitcostprice.Text = "";
					txtexpirydate.Text = "";
					txtsuppliername.Text = "";
					txtdatepurchased.Text = "";
					txtamountpaid.Text = "";
					txtinvoicenumber.Text = "";
					txtsupplierphonenumber.Text = "";
                    txtcode2.Text = "";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
            txtcode2.Focus();
		}

		private void product_Load(object sender, System.EventArgs e)
		{
            DataTable dtidentity = new DataTable();
            dtidentity = getdatabase("Select * from identity");
            salesAnalysisToolStripMenuItem.Visible = false;
            txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
            txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
     //       lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

            System.Data.DataTable dtgetproduct = new System.Data.DataTable();
			dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
			if (dtgetproduct.Rows.Count > 0)
			{
				ListViewItem lstitem = new ListViewItem();
				lsvitems.Items.Clear();
				for (var j = 0; j < dtgetproduct.Rows.Count; j++)
				{
					lstitem = new ListViewItem();
					lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
					lsvitems.Items.Add(lstitem);
				}
				txttotal.Text = dtgetproduct.Rows.Count.ToString();
               
			}
            txtcode2.Focus();
            
        }

		private void Button2_Click(object sender, System.EventArgs e)
		{

		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			sales x = new sales();
			x.txtcashiername1.Text = txtcashiername1.Text;
			x.Show();
		}

		private void Button2_Click_1(object sender, System.EventArgs e)
		{
			viewsaleslog x = new viewsaleslog();
			x.Show();

		}

		private void dgvdrugs_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{

		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				int intitems = 0;
				if (!string.IsNullOrEmpty(txtitems.Text))
				{
					if (Simulate.IsNumeric(txtitems.Text))
					{
						intitems = Convert.ToInt32(txtitems.Text);
						xlapp.Application APP = new xlapp.Application();
						xlapp.Worksheet worksheet = null;
						xlapp.Workbook workbook = null;
						OpenFileDialog1.ShowDialog();
						workbook = APP.Workbooks.Open(txtfile.Text);
						worksheet = (xlapp.Worksheet)workbook.Worksheets["sheet1"];
						int intproductid = 0;
						string strproductname = "";
						int intquantity = 0;
						double dblcost = 0;
						double dblprice = 0;
						string expirydate, barcode;
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
							expirydate =Convert.ToString(worksheet.Cells[i, 6].Value);
                            expirydate = Convert.ToDateTime(expirydate).ToShortDateString();
                            barcode = Convert.ToString(worksheet.Cells[i, 7].Value);
							if (intproductid > 0)
							{
								MySqlConnection cn = new MySqlConnection();
								MySqlDataAdapter ad = new MySqlDataAdapter();
								MySqlCommand cm = new MySqlCommand();
								string strconnection = "";
								strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
								cn.ConnectionString = strconnection;
								int newquantity = 0;
								dtgetproduct = getdatabase("Select * From product where productid=" + intproductid);
								cn.Open();
								newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) + Convert.ToInt32(intquantity);
								cm.CommandText = "Update product Set quantity =" + newquantity + ",unitcostprice=" + dblcost + ",unitsalesprice=" + dblprice + ",expirydate='" + expirydate + "',barcode='" + barcode+ "' Where productid=" + intproductid + ";";
								cm.Connection = cn;
								cm.ExecuteNonQuery();
								cn.Close();
								dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
								if (dtgetproduct.Rows.Count > 0)
								{
									ListViewItem lstitem = new ListViewItem();
									lsvitems.Items.Clear();
									for (var j = 0; j < dtgetproduct.Rows.Count; j++)
									{
										lstitem = new ListViewItem();
										lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
										lsvitems.Items.Add(lstitem);
									}
								}
								txttotal.Text = dtgetproduct.Rows.Count.ToString();
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
								cm.CommandText = "Insert Into product(productname,quantity,unitcostprice,unitsalesprice,expirydate,barcode) Values('" + strproductname + "'," + intquantity + "," + dblcost + "," + dblprice + ",'" + expirydate + "','" + barcode + "')";
								cm.Connection = cn;
								cm.ExecuteNonQuery();
								cn.Close();
								//computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
								dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
								if (dtgetproduct.Rows.Count > 0)
								{
									ListViewItem lstitem = new ListViewItem();
									lsvitems.Items.Clear();
									for (var j = 0; j < dtgetproduct.Rows.Count; j++)
									{
										lstitem = new ListViewItem();
										lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
										lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
										lsvitems.Items.Add(lstitem);
									}
								}
							}
							txttotal.Text = dtgetproduct.Rows.Count.ToString();
						}
						MessageBox.Show(intitems + " Records Entered Successfully");
						workbook.Save();
						workbook.Close(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
						APP.Quit();
						txtfile.Text = "";
						txtitems.Text = "";
					}
					else
					{
						MessageBox.Show("please enter a Value");
						txtitems.Focus();
					}
				}
				else
				{
					MessageBox.Show("please enter the TOTAL number of items to be UPLOADED");
					txtitems.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			txtfile.Text = OpenFileDialog1.FileName;
		}

		private void btnsearch_Click(object sender, System.EventArgs e)
		{

		}

		private void txtsearch_QueryContinueDrag(object sender, System.Windows.Forms.QueryContinueDragEventArgs e)
		{

			try
			{
				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				dtgetproduct = getdatabase("Select * From product Where productname Like '%" + txtsearch.Text + "%' Order By productname;");
				dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var j = 0; j < dtgetproduct.Rows.Count; j++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
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

		private void txtsearch_TextChanged(object sender, System.EventArgs e)
		{
			try
			{

				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				dtgetproduct = getdatabase("Select * From product Where productname Like '%" + txtsearch.Text + "%' Order By productname;");

				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var j = 0; j < dtgetproduct.Rows.Count; j++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
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

		private void Label8_Click(object sender, System.EventArgs e)
		{

		}

		private void txtitems_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void txtfile_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void SaveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void Button5_Click(object sender, System.EventArgs e)
		{


		}

		private void PictureBox1_Click(object sender, System.EventArgs e)
		{

		}

		private void Button6_Click(object sender, System.EventArgs e)
		{
			expirydateinfotype x = new expirydateinfotype();
			x.Show();
		}

		private void Button7_Click(object sender, System.EventArgs e)
		{
			reorderleveltype x = new reorderleveltype();
			x.Show();
		}

		private void txtamountpaid_TextAlignChanged(object sender, System.EventArgs e)
		{

		}

		private void txtamountpaid_TextChanged(object sender, System.EventArgs e)
		{
		}

		private void txtunitcostprice_Click(object sender, System.EventArgs e)
		{
			txtunitcostprice.Text = (Convert.ToDouble(txtamountpaid.Text) / Convert.ToDouble(txtquantity.Text)).ToString();
		}

		private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void txtunitcostprice_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Button8_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetadmin = new System.Data.DataTable();
				dtgetadmin = getdatabase("Select * from administrator");
				if (dtgetadmin.Rows.Count > 0)
				{
					for (var i = 0; i < dtgetadmin.Rows.Count; i++)
					{
						if (txtadminpassword.Text == (dtgetadmin.Rows[i]["adminpassword"]).ToString())
						{
							adminsales x = new adminsales();
							x.txtcashiername1.Text = txtcashiername1.Text;
							x.ShowDialog();
						}
						else if (txtcashiername1.Text.ToUpper() == Convert.ToString(dtgetadmin.Rows[i]["adminname"]).ToUpper())
						{
							adminsales x = new adminsales();
							x.txtcashiername1.Text = txtcashiername1.Text;
							x.Show();
						}
						else
						{
							MessageBox.Show("Please Look For The Administrator");
							txtadminpassword.Focus();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button9_Click(object sender, System.EventArgs e)
		{
			try
			{
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				string strconnection = "";
				int intproductid = 0;
				strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
				intproductid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
				dtgetproduct = getdatabase("Select * From product where productid=" + intproductid);
				//dtgetexpirydate = getdatabase("Select * From expirydate where productid=" & intproductid)
				cn.Open();
				delet x = new delet();
				x.txtproductid.Text = intproductid.ToString();
				x.txtproductname.Text = (dtgetproduct.Rows[0]["productname"]).ToString();
				x.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}

		private void lsvitems_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
				if (Simulate.IsNumeric(Convert.ToInt32(lsvitems.SelectedItems[0].Text)))
				{
					intproductid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
					//Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
					dtgetsales = getdatabase(" select * from product where productid=" + intproductid);
					txtproductid.Text = Convert.ToDouble(dtgetsales.Rows[0]["productid"]).ToString();
					txtproductname.Text = Convert.ToString(dtgetsales.Rows[0]["productname"]);
					txtquantity.Text = Convert.ToString(dtgetsales.Rows[0]["quantity"]);
					//txtamountpaid.Text = CStr(dtgetexpirydate.Rows(0).Item("amountpaid"))
					txtunitcostprice.Text = Convert.ToString(dtgetsales.Rows[0]["unitcostprice"]);
					txtunitprice.Text = Convert.ToString(dtgetsales.Rows[0]["unitsalesprice"]);
					txtexpirydate.Text = (dtgetsales.Rows[0]["expirydate"]).ToString();
					//txtsuppliername.Text = CStr(dtgetexpirydate.Rows(0).Item("suppliername"))
					//txtsupplierphonenumber.Text = CStr(dtgetexpirydate.Rows(0).Item("supplierphonenumber"))
					//txtdatepurchased.Text = CStr(dtgetexpirydate.Rows(0).Item("datepurchased"))
					//txtinvoicenumber .Text = CStr(dtgetexpirydate .Rows(0).Item(""))
					intproductid = Convert.ToInt32(txtproductid.Text);
				}
				else
				{
					MessageBox.Show("Please Select The ProductID");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void lsvitems_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}

		private void drugs_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Data.DataTable dtgetproduct = new System.Data.DataTable();
			dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
			if (dtgetproduct.Rows.Count > 0)
			{
				ListViewItem lstitem = new ListViewItem();
				lsvitems.Items.Clear();
				for (var j = 0; j < dtgetproduct.Rows.Count; j++)
				{
					lstitem = new ListViewItem();
					lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
					lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
					lsvitems.Items.Add(lstitem);
				}
				txttotal.Text = dtgetproduct.Rows.Count.ToString();
			}
		}

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcode2_TextChanged(object sender, EventArgs e)
        {
            try
            {


                    System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                    dtgetproduct = getdatabase("Select * From product Where barcode Like '%" + txtcode2.Text + "%' Order By productname;");

                    if (dtgetproduct.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
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

        private void txtcode2_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtcode2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //try
            //{
            //    MySqlConnection cn = new MySqlConnection();
            //    MySqlDataAdapter ad = new MySqlDataAdapter();
            //    MySqlCommand cm = new MySqlCommand();
            //    System.Data.DataTable dtgetproduct = new System.Data.DataTable();
            //    System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
            //    //dtgetproduct = getdatabase("Select * From product Where barcode Like '%" + txtcode2.Text + "%' Order By productname;");

            //    dtgetproduct = getdatabase(" select * from product where barcode=" + txtcode2.Text.ToString());

            //    if (dtgetproduct.Rows.Count > 0)
            //    {
            //        //intproductid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
            //        //Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
            //        //dtgetproduct = getdatabase(" select * from product where productid=" + intproductid);
            //        txtproductid.Text = Convert.ToDouble(dtgetproduct.Rows[0]["productid"]).ToString();
            //        txtproductname.Text = Convert.ToString(dtgetproduct.Rows[0]["productname"]);
            //        txtquantity.Text = Convert.ToString(dtgetproduct.Rows[0]["quantity"]);
            //        //txtamountpaid.Text = CStr(dtgetexpirydate.Rows(0).Item("amountpaid"))
            //        txtunitcostprice.Text = Convert.ToString(dtgetproduct.Rows[0]["unitcostprice"]);
            //        txtunitprice.Text = Convert.ToString(dtgetproduct.Rows[0]["unitsalesprice"]);
            //        txtexpirydate.Text = (dtgetproduct.Rows[0]["expirydate"]).ToString();
            //        // populate the listview
            //        ListViewItem lstitem = new ListViewItem();
            //        lsvitems.Items.Clear();
            //        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
            //        {
            //            lstitem = new ListViewItem();
            //            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
            //            lsvitems.Items.Add(lstitem);
            //        }

            //    }
            //    else
            //    {
            //        if (string.IsNullOrEmpty(txtquantity.Text))
            //        {
            //            MessageBox.Show("Please enter the Quantity of Product Purchased");
            //            txtquantity.Focus();
            //        }
            //        else if (string.IsNullOrEmpty(txtexpirydate.Text))
            //        {
            //            MessageBox.Show("Please enter the Expiry Date of the Drugs Purchased");
            //            txtexpirydate.Focus();
            //        }
            //        else if (string.IsNullOrEmpty(txtunitprice.Text))
            //        {
            //            MessageBox.Show("Please enter the Unit price of Product Purchased");
            //            txtunitprice.Focus();
            //        }
            //        else if (string.IsNullOrEmpty(txtunitcostprice.Text))
            //        {
            //            MessageBox.Show("Please enter the Unit Cost price of The Product Purchased");
            //            txtunitcostprice.Focus();
            //        }
            //        //Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
            //        //txtcode2.Focus();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void txtcode2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void txtcode2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    MySqlConnection cn = new MySqlConnection();
            //    MySqlDataAdapter ad = new MySqlDataAdapter();
            //    MySqlCommand cm = new MySqlCommand();
            //    System.Data.DataTable dtgetproduct = new System.Data.DataTable();
            //    System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
            //    //dtgetproduct = getdatabase("Select * From product Where barcode Like '%" + txtcode2.Text + "%' Order By productname;");

            //    dtgetproduct = getdatabase(" select * from product where barcode=" + txtcode2.Text.ToString());

            //    if (dtgetproduct.Rows.Count > 0)
            //    {
            //        //intproductid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
            //        //Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
            //        //dtgetproduct = getdatabase(" select * from product where productid=" + intproductid);
            //        txtproductid.Text = Convert.ToDouble(dtgetproduct.Rows[0]["productid"]).ToString();
            //        txtproductname.Text = Convert.ToString(dtgetproduct.Rows[0]["productname"]);
            //        txtquantity.Text = Convert.ToString(dtgetproduct.Rows[0]["quantity"]);
            //        //txtamountpaid.Text = CStr(dtgetexpirydate.Rows(0).Item("amountpaid"))
            //        txtunitcostprice.Text = Convert.ToString(dtgetproduct.Rows[0]["unitcostprice"]);
            //        txtunitprice.Text = Convert.ToString(dtgetproduct.Rows[0]["unitsalesprice"]);
            //        txtexpirydate.Text = (dtgetproduct.Rows[0]["expirydate"]).ToString();
            //        // populate the listview
            //        ListViewItem lstitem = new ListViewItem();
            //        lsvitems.Items.Clear();
            //        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
            //        {
            //            lstitem = new ListViewItem();
            //            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
            //            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
            //            lsvitems.Items.Add(lstitem);
            //        }

            //    }
            //    else
            //    {
            //        if (string.IsNullOrEmpty(txtquantity.Text))
            //        {
            //            MessageBox.Show("Please enter the Quantity of Product Purchased");
            //            txtquantity.Focus();
            //        }
            //        else if (string.IsNullOrEmpty(txtexpirydate.Text))
            //        {
            //            MessageBox.Show("Please enter the Expiry Date of the Drugs Purchased");
            //            txtexpirydate.Focus();
            //        }
            //        else if (string.IsNullOrEmpty(txtunitprice.Text))
            //        {
            //            MessageBox.Show("Please enter the Unit price of Product Purchased");
            //            txtunitprice.Focus();
            //        }
            //        else if (string.IsNullOrEmpty(txtunitcostprice.Text))
            //        {
            //            MessageBox.Show("Please enter the Unit Cost price of The Product Purchased");
            //            txtunitcostprice.Focus();
            //        }
            //        //Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
            //        //txtcode2.Focus();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void drugs_Enter(object sender, EventArgs e)
        {
            txtcode2.Focus();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                //dtgetproduct = getdatabase("Select * From product Where barcode Like '%" + txtcode2.Text + "%' Order By productname;");

                dtgetproduct = getdatabase(" select * from product where barcode=" + txtcode2.Text.ToString());

                if (dtgetproduct.Rows.Count > 0)
                {
                    //intproductid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
                    //Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
                    //dtgetproduct = getdatabase(" select * from product where productid=" + intproductid);
                    txtproductid.Text = Convert.ToDouble(dtgetproduct.Rows[0]["productid"]).ToString();
                    txtproductname.Text = Convert.ToString(dtgetproduct.Rows[0]["productname"]);
                    txtquantity.Text = Convert.ToString(dtgetproduct.Rows[0]["quantity"]);
                    //txtamountpaid.Text = CStr(dtgetexpirydate.Rows(0).Item("amountpaid"))
                    txtunitcostprice.Text = Convert.ToString(dtgetproduct.Rows[0]["unitcostprice"]);
                    txtunitprice.Text = Convert.ToString(dtgetproduct.Rows[0]["unitsalesprice"]);
                    txtexpirydate.Text = (dtgetproduct.Rows[0]["expirydate"]).ToString();
                    // populate the listview
                    ListViewItem lstitem = new ListViewItem();
                    lsvitems.Items.Clear();
                    for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                    {
                        lstitem = new ListViewItem();
                        lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                        lsvitems.Items.Add(lstitem);
                    }

                }
                else
                {
                    if (string.IsNullOrEmpty(txtquantity.Text))
                    {
                        MessageBox.Show("Please enter the Quantity of Product Purchased");
                        txtquantity.Focus();
                    }
                    else if (string.IsNullOrEmpty(txtexpirydate.Text))
                    {
                        MessageBox.Show("Please enter the Expiry Date of the Drugs Purchased");
                        txtexpirydate.Focus();
                    }
                    else if (string.IsNullOrEmpty(txtunitprice.Text))
                    {
                        MessageBox.Show("Please enter the Unit price of Product Purchased");
                        txtunitprice.Focus();
                    }
                    else if (string.IsNullOrEmpty(txtunitcostprice.Text))
                    {
                        MessageBox.Show("Please enter the Unit Cost price of The Product Purchased");
                        txtunitcostprice.Focus();
                    }
                    //Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
                    //txtcode2.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtexpirydate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})");
            Match m = reg.Match(txtexpirydate.Text);
            if (m.Success)
            {
                int mm = int.Parse(m.Groups[1].Value);
                int dd = int.Parse(m.Groups[2].Value);
                int yyyy = int.Parse(m.Groups[3].Value);
                e.Cancel = mm < 1 || mm > 12 || dd < 1 || dd > 31 || yyyy < 2019;
            }
            else e.Cancel = true;
            if (e.Cancel)
            {
                if (MessageBox.Show("Wrong date format. The correct format is mm/dd/yyyy\n+ mm should be between 1 and 12\n+ dd should be between 1 and 31.\n+ yyyy should be after 2019", "Invalid date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    e.Cancel = false;
            }

        }

        private void txtexpirydate_TextChanged(object sender, EventArgs e)
        {

        }

        private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            
            MySqlConnection cnn;
            string connectionString = null;
            string sql = null;
            string data = null;
            string column = null;
            int i = 0;
            int j = 0;
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
          //  xlWorkBook.SaveAs(ReadOnlyRecommended: true);
                connectionString = "Server=localhost;Port=3306;Database=businessdatabase;Uid=root;Pwd=prayer";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * FROM Product";
            MySqlDataAdapter dscmd = new MySqlDataAdapter(sql, cnn);
            DataTable ds = new DataTable();
            dscmd.Fill(ds);
            // DataColumn dc = new DataColumn();
            xlWorkSheet.Cells[1,1] ="Products DataBase As At "+ DateTimePicker1.Value.ToLongDateString();

            for (j = 0; j <= ds.Columns.Count - 1; j++)
            {
                // data = ds.Rows[i].ItemArray[j].ToString();
                column = ds.Columns[j].ColumnName.ToString();

                xlWorkSheet.Cells[2, j + 1] = column;
            }
            for (i = 0; i <= ds.Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Columns.Count - 1; j++)
                {
                    data = ds.Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 3, j + 1] = data;
                }
            }
            // workbook = APP.Workbooks.Open(txtfile.Text);
            saveFileDialog1.ShowDialog();
                // FileStream Fs = new FileStream(txtfile1.ToString(), FileMode.Create, FileAccess.Read);
             xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\"+ txtfile1.Text);
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }
            }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void saveFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            txtfile1.Text = saveFileDialog1.FileName+".xls";
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
           
        }

        private void reprintReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReprintReceipt x = new ReprintReceipt();
            x.txtcashiername1.Text = txtcashiername1.Text;
            x.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Analysis x = new Sales_Analysis();
            x.Show();
        }

        private void txtproductname_TextChanged(object sender, EventArgs e)
        {
            try
            {

                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = getdatabase("Select * From product Where productname Like '%" + txtproductname.Text + "%' Order By productname;");

                if (dtgetproduct.Rows.Count > 0)
                {
                    ListViewItem lstitem = new ListViewItem();
                    lsvitems.Items.Clear();
                    for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                    {
                        lstitem = new ListViewItem();
                        lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
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
