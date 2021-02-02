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
using System.Text.RegularExpressions;

namespace BusinessApp
{
	public partial class viewsales
	{
		internal viewsales()
		{
			InitializeComponent();
		}
        Regex rg = new Regex("^[0-9]+$");
		public double discount;
		public string txttotal1;
		public string txtcash1;
		public int inttransactionid;
		//Public lscitems1 As Double
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
		private void txttime_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void receipt_Load(object sender, System.EventArgs e)
		{
			try
            {
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");
                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                txtcash.Focus();
                DataTable dtgetreceipt = getdatabase("select * from receipt");
                if (dtgetreceipt.Rows.Count > 0)
                {
                    txtreceiptnumber.Text = dtgetreceipt.Rows.Count.ToString();
                }
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
				dtgetsales = getdatabase("select transactionid,quantitysold,itemsold,unitprice,amount from sales order by itemsold");
				if (dtgetsales.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetsales.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetsales.Rows[i]["transactionid"].ToString();
						lstitem.SubItems.Add(dtgetsales.Rows[i]["itemsold"].ToString());
						lstitem.SubItems.Add(dtgetsales.Rows[i]["quantitysold"].ToString());
						lstitem.SubItems.Add(dtgetsales.Rows[i]["unitprice"].ToString());
						lstitem.SubItems.Add(dtgetsales.Rows[i]["amount"].ToString());
						lsvitems.Items.Add(lstitem);
					}
					
					string time1 = null;
					 time1 = DateTime.Now.ToShortTimeString();
                    txttime.Text = time1;
					txttotal1 = (txttotal.Text).ToString();
					txtcash1 = (txtcash.Text).ToString();
				}
				else
				{
					lsvitems.Clear();
                   // txtcashiername1.Text = txtcashiername1.Text;
                    txtreceiptnumber.Text = "";
					txttotal.Text = "";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Label6_Click(object sender, System.EventArgs e)
		{

		}

		private void Label5_Click(object sender, System.EventArgs e)
		{

		}

		private void DateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{

		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			try
			{
                if (rg.Match(txtcash.Text).Success)
                {
                    MySqlConnection cn = new MySqlConnection();
                    MySqlDataAdapter ad = new MySqlDataAdapter();
                    MySqlCommand cm = new MySqlCommand();
                    string strconnection = null;
                    double amount = 0;
                    System.Data.DataTable dtgetsales = new System.Data.DataTable();
                    System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                    System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
                    double totalamount = 0;
                    dtgetsales = getdatabase("select amount from sales");
                    double temp = 0;
                    double change = Convert.ToDouble(txtcash.Text) - Convert.ToDouble(txtgrandtotal.Text);

                    if (txtcash.Text == "")
                    {
                        MessageBox.Show("Please Enter the Cash Paid");
                        txtcash.Focus();
                    }
                    else if (Convert.ToDouble(txtcash.Text) < Convert.ToDouble(txtgrandtotal.Text))
                    {
                        MessageBox.Show("Please  the Cash Paid is less Than the Cost of items Purchased");
                        txtcash.Focus();
                    }
                    if (dtgetsales.Rows.Count > 0 && Convert.ToDouble(txtcash.Text) >= Convert.ToDouble(txtgrandtotal.Text))
                    {
                        for (var i = 0; i < dtgetsales.Rows.Count; i++)
                        {
                            temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                        }
                        // cbotesttype.Items.Add(dtgettesttype.Rows(i).Item("testname").ToString)
                    }
                    totalamount = temp;
                    dtgetsales = getdatabase("select * from sales");
                    if (dtgetsales.Rows.Count > 0 && (Convert.ToDouble(txtcash.Text) >= Convert.ToDouble(txtgrandtotal.Text)))
                    {
                        for (var i = 0; i < dtgetsales.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dtgetsales.Rows[i]["productid"]) != Convert.ToInt32("0"))
                            {
                                double v = 0;
                                double amountcost = 0;
                                double profit = 0;
                                int newquantity = 0;
                                int newquantity1 = 0;
                                string ProductName1 = null;
                                int intproductid = 0;
                                ProductName1 = dtgetsales.Rows[i]["itemsold"].ToString();
                                v = Convert.ToDouble(dtgetsales.Rows[i]["unitcostprice"]);
                                amountcost = v * Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                double a = 0;
                                a = Convert.ToDouble(dtgetsales.Rows[i]["unitprice"]);
                                amount = a * Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                profit = amount - amountcost;

                                discount = 0;
                                intproductid = Convert.ToInt32(dtgetsales.Rows[i]["productid"]);
                                dtgetproduct = getdatabase("select * from product where productid=" + intproductid);
                                if (Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) >= Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]))
                                {
                                    System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                                    dtgetexpirydate = getdatabase("select * from expirydate where productname ='" + ProductName1 + "'order by expirydateid");
                                    if (dtgetexpirydate.Rows.Count > 0)
                                    {
                                        for (var k = 0; k < dtgetexpirydate.Rows.Count; k++)
                                        {
                                            if (Convert.ToInt32(dtgetexpirydate.Rows[k]["quantity"]) <= Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]))
                                            {
                                                if (dtgetexpirydate.Rows.Count > 1)
                                                {
                                                    newquantity1 = (Convert.ToInt32(dtgetexpirydate.Rows[k]["quantity"]) + Convert.ToInt32(dtgetexpirydate.Rows[k + 1]["quantity"])) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Update expirydate Set quantity=" + newquantity1 + " Where productname='" + ProductName1 + "' And expirydateid =" + Convert.ToInt32(dtgetexpirydate.Rows[k + 1]["expirydateid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    //Dim intnewproductid As Integer
                                                    //intnewproductid = CInt(dtgetexpirydate.Rows(0).Item("quantity"))
                                                    cn.Open();
                                                    newquantity1 = 0;
                                                    cm.CommandText = "Update expirydate Set quantity=" + newquantity1 + " Where productname='" + ProductName1 + "' And expirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[k]["expirydateid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + Convert.ToString(dtgetexpirydate.Rows[k]["productname"]) + "','" + newquantity1 + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitcostprice"]) + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitsalesprice"]) + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["suppliername"] + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"] + "','" + dtgetexpirydate.Rows[k]["datepurchased"] + "','" + dtgetexpirydate.Rows[k]["amountpaid"] + "','" + dtgetexpirydate.Rows[k]["invoicenumber"] + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Delete from expirydate where expirydateid= " + Convert.ToInt32(dtgetexpirydate.Rows[k]["expirydateid"]) + "";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into drugslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text +"','" + txtdiscount.Text +"','" + change.ToString() +"')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into generalsaleslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                    cm.CommandText = "Update product Set quantity=" + newquantity + " Where productid=" + intproductid + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    goto brake1;
                                                }
                                                else if (dtgetexpirydate.Rows.Count == 1 && Convert.ToInt32(dtgetexpirydate.Rows[k]["quantity"]) == Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]))
                                                {
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    newquantity1 = Convert.ToInt32(dtgetexpirydate.Rows[k]["quantity"]);
                                                    cm.CommandText = "Update expirydate Set quantity=" + newquantity1 + " Where productname='" + ProductName1 + "' And expirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[k]["expirydateid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + Convert.ToString(dtgetexpirydate.Rows[k]["productname"]) + "','" + newquantity1 + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitcostprice"]) + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitsalesprice"]) + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["suppliername"] + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"] + "','" + dtgetexpirydate.Rows[k]["datepurchased"] + "','" + dtgetexpirydate.Rows[k]["amountpaid"] + "','" + dtgetexpirydate.Rows[k]["invoicenumber"] + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Delete from expirydate where expirydateid= " + Convert.ToInt32(dtgetexpirydate.Rows[k]["expirydateid"]) + "";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into drugslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into generalsaleslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                    cm.CommandText = "Update product Set quantity=" + newquantity + " Where productid=" + intproductid + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    goto brake1;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please The Total Quantity in the DRUGS TABLE and  EXPIRYDATE TABLE Is Different.Remove from CART And Harmonise First.The  DRUG's  ID Is: " + Convert.ToInt32(dtgetsales.Rows[i]["productid"]));
                                                }
                                            }

                                            else
                                            {
                                                newquantity1 = Convert.ToInt32(dtgetexpirydate.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Update expirydate Set quantity=" + newquantity1 + " Where productname='" + ProductName1 + "' And expirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[0]["expirydateid"]) + ";";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Insert Into drugslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Insert Into generalsaleslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                cm.CommandText = "Update product Set quantity=" + newquantity + " Where productid=" + intproductid + ";";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                goto brake1;
                                            }
                                        }
                                    brake1:;
                                    }
                                }
                                else
                                {
                                    System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                                    dtgetexpirydate = getdatabase("select * from expirydate where productname ='" + ProductName1 + "'order by expirydateid");
                                    if (dtgetexpirydate.Rows.Count > 0)
                                    {
                                        newquantity1 = Convert.ToInt32(dtgetexpirydate.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                        cn.ConnectionString = strconnection;
                                        cn.Open();
                                        cm.CommandText = "Update expirydate Set quantity=" + newquantity1 + " Where productname='" + ProductName1 + "' And expirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[0]["expirydateid"]) + ";";
                                        cm.Connection = cn;
                                        cm.ExecuteNonQuery();
                                        cn.Close();
                                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                        cn.ConnectionString = strconnection;
                                        cn.Open();
                                        cm.CommandText = "Insert Into drugslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                        cm.Connection = cn;
                                        cm.ExecuteNonQuery();
                                        cn.Close();
                                        cn.ConnectionString = strconnection;
                                        cn.Open();
                                        cm.CommandText = "Insert Into generalsaleslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                        cm.Connection = cn;
                                        cm.ExecuteNonQuery();
                                        cn.Close();
                                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                        cn.ConnectionString = strconnection;
                                        cn.Open();
                                        newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                        cm.CommandText = "Update product Set quantity=" + newquantity + " Where productid=" + intproductid + ";";
                                        cm.Connection = cn;
                                        cm.ExecuteNonQuery();
                                        cn.Close();
                                        goto brake1;

                                    } 
                                    brake1:;
                                    
                                }
                            }
                            else
                            {
                                double v = 0;
                                double amountcost = 0;
                                double profit = 0;
                                string ProductName1 = null;
                                ProductName1 = dtgetsales.Rows[i]["itemsold"].ToString();
                                int newquantity = 0;
                                int newquantity1 = 0;
                                v = Convert.ToDouble(dtgetsales.Rows[i]["unitcostprice"]);
                                amountcost = v * Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                double a = 0;
                                a = Convert.ToDouble(dtgetsales.Rows[0]["unitprice"]);
                                amount = a * Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                profit = amount - amountcost;
                                dtgetcosmetics = getdatabase("select * from cosmetics where cosmeticsid=" + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]) + "");
                                if (Convert.ToInt32(dtgetcosmetics.Rows[0]["cosmeticsquantity"]) >= Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]))
                                {
                                    System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                                    dtgetexpirydate = getdatabase("select * from cosmeticsexpirydate where cosmeticsname ='" + ProductName1 + "'order by cosmeticsexpirydateid");
                                    if (dtgetexpirydate.Rows.Count > 0)
                                    {
                                        for (var k = 0; k < dtgetexpirydate.Rows.Count; k++)
                                        {
                                            if (Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsquantity"]) <= Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]))
                                            {
                                                if (dtgetexpirydate.Rows.Count > 1)
                                                {
                                                    newquantity1 = (Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsquantity"]) + Convert.ToInt32(dtgetexpirydate.Rows[k + 1]["cosmeticsquantity"])) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" + newquantity1 + " Where cosmeticsname='" + ProductName1 + "' And cosmeticsexpirydateid =" + Convert.ToInt32(dtgetexpirydate.Rows[k + 1]["cosmeticsexpirydateid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    //Dim intnewproductid As Integer
                                                    //intnewproductid = CInt(dtgetexpirydate.Rows(0).Item("quantity"))
                                                    newquantity1 = 0;
                                                    cn.Open();
                                                    cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" + newquantity1 + " Where cosmeticsname='" + ProductName1 + "' And cosmeticsexpirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[k]["cosmeticsexpirydateid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + dtgetexpirydate.Rows[k]["cosmeticsname"] + "','" + newquantity1 + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["cosmeticsunitcostprice"]) + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["cosmeticsunitsalesprice"]) + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["suppliername"] + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"] + "','" + dtgetexpirydate.Rows[k]["datepurchased"] + "','" + dtgetexpirydate.Rows[k]["amountpaid"] + "','" + dtgetexpirydate.Rows[k]["invoicenumber"] + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Delete from cosmeticsexpirydate where cosmeticsexpirydateid= " + Convert.ToInt32(dtgetexpirydate.Rows[k]["cosmeticsexpirydateid"]) + "";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into cosmeticslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into generalsaleslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    newquantity = Convert.ToInt32(dtgetcosmetics.Rows[0]["cosmeticsquantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                    cm.CommandText = "Update cosmetics Set cosmeticsquantity=" + newquantity + " Where cosmeticsid=" + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    goto brake2;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please The Total Quantity in the COSMETICS TABLE and COSMETICS EXPIRYDATE TABLE Is Diferent.Remove from CART And Harmonise First.The  COSMETICS's  ID Is: " + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]));

                                                }
                                            }
                                            else
                                            {
                                                newquantity1 = Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsquantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" + newquantity1 + " Where cosmeticsname='" + ProductName1 + "' And cosmeticsid=" + Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsid"]) + ";";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Insert Into cosmeticslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Insert Into generalsaleslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                newquantity = Convert.ToInt32(dtgetcosmetics.Rows[0]["cosmeticsquantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                cm.CommandText = "Update cosmetics Set cosmeticsquantity=" + newquantity + " Where cosmeticsid=" + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]) + ";";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                            }
                                            goto brake2;
                                        }
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Please There a Product Quantity Less Than The Quatity You Are Trying Sell.The  COSMETICS's  ID Is: " + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]));
                                    goto brake2;
                                }
                            brake2:;
                            }

                        }
                        //Dim x As New finalreceipt
                        //x.txtcashiername1.Text = txtcashiername1.Text
                        receiptmidip x = new receiptmidip();
                        x.txtcashiername1.Text = txtcashiername1.Text;
                        x.txttotal.Text = txtgrandtotal.Text;
                        x.txtdiscount1.Text = txtdiscount.Text;
                        x.txtcash.Text = txtcash.Text;
                        x.txtreceiptnumber.Text = txtreceiptnumber.Text;
                        x.txtchange.Text = change.ToString();
                        x.Show();
                        txttotal.Text = "";
                        txtcash.Text = "";
                        txtdiscount.Text = "";
                        txtgrandtotal.Text = "";
                        cbldiscount.Text = "";
                        txtdiscountapproval.Text = "";
                        lsvitems.Clear();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please, Enter Only Numeric Values");
                    txtcash.Focus();

                }
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());

			}

		}

		private void Button2_Click(object sender, System.EventArgs e)
		{

		}

		private void Label8_Click(object sender, System.EventArgs e)
		{

		}

		private void Label7_Click(object sender, System.EventArgs e)
		{

		}

		private void cbldiscount_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}

		private void txtgrandtotal_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				double finaltotal = 0;
				finaltotal = Convert.ToDouble(txttotal.Text) - Convert.ToDouble(txtdiscount.Text);
				txtgrandtotal.Text = finaltotal.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());

			}
		}

		private void txtgrandtotal_MouseHover(object sender, System.EventArgs e)
		{

		}

		private void txtgrandtotal_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void txtdiscount_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetadmin = new System.Data.DataTable();
				dtgetadmin = getdatabase("Select * from administrator");
				if (string.IsNullOrEmpty(cbldiscount.Text) && string.IsNullOrEmpty(txtnairadiscount.Text))
				{
					txtdiscount.Text = 0.ToString();
				}
				else if (string.IsNullOrEmpty(cbldiscount.Text) && !string.IsNullOrEmpty(txtnairadiscount.Text))
				{
					if (dtgetadmin.Rows.Count > 0)
					{
						for (var i = 0; i < dtgetadmin.Rows.Count; i++)
						{
							if (txtdiscountapproval.Text == (dtgetadmin.Rows[i]["adminpassword"]).ToString() || txtcashiername1.Text.ToUpper() == Convert.ToString(dtgetadmin.Rows[i]["adminname"]).ToUpper())
							{
			
								txtdiscount.Text =(Convert.ToInt32(discount) + Convert.ToInt32(txtnairadiscount.Text)).ToString();
							}
							else
							{
								MessageBox.Show("Please Look For The Administrator");
								txtdiscountapproval.Focus();
							}
						}
					}
				}
				else if (!string.IsNullOrEmpty(cbldiscount.Text))
				{
					if (dtgetadmin.Rows.Count > 0)
					{
						for (var i = 0; i < dtgetadmin.Rows.Count; i++)
						{
							if (txtdiscountapproval.Text == (dtgetadmin.Rows[i]["adminpassword"]).ToString())
							{
								txtdiscount.Text = (discount + (Convert.ToDouble(txttotal.Text) * (Convert.ToDouble(cbldiscount.Text)) / 100)).ToString();
							}
							else if (txtcashiername1.Text.ToUpper() == Convert.ToString(dtgetadmin.Rows[i]["adminname"]).ToUpper())
							{
								txtdiscount.Text = (discount + (Convert.ToDouble(txttotal.Text) * (Convert.ToDouble(cbldiscount.Text)) / 100)).ToString();
							}
							else
							{
								MessageBox.Show("Please Look For The Administrator");
								txtdiscountapproval.Focus();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());

			}
		}

		private void txtdiscount_MouseHover(object sender, System.EventArgs e)
		{
		}

		private void txtdiscount_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void txtdiscountapproval_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void TextBox1_ChangeUICues(object sender, System.Windows.Forms.UICuesEventArgs e)
		{

		}

		private void TextBox1_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void lsvitems_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				int inttransactionid = 0;
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				if (Simulate.IsNumeric(Convert.ToInt32(lsvitems.SelectedItems[0].Text)))
				{
					inttransactionid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
					//Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
					dtgetsales = getdatabase(" select * from sales where transactionid=" + inttransactionid);
					txtproductname.Text = (dtgetsales.Rows[0]["itemsold"]).ToString();
					txttransactionid.Text = (dtgetsales.Rows[0]["transactionid"]).ToString();
					txtquantity.Text = (dtgetsales.Rows[0]["quantitysold"]).ToString();
					inttransactionid = Convert.ToInt32(txttransactionid.Text);
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

		private void Button2_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				string strconnection = null;
				double x = 0;
				int inttransactionid = 0;
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				if (Simulate.IsNumeric(Convert.ToInt32(lsvitems.SelectedItems[0].Text)))
				{
					inttransactionid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
					dtgetsales = getdatabase(" select * from sales where transactionid=" + inttransactionid);
					x = Convert.ToInt32(txtquantity.Text) * Convert.ToDouble(dtgetsales.Rows[0]["unitprice"]);
					strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
					cn.ConnectionString = strconnection;
					cn.Open();
					cm.CommandText = "Update sales Set quantitysold='" + txtquantity.Text + "', amount=" + x + " Where transactionid=" + inttransactionid + ";";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					dtgetsales = getdatabase("select transactionid,quantitysold,itemsold,unitprice,amount from sales order by itemsold");
					if (dtgetsales.Rows.Count > 0)
					{
						ListViewItem lstitem = new ListViewItem();
						lsvitems.Items.Clear();
						for (var i = 0; i < dtgetsales.Rows.Count; i++)
						{
							lstitem = new ListViewItem();
							lstitem.Text = dtgetsales.Rows[i]["transactionid"].ToString();
							lstitem.SubItems.Add(dtgetsales.Rows[i]["itemsold"].ToString());
							lstitem.SubItems.Add(dtgetsales.Rows[i]["quantitysold"].ToString());
							lstitem.SubItems.Add(dtgetsales.Rows[i]["unitprice"].ToString());
							lstitem.SubItems.Add(dtgetsales.Rows[i]["amount"].ToString());
							lsvitems.Items.Add(lstitem);
						}
					}
				}
				else
				{
					MessageBox.Show("Please Select The ProductID");
				}
				//Dim totalamount As Double
				dtgetsales = getdatabase("select amount from sales");
				double temp = 0;
				if (dtgetsales.Rows.Count > 0)
				{
					for (var i = 0; i < dtgetsales.Rows.Count; i++)
					{
						temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
					}
				}
				txttotal.Text = temp.ToString();
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
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				string strconnection = "";
				strconnection = "server=localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				inttransactionid = Convert.ToInt32((txttransactionid.Text).ToString());
				dtgetproduct = getdatabase("Select * From sales where transactionid=" + inttransactionid);
				cn.Open();
				cm.CommandText = "Delete from sales where transactionid=" + inttransactionid + ";";
				cm.Connection = cn;
				cm.ExecuteNonQuery();
				cn.Close();
				editsales x = new editsales();
				x.txttransactionid.Text = inttransactionid.ToString();
				x.txtitemsold.Text = (dtgetproduct.Rows[0]["itemsold"]).ToString();
				x.txtcashiername1.Text = txtcashiername1.Text;
				x.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void viewsales_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				txtcash.Focus();
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				dtgetsales = getdatabase("select transactionid,quantitysold,itemsold,unitprice,amount from sales order by itemsold");
				if (dtgetsales.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var i = 0; i < dtgetsales.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetsales.Rows[i]["transactionid"].ToString();
						lstitem.SubItems.Add(dtgetsales.Rows[i]["itemsold"].ToString());
						lstitem.SubItems.Add(dtgetsales.Rows[i]["quantitysold"].ToString());
						lstitem.SubItems.Add(dtgetsales.Rows[i]["unitprice"].ToString());
						lstitem.SubItems.Add(dtgetsales.Rows[i]["amount"].ToString());
						lsvitems.Items.Add(lstitem);
					}
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
					txttotal.Text = temp.ToString();
					System.Data.DataTable dtgetsaleslog = new System.Data.DataTable();
                    DataTable dtgetreceipt = getdatabase("select * from receipt");
                    if (dtgetreceipt.Rows.Count > 0)
                    {
                        txtreceiptnumber.Text = dtgetreceipt.Rows.Count.ToString();
                    }
                    txtcashiername1.Text = txtcashiername1.Text;
				}
				else
				{
					lsvitems.Clear();
					txttotal.Text = "";
					txtreceiptnumber.Text = "";
                    txtgrandtotal.Text = "";
                    txtcash.Text = "";
				}
				string time1 = null;
				 time1 = DateTime.Now.ToShortTimeString();
				txttime.Text = time1;
				txttotal1 = (txttotal.Text).ToString();
				txtcash1 = (txtcash.Text).ToString();
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
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				System.Data.DataTable dtgetholdsales = new System.Data.DataTable();
				dtgetholdsales = getdatabase("select * from holdsales");
				if (dtgetholdsales.Rows.Count > 0)
				{
					MessageBox.Show("Please A Transaction Is Already On HOLD. Attend To That CUSTOMER or Clear HOLDSALES. Please Click On 'VIEW HOLD SALEs'");
				}
				else
				{
					dtgetsales = getdatabase("select * from sales");
					string strconnection = "";
					strconnection = "server=localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
					cn.ConnectionString = strconnection;
					if (dtgetsales.Rows.Count > 0)
					{
						for (var i = 0; i < dtgetsales.Rows.Count; i++)
						{
							if (Convert.ToInt32(dtgetsales.Rows[i]["productid"]) > 0)
							{
								cn.Open();
								cm.CommandText = "Insert Into holdsales(cashiername,itemsold,quantitysold,unitcostprice,unitprice,amount,discount,productid) Values('" + dtgetsales.Rows[i]["cashiername"].ToString() + "','" + dtgetsales.Rows[i]["itemsold"].ToString() + "','" + dtgetsales.Rows[i]["quantitysold"].ToString() + "','" + dtgetsales.Rows[i]["unitcostprice"] + "','" + dtgetsales.Rows[i]["unitprice"] + "'," + dtgetsales.Rows[i]["amount"].ToString() + "," + dtgetsales.Rows[i]["discount"].ToString() + "," + dtgetsales.Rows[i]["productid"].ToString() + ")";
								cm.Connection = cn;
								cm.ExecuteNonQuery();
								cn.Close();
							}
							else
							{
								//CInt(dtgetsales.Rows(i).Item("cosmeticsid"))
								cn.Open();
								cm.CommandText = "Insert Into holdsales(cashiername,itemsold,quantitysold,unitcostprice,unitprice,amount,discount,cosmeticsid) Values('" + dtgetsales.Rows[i]["cashiername"].ToString() + "','" + dtgetsales.Rows[i]["itemsold"].ToString() + "','" + dtgetsales.Rows[i]["quantitysold"].ToString() + "','" + dtgetsales.Rows[i]["unitcostprice"] + "','" + dtgetsales.Rows[i]["unitprice"] + "'," + dtgetsales.Rows[i]["amount"].ToString() + "," + dtgetsales.Rows[i]["discount"].ToString() + "," + dtgetsales.Rows[i]["cosmeticsid"].ToString() + ")";
								cm.Connection = cn;
								cm.ExecuteNonQuery();
								cn.Close();
							}
						}
					}

					cn.Open();
					cm.CommandText = "Delete from sales where transactionid>0";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("GOOD! The Sales Is On Hold. Just Click On The Form to Confirm and Then Carry On. To Resume This Sales Click On 'VIEW HOLD SALES' button. ");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button5_Click(object sender, System.EventArgs e)
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

		private void Button6_Click(object sender, System.EventArgs e)
		{
			            clearcart v = new clearcart();
            v.txtcashiername.Text = txtcashiername1.Text;
            this.Close();
            v.Show();
		}
	}
}