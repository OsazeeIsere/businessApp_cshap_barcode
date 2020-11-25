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
	public partial class expirydateinfo
	{
		internal expirydateinfo()
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
		private void expirydateinfo_Load(object sender, System.EventArgs e)
		{
			try
			{
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");

                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
             // lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

                // Use TimeSpan and some date calculaton, this should work:
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				dtgetproduct = getdatabase("Select * From expirydate order by productname");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var j = 0; j < dtgetproduct.Rows.Count; j++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetproduct.Rows[j]["expirydateid"].ToString();
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["productid"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
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

		private void Button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				int months = 0;
				int months1 = 0;
				int year = 0;
				int year1 = 0;
				int monthdiff1 = 0;
				int yeardiff = 0;
				int totalmonths = 0;
				DateTime dateOne = default(DateTime);
				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				System.Data.DataTable dtgetproduct1 = new System.Data.DataTable();
				if (string.IsNullOrEmpty(ComboBox1.Text))
				{
					MessageBox.Show("Please Select the period under which to examine the EXPIRY DATE INFO");
					ComboBox1.Focus();
				}
				else if ((ComboBox1.Text) == "Three Months(3) Time")
				{
					dtgetproduct = getdatabase("Select * from expirydate");
					if (dtgetproduct.Rows.Count > 0)
					{
						ListViewItem lstitem = new ListViewItem();
						lsvitems.Items.Clear();
						for (var i = 0; i < dtgetproduct.Rows.Count; i++)
						{
							lstitem = new ListViewItem();
							dateOne = Convert.ToDateTime(dtgetproduct.Rows[i]["expirydate"]);
							months = dateOne.Month;
							months1 = DateTimePicker1.Value.Month;
							monthdiff1 = 12 - months1;
							year = dateOne.Year;
							year1 = DateTimePicker1.Value.Year;
							//this helps to capture the full years  
							yeardiff = ((year - 1) - (year1 + 1)) + 1;
							totalmonths = (months + monthdiff1) + (12 * yeardiff);
							if (totalmonths > -1 && totalmonths < 4)
							{
								lstitem.Text = dtgetproduct.Rows[i]["expirydateid"].ToString();
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["productid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["productname"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["suppliername"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["supplierphonenumber"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["datepurchased"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["amountpaid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["invoicenumber"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["entrydate"].ToString());
								lsvitems.Items.Add(lstitem);
							}
						}
						lsvitems.ForeColor = Color.IndianRed;
						txttotal.Text = lsvitems.Items.Count.ToString();
					}
				}
				else if ((ComboBox1.Text) == "Six Months(6) Time")
				{
					dtgetproduct = getdatabase("Select * from expirydate");
					if (dtgetproduct.Rows.Count > 0)
					{
						ListViewItem lstitem = new ListViewItem();
						lsvitems.Items.Clear();
						for (var i = 0; i < dtgetproduct.Rows.Count; i++)
						{
							lstitem = new ListViewItem();
							dateOne = Convert.ToDateTime(dtgetproduct.Rows[i]["expirydate"]);
							months = dateOne.Month;
							months1 = DateTimePicker1.Value.Month;
							monthdiff1 = 12 - months1;
							year = dateOne.Year;
							year1 = DateTimePicker1.Value.Year;
							//this helps to capture the full years  
							yeardiff = ((year - 1) - (year1 + 1)) + 1;
							totalmonths = (months + monthdiff1) + (12 * yeardiff);
							if (totalmonths > -1 && totalmonths < 7)
							{
								lstitem.Text = dtgetproduct.Rows[i]["expirydateid"].ToString();
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["productid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["productname"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["suppliername"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["supplierphonenumber"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["datepurchased"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["amountpaid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["invoicenumber"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["entrydate"].ToString());
								lsvitems.Items.Add(lstitem);
							}
						}
						lsvitems.ForeColor = Color.Red;
						txttotal.Text = lsvitems.Items.Count.ToString();
					}
				}
				else if ((ComboBox1.Text) == "Above Six Months(6) Time")
				{
					dtgetproduct = getdatabase("Select * from expirydate");
					if (dtgetproduct.Rows.Count > 0)
					{
						ListViewItem lstitem = new ListViewItem();
						lsvitems.Items.Clear();
						for (var i = 0; i < dtgetproduct.Rows.Count; i++)
						{
							lstitem = new ListViewItem();
							dateOne = Convert.ToDateTime(dtgetproduct.Rows[i]["expirydate"]);
							months = dateOne.Month;
							months1 = DateTimePicker1.Value.Month;
							monthdiff1 = 12 - months1;
							year = dateOne.Year;
							year1 = DateTimePicker1.Value.Year;
							//this helps to capture the full years  
							yeardiff = ((year - 1) - (year1 + 1)) + 1;
							totalmonths = (months + monthdiff1) + (12 * yeardiff);
							if (totalmonths > 6)
							{
								lstitem.Text = dtgetproduct.Rows[i]["expirydateid"].ToString();
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["productid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["productname"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["suppliername"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["supplierphonenumber"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["datepurchased"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["amountpaid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["invoicenumber"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["entrydate"].ToString());
								lsvitems.Items.Add(lstitem);
							}
						}
						lsvitems.ForeColor = Color.Green;
						txttotal.Text = lsvitems.Items.Count.ToString();
					}
				}
				else if ((ComboBox1.Text) == "Drugs Already Expired")
				{
					dtgetproduct = getdatabase("Select * from expirydate");
					if (dtgetproduct.Rows.Count > 0)
					{
						ListViewItem lstitem = new ListViewItem();
						lsvitems.Items.Clear();
						for (var i = 0; i < dtgetproduct.Rows.Count; i++)
						{
							lstitem = new ListViewItem();
							dateOne = Convert.ToDateTime(dtgetproduct.Rows[i]["expirydate"]);
							months = dateOne.Month;
							months1 = DateTimePicker1.Value.Month;
							monthdiff1 = 12 - months1;
							year = dateOne.Year;
							year1 = DateTimePicker1.Value.Year;
							//this helps to capture the full years  
							yeardiff = ((year - 1) - (year1 + 1)) + 1;
							totalmonths = (months + monthdiff1) + (12 * yeardiff);
							if (totalmonths < 0)
							{
								lstitem.Text = dtgetproduct.Rows[i]["expirydateid"].ToString();
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["productid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["productname"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["suppliername"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["supplierphonenumber"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["datepurchased"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["amountpaid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["invoicenumber"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["entrydate"].ToString());
								lsvitems.Items.Add(lstitem);
							}
						}
						lsvitems.ForeColor = Color.Black;
						txttotal.Text = lsvitems.Items.Count.ToString();
					}
				}
				else if ((ComboBox1.Text) == "Drugs That Will Expire This Month")
				{
					dtgetproduct = getdatabase("Select * from expirydate");
					if (dtgetproduct.Rows.Count > 0)
					{
						ListViewItem lstitem = new ListViewItem();
						lsvitems.Items.Clear();
						for (var i = 0; i < dtgetproduct.Rows.Count; i++)
						{
							lstitem = new ListViewItem();
							dateOne = Convert.ToDateTime(dtgetproduct.Rows[i]["expirydate"]);
							months = dateOne.Month;
							months1 = DateTimePicker1.Value.Month;
							monthdiff1 = 12 - months1;
							year = dateOne.Year;
							year1 = DateTimePicker1.Value.Year;
							//this helps to capture the full years  
							yeardiff = ((year - 1) - (year1 + 1)) + 1;
							totalmonths = (months + monthdiff1) + (12 * yeardiff);
							if (totalmonths == 0)
							{
								lstitem.Text = dtgetproduct.Rows[i]["expirydateid"].ToString();
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["productid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["productname"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["suppliername"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["supplierphonenumber"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["datepurchased"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["amountpaid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["invoicenumber"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[i]["entrydate"].ToString());
								lsvitems.Items.Add(lstitem);
							}
						}
						lsvitems.ForeColor = Color.Red;
						txttotal.Text = lsvitems.Items.Count.ToString();
					}
				}
				else if ((ComboBox1.Text) == "All Drugs")
				{
					try
					{
						// Use TimeSpan and some date calculaton, this should work:
						dtgetproduct = getdatabase("Select * From expirydate order by productname");
						if (dtgetproduct.Rows.Count > 0)
						{
							ListViewItem lstitem = new ListViewItem();
							lsvitems.Items.Clear();
							for (var j = 0; j < dtgetproduct.Rows.Count; j++)
							{
								lstitem = new ListViewItem();
								lstitem.Text = dtgetproduct.Rows[j]["expirydateid"].ToString();
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["productid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
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
			}
			catch (Exception ex)
			{
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
						MessageBox.Show("please enter a Value");
						txtitems.Focus();
					}
				}
				else
				{
					MessageBox.Show("please enter the TOTAL number of items to be UPLOADED");
					txtitems.Focus();
				}
				if (!string.IsNullOrEmpty(txtitems.Text))
				{
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
                    string expirydate,barcode;
					string suppliername = null;
					string suppliertel = null;
					string  datepurchased ;
					double dblamount = 0;
					string invoicenumber = null;
					for (var i = 2; i < 2 + intitems; i++)
					{
						//intproductid = 0
						//If Not IsNothing(worksheet.Cells(i, 1).Value) Then
						//    If worksheet.Cells(i, 1).Value.ToString <> "" Then
						//        If IsNumeric(worksheet.Cells(i, 1).Value.ToString) Then
						//            intproductid = CInt(worksheet.Cells(i, 1).Value)
						//        End If
						//    End If
						strproductname = worksheet.Cells[i, 2].Value;
						intquantity = Convert.ToInt32(worksheet.Cells[i, 3].Value);
						dblcost = Convert.ToDouble(worksheet.Cells[i, 4].Value);
						dblprice = Convert.ToDouble(worksheet.Cells[i, 5].Value);
						expirydate =Convert.ToString (worksheet.Cells[i, 6].Value);
                        expirydate = Convert.ToDateTime(expirydate).ToShortDateString();
                        barcode = Convert.ToString(worksheet.Cells[i, 7].Value);

                        suppliername = (worksheet.Cells[i, 8].Value);
						suppliertel = (worksheet.Cells[i, 9].Value);
						datepurchased = (worksheet.Cells[i, 10].Value);
						dblamount = Convert.ToDouble(worksheet.Cells[i, 11].Value);
						invoicenumber = (worksheet.Cells[i, 12].Value);
						//If intproductid > 0 Then

						//    Dim cn As New MySqlConnection
						//    Dim ad As New MySqlDataAdapter
						//    Dim cm As New MySqlCommand
						//    Dim strconnection As String = ""
						//    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
						//    cn.ConnectionString = strconnection
						//    Dim newquantity As Integer
						//    Dim dtgetproduct As New System.Data.DataTable
						//    dtgetproduct = getdatabase("Select * From product where productid=" & intproductid)
						//    cn.Open()
						//    newquantity = CInt(dtgetproduct.Rows(0).Item("quantity")) + CInt(intquantity)
						//    cm.CommandText = "Update product Set quantity =" & newquantity & ",unitcostprice=" & dblcost & ",unitsalesprice=" & dblprice & ",expirydate='" & expirydate.ToString & "' Where productid=" & intproductid & ";"
						//    cm.Connection = cn
						//    cm.ExecuteNonQuery()
						//    cn.Close()
						//    dgvdrugs.DataSource = getdatabase("Select * From product")
						MySqlConnection cn = new MySqlConnection();
						MySqlDataAdapter ad = new MySqlDataAdapter();
						MySqlCommand cm = new MySqlCommand();
						string strconnection = "";
						strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
						cn.ConnectionString = strconnection;
						cn.Open();
						cm.CommandText = "Insert Into expirydate(productname,quantity,unitcostprice,unitsalesprice,expirydate,barcode,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + strproductname + "'," + intquantity + "," + dblcost + "," + dblprice + ",'" + expirydate + "','" + barcode + "','" + suppliername + "','" + suppliertel + "','" + datepurchased + "'," + dblamount + ",'" + invoicenumber + "')";
						cm.Connection = cn;
						cm.ExecuteNonQuery();
						cn.Close();
						System.Data.DataTable dtgetproduct = new System.Data.DataTable();
						dtgetproduct = getdatabase("Select * From expirydate");
						if (dtgetproduct.Rows.Count > 0)
						{
							ListViewItem lstitem = new ListViewItem();
							lsvitems.Items.Clear();
							for (var j = 0; j < dtgetproduct.Rows.Count; j++)
							{
								lstitem = new ListViewItem();
								lstitem.Text = dtgetproduct.Rows[j]["expirydateid"].ToString();
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["productid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["amountpaid"].ToString());
								lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());
								lsvitems.Items.Add(lstitem);
							}
							txttotal.Text = dtgetproduct.Rows.Count.ToString();
						}
					}
					MessageBox.Show(intitems + " Records Entered Successfully");
					workbook.Save();
					workbook.Close(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
					APP.Quit();
					txtitems.Text = "";
					txtfile.Text = "";
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
				dtgetproduct = getdatabase("Select * From expirydate Where productname Like '%" + txtsearch.Text + "%' Order By productname;");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var j = 0; j < dtgetproduct.Rows.Count; j++)
					{
						lstitem = new ListViewItem();

						lstitem.Text = dtgetproduct.Rows[j]["expirydateid"].ToString();
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["productid"].ToString());
						lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
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

		private void lsvitems_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}
	}
}