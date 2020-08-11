using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BusinessApp
{
    public partial class trackExpiryDate3 : Form
    {
        public trackExpiryDate3()
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
        private void trackExpiryDate3_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");

                lbname.Text = dtidentity.Rows[0]["businessName"].ToString();
                lbaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //            lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
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
                        if (totalmonths>-1 && totalmonths < 4)
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
                    lsvitems.ForeColor = Color.Gold ;
                    txttotal.Text = lsvitems.Items.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void check_Click(object sender, EventArgs e)
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
                        lsvitems.ForeColor = Color.DeepPink;
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
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
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
    }
    
    
}
