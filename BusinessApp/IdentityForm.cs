using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessApp
{
    public partial class IdentityForm : Form
    {
      
        public IdentityForm()
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strconnection;
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                cn.Open();
                cm.CommandText = "Insert Into identity(businessName,address,telephone) Values('" + txtName.Text + "','" + txtAddress.Text + "','" + txtTel.Text + "')";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("The App. is Already Set-up with Your Business Information");
                txtName.Text = "";
                txtAddress.Text = "";
                txtTel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
