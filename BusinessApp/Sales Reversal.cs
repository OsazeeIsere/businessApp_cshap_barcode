using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApp
{
    public partial class Sales_Reversal : Form
    {
        public Sales_Reversal()
        {
            InitializeComponent();
        }

        private void txtproductname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                System.Data.DataTable dtgetsaleslog = new System.Data.DataTable();
                settings v = new settings();
                dtgetsaleslog = v.getdatabase("Select * From drugslog where salesid=" + Convert.ToInt32(txtproductid.Text));
                string strconnection = "";
                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                cn.Open();
                cm.CommandText = "Delete from drugslog where salesid=" + Convert.ToInt32(txtproductid.Text) + ";";
                //& intproductid & ";"
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                cn.Open();
                cm.CommandText = "Delete from generalsaleslog where salesid=" + Convert.ToInt32(txtproductid.Text) + ";";
                //& intproductid & ";"
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                cn.Open();
                dtgetproduct = v.getdatabase("Select * From product where productid=" + Convert.ToInt32(dtgetsaleslog.Rows[0]["productid"]).ToString());
                int newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) + Convert.ToInt32(txtquantity.Text);
                int intproductid = Convert.ToInt32(dtgetsaleslog.Rows[0]["productid"]);
                String ProductName1 = dtgetsaleslog.Rows[0]["itemsold"].ToString();

                cm.CommandText = "Update product Set quantity=" + newquantity + " Where productid=" + intproductid + ";";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                cn.ConnectionString = strconnection;
                cn.Open();
                cm.CommandText = "Update expirydate Set quantity=" + newquantity + " Where productname='" + ProductName1 + "';";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("This Sale Has Been Successfully Reversed! Please, Click On The Body Of The Form" +
                    "To Reflect The Update");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtproductid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
