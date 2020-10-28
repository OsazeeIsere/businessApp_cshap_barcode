﻿//INSTANT C# NOTE: Formerly VB project-level imports:
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
	public partial class drugslog
	{
		internal drugslog()
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
		private void saleslog_Load(object sender, System.EventArgs e)
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
				for (var i = 0; i < dtgetadmin.Rows.Count; i++)
				{
					if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && dtgetsaleslog1.Rows.Count > 0)
					{

						for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
						{
							temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
							temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[j]["profit"]);
						}

						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
						c = dtgetsaleslog1.Rows.Count;
						txtcustomer.Text = c.ToString();
                        dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                            "unitsalesprice,amountsold,receiptnumber,profit,entrydate from drugslog order by date");
                        dgvsaleslog.DataSource = dtgetsaleslog;

                    }
                    else
					{
                        dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                            "unitsalesprice,amountsold,receiptnumber,entrydate from drugslog order by date");
                        dgvsaleslog.DataSource = dtgetsaleslog;

                        for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
						{
							temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
							temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[j]["profit"]);
						}
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						c = dtgetsaleslog1.Rows.Count;
						txtcustomer.Text = c.ToString();
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
                System.Data.DataTable dtgetsaleslog_dgv = new System.Data.DataTable();
                
                dtgetadmin = getdatabase("select * from administrator");
				for (var i = 0; i < dtgetadmin.Rows.Count; i++)
				{
					if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Sales")
					{
                        dtgetsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                                            "unitsalesprice,amountsold,receiptnumber,profit,entrydate from drugslog order by entrydate");
                        dgvsaleslog.DataSource = dtgetsaleslog_dgv;
						// generate another table for necessary calculation
						dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							//to sum the 2 columns
							for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[j]["profit"]);
							}
						}
						c = dtgetsaleslog1.Rows.Count;
						txtcustomer.Text = c.ToString();
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && DateTimePicker1.Value.Date.ToShortDateString() == DateTimePicker2.Value.Date.ToShortDateString() && cbocashier.Text != "All Cashiers' Sales")
					{
						dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                                            "unitsalesprice,amountsold,profit,receiptnumber,entrydate from drugslog where  cashiername='" + cbocashier.Text + "' And date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						dgvsaleslog.DataSource = dtgetsaleslog;
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog where cashiername='" + cbocashier.Text + "' And date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var k = 0; k < dtgetsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[k]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[k]["profit"]);
							}
							c = dtgetsaleslog1.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && DateTimePicker1.Value.Date.ToShortDateString() != DateTimePicker2.Value.Date.ToShortDateString() && cbocashier.Text != "All Cashiers' Sales")
					{
						string stdate = DateTimePicker1.Value.Date.ToShortDateString();
						string eddate = DateTimePicker2.Value.Date.ToShortDateString();
						dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                                            "unitsalesprice,amountsold,profit,receiptnumber,entrydate from drugslog where date >='" + stdate + "' and date <='" + eddate + "'and  cashiername='" + cbocashier.Text + "'");
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dgvsaleslog.DataSource = dtgetsaleslog;
						dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog where date >='" + stdate + "' and date <='" + eddate + "' and cashiername='" + cbocashier.Text + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var l = 0; l < dtgetsaleslog1.Rows.Count; l++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[l]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[l]["profit"]);
							}
							c = dtgetsaleslog.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && DateTimePicker1.Value.Date.ToShortDateString() == DateTimePicker2.Value.Date.ToShortDateString())
					{
						dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                                            "unitsalesprice,amountsold,receiptnumber,profit,entrydate from drugslog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						dgvsaleslog.DataSource = dtgetsaleslog;
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
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
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && DateTimePicker1.Value.Date.ToShortDateString() != DateTimePicker2.Value.Date.ToShortDateString())
					{
						string stdate = DateTimePicker1.Value.Date.ToShortDateString();
						string eddate = DateTimePicker2.Value.Date.ToShortDateString();
						dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                                            "unitsalesprice,amountsold,receiptnumber,profit,entrydate from drugslog where date >='" + stdate + "' and date <='" + eddate + "'");
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dgvsaleslog.DataSource = dtgetsaleslog;
						dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog where date >='" + stdate + "' and date <='" + eddate + "'");
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
						dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                                            "unitsalesprice,amountsold,receiptnumber,entrydate from drugslog order by date");
						dgvsaleslog.DataSource = dtgetsaleslog;
						// generate another table for necessary calculation
						dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							//to sum the 2 columns
							for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
							}
						}
						c = dtgetsaleslog1.Rows.Count;
						txtcustomer.Text = c.ToString();

						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
					}
					else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && DateTimePicker1.Value.Date.ToShortDateString() == DateTimePicker2.Value.Date.ToShortDateString() && cbocashier.Text != "All Cashiers' Sales")
					{
						dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                                            "unitsalesprice,amountsold,receiptnumber,entrydate from drugslog where  cashiername='" + cbocashier.Text + "' And date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						dgvsaleslog.DataSource = dtgetsaleslog;
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog where cashiername='" + cbocashier.Text + "' And date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var k = 0; k < dtgetsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[k]["amountsold"]);
							}
							c = dtgetsaleslog1.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
					}
					else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && DateTimePicker1.Value.Date.ToShortDateString() != DateTimePicker2.Value.Date.ToShortDateString() && cbocashier.Text != "All Cashiers' Sales")
					{
						string stdate = DateTimePicker1.Value.Date.ToShortDateString();
						string eddate = DateTimePicker2.Value.Date.ToShortDateString();
						dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                                            "unitsalesprice,amountsold,receiptnumber,entrydate from drugslog where date >='" + stdate + "' and date <='" + eddate + "'and  cashiername='" + cbocashier.Text + "'");
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dgvsaleslog.DataSource = dtgetsaleslog;
						dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog where date >='" + stdate + "' and date <='" + eddate + "' and cashiername='" + cbocashier.Text + "'");
						if (dtgetsaleslog1.Rows.Count > 0)
						{
							for (var l = 0; l < dtgetsaleslog1.Rows.Count; l++)
							{
								temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[l]["amountsold"]);
							}
							c = dtgetsaleslog.Rows.Count;
							txtcustomer.Text = c.ToString();
						}
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
					}
					else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && DateTimePicker1.Value.Date.ToShortDateString() == DateTimePicker2.Value.Date.ToShortDateString())
					{
						dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                                            "unitsalesprice,amountsold,receiptnumber,entrydate from drugslog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						dgvsaleslog.DataSource = dtgetsaleslog;
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
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
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
					}
					else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && DateTimePicker1.Value.Date.ToShortDateString() != DateTimePicker2.Value.Date.ToShortDateString())
					{
						string stdate = DateTimePicker1.Value.Date.ToShortDateString();
						string eddate = DateTimePicker2.Value.Date.ToShortDateString();
						dtgetsaleslog = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                                            "unitsalesprice,amountsold,receiptnumber,entrydate from drugslog where date >='" + stdate + "' and date <='" + eddate + "'");
						if (dtgetsaleslog.Rows.Count > 0)
						{
							c = dtgetsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dgvsaleslog.DataSource = dtgetsaleslog;
						dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog where date >='" + stdate + "' and date <='" + eddate + "'");
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
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void DateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
		}

		private void Label4_Click(object sender, System.EventArgs e)
		{
		}

		private void Label8_Click(object sender, System.EventArgs e)
		{

		}

		private void DateTimePicker2_ValueChanged(object sender, System.EventArgs e)
		{

		}

		private void txtcustomer_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Label6_Click(object sender, System.EventArgs e)
		{

		}

		private void txttotaprofit_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Label2_Click(object sender, System.EventArgs e)
		{

		}

		private void txttotalsales_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Label1_Click(object sender, System.EventArgs e)
		{

		}

		private void cbocashier_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}

		private void Label7_Click(object sender, System.EventArgs e)
		{

		}

		private void dgvsaleslog_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{

		}

		private void Label5_Click(object sender, System.EventArgs e)
		{

		}

		private void Label3_Click(object sender, System.EventArgs e)
		{

		}

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //dgvsales.SelectedCells(0).Value.ToString
                if (this.dgvsaleslog.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please Select the roll of the Sale you want to cancel");

                }
                else
                {
                    MySqlConnection cn = new MySqlConnection();
                    MySqlDataAdapter ad = new MySqlDataAdapter();
                    MySqlCommand cm = new MySqlCommand();
                    string strconnection = "";
                    int intsalesid = 0;
                    System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                    dtgetadmin = getdatabase("select * from administrator");
                    for (var i = 0; i < dtgetadmin.Rows.Count; i++)
                    {
                        if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString()||txtcancelsalesapproval.Text== dtgetadmin.Rows[i]["adminpassword"].ToString())
                        {

                            strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                            cn.ConnectionString = strconnection;
                            System.Data.DataTable dtgetsales = new System.Data.DataTable();
                            System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                            intsalesid = Convert.ToInt32(dgvsaleslog.SelectedRows[0].Cells[1].Value.ToString());
                            dtgetsales = getdatabase("Select * From drugslog where salesid=" + intsalesid);
                            //dtgetexpirydate = getdatabase("Select * From expirydate where productid=" & intproductid)
                            cn.Open();
                            Sales_Reversal x = new Sales_Reversal();
                            x.txtproductid.Text = intsalesid.ToString();
                            x.txtproductname.Text = (dtgetsales.Rows[0]["itemsold"]).ToString();
                            x.txtquantity.Text = dtgetsales.Rows[0]["quantitysold"].ToString();
                            x.txtreceiptnumber.Text = dtgetsales.Rows[0]["receiptnumber"].ToString();
                            txtcancelsalesapproval.Text = "";
                            x.Show();
                        }
                        else
                        {
                            MessageBox.Show("Please This Operation is only for the ADMINISTRATOR. Call For His or Her Approval");
                             txtcancelsalesapproval.Focus();

                        }
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void drugslog_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");
                cbocashier.Items.Clear();
                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //    lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

                drugslog x = new drugslog();
                double totalsales = 0;
                double totalprofit = 0;
                System.Data.DataTable dtgetsaleslog = new System.Data.DataTable();
                dtgetsaleslog = getdatabase("select * from drugslog order by date");
                dgvsaleslog.DataSource = dtgetsaleslog;
                System.Data.DataTable dtgetsaleslog1 = new System.Data.DataTable();
                dtgetsaleslog1 = getdatabase("select amountsold,profit from drugslog");
                double temp = 0;
                double temp1 = 0;
                int c = 0;
                System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                dtgetadmin = getdatabase("select * from administrator");
                for (var i = 0; i < dtgetadmin.Rows.Count; i++)
                {
                    if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && dtgetsaleslog1.Rows.Count > 0)
                    {
                        for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
                        {
                            temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
                            temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[j]["profit"]);
                        }

                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                        txttotaprofit.Text = totalprofit.ToString();
                        c = dtgetsaleslog1.Rows.Count;
                        txtcustomer.Text = c.ToString();
                    }
                    else
                    {
                        for (var j = 0; j < dtgetsaleslog1.Rows.Count; j++)
                        {
                            temp = temp + Convert.ToDouble(dtgetsaleslog1.Rows[j]["amountsold"]);
                            temp1 = temp1 + Convert.ToDouble(dtgetsaleslog1.Rows[j]["profit"]);
                        }
                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                        c = dtgetsaleslog1.Rows.Count;
                        txtcustomer.Text = c.ToString();
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
    }
}