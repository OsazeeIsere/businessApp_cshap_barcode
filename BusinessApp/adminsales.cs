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
	public partial class adminsales
	{
		internal adminsales()
		{
			InitializeComponent();
		}

		public double discount;
		public int intproductid;
		private System.Data.DataTable getdatabase(string strcommand)
		{
			System.Data.DataTable tempgetdatabase = null;
			tempgetdatabase = new System.Data.DataTable();
			MySqlConnection cn = new MySqlConnection();
			MySqlDataAdapter ad = new MySqlDataAdapter();
			MySqlCommand cm = new MySqlCommand();
			string strconnection1 = "";
			strconnection1 = "Server=localhost;Port=3306;Database=businessdatabase;Uid=root;Pwd=prayer;";
			cn.ConnectionString = strconnection1;
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
		private void adminsales_Load(object sender, System.EventArgs e)
		{
			try
			{
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");
                txtcode2.Focus();
                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                this.ActiveControl = txtcode2;
                lsvitems1.Visible = false;
                Label1.Visible = false;
                txtcosmeticsid.Visible = false;
                txtunitsalesprice1.Visible = false;
                Label7.Visible = false;
                txtcardsquantity.Visible = false;
                btncards.Visible = false;
                txtcardssearch.Visible = false;
                Label6.Visible = false;
                PictureBox2.Visible = false;
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var j = 0; j < dtgetproduct.Rows.Count; j++)
					{
                        if (Convert.ToInt32(dtgetproduct.Rows[j]["quantity"].ToString()) < 6)
                        {
                                              
                            lstitem = new ListViewItem();
                            lstitem.ForeColor = Color.Red;
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                        else
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
				txtquantity.Text = 1.ToString();
                string time1 = null;
                time1 = DateTime.Now.ToShortTimeString();
                txttime.Text = time1;
                //Dim time1 As String
                //time1 = TimeOfDay
                //txttime.Text = time1
                //Dim dtgetproduct As New System.Data.DataTable
                //dtgetproduct = getdatabase("select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate from product")
                //dgvsales.DataSource = dtgetproduct
                //With dgvsales
                //    .RowHeadersVisible = False
                //    .Columns(0).HeaderCell.Value = "ID"
                //    .Columns(1).HeaderCell.Value = "Product Name"
                //    .Columns(2).HeaderCell.Value = "Qtys"
                //    .Columns(3).HeaderCell.Value = "S/Price"
                //    .Columns(4).HeaderCell.Value = "C/Price"
                //    .Columns(5).HeaderCell.Value = "Exp.Date"
                //    '.Columns(6).HeaderCell.Value = "Entry Date"
                //End With
                //Dim dtgetdrinks As New System.Data.DataTable
                //dtgetdrinks = getdatabase("select drinksid,drinksname,drinksquantity,drinksunitsalesprice,drinksunitcostprice,expirydate from drinks")
                //dgvdrinks.DataSource = dtgetdrinks
                //With dgvdrinks
                //    .RowHeadersVisible = False
                //    .Columns(0).HeaderCell.Value = "ID"
                //    .Columns(1).HeaderCell.Value = "Product Name"
                //    .Columns(2).HeaderCell.Value = "Qtys"
                //    .Columns(3).HeaderCell.Value = "S/Price"
                //    .Columns(4).HeaderCell.Value = "C/Price"
                //    .Columns(5).HeaderCell.Value = "Expiry Date"
                //    '    .Columns(6).HeaderCell.Value = "Entry Date"
                //End With
                System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
				dtgetcosmetics = getdatabase("select cosmeticsid,cosmeticsname,cosmeticsquantity,cosmeticsunitsalesprice,cosmeticsunitcostprice,expirydate,entrydate from cosmetics");
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
				txtcardsquantity.Text = 1.ToString();
                int months = 0;
                int months1 = 0;
                int year = 0;
                int year1 = 0;
                int monthdiff1 = 0;
                int yeardiff = 0;
                int totalmonths = 0;
                int k = 0;
                int l = 0;
                int v = 0;
                DateTime dateOne;
                System.Data.DataTable dtgetproduct0 = new System.Data.DataTable();
                System.Data.DataTable dtgetproduct1 = new System.Data.DataTable();
                //if (string.IsNullOrEmpty(ComboBox1.Text))
                //{
                //    MessageBox.Show("Please Select the period under which to examine the EXPIRY DATE INFO");
                //    ComboBox1.Focus();
                //}
                //else if ((ComboBox1.Text) == "Three Months(3) Time")
                //{
                dtgetproduct0 = getdatabase("Select * from expirydate");
                int[] myCount = new int[dtgetproduct0.Rows.Count];
                int[] myCount1 = new int[dtgetproduct0.Rows.Count];
                int[] myCount2 = new int[dtgetproduct0.Rows.Count];
                if (dtgetproduct0.Rows.Count > 0)
                {

                    for (var i = 0; i < dtgetproduct0.Rows.Count; i++)
                    //for (var i = 0; i < dtgetproduct0.Rows.Count; i++)
                    {
                        //lstitem = new ListViewItem();
                        dateOne = Convert.ToDateTime(dtgetproduct0.Rows[i]["expirydate"]);
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
                            myCount[k] = k + 1;
                            txt3.Text = myCount[k].ToString() + "  Products Will Expire Within The Next Three Months. ";
                            k = k + 1;
                            if (totalmonths == 0)
                            {
                                myCount1[l] = l + 1;
                                txt1.Text = myCount1[l].ToString() + "  Products Will Expire This Months.";
                                l = l + 1;
                            }

                        }

                        else if (totalmonths < 0)
                        {
                            myCount2[v] = v + 1;
                            txt0.Text = myCount2[v].ToString() + "  Products Have Expired. ";
                            v = v + 1;
                        }

                    }
                }

            }
            catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnenter_Click(object sender, System.EventArgs e)
		{
			try
			{

				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				double amount = 0;
				string strconnection = "";
				if (string.IsNullOrEmpty(txtquantity.Text))
				{
					MessageBox.Show("Please Type The Quantity of Drug To Be Sold");
				}
				else
				{
					if (Simulate.IsNumeric(txtquantity.Text))
					{
						if (txtdrugid.Text != "")
						{
                            intproductid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
                            dtgetsales = getdatabase(" select * from product where productid=" + intproductid);
							amount = Convert.ToDouble(txtunitsalesprice.Text) * Convert.ToInt32(txtquantity.Text);
							strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
							cn.ConnectionString = strconnection;
							cn.Open();
							cm.CommandText = "Insert Into sales(cashiername,itemsold,quantitysold,unitcostprice,unitprice,amount,discount,productid) Values('" + txtcashiername1.Text + "','" + dtgetsales.Rows[0]["productname"].ToString() + "','" + txtquantity.Text + "','" + dtgetsales.Rows[0]["unitcostprice"].ToString() + "'," + Convert.ToDouble(txtunitsalesprice.Text) + "," + amount + "," + discount + "," + intproductid + ")";
							cm.Connection = cn;
							cm.ExecuteNonQuery();
							cn.Close();
                            SalesAlert pop = new SalesAlert();
                            pop.ShowDialog();
                            //Dim v As Double
                            //Dim amountcost As Double
                            //Dim profit As Double
                            //Dim newquantity As Integer
                            //Dim newquantity1 As Integer
                            //Dim ProductName1 As String
                            //ProductName1 = dtgetsales.Rows(0).Item("productname")
                            //v = CDbl(dtgetsales.Rows(0).Item("unitcostprice"))
                            //amountcost = v * CInt(txtquantity.Text)
                            //profit = amount - amountcost
                            //discount = 0
                            //strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                            //cn.ConnectionString = strconnection
                            //cn.Open()
                            //cm.CommandText = "Insert Into drugslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date) Values('" & txtcashiername1.Text & "','" & dtgetsales.Rows(0).Item("productname").ToString & "','" & txtquantity.Text & "','" & dtgetsales.Rows(0).Item("unitcostprice").ToString & "'," & amountcost & "," & CDbl(txtunitsalesprice.Text) & "," & amount & "," & profit & ", '" & DateTimePicker1.Value.Date & "')"
                            //cm.Connection = cn
                            //cm.ExecuteNonQuery()
                            //cn.Close()
                            //cn.ConnectionString = strconnection
                            //cn.Open()
                            //cm.CommandText = "Insert Into generalsaleslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date) Values('" & txtcashiername1.Text & "','" & dtgetsales.Rows(0).Item("productname").ToString & "','" & txtquantity.Text & "','" & dtgetsales.Rows(0).Item("unitcostprice").ToString & "'," & amountcost & "," & CDbl(txtunitsalesprice.Text) & "," & amount & "," & profit & ", '" & DateTimePicker1.Value.Date & "')"
                            //cm.Connection = cn
                            //cm.ExecuteNonQuery()
                            //cn.Close()
                            //strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                            //cn.ConnectionString = strconnection
                            //cn.Open()
                            //newquantity = CInt(dtgetsales.Rows(0).Item("quantity")) - CInt(txtquantity.Text)
                            //cm.CommandText = "Update product Set quantity=" & newquantity & " Where productid=" & intproductid & ";"
                            //cm.Connection = cn
                            //cm.ExecuteNonQuery()
                            //cn.Close()
                            //MessageBox.Show("successfull You Can CONTINUE")
                            //Dim dtgetproduct As New System.Data.DataTable
                            //dtgetproduct = getdatabase("select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product")
                            //If dtgetproduct.Rows.Count > 0 Then
                            //    Dim lstitem As New ListViewItem
                            //    lsvitems.Items.Clear()
                            //    For j = 0 To dtgetproduct.Rows.Count - 1
                            //        lstitem = New ListViewItem
                            //        lstitem.Text = dtgetproduct.Rows(j).Item("productid").ToString
                            //        lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("productname").ToString)
                            //        lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("quantity").ToString)
                            //        lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("unitsalesprice").ToString)
                            //        lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("unitcostprice").ToString)
                            //        lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("expirydate").ToString)
                            //        lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("entrydate").ToString)
                            //        lsvitems.Items.Add(lstitem)
                            //    Next
                            //End If

                            //                        Dim dtgetexpirydate As New System.Data.DataTable
                            //dtgetexpirydate = getdatabase("select productid,productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber,entrydate from expirydate where productname ='" & ProductName1 & "'order by productid")
                            //If dtgetexpirydate.Rows.Count > 0 Then
                            //    For k = 0 To dtgetexpirydate.Rows.Count - 1
                            //        If CInt(dtgetexpirydate.Rows(0).Item("quantity")) < CInt(txtquantity.Text) Then
                            //            newquantity1 = (CInt(dtgetexpirydate.Rows(0).Item("quantity")) + CInt(dtgetexpirydate.Rows(k + 1).Item("quantity"))) - CInt(txtquantity.Text)
                            //            strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                            //            cn.ConnectionString = strconnection
                            //            cn.Open()
                            //            cm.CommandText = "Update expirydate Set quantity=" & newquantity1 & " Where productname='" & ProductName1 & "' And productid =" & CInt(dtgetexpirydate.Rows(k + 1).Item("productid")) & ";"
                            //            cm.Connection = cn
                            //            cm.ExecuteNonQuery()
                            //            cn.Close()
                            //            strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                            //            cn.ConnectionString = strconnection
                            //            'Dim intnewproductid As Integer
                            //            'intnewproductid = CInt(dtgetexpirydate.Rows(0).Item("quantity"))
                            //            cn.Open()
                            //            newquantity1 = 0
                            //            cm.CommandText = "Update expirydate Set quantity=" & newquantity1 & " Where productname='" & ProductName1 & "' And productid=" & CInt(dtgetexpirydate.Rows(k).Item("productid")) & ";"
                            //            cm.Connection = cn
                            //            cm.ExecuteNonQuery()
                            //            cn.Close()
                            //            cn.Open()
                            //            cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" & CStr(dtgetexpirydate.Rows(k).Item("productname")) & "','" & newquantity1 & "','" & CDbl(dtgetexpirydate.Rows(k).Item("unitcostprice")) & "','" & CDbl(dtgetexpirydate.Rows(k).Item("unitsalesprice")) & "','" & CDate(dtgetexpirydate.Rows(k).Item("expirydate")) & "','" & CStr(dtgetexpirydate.Rows(k).Item("suppliername")) & "','" & CStr(dtgetexpirydate.Rows(k).Item("supplierphonenumber")) & "','" & CDate(dtgetexpirydate.Rows(k).Item("datepurchased")) & "'," & CDbl(dtgetexpirydate.Rows(k).Item("amountpaid")) & ",'" & CStr(dtgetexpirydate.Rows(k).Item("invoicenumber")) & "')"
                            //            cm.Connection = cn
                            //            cm.ExecuteNonQuery()
                            //            cn.Close()
                            //            cn.Open()
                            //            cm.CommandText = "Delete from expirydate where productid= " & CInt(dtgetexpirydate.Rows(k).Item("productid")) & ""
                            //            cm.Connection = cn
                            //            cm.ExecuteNonQuery()
                            //            cn.Close()
                            //            txtquantity.Text = 1
                            //            txtunitsalesprice.Text = ""
                            //            GoTo 233
                            //        Else
                            //            newquantity1 = CInt(dtgetexpirydate.Rows(0).Item("quantity")) - CInt(txtquantity.Text)
                            //            strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                            //            cn.ConnectionString = strconnection
                            //            cn.Open()
                            //            cm.CommandText = "Update expirydate Set quantity=" & newquantity1 & " Where productname='" & ProductName1 & "' And productid=" & CInt(dtgetexpirydate.Rows(0).Item("productid")) & ";"
                            //            cm.Connection = cn
                            //            cm.ExecuteNonQuery()
                            //            cn.Close()
                            //            GoTo 234
                            //            '    'and  productid <> " & intproductid & "
                            //            '    'Else
                            //            '    '    cn.Open()
                            //            '    '    cm.CommandText = "Update expirydate Set quantity=" & newquantity & " Where productid=" & intproductid & ";"
                            //            '    '    cm.Connection = cn
                            //            '    '    cm.ExecuteNonQuery()
                            //            '    cn.Close()
                            //        End If
                            //    Next
                            //End If
                        }
                        else if (txtcode2.Text != "")
                        {
                            dtgetsales = getdatabase(" select * from product where barcode=" + txtcode2.Text);
                            double x = 0;
                            x = Convert.ToDouble(dtgetsales.Rows[0]["unitsalesprice"]);
                            amount = x * Convert.ToInt32(txtquantity.Text);
                            strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                            cn.ConnectionString = strconnection;
                            cn.Open();
                            cm.CommandText = "Insert Into sales(cashiername,itemsold,quantitysold,unitcostprice,unitprice,amount,discount,productid) Values('" + txtcashiername1.Text + "','" + dtgetsales.Rows[0]["productname"].ToString() + "','" + txtquantity.Text + "','" + dtgetsales.Rows[0]["unitcostprice"] + "','" + dtgetsales.Rows[0]["unitsalesprice"] + "'," + amount + "," + discount + ",'" + dtgetsales.Rows[0]["productid"] + "')";
                            cm.Connection = cn;
                            cm.ExecuteNonQuery();
                            cn.Close();
                            SalesAlert pop = new SalesAlert();
                            pop.ShowDialog();
                            txtcode2.Text = "";
                            txtdrugid.Text = "";
                            txtproductname.Text = dtgetsales.Rows[0]["productname"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Please, If you want to sell, snap product's barcode or select product from list");
                        }
                    }
                    else
					{
						MessageBox.Show("please Enter a Number");
					}
				}
				//233:
				//234:
				txtquantity.Text = 1.ToString();
				txtunitsalesprice.Text = "";
				txtdrugid.Text = "";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btncards_Click(object sender, System.EventArgs e)
		{
			try
			{
				intproductid = Convert.ToInt32(lsvitems1.SelectedItems[0].Text);
				if (string.IsNullOrEmpty(txtcardsquantity.Text))
				{
					MessageBox.Show("Please Type The Quantity of Products To Be Sold");
				}
				else
				{
					if (Simulate.IsNumeric(txtcardsquantity.Text))
					{
						MySqlConnection cn = new MySqlConnection();
						MySqlDataAdapter ad = new MySqlDataAdapter();
						MySqlCommand cm = new MySqlCommand();
						System.Data.DataTable dtgetsales = new System.Data.DataTable();
						string strconnection = "";
						double amount = 0;
						if (intproductid != 0)
						{
							dtgetsales = getdatabase(" select * from cosmetics where cosmeticsid=" + intproductid);
							amount = Convert.ToDouble(txtunitsalesprice1.Text) * Convert.ToInt32(txtcardsquantity.Text);
							strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
							cn.ConnectionString = strconnection;
							cn.Open();
							cm.CommandText = "Insert Into sales(cashiername,itemsold,quantitysold,unitcostprice,unitprice,amount,discount,cosmeticsid) Values('" + txtcashiername1.Text + "','" + dtgetsales.Rows[0]["cosmeticsname"].ToString() + "','" + txtcardsquantity.Text + "','" + dtgetsales.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + Convert.ToDouble(txtunitsalesprice1.Text) + "," + amount + "," + discount + "," + intproductid + ")";
							cm.Connection = cn;
							cm.ExecuteNonQuery();
							cn.Close();
                            SalesAlert pop = new SalesAlert();
                            pop.ShowDialog();
                            //Dim v As Double
                            //Dim amountcost As Double
                            //Dim profit As Double
                            //Dim ProductName1 As String
                            //ProductName1 = dtgetsales.Rows(0).Item("cosmeticsname")
                            //Dim newquantity, newquantity1 As Integer
                            //v = CDbl(dtgetsales.Rows(0).Item("cosmeticsunitcostprice"))
                            //amountcost = v * CInt(txtcardsquantity.Text)
                            //profit = amount - amountcost
                            //strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                            //cn.ConnectionString = strconnection
                            //cn.Open()
                            //cm.CommandText = "Insert Into cosmeticslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date) Values('" & txtcashiername1.Text & "','" & dtgetsales.Rows(0).Item("cosmeticsname").ToString & "','" & txtcardsquantity.Text & "','" & dtgetsales.Rows(0).Item("cosmeticsunitcostprice").ToString & "'," & amountcost & "," & CDbl(txtunitsalesprice1.Text) & "," & amount & "," & profit & ", '" & DateTimePicker1.Value.Date & "')"
                            //cm.Connection = cn
                            //cm.ExecuteNonQuery()
                            //cn.Close()
                            //cn.ConnectionString = strconnection
                            //cn.Open()
                            //cm.CommandText = "Insert Into generalsaleslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date) Values('" & txtcashiername1.Text & "','" & dtgetsales.Rows(0).Item("cosmeticsname").ToString & "','" & txtcardsquantity.Text & "','" & dtgetsales.Rows(0).Item("cosmeticsunitcostprice").ToString & "'," & amountcost & "," & CDbl(txtunitsalesprice1.Text) & "," & amount & "," & profit & ", '" & DateTimePicker1.Value.Date & "')"
                            //cm.Connection = cn
                            //cm.ExecuteNonQuery()
                            //cn.Close()
                            //strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                            //cn.ConnectionString = strconnection
                            //cn.Open()
                            //newquantity = CInt(dtgetsales.Rows(0).Item("cosmeticsquantity")) - CInt(txtcardsquantity.Text)
                            //cm.CommandText = "Update cosmetics Set cosmeticsquantity=" & newquantity & " Where cosmeticsid=" & intproductid & ";"
                            //cm.Connection = cn
                            //cm.ExecuteNonQuery()
                            //cn.Close()
                            //MessageBox.Show("successfull You Can CONTINUE")
                            //Dim dtgetcards As New System.Data.DataTable
                            //dtgetcards = getdatabase("select cosmeticsid,cosmeticsname,cosmeticsquantity,cosmeticsunitsalesprice,cosmeticsunitcostprice,expirydate,entrydate from cosmetics")
                            //If dtgetcards.Rows.Count > 0 Then
                            //    Dim lstitem As New ListViewItem
                            //    lsvitems1.Items.Clear()
                            //    For j = 0 To dtgetcards.Rows.Count - 1
                            //        lstitem = New ListViewItem
                            //        lstitem.Text = dtgetcards.Rows(j).Item("cosmeticsid").ToString
                            //        lstitem.SubItems.Add(dtgetcards.Rows(j).Item("cosmeticsname").ToString)
                            //        lstitem.SubItems.Add(dtgetcards.Rows(j).Item("cosmeticsquantity").ToString)
                            //        lstitem.SubItems.Add(dtgetcards.Rows(j).Item("cosmeticsunitsalesprice").ToString)
                            //        lstitem.SubItems.Add(dtgetcards.Rows(j).Item("cosmeticsunitcostprice").ToString)
                            //        lstitem.SubItems.Add(dtgetcards.Rows(j).Item("expirydate").ToString)
                            //        lstitem.SubItems.Add(dtgetcards.Rows(j).Item("entrydate").ToString)
                            //        lsvitems1.Items.Add(lstitem)
                            //    Next
                            //End If
                            //Dim dtgetexpirydate As New System.Data.DataTable
                            //dtgetexpirydate = getdatabase("select cosmeticsid,cosmeticsname,cosmeticsquantity,cosmeticsunitcostprice,cosmeticsunitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber,entrydate from cosmeticsexpirydate where cosmeticsname ='" & ProductName1 & "'order by cosmeticsid")
                            //If dtgetexpirydate.Rows.Count > 0 Then
                            //    For k = 0 To dtgetexpirydate.Rows.Count - 1
                            //        If CInt(dtgetexpirydate.Rows(0).Item("cosmeticsquantity")) < CInt(txtcardsquantity.Text) Then
                            //            newquantity1 = (CInt(dtgetexpirydate.Rows(0).Item("cosmeticsquantity")) + CInt(dtgetexpirydate.Rows(k + 1).Item("cosmeticsquantity"))) - CInt(txtcardsquantity.Text)
                            //            strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                            //            cn.ConnectionString = strconnection
                            //            cn.Open()
                            //            cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" & newquantity1 & " Where cosmeticsname='" & ProductName1 & "' And cosmeticsid =" & CInt(dtgetexpirydate.Rows(k + 1).Item("cosmeticsid")) & ";"
                            //            cm.Connection = cn
                            //            cm.ExecuteNonQuery()
                            //            cn.Close()
                            //            strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                            //            cn.ConnectionString = strconnection
                            //            'Dim intnewproductid As Integer
                            //            'intnewproductid = CInt(dtgetexpirydate.Rows(0).Item("quantity"))
                            //            newquantity1 = 0
                            //            cn.Open()
                            //            cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" & newquantity1 & " Where cosmeticsname='" & ProductName1 & "' And cosmeticsid=" & CInt(dtgetexpirydate.Rows(k).Item("cosmeticsid")) & ";"
                            //            cm.Connection = cn
                            //            cm.ExecuteNonQuery()
                            //            cn.Close()
                            //            cn.Open()
                            //            cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" & CStr(dtgetexpirydate.Rows(k).Item("cosmeticsname")) & "','" & newquantity1 & "','" & CDbl(dtgetexpirydate.Rows(k).Item("cosmeticsunitcostprice")) & "','" & CDbl(dtgetexpirydate.Rows(k).Item("cosmeticsunitsalesprice")) & "','" & CDate(dtgetexpirydate.Rows(k).Item("expirydate")) & "','" & CStr(dtgetexpirydate.Rows(k).Item("suppliername")) & "','" & CStr(dtgetexpirydate.Rows(k).Item("supplierphonenumber")) & "','" & CDate(dtgetexpirydate.Rows(k).Item("datepurchased")) & "'," & CDbl(dtgetexpirydate.Rows(k).Item("amountpaid")) & ",'" & CStr(dtgetexpirydate.Rows(k).Item("invoicenumber")) & "')"
                            //            cm.Connection = cn
                            //            cm.ExecuteNonQuery()
                            //            cn.Close()
                            //            cn.Open()
                            //            cm.CommandText = "Delete from cosmeticsexpirydate where cosmeticsid= " & CInt(dtgetexpirydate.Rows(k).Item("cosmeticsid")) & ""
                            //            cm.Connection = cn
                            //            cm.ExecuteNonQuery()
                            //            cn.Close()
                            //            txtcardsquantity.Text = ""
                            //            txtunitsalesprice1.Text = ""
                            //            GoTo 379
                            //        Else
                            //            newquantity1 = CInt(dtgetexpirydate.Rows(0).Item("cosmeticsquantity")) - CInt(txtcardsquantity.Text)
                            //            strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                            //            cn.ConnectionString = strconnection
                            //            cn.Open()
                            //            cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" & newquantity1 & " Where cosmeticsname='" & ProductName1 & "' And cosmeticsid=" & CInt(dtgetexpirydate.Rows(0).Item("cosmeticsid")) & ";"
                            //            cm.Connection = cn
                            //            cm.ExecuteNonQuery()
                            //            cn.Close()
                            //            GoTo 380
                            //            '    'and  productid <> " & intproductid & "
                            //            '    'Else
                            //            '    '    cn.Open()
                            //            '    '    cm.CommandText = "Update expirydate Set quantity=" & newquantity & " Where productid=" & intproductid & ";"
                            //            '    '    cm.Connection = cn
                            //            '    '    cm.ExecuteNonQuery()
                            //            '    cn.Close()
                            //        End If
                            //    Next
                            //End If
                        }
                        else
						{
							MessageBox.Show("please Select The Product To Sell");
						}
					}
					else
					{
						MessageBox.Show("please Enter a Number");
					}
				}
				txtcardsquantity.Text = 1.ToString();
				txtunitsalesprice1.Text = "";
				txtcosmeticsid.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			try
			{
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                double amount = 0;
                string strconnection = "";
              
				double totalamount = 0;
				dtgetsales = getdatabase("select amount from sales");
				double temp = 0;
				if (dtgetsales.Rows.Count > 0)
				{
					for (var i = 0; i < dtgetsales.Rows.Count; i++)
					{
						temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
					}
				}
				totalamount = temp;
				viewsales x = new viewsales();
                System.Data.DataTable dtgetreceipt = new System.Data.DataTable();

                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                cn.Open();
                cm.CommandText = "Insert Into receipt() values()";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                dtgetreceipt = getdatabase("select * from receipt");
                totalamount = temp;
                if (dtgetreceipt.Rows.Count > 0)
                {
                    x.txtreceiptnumber.Text = dtgetreceipt.Rows.Count.ToString();
                }
                x.txtcashiername1.Text = txtcashiername1.Text;
				x.txttotal.Text = totalamount.ToString();
				x.txtdiscount.Text = 0.ToString();
				x.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			viewsaleslog x = new viewsaleslog();
			x.Show();
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

		private void txtcardssearch_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetcards = new System.Data.DataTable();
				dtgetcards = getdatabase("Select * From cosmetics Where cosmeticsname Like '%" + txtcardssearch.Text + "%' Order By cosmeticsname;");
				if (dtgetcards.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems1.Items.Clear();
					for (var j = 0; j < dtgetcards.Rows.Count; j++)
					{

						lstitem = new ListViewItem();
						lstitem.Text = dtgetcards.Rows[j]["cosmeticsid"].ToString();
						lstitem.SubItems.Add(dtgetcards.Rows[j]["cosmeticsname"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[j]["cosmeticsquantity"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[j]["cosmeticsunitsalesprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[j]["cosmeticsunitcostprice"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[j]["expirydate"].ToString());
						lstitem.SubItems.Add(dtgetcards.Rows[j]["entrydate"].ToString());
						lsvitems1.Items.Add(lstitem);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void txtseachdrugs_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				dtgetproduct = getdatabase("Select * From product Where productname Like '%" + txtseachdrugs.Text + "%' Order By productname;");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var j = 0; j < dtgetproduct.Rows.Count; j++)
					{
                        if (Convert.ToInt32(dtgetproduct.Rows[j]["quantity"].ToString()) < 6)
                        {

                            lstitem = new ListViewItem();
                            lstitem.ForeColor = Color.Red;
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                        else
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
				if (Simulate.IsNumeric(Convert.ToInt32(lsvitems.SelectedItems[0].Text)))
				{
					intproductid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
					//Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
					dtgetsales = getdatabase(" select * from product where productid=" + intproductid);
					txtunitsalesprice.Text = Convert.ToDouble(dtgetsales.Rows[0]["unitsalesprice"]).ToString();
                    txtproductname.Text = dtgetsales.Rows[0]["productname"].ToString();

                    txtdrugid.Text = Convert.ToDouble(dtgetsales.Rows[0]["productid"]).ToString();
					intproductid = Convert.ToInt32(txtdrugid.Text);
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
					txtunitsalesprice1.Text = Convert.ToDouble(dtgetsales.Rows[0]["cosmeticsunitsalesprice"]).ToString();
					txtcosmeticsid.Text = Convert.ToDouble(dtgetsales.Rows[0]["cosmeticsid"]).ToString();
					intproductid = Convert.ToInt32(txtcosmeticsid.Text);
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

		private void adminsales_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
				if (dtgetproduct.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var j = 0; j < dtgetproduct.Rows.Count; j++)
					{
                        if (Convert.ToInt32(dtgetproduct.Rows[j]["quantity"].ToString()) < 6)
                        {

                            lstitem = new ListViewItem();
                            lstitem.ForeColor = Color.Red;
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                        else
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
				txtquantity.Text = 1.ToString();
				//Dim time1 As String
				//time1 = TimeOfDay
				//txttime.Text = time1
				//Dim dtgetproduct As New System.Data.DataTable
				//dtgetproduct = getdatabase("select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate from product")
				//dgvsales.DataSource = dtgetproduct
				//With dgvsales
				//    .RowHeadersVisible = False
				//    .Columns(0).HeaderCell.Value = "ID"
				//    .Columns(1).HeaderCell.Value = "Product Name"
				//    .Columns(2).HeaderCell.Value = "Qtys"
				//    .Columns(3).HeaderCell.Value = "S/Price"
				//    .Columns(4).HeaderCell.Value = "C/Price"
				//    .Columns(5).HeaderCell.Value = "Exp.Date"
				//    '.Columns(6).HeaderCell.Value = "Entry Date"
				//End With
				//Dim dtgetdrinks As New System.Data.DataTable
				//dtgetdrinks = getdatabase("select drinksid,drinksname,drinksquantity,drinksunitsalesprice,drinksunitcostprice,expirydate from drinks")
				//dgvdrinks.DataSource = dtgetdrinks
				//With dgvdrinks
				//    .RowHeadersVisible = False
				//    .Columns(0).HeaderCell.Value = "ID"
				//    .Columns(1).HeaderCell.Value = "Product Name"
				//    .Columns(2).HeaderCell.Value = "Qtys"
				//    .Columns(3).HeaderCell.Value = "S/Price"
				//    .Columns(4).HeaderCell.Value = "C/Price"
				//    .Columns(5).HeaderCell.Value = "Expiry Date"
				//    '    .Columns(6).HeaderCell.Value = "Entry Date"
				//End With
				System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
				dtgetcosmetics = getdatabase("select cosmeticsid,cosmeticsname,cosmeticsquantity,cosmeticsunitsalesprice,cosmeticsunitcostprice,expirydate,entrydate from cosmetics");
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
				txtcardsquantity.Text = 1.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				double totalamount = 0;
				dtgetsales = getdatabase("select amount from holdsales");
				double temp = 0;
				if (dtgetsales.Rows.Count > 0)
				{
					for (var i = 0; i < dtgetsales.Rows.Count; i++)
					{
						temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
					}
				}
				totalamount = temp;
				holdsales x = new holdsales();
				x.txtcashiername1.Text = txtcashiername1.Text;
				x.txttotal.Text = totalamount.ToString();
				x.txtdiscount.Text = 0.ToString();
				x.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

        private void thisMonth_Click(object sender, EventArgs e)
        {
            trackExpiryDate3 x = new trackExpiryDate3();
            x.Show();
        }

        private void thisMonth2_Click(object sender, EventArgs e)
        {
            trackExpiryDate1 x = new trackExpiryDate1();
            x.Show();
        }

        private void thisMonth1_Click(object sender, EventArgs e)
        {
            trackExpiryDate2 x = new trackExpiryDate2();
            x.Show();
        }

        private void lbname_Click(object sender, EventArgs e)
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
                        if (Convert.ToInt32(dtgetproduct.Rows[j]["quantity"].ToString()) < 6)
                        {

                            lstitem = new ListViewItem();
                            lstitem.ForeColor = Color.Red;
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                            //   lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                        else
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                            //               lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}