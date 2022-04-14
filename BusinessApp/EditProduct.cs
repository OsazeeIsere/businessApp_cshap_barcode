using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using xlapp = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
namespace BusinessApp
{
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        settings v = new settings();

        private void EditProduct_Load(object sender, EventArgs e)
        {
            DataTable dtidentity = new DataTable();
            dtidentity =v.getdatabase("Select * from identity");
            salesAnalysisToolStripMenuItem.Visible = false;
            txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
            txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
            //       lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

            System.Data.DataTable dtgetproduct = new System.Data.DataTable();
            dtgetproduct = v.getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
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

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void lsvitems_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int intproductid = 0;
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                if (Simulate.IsNumeric(Convert.ToInt32(lsvitems.SelectedItems[0].Text)))
                {
                    intproductid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
                    //Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
                    dtgetsales = v.getdatabase(" select * from product where productid=" + intproductid);
                    txtproductid.Text = Convert.ToDouble(dtgetsales.Rows[0]["productid"]).ToString();
                    txtproductname.Text = Convert.ToString(dtgetsales.Rows[0]["productname"]);
                    txtquantity.Text = Convert.ToString(dtgetsales.Rows[0]["quantity"]);
                    //txtamountpaid.Text = CStr(dtgetexpirydate.Rows(0).Item("amountpaid"))
                    txtunitcostprice.Text = Convert.ToString(dtgetsales.Rows[0]["unitcostprice"]);
                    txtunitprice.Text = Convert.ToString(dtgetsales.Rows[0]["unitsalesprice"]);
                    txtexpirydate.Text = (dtgetsales.Rows[0]["expirydate"]).ToString();
                    //
                    //this is clean code but is not used here because these columns are not product table
                    //txtsuppliername.Text = dtgetsales.Rows[0]["suppliername"].ToString() ?? "";
                    //txtsupplierphonenumber.Text = dtgetsales.Rows[0]["supplierphonenumber"].ToString() ?? "";
                    //txtdatepurchased.Text = dtgetsales.Rows[0]["datepurchased"].ToString() ?? "";
                    //txtinvoicenumber.Text = dtgetsales.Rows[0]["invoicenumber"].ToString() ?? "";
                    txtcode2.Text = dtgetsales.Rows[0]["barcode"].ToString() ?? "";

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

        private void Button1_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Please enter the Quantity of Product");
                }
                else if (string.IsNullOrEmpty(txtexpirydate.Text))
                {
                    MessageBox.Show("Please enter the Expiry Date of the Drugs");
                }
                else if (string.IsNullOrEmpty(txtunitprice.Text))
                {
                    MessageBox.Show("Please enter the Unit price of Product");

                }
                else if (string.IsNullOrEmpty(txtamountpaid.Text))
                {
                    MessageBox.Show("Please enter the Amount Paid for The Product");
                }

                else if (string.IsNullOrEmpty(txtunitcostprice.Text))
                {
                    MessageBox.Show("Please enter the Unit Cost price of The Product");
                }
                else if (Simulate.IsNumeric(txtquantity.Text) && !string.IsNullOrEmpty(txtproductid.Text))
                {
                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    int newquantity = 0;
                    intproductid = Convert.ToInt32(txtproductid.Text);
                    dtgetproduct = v.getdatabase("Select * From product where productid=" + intproductid);
                    cn.Open();
                    newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) + Convert.ToInt32(txtquantity.Text);
                    cm.CommandText = "Update product Set productname='" + txtproductname.Text + "',quantity =" + newquantity + ",unitcostprice=" + txtunitcostprice.Text + ",unitsalesprice=" + txtunitprice.Text + ",barcode='" + txtcode2.Text + "',expirydate='" + txtexpirydate.Text + "' Where productid=" + intproductid + ";";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) + Convert.ToInt32(txtquantity.Text);
                    cm.CommandText = "Update expirydate Set productname='" + txtproductname.Text + "',quantity =" + newquantity + ",unitcostprice=" + txtunitcostprice.Text + ",unitsalesprice=" + txtunitprice.Text + ",barcode='" + txtcode2.Text + "',expirydate='" + txtexpirydate.Text + "',suppliername='" + txtsuppliername.Text + "',datepurchased='" + txtdatepurchased.Text + "',amountpaid='" + txtamountpaid.Text + "',invoicenumber='" + txtinvoicenumber.Text + "',supplierphonenumber='" + txtsupplierphonenumber.Text + "' Where productid=" + intproductid + ";";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    
                    dtgetproduct =v.getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
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
                    txtproductname.Text = "";
                    txtcode2.Text = "";
                    txtcode2.Focus();
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtcode2.Focus();
        }

        private void Button9_Click(object sender, EventArgs e)
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
                dtgetproduct = v.getdatabase("Select * From product where productid=" + intproductid);
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

        private void Button2_Click(object sender, EventArgs e)
        {
            viewsaleslog x = new viewsaleslog();
            x.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                dtgetadmin = v.getdatabase("Select * from administrator");
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

        private void Button3_Click(object sender, EventArgs e)
        {
            sales x = new sales();
            x.txtcashiername1.Text = txtcashiername1.Text;
            x.Show();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct =v.getdatabase("Select * From product Where productname Like '%" + txtsearch.Text + "%' Order By productname;");

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

        private void Button6_Click(object sender, EventArgs e)
        {
            expirydateinfotype x = new expirydateinfotype();
            x.Show();
        }

        private void txtamountpaid_MouseClick(object sender, MouseEventArgs e)
        {
            txtamountpaid.Text = ((Convert.ToInt32(txtquantity.Text)) * (Convert.ToInt32(txtunitcostprice.Text))).ToString();

        }

        private void EditProduct_MouseClick(object sender, MouseEventArgs e)
        {
            System.Data.DataTable dtgetproduct = new System.Data.DataTable();
            dtgetproduct = v.getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
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
    }
}
