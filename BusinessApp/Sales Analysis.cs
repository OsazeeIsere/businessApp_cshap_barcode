using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;

namespace BusinessApp
{
    public partial class Sales_Analysis : Form
    {
        public Sales_Analysis()
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
        ReportDocument rd = new ReportDocument();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void Sales_Analysis_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");

                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //    lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

                drugslog x = new drugslog();
                double totalsales = 0;
                double totalprofit = 0;
                System.Data.DataTable dtgetsaleslog = new System.Data.DataTable();
                System.Data.DataTable dtgetsaleslog1 = new System.Data.DataTable();
                dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog");
                double temp = 0;
                double temp1 = 0;
                int c = 0;
                System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                dtgetadmin = getdatabase("select * from administrator");
                rd.Load(Application.StartupPath + "\\Reports\\SalesReport.rpt");
                rd.SetDataSource(dtgetsaleslog1);
                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.RefreshReport();
                //for (var i = 0; i < dtgetadmin.Rows.Count; i++)
                //{
                //    if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && dtgetsaleslog1.Rows.Count > 0)
                //    {

                //        for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
                //        {
                //            temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
                //            temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[j]["profit"]);
                //        }

                //        totalsales = temp;
                //        totalprofit = temp1;
                //        txttotalsales.Text = totalsales.ToString();
                //        txttotaprofit.Text = totalprofit.ToString();
                //        c = dtgetsaleslog1.Rows.Count;
                //        txtcustomer.Text = c.ToString();
                //        dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                //            "unitsalesprice,amountsold,receiptnumber,profit,entrydate from drugslog order by date");
                //        dgvsaleslog.DataSource = dtgetsaleslog;

                //    }
                //    else
                //    {
                //        menuStrip1.Visible = false;
                //        dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                //            "unitsalesprice,amountsold,receiptnumber,entrydate from drugslog order by date");
                //        dgvsaleslog.DataSource = dtgetsaleslog;

                //        for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
                //        {
                //            temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
                //            temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[j]["profit"]);
                //        }
                //        totalsales = temp;
                //        totalprofit = temp1;
                //        txttotalsales.Text = totalsales.ToString();
                //        c = dtgetsaleslog1.Rows.Count;
                //        txtcustomer.Text = c.ToString();
                //    }
                //}
                //System.Data.DataTable dtgetcashier = new System.Data.DataTable();
                //dtgetcashier = getdatabase("select * from cashier");
                //System.Data.DataTable dtgetbackup = new System.Data.DataTable();
                //dtgetadmin = getdatabase("select * from administrator");
                //dtgetbackup = getdatabase("select * from backup");
                //cbocashier.Items.Add("All Sales").ToString();
                //cbocashier.Items.Add("All Cashiers' Sales").ToString();
                //if (dtgetcashier.Rows.Count > 0)
                //{
                //    for (var i = 0; i < dtgetcashier.Rows.Count; i++)
                //    {
                //        cbocashier.Items.Add(dtgetcashier.Rows[i]["cashiername"]).ToString();
                //    }
                //}

                //if (dtgetbackup.Rows.Count > 0)
                //{
                //    for (var i = 0; i < dtgetbackup.Rows.Count; i++)
                //    {
                //        cbocashier.Items.Add(dtgetbackup.Rows[i]["backupname"]).ToString();
                //    }

                //}
                //if (dtgetadmin.Rows.Count > 0)
                //{
                //    for (var i = 0; i < dtgetadmin.Rows.Count; i++)
                //    {
                //        cbocashier.Items.Add(dtgetadmin.Rows[i]["adminname"]).ToString();
                //    }

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
