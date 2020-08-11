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
	public partial class cosmeticslog
	{

		internal cosmeticslog()
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
		private void cardslog_Load(object sender, System.EventArgs e)
		{
			try
			{
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");

                lbname.Text = dtidentity.Rows[0]["businessName"].ToString();
                lbaddress.Text = dtidentity.Rows[0]["address"].ToString();
           //     lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

                cosmeticslog x = new cosmeticslog();
				double totalsales = 0;
				double totalprofit = 0;
				System.Data.DataTable dtgetsaleslog = new System.Data.DataTable();
				dtgetsaleslog = getdatabase("select * from cosmeticslog order by date");
				dgvcardslog.DataSource = dtgetsaleslog;
				System.Data.DataTable dtgetsaleslog1 = new System.Data.DataTable();
				dtgetsaleslog1 = getdatabase("select amountsold,profit from cosmeticslog");
				double temp = 0;
				double temp1 = 0;
				int c = 0;
				System.Data.DataTable dtgetadmin = new System.Data.DataTable();
				dtgetadmin = getdatabase("select * from administrator");
				for (var i = 0; i < dtgetadmin.Rows.Count; i++)
				{
					if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && dtgetsaleslog1.Rows.Count > 0)
					{
						for (var k = 0; k < dtgetsaleslog1.Rows.Count; k++)
						{
							temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[k]["amountsold"]);
							temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[k]["profit"]);
						}
						c = dtgetsaleslog1.Rows.Count;
						txtcustomer.Text = c.ToString();

						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
					else
					{
						for (var k = 0; k < dtgetsaleslog1.Rows.Count; k++)
						{
							temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[k]["amountsold"]);
						}
						c = dtgetsaleslog1.Rows.Count;
						txtcustomer.Text = c.ToString();
						totalsales = temp;
						txttotalsales.Text = totalsales.ToString();
					}
				}
				System.Data.DataTable dtgetcashier = new System.Data.DataTable();
				dtgetcashier = getdatabase("select * from cashier");
				System.Data.DataTable dtgetbackup = new System.Data.DataTable();
				dtgetadmin = getdatabase("select * from administrator");
				dtgetbackup = getdatabase("select * from backup");
				cbocashier.Items.Add("All Sales").ToString();
				cbocashier.Items.Add("All Cashiers' Sales").ToString();
				if (dtgetcashier.Rows.Count > 0)
				{
					for (var i = 0; i < dtgetcashier.Rows.Count; i++)
					{
						cbocashier.Items.Add(dtgetcashier.Rows[i]["cashiername"]).ToString();
					}
				}

				if (dtgetbackup.Rows.Count > 0)
				{
					for (var i = 0; i < dtgetbackup.Rows.Count; i++)
					{
						cbocashier.Items.Add(dtgetbackup.Rows[i]["backupname"]).ToString();
					}

				}
				if (dtgetadmin.Rows.Count > 0)
				{
					for (var i = 0; i < dtgetadmin.Rows.Count; i++)
					{
						cbocashier.Items.Add(dtgetadmin.Rows[i]["adminname"]).ToString();
					}

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
				double temp = 0;
				double temp1 = 0;
				int c = 0;
				System.Data.DataTable dtgetsaleslog1 = new System.Data.DataTable();
				System.Data.DataTable dtgetsaleslog = new System.Data.DataTable();
				double totalsales = 0;
				double totalprofit = 0;
				System.Data.DataTable dtgetadmin = new System.Data.DataTable();
				dtgetadmin = getdatabase("select * from administrator");
				for (var i = 0; i < dtgetadmin.Rows.Count; i++)
				{
					if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Sales")
					{
						dtgetsaleslog = getdatabase("select * from cosmeticslog order by date");
						dgvcardslog.DataSource = dtgetsaleslog;
						// generate another table for necessary calculation
						dtgetsaleslog1 = getdatabase("select amountsold,profit from cosmeticslog");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							//to sum the 2 columns
							for (var k = 0; k < dtgetsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[k]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[k]["profit"]);
							}
						}
						c = dtgetsaleslog1.Rows.Count;
						txtcustomer.Text = c.ToString();

						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && Convert.ToDateTime(DateTimePicker1.Value) == Convert.ToDateTime(DateTimePicker2.Value) && cbocashier.Text != "All Cashiers' Sales")
					{
						dtgetsaleslog = getdatabase("select * from cosmeticslog where  cashiername='" + cbocashier.Text + "' And date='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "'");
						dgvcardslog.DataSource = dtgetsaleslog;
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dtgetsaleslog1 = getdatabase("select amountsold,profit from cosmeticslog where cashiername='" + cbocashier.Text + "' And date='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[j]["profit"]);
							}
							c = dtgetsaleslog1.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && Convert.ToDateTime(DateTimePicker1.Value.Date) != Convert.ToDateTime(DateTimePicker2.Value.Date) && cbocashier.Text != "All Cashiers' Sales")
					{
						dtgetsaleslog = getdatabase("select * from cosmeticslog where date >='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "' And date <='" + Convert.ToDateTime(DateTimePicker2.Value.Date) + "' And cashiername='" + cbocashier.Text + "'");
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dgvcardslog.DataSource = dtgetsaleslog;
						dtgetsaleslog1 = getdatabase("select amountsold,profit from cosmeticslog where date >='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "' and date <='" + Convert.ToDateTime(DateTimePicker2.Value.Date) + "' and cashiername='" + cbocashier.Text + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var k = 0; k < dtgetsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[k]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[k]["profit"]);
							}
							c = dtgetsaleslog.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && Convert.ToDateTime(DateTimePicker1.Value.Date).ToString() == Convert.ToDateTime(DateTimePicker2.Value.Date).ToString())
					{
						dtgetsaleslog = getdatabase("select * from cosmeticslog where date='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "'");
						dgvcardslog.DataSource = dtgetsaleslog;
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dtgetsaleslog1 = getdatabase("select amountsold,profit from cosmeticslog where date='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[j]["profit"]);
							}
							c = dtgetsaleslog1.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && Convert.ToDateTime(DateTimePicker1.Value.Date).ToString() != Convert.ToDateTime(DateTimePicker2.Value.Date).ToString())
					{
						dtgetsaleslog = getdatabase("select * from cosmeticslog where date >='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "' And date <='" + Convert.ToDateTime(DateTimePicker2.Value.Date) + "'");
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dgvcardslog.DataSource = dtgetsaleslog;
						dtgetsaleslog1 = getdatabase("select amountsold,profit from cosmeticslog where date >='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "' and date <='" + Convert.ToDateTime(DateTimePicker2.Value.Date) + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var k = 0; k < dtgetsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[k]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[k]["profit"]);
							}
							c = dtgetsaleslog.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
				}
				for (var i = 0; i < dtgetadmin.Rows.Count; i++)
				{
					if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Sales")
					{
						dtgetsaleslog = getdatabase("select * from cosmeticslog order by date");
						dgvcardslog.DataSource = dtgetsaleslog;
						// generate another table for necessary calculation
						dtgetsaleslog1 = getdatabase("select amountsold,profit from cosmeticslog");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							//to sum the 2 columns
							for (var k = 0; k < dtgetsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[k]["amountsold"]);
							}
						}
						c = dtgetsaleslog1.Rows.Count;
						txtcustomer.Text = c.ToString();
						totalsales = temp;
						txttotalsales.Text = totalsales.ToString();
					}
					else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && Convert.ToDateTime(DateTimePicker1.Value) == Convert.ToDateTime(DateTimePicker2.Value) && cbocashier.Text != "All Cashiers' Sales")
					{
						dtgetsaleslog = getdatabase("select * from cosmeticslog where  cashiername='" + cbocashier.Text + "' And date='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "'");
						dgvcardslog.DataSource = dtgetsaleslog;
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dtgetsaleslog1 = getdatabase("select amountsold,profit from cosmeticslog where cashiername='" + cbocashier.Text + "' And date='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
							}
							c = dtgetsaleslog1.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						txttotalsales.Text = totalsales.ToString();
					}
					else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && Convert.ToDateTime(DateTimePicker1.Value.Date) != Convert.ToDateTime(DateTimePicker2.Value.Date) && cbocashier.Text != "All Cashiers' Sales")
					{
						dtgetsaleslog = getdatabase("select * from cosmeticslog where date >='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "' And date <='" + Convert.ToDateTime(DateTimePicker2.Value.Date) + "' And cashiername='" + cbocashier.Text + "'");
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dgvcardslog.DataSource = dtgetsaleslog;
						dtgetsaleslog1 = getdatabase("select amountsold,profit from cosmeticslog where date >='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "' and date <='" + Convert.ToDateTime(DateTimePicker2.Value.Date) + "' and cashiername='" + cbocashier.Text + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var k = 0; k < dtgetsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[k]["amountsold"]);
							}
							c = dtgetsaleslog.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						txttotalsales.Text = totalsales.ToString();
					}
					else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && Convert.ToDateTime(DateTimePicker1.Value.Date).ToString() == Convert.ToDateTime(DateTimePicker2.Value.Date).ToString())
					{
						dtgetsaleslog = getdatabase("select * from cosmeticslog where date='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "'");
						dgvcardslog.DataSource = dtgetsaleslog;
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dtgetsaleslog1 = getdatabase("select amountsold,profit from cosmeticslog where date='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
							}
							c = dtgetsaleslog1.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						txttotalsales.Text = totalsales.ToString();
					}
					else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && Convert.ToDateTime(DateTimePicker1.Value.Date).ToString() != Convert.ToDateTime(DateTimePicker2.Value.Date).ToString())
					{
						dtgetsaleslog = getdatabase("select * from cosmeticslog where date >='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "' And date <='" + Convert.ToDateTime(DateTimePicker2.Value.Date) + "'");
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dgvcardslog.DataSource = dtgetsaleslog;
						dtgetsaleslog1 = getdatabase("select amountsold,profit from cosmeticslog where date >='" + Convert.ToDateTime(DateTimePicker1.Value.Date) + "' and date <='" + Convert.ToDateTime(DateTimePicker2.Value.Date) + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var k = 0; k < dtgetsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[k]["amountsold"]);
							}
							c = dtgetsaleslog.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						txttotalsales.Text = totalsales.ToString();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

        private void dgvcardslog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}