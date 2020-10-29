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
using System.Threading.Tasks;
namespace BusinessApp
{
	public partial class sales
	{
		internal sales()
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

		private void DateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
			DateTimePicker x = new DateTimePicker();
			x.Value = Convert.ToDateTime(DateTimePicker1.Value);

		}

		private void sales_Load(object sender, System.EventArgs e)
        {
			try
            {
                Label12.Hide();
                txtcosmeticsid.Hide();
                Label13.Hide();
                txtcosmeticsname.Hide();
                Label7.Hide();
                txtcardsquantity.Hide();
                btncards.Hide();
                PictureBox2.Hide();
                txtcardssearch.Hide();
                Label14.Hide();
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");

                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                lbname.Visible = false;
                lbaddress.Visible = false;
                //            lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                // Use TimeSpan and some date calculaton, this should work:
                lsvitems1.Visible = false;
                Label12.Visible = false;
                txtcosmeticsid.Visible = false;
                Label13.Visible = false;
                txtcosmeticsname.Visible = false;
                Label7.Visible = false;
                txtcardsquantity.Visible = false;
                btncards.Visible = false;
                txtcardssearch.Visible = false;
                Label14.Visible = false;
                PictureBox2.Visible = false;
                string quantityColor;
				System.Data.DataTable dtgetproduct = new System.Data.DataTable();
				dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
				if (dtgetproduct.Rows.Count > 0)
				{

					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();
					for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        //lstitem = new ListViewItem();
                    {
                        if (Convert.ToInt32(dtgetproduct.Rows[j]["quantity"].ToString()) < 6)
                        {
                            
                            lstitem = new ListViewItem();
                            lstitem.ForeColor = Color.Red;
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("unitcostprice").ToString)
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
                            //lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("unitcostprice").ToString)
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
					}
					txtquantity.Text = 1.ToString();
                    string time1 = null;
                    time1 = DateTime.Now.ToShortTimeString();
                    txttime.Text = time1;
                    txtcode2.Focus();
                }


				
				//System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
				//dtgetcosmetics = getdatabase("select cosmeticsid,cosmeticsname,cosmeticsquantity,cosmeticsunitsalesprice,cosmeticsunitcostprice,expirydate,entrydate from cosmetics");
				//if (dtgetcosmetics.Rows.Count > 0)
				//{
				//	ListViewItem lstitem = new ListViewItem();
				//	lsvitems1.Items.Clear();
				//	for (var j = 0; j < dtgetcosmetics.Rows.Count; j++)
				//	{
				//		lstitem = new ListViewItem();
				//		lstitem.Text = dtgetcosmetics.Rows[j]["cosmeticsid"].ToString();
				//		lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsname"].ToString());
				//		lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsquantity"].ToString());
				//		lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["cosmeticsunitsalesprice"].ToString());
				//		//lstitem.SubItems.Add(dtgetcosmetics.Rows(j).Item("cosmeticsunitcostprice").ToString)
				//		lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["expirydate"].ToString());
				//		lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["entrydate"].ToString());
				//		lsvitems1.Items.Add(lstitem);
				//	}
				//	txtcardsquantity.Text = 1.ToString();
				//}
                int months = 0;
                int months1 = 0;
                int year = 0;
                int year1 = 0;
                int monthdiff1 = 0;
                int yeardiff = 0;
                int totalmonths = 0;
                int k= 0;
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
                            txt3 .Text = myCount[k].ToString() + "  Product(s) Will Expire Within The Next Three Months. ";
                            k = k + 1;
                            if (totalmonths == 0)
                            {
                                myCount1[l] = l + 1;
                                txt1 .Text = myCount1[l].ToString() + "  Product(s) Will Expire This Months.";
                                l = l + 1;
                            }

                        }
                        
                        else if (totalmonths < 0)
                        {
                            myCount2[v] = v + 1;
                            txt0 .Text = " You Have "+ myCount2[v].ToString() + " Expired Product(s). ";
                            v= v + 1;
                        }

                    }
                }
                        
                    }
    //            }
    //            else if ((ComboBox1.Text) == "Six Months(6) Time")
    //            {
    //                dtgetproduct = getdatabase("Select * from expirydate");
    //                if (dtgetproduct.Rows.Count > 0)
    //                {
    //                    ListViewItem lstitem = new ListViewItem();
    //                    lsvitems.Items.Clear();
    //                    for (var i = 0; i < dtgetproduct.Rows.Count; i++)
    //                    {
    //                        lstitem = new ListViewItem();
    //                        dateOne = Convert.ToDateTime(dtgetproduct.Rows[i]["expirydate"]);
    //                        months = dateOne.Month;
    //                        months1 = DateTimePicker1.Value.Month;
    //                        monthdiff1 = 12 - months1;
    //                        year = dateOne.Year;
    //                        year1 = DateTimePicker1.Value.Year;
    //                        //this helps to capture the full years  
    //                        yeardiff = ((year - 1) - (year1 + 1)) + 1;
    //                        totalmonths = (months + monthdiff1) + (12 * yeardiff);
    //                        if (totalmonths > -1 && totalmonths < 7)
    //                        {
    //                            lstitem.Text = dtgetproduct.Rows[i]["expirydateid"].ToString();
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["productid"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["productname"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["suppliername"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["supplierphonenumber"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["datepurchased"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["amountpaid"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["invoicenumber"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["entrydate"].ToString());
    //                            lsvitems.Items.Add(lstitem);
    //                        }
    //                    }
    //                    lsvitems.ForeColor = Color.DeepPink;
    //                    txttotal.Text = lsvitems.Items.Count.ToString();
    //                }
    //            }
    //            else if ((ComboBox1.Text) == "Above Six Months(6) Time")
    //            {
    //                dtgetproduct = getdatabase("Select * from expirydate");
    //                if (dtgetproduct.Rows.Count > 0)
    //                {
    //                    ListViewItem lstitem = new ListViewItem();
    //                    lsvitems.Items.Clear();
    //                    for (var i = 0; i < dtgetproduct.Rows.Count; i++)
    //                    {
    //                        lstitem = new ListViewItem();
    //                        dateOne = Convert.ToDateTime(dtgetproduct.Rows[i]["expirydate"]);
    //                        months = dateOne.Month;
    //                        months1 = DateTimePicker1.Value.Month;
    //                        monthdiff1 = 12 - months1;
    //                        year = dateOne.Year;
    //                        year1 = DateTimePicker1.Value.Year;
    //                        //this helps to capture the full years  
    //                        yeardiff = ((year - 1) - (year1 + 1)) + 1;
    //                        totalmonths = (months + monthdiff1) + (12 * yeardiff);
    //                        if (totalmonths > 6)
    //                        {
    //                            lstitem.Text = dtgetproduct.Rows[i]["expirydateid"].ToString();
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["productid"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["productname"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["suppliername"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["supplierphonenumber"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["datepurchased"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["amountpaid"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["invoicenumber"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["entrydate"].ToString());
    //                            lsvitems.Items.Add(lstitem);
    //                        }
    //                    }
    //                    lsvitems.ForeColor = Color.Green;
    //                    txttotal.Text = lsvitems.Items.Count.ToString();
    //                }
    //            }
    //            else if ((ComboBox1.Text) == "Drugs Already Expired")
    //            {
    //                dtgetproduct = getdatabase("Select * from expirydate");
    //                if (dtgetproduct.Rows.Count > 0)
    //                {
    //                    ListViewItem lstitem = new ListViewItem();
    //                    lsvitems.Items.Clear();
    //                    for (var i = 0; i < dtgetproduct.Rows.Count; i++)
    //                    {
    //                        lstitem = new ListViewItem();
    //                        dateOne = Convert.ToDateTime(dtgetproduct.Rows[i]["expirydate"]);
    //                        months = dateOne.Month;
    //                        months1 = DateTimePicker1.Value.Month;
    //                        monthdiff1 = 12 - months1;
    //                        year = dateOne.Year;
    //                        year1 = DateTimePicker1.Value.Year;
    //                        //this helps to capture the full years  
    //                        yeardiff = ((year - 1) - (year1 + 1)) + 1;
    //                        totalmonths = (months + monthdiff1) + (12 * yeardiff);
    //                        if (totalmonths < 0)
    //                        {
    //                            lstitem.Text = dtgetproduct.Rows[i]["expirydateid"].ToString();
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["productid"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["productname"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["suppliername"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["supplierphonenumber"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["datepurchased"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["amountpaid"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["invoicenumber"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["entrydate"].ToString());
    //                            lsvitems.Items.Add(lstitem);
    //                        }
    //                    }
    //                    lsvitems.ForeColor = Color.Black;
    //                    txttotal.Text = lsvitems.Items.Count.ToString();
    //                }
    //            }
    //            else if ((ComboBox1.Text) == "Drugs That Will Expire This Month")
    //            {
    //                dtgetproduct = getdatabase("Select * from expirydate");
    //                if (dtgetproduct.Rows.Count > 0)
    //                {
    //                    ListViewItem lstitem = new ListViewItem();
    //                    lsvitems.Items.Clear();
    //                    for (var i = 0; i < dtgetproduct.Rows.Count; i++)
    //                    {
    //                        lstitem = new ListViewItem();
    //                        dateOne = Convert.ToDateTime(dtgetproduct.Rows[i]["expirydate"]);
    //                        months = dateOne.Month;
    //                        months1 = DateTimePicker1.Value.Month;
    //                        monthdiff1 = 12 - months1;
    //                        year = dateOne.Year;
    //                        year1 = DateTimePicker1.Value.Year;
    //                        //this helps to capture the full years  
    //                        yeardiff = ((year - 1) - (year1 + 1)) + 1;
    //                        totalmonths = (months + monthdiff1) + (12 * yeardiff);
    //                        if (totalmonths == 0)
    //                        {
    //                            lstitem.Text = dtgetproduct.Rows[i]["expirydateid"].ToString();
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["productid"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["productname"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["quantity"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitcostprice"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["unitsalesprice"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["expirydate"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["suppliername"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["supplierphonenumber"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["datepurchased"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["amountpaid"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["invoicenumber"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[i]["entrydate"].ToString());
    //                            lsvitems.Items.Add(lstitem);
    //                        }
    //                    }
    //                    lsvitems.ForeColor = Color.Red;
    //                    txttotal.Text = lsvitems.Items.Count.ToString();
    //                }
    //            }
    //            else if ((ComboBox1.Text) == "All Drugs")
    //            {
    //                try
    //                {
    //                    // Use TimeSpan and some date calculaton, this should work:
    //                    dtgetproduct = getdatabase("Select * From expirydate order by productname");
    //                    if (dtgetproduct.Rows.Count > 0)
    //                    {
    //                        ListViewItem lstitem = new ListViewItem();
    //                        lsvitems.Items.Clear();
    //                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
    //                        {
    //                            lstitem = new ListViewItem();
    //                            lstitem.Text = dtgetproduct.Rows[j]["expirydateid"].ToString();
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productid"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["amountpaid"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());
    //                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
    //                            lsvitems.Items.Add(lstitem);
    //                        }
    //                        txttotal.Text = dtgetproduct.Rows.Count.ToString();
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Chkproduct_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}

		private void Label2_Click(object sender, System.EventArgs e)
		{

		}

		private void Button1_Click(object sender, System.EventArgs e)
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

                else if (Simulate.IsNumeric(txtquantity.Text))
                {
                    if (txtdrugid.Text != "")
                    {
                        intproductid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);





                        //If dgvsales.SelectedCells(0).Value.ToString <> "" Then
                        //    If IsNumeric(dgvsales.SelectedCells(0).Value.ToString) Then
                        //        Dim intproductid = CInt(dgvsales.SelectedCells(0).Value)
                        //" Where productname='" + ProductName1 + "' And expirydateid =" + Convert.ToInt32(dtgetexpirydate.Rows[k + 1]["expirydateid"])
                        //SELECT * FROM "users" WHERE (username = '".$username."' OR username = '".$email."')
                        dtgetsales = getdatabase(" select * from product where productid=" +  intproductid);
                        double x = 0;
                        x = Convert.ToDouble(dtgetsales.Rows[0]["unitsalesprice"]);
                        amount = x * Convert.ToInt32(txtquantity.Text);
                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                        cn.ConnectionString = strconnection;
                        cn.Open();
                        cm.CommandText = "Insert Into sales(cashiername,itemsold,quantitysold,unitcostprice,unitprice,amount,discount,productid) Values('" + txtcashiername1.Text + "','" + dtgetsales.Rows[0]["productname"].ToString() + "','" + txtquantity.Text + "','" + dtgetsales.Rows[0]["unitcostprice"] + "','" + dtgetsales.Rows[0]["unitsalesprice"] + "'," + amount + "," + discount + "," + Convert.ToInt32(txtdrugid.Text) + ")";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        SalesAlert pop = new SalesAlert();
                        pop.ShowDialog ();



                        //Define the waitSomeTime method for display time and then disappear without interrupting the main thread

                        // MessageBox.Show. ("Successfully Added To Cart");

                        txtcode2.Text = "";
                        txtdrugid.Text = "";
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
                        pop.ShowDialog ();
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
                //                        Dim v As Double
                //                        Dim amountcost As Double
                //                        Dim profit As Double
                //                        Dim newquantity As Integer
                //                        Dim newquantity1 As Integer
                //                        Dim ProductName1 As String
                //                        ProductName1 = dtgetsales.Rows(0).Item("productname")
                //                        v = CDbl(dtgetsales.Rows(0).Item("unitcostprice"))
                //                        amountcost = v * CInt(txtquantity.Text)
                //                        profit = amount - amountcost
                //                        discount = 0
                //                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                //                        cn.ConnectionString = strconnection
                //                        cn.Open()
                //                        cm.CommandText = "Insert Into drugslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date) Values('" & txtcashiername1.Text & "','" & dtgetsales.Rows(0).Item("productname").ToString & "','" & txtquantity.Text & "','" & dtgetsales.Rows(0).Item("unitcostprice").ToString & "'," & amountcost & ",'" & dtgetsales.Rows(0).Item("unitsalesprice").ToString & "'," & amount & "," & profit & ", '" & DateTimePicker1.Value.Date & "')"
                //                        cm.Connection = cn
                //                        cm.ExecuteNonQuery()
                //                        cn.Close()
                //                        cn.ConnectionString = strconnection
                //                        cn.Open()
                //                        cm.CommandText = "Insert Into generalsaleslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date) Values('" & txtcashiername1.Text & "','" & dtgetsales.Rows(0).Item("productname").ToString & "','" & txtquantity.Text & "','" & dtgetsales.Rows(0).Item("unitcostprice").ToString & "'," & amountcost & ",'" & dtgetsales.Rows(0).Item("unitsalesprice").ToString & "'," & amount & "," & profit & ", '" & DateTimePicker1.Value.Date & "')"
                //                        cm.Connection = cn
                //                        cm.ExecuteNonQuery()
                //                        cn.Close()
                //                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                //                        cn.ConnectionString = strconnection
                //                        cn.Open()
                //                        newquantity = CInt(dtgetsales.Rows(0).Item("quantity")) - CInt(txtquantity.Text)
                //                        cm.CommandText = "Update product Set quantity=" & newquantity & " Where productid=" & intproductid & ";"
                //                        cm.Connection = cn
                //                        cm.ExecuteNonQuery()
                //                        cn.Close()

                //                        Dim dtgetproduct As New System.Data.DataTable
                //                        dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product")
                //                        If dtgetproduct.Rows.Count > 0 Then
                //                            Dim lstitem As New ListViewItem
                //                            lsvitems.Items.Clear()
                //                            For j = 0 To dtgetproduct.Rows.Count - 1
                //                                lstitem = New ListViewItem
                //                                lstitem.Text = dtgetproduct.Rows(j).Item("productid").ToString
                //                                lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("productname").ToString)
                //                                lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("quantity").ToString)
                //                                lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("unitsalesprice").ToString)
                //                                lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("unitcostprice").ToString)
                //                                lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("expirydate").ToString)
                //                                lstitem.SubItems.Add(dtgetproduct.Rows(j).Item("entrydate").ToString)
                //                                lsvitems.Items.Add(lstitem)
                //                            Next
                //                              End If
                //                        Dim dtgetexpirydate As New System.Data.DataTable
                //                        dtgetexpirydate = getdatabase("select productid,productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber,entrydate from expirydate where productname ='" & ProductName1 & "'order by productid")
                //                        If dtgetexpirydate.Rows.Count > 0 Then
                //                            For k = 0 To dtgetexpirydate.Rows.Count - 1
                //                                If CInt(dtgetexpirydate.Rows(0).Item("quantity")) < CInt(txtquantity.Text) Then
                //                                    newquantity1 = (CInt(dtgetexpirydate.Rows(0).Item("quantity")) + CInt(dtgetexpirydate.Rows(k + 1).Item("quantity"))) - CInt(txtquantity.Text)
                //                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                //                                    cn.ConnectionString = strconnection
                //                                    cn.Open()
                //                                    cm.CommandText = "Update expirydate Set quantity=" & newquantity1 & " Where productname='" & ProductName1 & "' And productid =" & CInt(dtgetexpirydate.Rows(k + 1).Item("productid")) & ";"
                //                                    cm.Connection = cn
                //                                    cm.ExecuteNonQuery()
                //                                    cn.Close()

                //                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                //                                    cn.ConnectionString = strconnection
                //                                    'Dim intnewproductid As Integer
                //                                    'intnewproductid = CInt(dtgetexpirydate.Rows(0).Item("quantity"))
                //                                    cn.Open()
                //                                    newquantity1 = 0
                //                                    cm.CommandText = "Update expirydate Set quantity=" & newquantity1 & " Where productname='" & ProductName1 & "' And productid=" & CInt(dtgetexpirydate.Rows(k).Item("productid")) & ";"
                //                                    cm.Connection = cn
                //                                    cm.ExecuteNonQuery()
                //                                    cn.Close()
                //                                    cn.Open()
                //                                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" & CStr(dtgetexpirydate.Rows(k).Item("productname")) & "','" & newquantity1 & "','" & CDbl(dtgetexpirydate.Rows(k).Item("unitcostprice")) & "','" & CDbl(dtgetexpirydate.Rows(k).Item("unitsalesprice")) & "','" & CDate(dtgetexpirydate.Rows(k).Item("expirydate")) & "','" & CStr(dtgetexpirydate.Rows(k).Item("suppliername")) & "','" & CStr(dtgetexpirydate.Rows(k).Item("supplierphonenumber")) & "','" & CDate(dtgetexpirydate.Rows(k).Item("datepurchased")) & "'," & CDbl(dtgetexpirydate.Rows(k).Item("amountpaid")) & ",'" & CStr(dtgetexpirydate.Rows(k).Item("invoicenumber")) & "')"
                //                                    cm.Connection = cn
                //                                    cm.ExecuteNonQuery()
                //                                    cn.Close()
                //                                    cn.Open()
                //                                    cm.CommandText = "Delete from expirydate where productid= " & CInt(dtgetexpirydate.Rows(k).Item("productid")) & ""
                //                                    cm.Connection = cn
                //                                    cm.ExecuteNonQuery()
                //                                    cn.Close()

                //                                    GoTo 256
                //                                Else
                //                                    newquantity1 = CInt(dtgetexpirydate.Rows(0).Item("quantity")) - CInt(txtquantity.Text)
                //                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
                //                                    cn.ConnectionString = strconnection
                //                                    cn.Open()
                //                                    cm.CommandText = "Update expirydate Set quantity=" & newquantity1 & " Where productname='" & ProductName1 & "' And productid=" & CInt(dtgetexpirydate.Rows(0).Item("productid")) & ";"
                //                                    cm.Connection = cn
                //                                    cm.ExecuteNonQuery()
                //                                    cn.Close()
                //                                    GoTo 257
                //                                    '    'and  productid <> " & intproductid & "
                //                                    '    'Else
                //                                    '    '    cn.Open()
                //                                    '    '    cm.CommandText = "Update expirydate Set quantity=" & newquantity & " Where productid=" & intproductid & ";"
                //                                    '    '    cm.Connection = cn
                //                                    '    '    cm.ExecuteNonQuery()
                //                                    '    cn.Close()
                //                                End If
                //                            Next
                //                        End If
            
						
					
				




				txtquantity.Text = 1.ToString();
                txtcode2.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
        private void Timer1_Tick(SalesAlert pop,int v)
        {
           
        }
        //public async void WaitSomeTime(Form item)
        //{
        //    await Task. (3000);
        //    item.Close();
        //}


        private void Button1_Click_1(object sender, System.EventArgs e)
		{

		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			try
			{

                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                string strconnection = "";
                System.Data.DataTable dtgetreceipt = new System.Data.DataTable();
				double totalamount = 0;
				dtgetsales = getdatabase("select amount from sales");
				double temp = 0;
				if (dtgetsales.Rows.Count > 0)
				{
					for (var i = 0; i < dtgetsales.Rows.Count; i++)
					{
						temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
					}
                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into receipt() values()"; 
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    totalamount = temp;
                    viewsales x = new viewsales();
                    x.txtcashiername1.Text = txtcashiername1.Text;
					x.txttotal.Text = totalamount.ToString();
					x.txtdiscount.Text = 0.ToString();
					x.Show();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private void Button1_Click_2(object sender, System.EventArgs e)
		{
			viewsaleslog x = new viewsaleslog();
			x.Show();
		}

		private void txttime_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void TextBox2_TextChanged(object sender, System.EventArgs e)
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

		private void Label10_Click(object sender, System.EventArgs e)
		{

		}

		private void Label14_Click(object sender, System.EventArgs e)
		{

		}

		//Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
		//    Try
		//        Dim dtgetdrinks As New System.Data.DataTable
		//        dtgetdrinks = getdatabase("Select * From drinks Where drinksname Like '%" & txtdrinkssearch.Text & "%' Order By drinksname;")
		//        dgvdrinks.DataSource = dtgetdrinks
		//    Catch ex As Exception
		//        MsgBox(ex.ToString)
		//    End Try
		//End Sub

		private void TextBox3_TextChanged(object sender, System.EventArgs e)
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

		//    Private Sub btndrinks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		//        Try
		//            If txtdrinksquantity.Text = "" Then
		//                MessageBox.Show("Please Type The Quantity of drink To Be Sold")
		//            Else
		//                If IsNumeric(txtdrinksquantity.Text) Then
		//                    Dim cn As New MySqlConnection
		//                    Dim ad As New MySqlDataAdapter
		//                    Dim cm As New MySqlCommand
		//                    Dim dtgetsales As New System.Data.DataTable
		//                    Dim strconnection As String = ""
		//                    Dim amount As Double
		//                    If dgvdrinks.SelectedCells(0).Value.ToString <> "" Then
		//                        If IsNumeric(dgvdrinks.SelectedCells(0).Value.ToString) Then
		//                            Dim intproductid = CInt(dgvdrinks.SelectedCells(0).Value)
		//                            dtgetsales = getdatabase(" select * from drinks where drinksid=" & intproductid)
		//                            Dim x As Double
		//                            x = CDbl(dtgetsales.Rows(0).Item("drinksunitsalesprice"))
		//                            amount = x * CInt(txtdrinksquantity.Text)
		//                            strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
		//                            cn.ConnectionString = strconnection
		//                            cn.Open()
		//                            cm.CommandText = "Insert Into sales(cashiername,itemsold,quantitysold,unitprice,amount) Values('" & txtcashiername1.Text & "','" & dtgetsales.Rows(0).Item("drinksname").ToString & "','" & txtdrinksquantity.Text & "','" & dtgetsales.Rows(0).Item("drinksunitsalesprice") & "'," & amount & ")"
		//                            cm.Connection = cn
		//                            cm.ExecuteNonQuery()
		//                            cn.Close()
		//                            Dim v As Double
		//                            Dim amountcost As Double
		//                            Dim profit As Double
		//                            Dim ProductName1 As String
		//                            ProductName1 = dtgetsales.Rows(0).Item("drinksname")
		//                            Dim newquantity, newquantity1 As Integer
		//                            v = CDbl(dtgetsales.Rows(0).Item("drinksunitcostprice"))
		//                            amountcost = v * CInt(txtdrinksquantity.Text)
		//                            profit = amount - amountcost
		//                            strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
		//                            cn.ConnectionString = strconnection
		//                            cn.Open()
		//                            cm.CommandText = "Insert Into drinkslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date) Values('" & txtcashiername1.Text & "','" & dtgetsales.Rows(0).Item("drinksname").ToString & "','" & txtdrinksquantity.Text & "','" & dtgetsales.Rows(0).Item("drinksunitcostprice").ToString & "'," & amountcost & ",'" & dtgetsales.Rows(0).Item("drinksunitsalesprice").ToString & "'," & amount & "," & profit & ", '" & DateTimePicker1.Value.Date & "')"
		//                            cm.Connection = cn
		//                            cm.ExecuteNonQuery()
		//                            cn.Close()
		//                            cn.ConnectionString = strconnection
		//                            cn.Open()
		//                            cm.CommandText = "Insert Into generalsaleslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date) Values('" & txtcashiername1.Text & "','" & dtgetsales.Rows(0).Item("drinksname").ToString & "','" & txtdrinksquantity.Text & "','" & dtgetsales.Rows(0).Item("drinksunitcostprice").ToString & "'," & amountcost & ",'" & dtgetsales.Rows(0).Item("drinksunitsalesprice").ToString & "'," & amount & "," & profit & ",'" & DateTimePicker1.Value.Date & "')"
		//                            cm.Connection = cn
		//                            cm.ExecuteNonQuery()
		//                            cn.Close()
		//                            strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
		//                            cn.ConnectionString = strconnection
		//                            cn.Open()
		//                            newquantity = CInt(dtgetsales.Rows(0).Item("drinksquantity")) - CInt(txtdrinksquantity.Text)
		//                            cm.CommandText = "Update drinks Set drinksquantity=" & newquantity & " Where drinksid=" & intproductid & ";"
		//                            cm.Connection = cn
		//                            cm.ExecuteNonQuery()
		//                            cn.Close()
		//                            MessageBox.Show("successfull You Can CONTINUE")
		//                            Dim dtgetdrinks As New System.Data.DataTable
		//                            dtgetdrinks = getdatabase("select drinksid,drinksname,drinksquantity,drinksunitsalesprice,drinksunitcostprice,expirydate from drinks")
		//                            dgvdrinks.DataSource = dtgetdrinks
		//                            With dgvdrinks
		//                                .RowHeadersVisible = False
		//                                .Columns(0).HeaderCell.Value = "ID"
		//                                .Columns(1).HeaderCell.Value = "Product Name"
		//                                .Columns(2).HeaderCell.Value = "Qtys"
		//                                .Columns(3).HeaderCell.Value = "Sales Price"
		//                                .Columns(4).HeaderCell.Value = "Cost Price"
		//                                .Columns(5).HeaderCell.Value = "Exp.Date"
		//                                '.Columns(6).HeaderCell.Value = "Entry Date"
		//                            End With
		//                            Dim dtgetexpirydate As New System.Data.DataTable
		//                            dtgetexpirydate = getdatabase("select drinksid,drinksname,drinksquantity,drinksunitcostprice,drinksunitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber,entrydate from drinksexpirydate where drinksname ='" & ProductName1 & "'order by drinksid")
		//                            If dtgetexpirydate.Rows.Count > 0 Then
		//                                For k = 0 To dtgetexpirydate.Rows.Count - 1
		//                                    If CInt(dtgetexpirydate.Rows(0).Item("drinksquantity")) < CInt(txtdrinksquantity.Text) Then
		//                                        newquantity1 = (CInt(dtgetexpirydate.Rows(0).Item("drinksquantity")) + CInt(dtgetexpirydate.Rows(k + 1).Item("drinksquantity"))) - CInt(txtdrinksquantity.Text)
		//                                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
		//                                        cn.ConnectionString = strconnection
		//                                        cn.Open()
		//                                        cm.CommandText = "Update drinksexpirydate Set drinksquantity=" & newquantity1 & " Where drinksname='" & ProductName1 & "' And drinksid =" & CInt(dtgetexpirydate.Rows(k + 1).Item("drinksid")) & ";"
		//                                        cm.Connection = cn
		//                                        cm.ExecuteNonQuery()
		//                                        cn.Close()

		//                                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
		//                                        cn.ConnectionString = strconnection
		//                                        'Dim intnewproductid As Integer
		//                                        'intnewproductid = CInt(dtgetexpirydate.Rows(0).Item("quantity"))
		//                                        cn.Open()
		//                                        newquantity1 = 0
		//                                        cm.CommandText = "Update drinksexpirydate Set drinksquantity=" & newquantity1 & " Where drinksname='" & ProductName1 & "' And drinksid=" & CInt(dtgetexpirydate.Rows(k).Item("drinksid")) & ";"
		//                                        cm.Connection = cn
		//                                        cm.ExecuteNonQuery()
		//                                        cn.Close()
		//                                        cn.Open()
		//                                        cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" & CStr(dtgetexpirydate.Rows(k).Item("drinksname")) & "','" & newquantity1 & "','" & CDbl(dtgetexpirydate.Rows(k).Item("drinksunitcostprice")) & "','" & CDbl(dtgetexpirydate.Rows(k).Item("drinksunitsalesprice")) & "','" & CDate(dtgetexpirydate.Rows(k).Item("expirydate")) & "','" & CStr(dtgetexpirydate.Rows(k).Item("suppliername")) & "','" & CStr(dtgetexpirydate.Rows(k).Item("supplierphonenumber")) & "','" & CDate(dtgetexpirydate.Rows(k).Item("datepurchased")) & "'," & CDbl(dtgetexpirydate.Rows(k).Item("amountpaid")) & ",'" & CStr(dtgetexpirydate.Rows(k).Item("invoicenumber")) & "')"
		//                                        cm.Connection = cn
		//                                        cm.ExecuteNonQuery()
		//                                        cn.Close()
		//                                        cn.Open()
		//                                        cm.CommandText = "Delete from drinksexpirydate where drinksid= " & CInt(dtgetexpirydate.Rows(k).Item("drinksid")) & ""
		//                                        cm.Connection = cn
		//                                        cm.ExecuteNonQuery()
		//                                        cn.Close()
		//                                        txtdrinksquantity.Text = ""
		//                                        GoTo 424
		//                                    Else
		//                                        newquantity1 = CInt(dtgetexpirydate.Rows(0).Item("drinksquantity")) - CInt(txtdrinksquantity.Text)
		//                                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
		//                                        cn.ConnectionString = strconnection
		//                                        cn.Open()
		//                                        cm.CommandText = "Update drinksexpirydate Set drinksquantity=" & newquantity1 & " Where drinksname='" & ProductName1 & "' And drinksid=" & CInt(dtgetexpirydate.Rows(0).Item("drinksid")) & ";"
		//                                        cm.Connection = cn
		//                                        cm.ExecuteNonQuery()
		//                                        cn.Close()
		//                                        GoTo 425
		//                                        '    'and  productid <> " & intproductid & "
		//                                        '    'Else
		//                                        '    '    cn.Open()
		//                                        '    '    cm.CommandText = "Update expirydate Set quantity=" & newquantity & " Where productid=" & intproductid & ";"
		//                                        '    '    cm.Connection = cn
		//                                        '    '    cm.ExecuteNonQuery()
		//                                        '    cn.Close()
		//                                    End If
		//                                Next
		//                            End If
		//                        Else
		//                            MsgBox("please Select The Product ID")
		//                        End If
		//                    End If
		//                Else
		//                    MsgBox("please Enter a Number")
		//                End If
		//424:        End If
		//425:        txtdrinksquantity.Text = ""
		//        Catch ex As Exception
		//            MessageBox.Show(ex.ToString)
		//        End Try
		//End Sub


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
							double x = 0;
							x = Convert.ToDouble(dtgetsales.Rows[0]["cosmeticsunitsalesprice"]);
							amount = x * Convert.ToInt32(txtcardsquantity.Text);
							strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
							cn.ConnectionString = strconnection;
							cn.Open();
							cm.CommandText = "Insert Into sales(cashiername,itemsold,quantitysold,unitcostprice,unitprice,amount,discount,cosmeticsid) Values('" + txtcashiername1.Text + "','" + dtgetsales.Rows[0]["cosmeticsname"].ToString() + "','" + txtcardsquantity.Text + "','" + dtgetsales.Rows[0]["cosmeticsunitcostprice"] + "','" + dtgetsales.Rows[0]["cosmeticsunitsalesprice"] + "'," + amount + "," + discount + "," + intproductid + ")";
							cm.Connection = cn;
							cm.ExecuteNonQuery();
							cn.Close();
							MessageBox.Show("Successfully Added To Cart"); // Dim v As Double
							//                        Dim amountcost As Double
							//                        Dim profit As Double
							//                        Dim ProductName1 As String
							//                        ProductName1 = dtgetsales.Rows(0).Item("cosmeticsname")
							//                        Dim newquantity, newquantity1 As Integer
							//                        v = CDbl(dtgetsales.Rows(0).Item("cosmeticsunitcostprice"))
							//                        amountcost = v * CInt(txtcardsquantity.Text)
							//                        profit = amount - amountcost
							//                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
							//                        cn.ConnectionString = strconnection
							//                        cn.Open()
							//                        cm.CommandText = "Insert Into cosmeticslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date) Values('" & txtcashiername1.Text & "','" & dtgetsales.Rows(0).Item("cosmeticsname").ToString & "','" & txtcardsquantity.Text & "','" & dtgetsales.Rows(0).Item("cosmeticsunitcostprice").ToString & "'," & amountcost & ",'" & dtgetsales.Rows(0).Item("cosmeticsunitsalesprice").ToString & "'," & amount & "," & profit & ", '" & DateTimePicker1.Value.Date & "')"
							//                        cm.Connection = cn
							//                        cm.ExecuteNonQuery()
							//                        cn.Close()
							//                        cn.ConnectionString = strconnection
							//                        cn.Open()
							//                        cm.CommandText = "Insert Into generalsaleslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date) Values('" & txtcashiername1.Text & "','" & dtgetsales.Rows(0).Item("cosmeticsname").ToString & "','" & txtcardsquantity.Text & "','" & dtgetsales.Rows(0).Item("cosmeticsunitcostprice").ToString & "'," & amountcost & ",'" & dtgetsales.Rows(0).Item("cosmeticsunitsalesprice").ToString & "'," & amount & "," & profit & ", '" & DateTimePicker1.Value.Date & "')"
							//                        cm.Connection = cn
							//                        cm.ExecuteNonQuery()
							//                        cn.Close()
							//                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
							//                        cn.ConnectionString = strconnection
							//                        cn.Open()
							//                        newquantity = CInt(dtgetsales.Rows(0).Item("cosmeticsquantity")) - CInt(txtcardsquantity.Text)
							//                        cm.CommandText = "Update cosmetics Set cosmeticsquantity=" & newquantity & " Where cosmeticsid=" & intproductid & ";"
							//                        cm.Connection = cn
							//                        cm.ExecuteNonQuery()
							//                        cn.Close()

							//                        Dim dtgetcards As New System.Data.DataTable
							//                        dtgetcards = getdatabase("select cosmeticsid,cosmeticsname,cosmeticsquantity,cosmeticsunitsalesprice,cosmeticsunitcostprice,expirydate,entrydate from cosmetics")
							//                        If dtgetcards.Rows.Count > 0 Then
							//                            Dim lstitem As New ListViewItem
							//                            lsvitems1.Items.Clear()
							//                            For j = 0 To dtgetcards.Rows.Count - 1
							//                                lstitem = New ListViewItem
							//                                lstitem.Text = dtgetcards.Rows(j).Item("cosmeticsid").ToString
							//                                lstitem.SubItems.Add(dtgetcards.Rows(j).Item("cosmeticsname").ToString)
							//                                lstitem.SubItems.Add(dtgetcards.Rows(j).Item("cosmeticsquantity").ToString)
							//                                lstitem.SubItems.Add(dtgetcards.Rows(j).Item("cosmeticsunitsalesprice").ToString)
							//                                lstitem.SubItems.Add(dtgetcards.Rows(j).Item("cosmeticsunitcostprice").ToString)
							//                                lstitem.SubItems.Add(dtgetcards.Rows(j).Item("expirydate").ToString)
							//                                lstitem.SubItems.Add(dtgetcards.Rows(j).Item("entrydate").ToString)
							//                                lsvitems1.Items.Add(lstitem)
							//                            Next
							//                        End If
							//                        Dim dtgetexpirydate As New System.Data.DataTable
							//                        dtgetexpirydate = getdatabase("select cosmeticsid,cosmeticsname,cosmeticsquantity,cosmeticsunitcostprice,cosmeticsunitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber,entrydate from cosmeticsexpirydate where cosmeticsname ='" & ProductName1 & "'order by cosmeticsid")
							//                        If dtgetexpirydate.Rows.Count > 0 Then
							//                            For k = 0 To dtgetexpirydate.Rows.Count - 1
							//                                If CInt(dtgetexpirydate.Rows(0).Item("cosmeticsquantity")) < CInt(txtcardsquantity.Text) Then
							//                                    newquantity1 = (CInt(dtgetexpirydate.Rows(0).Item("cosmeticsquantity")) + CInt(dtgetexpirydate.Rows(k + 1).Item("cosmeticsquantity"))) - CInt(txtcardsquantity.Text)
							//                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
							//                                    cn.ConnectionString = strconnection
							//                                    cn.Open()
							//                                    cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" & newquantity1 & " Where cosmeticsname='" & ProductName1 & "' And cosmeticsid =" & CInt(dtgetexpirydate.Rows(k + 1).Item("cosmeticsid")) & ";"
							//                                    cm.Connection = cn
							//                                    cm.ExecuteNonQuery()
							//                                    cn.Close()

							//                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
							//                                    cn.ConnectionString = strconnection
							//                                    'Dim intnewproductid As Integer
							//                                    'intnewproductid = CInt(dtgetexpirydate.Rows(0).Item("quantity"))
							//                                    newquantity1 = 0
							//                                    cn.Open()
							//                                    cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" & newquantity1 & " Where cosmeticsname='" & ProductName1 & "' And cosmeticsid=" & CInt(dtgetexpirydate.Rows(k).Item("cosmeticsid")) & ";"
							//                                    cm.Connection = cn
							//                                    cm.ExecuteNonQuery()
							//                                    cn.Close()
							//                                    cn.Open()
							//                                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" & CStr(dtgetexpirydate.Rows(k).Item("cosmeticsname")) & "','" & newquantity1 & "','" & CDbl(dtgetexpirydate.Rows(k).Item("cosmeticsunitcostprice")) & "','" & CDbl(dtgetexpirydate.Rows(k).Item("cosmeticsunitsalesprice")) & "','" & CDate(dtgetexpirydate.Rows(k).Item("expirydate")) & "','" & CStr(dtgetexpirydate.Rows(k).Item("suppliername")) & "','" & CStr(dtgetexpirydate.Rows(k).Item("supplierphonenumber")) & "','" & CDate(dtgetexpirydate.Rows(k).Item("datepurchased")) & "'," & CDbl(dtgetexpirydate.Rows(k).Item("amountpaid")) & ",'" & CStr(dtgetexpirydate.Rows(k).Item("invoicenumber")) & "')"
							//                                    cm.Connection = cn
							//                                    cm.ExecuteNonQuery()
							//                                    cn.Close()
							//                                    cn.Open()
							//                                    cm.CommandText = "Delete from cosmeticsexpirydate where cosmeticsid= " & CInt(dtgetexpirydate.Rows(k).Item("cosmeticsid")) & ""
							//                                    cm.Connection = cn
							//                                    cm.ExecuteNonQuery()
							//                                    cn.Close()
							//                                    txtcardsquantity.Text = ""
							//                                    GoTo 642
							//                                Else
							//                                    newquantity1 = CInt(dtgetexpirydate.Rows(0).Item("cosmeticsquantity")) - CInt(txtcardsquantity.Text)
							//                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer"
							//                                    cn.ConnectionString = strconnection
							//                                    cn.Open()
							//                                    cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" & newquantity1 & " Where cosmeticsname='" & ProductName1 & "' And cosmeticsid=" & CInt(dtgetexpirydate.Rows(0).Item("cosmeticsid")) & ";"
							//                                    cm.Connection = cn
							//                                    cm.ExecuteNonQuery()
							//                                    cn.Close()
							//                                    GoTo 643
							//                                    '    'and  productid <> " & intproductid & "
							//                                    '    'Else
							//                                    '    '    cn.Open()
							//                                    '    '    cm.CommandText = "Update expirydate Set quantity=" & newquantity & " Where productid=" & intproductid & ";"
							//                                    '    '    cm.Connection = cn
							//                                    '    '    cm.ExecuteNonQuery()
							//                                    '    cn.Close()
							//                                End If
							//                            Next
							//                        End If
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
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button7_Click(object sender, System.EventArgs e)
		{
			reorderleveltype x = new reorderleveltype();
			x.Show();
		}

		private void Button6_Click(object sender, System.EventArgs e)
		{
			expirydateinfotype x = new expirydateinfotype();
			x.Show();
		}

		private void dgvsales_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{

		}

		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			//Dim time1 As String
			//time1 = TimeOfDay.Ticks
			//txttime.Text = time1
		}

		private void Label6_Click(object sender, System.EventArgs e)
		{

		}

		private void PictureBox2_Click(object sender, System.EventArgs e)
		{

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
					txtproductname.Text = (dtgetsales.Rows[0]["productname"]).ToString();
					txtdrugid.Text = (dtgetsales.Rows[0]["productid"]).ToString();
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
					txtcosmeticsname.Text = (dtgetsales.Rows[0]["cosmeticsname"]).ToString();
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

		private void txtcosmeticsid_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void sales_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				// Use TimeSpan and some date calculaton, this should work:

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
                           // lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
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
                       //     lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                    }
					txtquantity.Text = 1.ToString();
                    txtcode2.Focus();
                    txtproductname.Text = "";
				}


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
						//lstitem.SubItems.Add(dtgetcosmetics.Rows(j).Item("cosmeticsunitcostprice").ToString)
						lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["expirydate"].ToString());
						lstitem.SubItems.Add(dtgetcosmetics.Rows[j]["entrydate"].ToString());
						lsvitems1.Items.Add(lstitem);
					}
					txtcardsquantity.Text = 1.ToString();
				}
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

        private void button4_Click(object sender, EventArgs e)
        {
            trackExpiryDate1 x = new trackExpiryDate1();
            x.Show();
        }

        private void thisMonth1_Click(object sender, EventArgs e)
        {
            trackExpiryDate2 x = new trackExpiryDate2();
            x.Show();
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

        private void sales_Click(object sender, EventArgs e)
        {

        }

        private void btnreptrintReceipt_Click(object sender, EventArgs e)
        {
            ReprintReceipt x = new ReprintReceipt();
            x.txtcashiername1.Text = txtcashiername1.Text;
            x.Show();
        }
    }
}