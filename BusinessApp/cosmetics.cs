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
using System.IO;
using MySql.Data.MySqlClient;
using xlapp = Microsoft.Office.Interop.Excel;
namespace BusinessApp
{
	public partial class cosmetics
	{
		internal cosmetics()
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
		private void txtsearch_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
				dtgetcosmetics = getdatabase("Select * From cosmetics Where cosmeticsname Like '%" + txtsearch.Text + "%' Order By cosmeticsname;");
				if (dtgetcosmetics.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems1.Items.Clear();
					for (var j = 0; j < dtgetcosmetics.Rows.Count; j++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetcosmetics.Rows[j]["cosmeticsid"].ToString();
						lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsname"].ToString());
						lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsquantity"].ToString());
						lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["expirydate"].ToString());
						lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["entrydate"].ToString());
						lsvitems1.Items.Add(lstitem);
					}
				}
				txttotal.Text = dtgetcosmetics.Rows.Count.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
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
					MessageBox.Show("Please enter the Quantity of Products Purchased");

				}
				else if (string.IsNullOrEmpty(txtunitprice.Text))
				{
					MessageBox.Show("Please enter the Unit price of Products Purchased");
				}
				else if (string.IsNullOrEmpty(txtunitcostprice.Text))
				{
					MessageBox.Show("Please enter the Unit Cost price of The Products Purchased");
				}
				else if (Simulate.IsNumeric(txtquantity.Text) && !string.IsNullOrEmpty(txtproductid.Text))
				{
					strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
					cn.ConnectionString = strconnection;
					int newquantity = 0;
					System.Data.DataTable dtgetcards = new System.Data.DataTable();
					if (!string.IsNullOrEmpty(lsvitems1.SelectedItems[0].Text))
					{
						intproductid = Convert.ToInt32(lsvitems1.SelectedItems[0].Text);
						dtgetcards = getdatabase("Select * From cosmetics where cosmeticsid=" + intproductid);
						cn.Open();
						newquantity = Convert.ToInt32(dtgetcards.Rows[0]["cosmeticsquantity"]) + Convert.ToInt32(txtquantity.Text);
						cm.CommandText = "Update cosmetics Set cosmeticsname='" + txtproductname.Text + "',cosmeticsquantity =" + newquantity + ",cosmeticsunitcostprice=" + txtunitcostprice.Text + ",cosmeticsunitsalesprice=" + txtunitprice.Text + ",barcode=" + txtcode .Text +",expirydate=" + txtexpirydate .Text + " Where cosmeticsid=" + intproductid + ";";
						cm.Connection = cn;
						cm.ExecuteNonQuery();
						cn.Close();
						cn.Open();
						cm.CommandText = "Insert Into cosmeticsexpirydate(cosmeticsid,cosmeticsname,cosmeticsquantity,cosmeticsunitcostprice,cosmeticsunitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + dtgetcards.Rows[0]["cosmeticsid"] + "','" + dtgetcards.Rows[0]["cosmeticsname"] + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "','" + txtamountpaid.Text + "','" + txtinvoicenumber.Text + "')";
						cm.Connection = cn;
						cm.ExecuteNonQuery();
						cn.Close();
						cn.Open();
						cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + dtgetcards.Rows[0]["cosmeticsname"] + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "','" + txtamountpaid.Text + "','" + txtinvoicenumber.Text + "')";
						cm.Connection = cn;
						cm.ExecuteNonQuery();
						cn.Close();
						System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
						dtgetcosmetics = getdatabase("Select * From cosmetics order by cosmeticsname");
						if (dtgetcosmetics.Rows.Count > 0)
						{
							ListViewItem lstitem = new ListViewItem();
							lsvitems1.Items.Clear();
							for (var j = 0; j < dtgetcosmetics.Rows.Count; j++)
							{
								lstitem = new ListViewItem();
								lstitem.Text = dtgetcosmetics.Rows[j]["cosmeticsid"].ToString();
								lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsname"].ToString());
								lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsquantity"].ToString());
								lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitsalesprice"].ToString());
								lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitcostprice"].ToString());
								lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["expirydate"].ToString());
								lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["entrydate"].ToString());
								lsvitems1.Items.Add(lstitem);
							}
							txttotal.Text = dtgetcosmetics.Rows.Count.ToString();
						}
						txtquantity.Text = "";
						txtunitprice.Text = "";
						txtunitcostprice.Text = "";
						txtsuppliername.Text = "";
						txtsupplierphonenumber.Text = "";
						txtexpirydate.Text = "";
						txtamountpaid.Text = "";
						txtinvoicenumber.Text = "";
						txtproductname.Text = "";
						txtproductid.Text = "";
					}
					else
					{
						MessageBox.Show("please Select The Product");
					}
				}
				else
				{
					//Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
					strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
					cn.ConnectionString = strconnection;
					cn.Open();
					cm.CommandText = "Insert Into cosmetics(cosmeticsname,cosmeticsquantity,cosmeticsunitcostprice,cosmeticsunitsalesprice) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
					dtgetcosmetics = getdatabase("Select * From cosmetics order by cosmeticsname");
					cn.Open();
					cm.CommandText = "Insert Into cosmeticsexpirydate(cosmeticsname,cosmeticsquantity,cosmeticsunitcostprice,cosmeticsunitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "'," + txtamountpaid.Text + ",'" + txtinvoicenumber.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					cn.Open();
					cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "'," + txtamountpaid.Text + ",'" + txtinvoicenumber.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();

					//computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
					dtgetcosmetics = getdatabase("Select * From cosmetics order by cosmeticsname");
					if (dtgetcosmetics.Rows.Count > 0)
					{
						ListViewItem lstitem = new ListViewItem();
						lsvitems1.Items.Clear();
						for (var j = 0; j < dtgetcosmetics.Rows.Count; j++)
						{
							lstitem = new ListViewItem();
							lstitem.Text = dtgetcosmetics.Rows[j]["cosmeticsid"].ToString();
							lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsname"].ToString());
							lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsquantity"].ToString());
							lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitsalesprice"].ToString());
							lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitcostprice"].ToString());
							lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["expirydate"].ToString());
							lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["entrydate"].ToString());
							lsvitems1.Items.Add(lstitem);
						}
					}
					txttotal.Text = dtgetcosmetics.Rows.Count.ToString();
					txtproductname.Text = "";
					txtquantity.Text = "";
					txtunitprice.Text = "";
					txtunitcostprice.Text = "";
					txtsuppliername.Text = "";
					txtsupplierphonenumber.Text = "";
					txtexpirydate.Text = "";
					txtamountpaid.Text = "";
					txtinvoicenumber.Text = "";
					txtdatepurchased.Text = "";
                    txtcode.Text = "";
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
						xlapp.Application APP = new xlapp.Application();
						xlapp.Worksheet worksheet = null;
						xlapp.Workbook workbook = null;
						OpenFileDialog1.ShowDialog();
						workbook = APP.Workbooks.Open(txtfile.Text);
						worksheet = (xlapp.Worksheet)workbook.Worksheets["sheet2"];
						int intproductid = 0;
						string strproductname = "";
						int intquantity = 0;
						double dblcost = 0;
						double dblprice = 0;
						DateTime expirydate = default(DateTime);
						for (var i = 2; i < 2 + intitems; i++)
						{
							intproductid = 0;
							if (!(worksheet.Cells[i, 1].Value == null))
							{
								if (!string.IsNullOrEmpty(worksheet.Cells[i, 1].Value.ToString()))
								{
									if (Simulate.IsNumeric(worksheet.Cells[i, 1].Value.ToString()))
									{
										intproductid = Convert.ToInt32(worksheet.Cells[i, 1].Value);
									}
                                  //  worksheet.Cells[i, 1].Value.ToString())
								}
							}
							strproductname = worksheet.Cells[i, 2].Value;
							intquantity = Convert.ToInt32(worksheet.Cells[i, 3].Value);
							dblcost = Convert.ToDouble(worksheet.Cells[i, 4].Value);
							dblprice = Convert.ToDouble(worksheet.Cells[i, 5].Value);
							expirydate = (worksheet.Cells[i, 6].Value);
							if (intproductid > 0)
							{

								MySqlConnection cn = new MySqlConnection();
								MySqlDataAdapter ad = new MySqlDataAdapter();
								MySqlCommand cm = new MySqlCommand();
								string strconnection = "";
								strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
								cn.ConnectionString = strconnection;
								int newquantity = 0;
								System.Data.DataTable dtgetcards = new System.Data.DataTable();
								dtgetcards = getdatabase("Select * From cosmetics where cosmeticsid=" + intproductid);
								cn.Open();
								newquantity = Convert.ToInt32(dtgetcards.Rows[0]["cosmeticsquantity"]) + Convert.ToInt32(intquantity);
								cm.CommandText = "Update cosmetics Set cosmeticsquantity =" + newquantity + ",cosmeticsunitcostprice=" + dblcost + ",cosmeticsunitsalesprice=" + dblprice + " Where cosmeticsid=" + intproductid + ";";
								cm.Connection = cn;
								cm.ExecuteNonQuery();
								cn.Close();
								System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
								dtgetcosmetics = getdatabase("Select * From cosmetics order by cosmeticsname");
								if (dtgetcosmetics.Rows.Count > 0)
								{
									ListViewItem lstitem = new ListViewItem();
									lsvitems1.Items.Clear();
									for (var j = 0; j < dtgetcosmetics.Rows.Count; j++)
									{
										lstitem = new ListViewItem();
										lstitem.Text = dtgetcosmetics.Rows[j]["cosmeticsid"].ToString();
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsname"].ToString());
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsquantity"].ToString());
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitsalesprice"].ToString());
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitcostprice"].ToString());
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["expirydate"].ToString());
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["entrydate"].ToString());
										lsvitems1.Items.Add(lstitem);
									}
								}
								txttotal.Text = dtgetcosmetics.Rows.Count.ToString();
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
								cm.CommandText = "Insert Into cosmetics(cosmeticsname,cosmeticsquantity,cosmeticsunitcostprice,cosmeticsunitsalesprice,expirydate) Values('" + strproductname + "'," + intquantity + "," + dblcost + "," + dblprice + ",'" + expirydate + "')";
								cm.Connection = cn;
								cm.ExecuteNonQuery();
								cn.Close();
								//computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
								System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
								dtgetcosmetics = getdatabase("Select * From cosmetics order by cosmeticsname");
								if (dtgetcosmetics.Rows.Count > 0)
								{
									ListViewItem lstitem = new ListViewItem();
									lsvitems1.Items.Clear();
									for (var j = 0; j < dtgetcosmetics.Rows.Count; j++)
									{
										lstitem = new ListViewItem();
										lstitem.Text = dtgetcosmetics.Rows[j]["cosmeticsid"].ToString();
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsname"].ToString());
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsquantity"].ToString());
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitsalesprice"].ToString());
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitcostprice"].ToString());
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["expirydate"].ToString());
										lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["entrydate"].ToString());
										lsvitems1.Items.Add(lstitem);
									}
								}
								txttotal.Text = dtgetcosmetics.Rows.Count.ToString();
							}
						}
						MessageBox.Show(intitems + " Records Entered Successfully");
						workbook.Save();
						workbook.Close(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
						APP.Quit();
						txtitems.Text = "";
						txtfile.Text = "";
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

		private void cards_Load(object sender, System.EventArgs e)
		{

            // Use TimeSpan and some date calculaton, this should work:

            DataTable dtidentity = new DataTable();
            dtidentity = getdatabase("Select * from identity");

            lbname.Text = dtidentity.Rows[0]["businessName"].ToString();
            lbaddress.Text = dtidentity.Rows[0]["address"].ToString();
           // lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

            System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
			dtgetcosmetics = getdatabase("Select * From cosmetics order by cosmeticsname");
			if (dtgetcosmetics.Rows.Count > 0)
			{
				ListViewItem lstitem = new ListViewItem();
				lsvitems1.Items.Clear();
				for (var j = 0; j < dtgetcosmetics.Rows.Count; j++)
				{
					lstitem = new ListViewItem();
					lstitem.Text = dtgetcosmetics.Rows[j]["cosmeticsid"].ToString();
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsname"].ToString());
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsquantity"].ToString());
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitsalesprice"].ToString());
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitcostprice"].ToString());
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["expirydate"].ToString());
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["entrydate"].ToString());
					lsvitems1.Items.Add(lstitem);
				}
			}
			txttotal.Text = dtgetcosmetics.Rows.Count.ToString();
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			sales x = new sales();
			x.txtcashiername1.Text = txtcashiername1.Text;
			x.Show();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			viewsaleslog x = new viewsaleslog();
			x.Show();
		}

		private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			txtfile.Text = OpenFileDialog1.FileName;

		}

		private void Button7_Click(object sender, System.EventArgs e)
		{
			reorderleveltype x = new reorderleveltype();
			x.Show();
		}

		private void dgvcards_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{

		}

		private void Button5_Click(object sender, System.EventArgs e)
		{
			expirydateinfotype x = new expirydateinfotype();
			x.Show();
		}

		private void txtunitcostprice_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			txtunitcostprice.Text = (Convert.ToDouble(txtamountpaid.Text) / Convert.ToDouble(txtquantity.Text)).ToString();
		}

		private void txtunitcostprice_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Button6_Click(object sender, System.EventArgs e)
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
				intproductid = Convert.ToInt32(lsvitems1.SelectedItems[0].Text);
				dtgetproduct = getdatabase("Select * From cosmetics where cosmeticsid=" + intproductid);
				cn.Open();
				deletcosmetics x = new deletcosmetics();
				x.txtproductid.Text = intproductid.ToString();
				x.txtproductname.Text = (dtgetproduct.Rows[0]["cosmeticsname"]).ToString();
				x.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void lsvitems1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				if (Simulate.IsNumeric(Convert.ToInt32(lsvitems1.SelectedItems[0].Text)))
				{
					intproductid = Convert.ToInt32(lsvitems1.SelectedItems[0].Text);
					//Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
					dtgetsales = getdatabase(" select * from cosmetics where cosmeticsid=" + intproductid);
					txtproductid.Text = Convert.ToDouble(dtgetsales.Rows[0]["cosmeticsid"]).ToString();
					txtproductname.Text = Convert.ToString(dtgetsales.Rows[0]["cosmeticsname"]);
					txtquantity.Text = Convert.ToString(dtgetsales.Rows[0]["cosmeticsquantity"]);
					//txtamountpaid.Text = CStr(dtgetexpirydate.Rows(0).Item("amountpaid"))
					txtunitcostprice.Text = Convert.ToString(dtgetsales.Rows[0]["cosmeticsunitcostprice"]);
					txtunitprice.Text = Convert.ToString(dtgetsales.Rows[0]["cosmeticsunitsalesprice"]);
					txtexpirydate.Text = Convert.ToString(dtgetsales.Rows[0]["expirydate"]);
                    //txtcode .Text = Convert.ToString(dtgetsales.Rows[0]["barcode"]);
                    
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

		private void lsvitems1_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}

		private void cosmetics_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
			dtgetcosmetics = getdatabase("Select * From cosmetics order by cosmeticsname");
			if (dtgetcosmetics.Rows.Count > 0)
			{
				ListViewItem lstitem = new ListViewItem();
				lsvitems1.Items.Clear();
				for (var j = 0; j < dtgetcosmetics.Rows.Count; j++)
				{
					lstitem = new ListViewItem();
					lstitem.Text = dtgetcosmetics.Rows[j]["cosmeticsid"].ToString();
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsname"].ToString());
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsquantity"].ToString());
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitsalesprice"].ToString());
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitcostprice"].ToString());
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["expirydate"].ToString());
					lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["entrydate"].ToString());
					lsvitems1.Items.Add(lstitem);
				}
			}
			txttotal.Text = dtgetcosmetics.Rows.Count.ToString();

		}

        private void txtcode_TextChanged(object sender, EventArgs e)
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
                    MessageBox.Show("Please enter the Quantity of Products Purchased");

                }
                else if (string.IsNullOrEmpty(txtunitprice.Text))
                {
                    MessageBox.Show("Please enter the Unit price of Products Purchased");
                }
                else if (string.IsNullOrEmpty(txtunitcostprice.Text))
                {
                    MessageBox.Show("Please enter the Unit Cost price of The Products Purchased");
                }
                else if (Simulate.IsNumeric(txtquantity.Text) && !string.IsNullOrEmpty(txtproductid.Text))
                {
                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    int newquantity = 0;
                    System.Data.DataTable dtgetcards = new System.Data.DataTable();
                    if (!string.IsNullOrEmpty(lsvitems1.SelectedItems[0].Text))
                    {
                        intproductid = Convert.ToInt32(lsvitems1.SelectedItems[0].Text);
                        dtgetcards = getdatabase("Select * From cosmetics where cosmeticsid=" + intproductid);
                        cn.Open();
                        newquantity = Convert.ToInt32(dtgetcards.Rows[0]["cosmeticsquantity"]) + Convert.ToInt32(txtquantity.Text);
                        cm.CommandText = "Update cosmetics Set cosmeticsname='" + txtproductname.Text + "',cosmeticsquantity =" + newquantity + ",cosmeticsunitcostprice=" + txtunitcostprice.Text + ",cosmeticsunitsalesprice=" + txtunitprice.Text + " ,barcode=" + txtcode.Text + ",expirydate=" + txtexpirydate.Text + " Where cosmeticsid=" + intproductid + ";";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        cm.CommandText = "Insert Into cosmeticsexpirydate(cosmeticsid,cosmeticsname,cosmeticsquantity,cosmeticsunitcostprice,cosmeticsunitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + dtgetcards.Rows[0]["cosmeticsid"] + "','" + dtgetcards.Rows[0]["cosmeticsname"] + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "','" + txtamountpaid.Text + "','" + txtinvoicenumber.Text + "')";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + dtgetcards.Rows[0]["cosmeticsname"] + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "','" + txtamountpaid.Text + "','" + txtinvoicenumber.Text + "')";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
                        dtgetcosmetics = getdatabase("Select * From cosmetics order by cosmeticsname");
                        if (dtgetcosmetics.Rows.Count > 0)
                        {
                            ListViewItem lstitem = new ListViewItem();
                            lsvitems1.Items.Clear();
                            for (var j = 0; j < dtgetcosmetics.Rows.Count; j++)
                            {
                                lstitem = new ListViewItem();
                                lstitem.Text = dtgetcosmetics.Rows[j]["cosmeticsid"].ToString();
                                lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsname"].ToString());
                                lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsquantity"].ToString());
                                lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitsalesprice"].ToString());
                                lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitcostprice"].ToString());
                                lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["expirydate"].ToString());
                                lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["entrydate"].ToString());
                                lsvitems1.Items.Add(lstitem);
                            }
                            txttotal.Text = dtgetcosmetics.Rows.Count.ToString();
                        }
                        txtquantity.Text = "";
                        txtunitprice.Text = "";
                        txtunitcostprice.Text = "";
                        txtsuppliername.Text = "";
                        txtsupplierphonenumber.Text = "";
                        txtexpirydate.Text = "";
                        txtamountpaid.Text = "";
                        txtinvoicenumber.Text = "";
                        txtproductname.Text = "";
                        txtproductid.Text = "";
                        txtcode.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show("please Select The Product");
                    }
                }
                else
                {
                    //Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into cosmetics(cosmeticsname,cosmeticsquantity,cosmeticsunitcostprice,cosmeticsunitsalesprice) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
                    dtgetcosmetics = getdatabase("Select * From cosmetics order by cosmeticsname");
                    cn.Open();
                    cm.CommandText = "Insert Into cosmeticsexpirydate(cosmeticsname,cosmeticsquantity,cosmeticsunitcostprice,cosmeticsunitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "'," + txtamountpaid.Text + ",'" + txtinvoicenumber.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    cn.Open();
                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtunitcostprice.Text + "','" + txtunitprice.Text + "','" + txtexpirydate.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtdatepurchased.Text + "'," + txtamountpaid.Text + ",'" + txtinvoicenumber.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();

                    //computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
                    dtgetcosmetics = getdatabase("Select * From cosmetics order by cosmeticsname");
                    if (dtgetcosmetics.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems1.Items.Clear();
                        for (var j = 0; j < dtgetcosmetics.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetcosmetics.Rows[j]["cosmeticsid"].ToString();
                            lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsname"].ToString());
                            lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsquantity"].ToString());
                            lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitsalesprice"].ToString());
                            lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitcostprice"].ToString());
                            lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["expirydate"].ToString());
                            lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["entrydate"].ToString());
                            lsvitems1.Items.Add(lstitem);
                        }
                    }
                    txttotal.Text = dtgetcosmetics.Rows.Count.ToString();
                    txtproductname.Text = "";
                    txtquantity.Text = "";
                    txtunitprice.Text = "";
                    txtunitcostprice.Text = "";
                    txtsuppliername.Text = "";
                    txtsupplierphonenumber.Text = "";
                    txtexpirydate.Text = "";
                    txtamountpaid.Text = "";
                    txtinvoicenumber.Text = "";
                    txtdatepurchased.Text = "";
                    txtcode.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}