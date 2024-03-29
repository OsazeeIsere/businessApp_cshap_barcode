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
	public partial class generalsaleslog
	{
		internal generalsaleslog()
		{
			InitializeComponent();
		}

		public saleslog x = new saleslog();
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

		private void generalsaleslog_Load(object sender, System.EventArgs e)
		{
			try
			{
                txtadmin.Text = txtpassword1.Text;
                txtpassword1.Visible = false;
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");

                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //            lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                generalsaleslog x = new generalsaleslog();
				double totalsales = 0;
				double totalprofit = 0;
				System.Data.DataTable dtgetgeneralsaleslog = new System.Data.DataTable();
                System.Data.DataTable dtgetgeneralsaleslog_dgv = new System.Data.DataTable();

                dtgetgeneralsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                    "unitsalesprice,amountsold,receiptnumber,entrydate from generalsaleslog order by entrydate");
                dtgetgeneralsaleslog = getdatabase("select * from generalsaleslog order by entrydate");

                System.Data.DataTable dtgetgeneralsaleslog1 = new System.Data.DataTable();
				dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog");
				double temp = 0;
				double temp1 = 0;
				int c = 0;
				System.Data.DataTable dtgetcashier = new System.Data.DataTable();
				System.Data.DataTable dtgetadmin = new System.Data.DataTable();
				dtgetadmin = getdatabase("select * from administrator");
				for (var i = 0; i < dtgetadmin.Rows.Count; i++)
				{
					if (txtadmin.Text == dtgetadmin.Rows[i]["adminpassword"].ToString())
					{
						dtgetgeneralsaleslog = getdatabase("select * from generalsaleslog order by date");
						dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
						// generate another table for necessary calculation

						dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog");

						if (dtgetgeneralsaleslog1.Rows.Count > 0)
						{
							//to sum the 2 columns
							for (var k = 0; k < dtgetgeneralsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["profit"]);
							}
						}
						c = dtgetgeneralsaleslog1.Rows.Count;
						txtcustomer.Text = c.ToString();

						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
				}
				for (var i = 0; i < dtgetadmin.Rows.Count; i++)
				{
					if (txtadmin.Text != dtgetadmin.Rows[i]["adminpassword"].ToString())
					{
						dtgetgeneralsaleslog = getdatabase("select * from generalsaleslog order by date");
						dgvsaleslog.DataSource = dtgetgeneralsaleslog;
						// generate another table for necessary calculation

						dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog");

						if (dtgetgeneralsaleslog1.Rows.Count > 0)
						{
							//to sum the 2 columns
							for (var k = 0; k < dtgetgeneralsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["profit"]);
							}
						}
						c = dtgetgeneralsaleslog1.Rows.Count;
						txtcustomer.Text = c.ToString();
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
					}
				}
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
				System.Data.DataTable dtgetgeneralsaleslog = new System.Data.DataTable();
				System.Data.DataTable dtgetgeneralsaleslog1 = new System.Data.DataTable();
				double totalsales = 0;
				double totalprofit = 0;
				System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                System.Data.DataTable dtgetgeneralsaleslog_dgv = new System.Data.DataTable();

                dtgetgeneralsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                    "unitsalesprice,amountsold,receiptnumber,entrydate from generalsaleslog order by entrydate");

                dtgetadmin = getdatabase("select * from administrator");
				for (var i = 0; i < dtgetadmin.Rows.Count; i++)
				{
					if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Sales")
					{
						drugslog x = new drugslog();
						dtgetgeneralsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                    "unitsalesprice,amountsold,receiptnumber,entrydate from generalsaleslog order by date");
						dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
						// generate another table for necessary calculation

						dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog");

						if (dtgetgeneralsaleslog1.Rows.Count > 0)
						{
							//to sum the 2 columns
							for (var k = 0; k < dtgetgeneralsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["profit"]);
							}
						}
						totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
                        txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
					}
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && DateTimePicker1.Value.Date.ToShortDateString() == DateTimePicker2.Value.Date.ToShortDateString() && cbocashier.Text != "All Cashiers' Sales")
					{
						dtgetgeneralsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold,unitsalesprice,amountsold,receiptnumber,entrydate from generalsaleslog where  cashiername='" + cbocashier.Text + "' And date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
						if (dtgetgeneralsaleslog.Rows.Count > 0)
						{
							c = dtgetgeneralsaleslog.Rows.Count;
						}
						txtcustomer.Text = c.ToString();
						dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog where cashiername='" + cbocashier.Text + "' And date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						if (dtgetgeneralsaleslog1.Rows.Count > 0)
						{
							for (var k = 0; k < dtgetgeneralsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["profit"]);
							}
                            txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        }
                        totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && DateTimePicker1.Value.Date.ToShortDateString() != DateTimePicker2.Value.Date.ToShortDateString() && cbocashier.Text != "All Cashiers' Sales")
					{
						DateTime stdate = Convert.ToDateTime(DateTimePicker1.Value.Date.ToShortDateString());
						DateTime eddate = Convert.ToDateTime(DateTimePicker2.Value.Date.ToShortDateString());
						dtgetgeneralsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                    "unitsalesprice,amountsold,receiptnumber,entrydate from generalsaleslog where date >='" + stdate + "' and date <='" + eddate + "'and  cashiername='" + cbocashier.Text + "'");
						if (dtgetgeneralsaleslog.Rows.Count > 0)
						{
							c = dtgetgeneralsaleslog.Rows.Count;
						}
                        txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
						dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog where date >='" + stdate + "' and date <='" + eddate + "' and cashiername='" + cbocashier.Text + "'");
						if (dtgetgeneralsaleslog1.Rows.Count > 0)
						{
							for (var j = 0; j < dtgetgeneralsaleslog1.Rows.Count; j++)
							{
								temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[j]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[j]["profit"]);
							}
                            txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        }
                        totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && DateTimePicker1.Value.Date.ToShortDateString() == DateTimePicker2.Value.Date.ToShortDateString())
					{
						dtgetgeneralsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold,unitsalesprice,amountsold,receiptnumber,entrydate from generalsaleslog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
						if (dtgetgeneralsaleslog_dgv.Rows.Count > 0)
						{
							c = dtgetgeneralsaleslog.Rows.Count;
						}
                        txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						if (dtgetgeneralsaleslog1.Rows.Count > 0)
						{
							for (var k = 0; k < dtgetgeneralsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["profit"]);
							}
                            txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        }
                        totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
						txttotaprofit.Text = totalprofit.ToString();
					}
					else if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && DateTimePicker1.Value.Date.ToShortDateString().ToString() != DateTimePicker2.Value.Date.ToShortDateString().ToString())
					{
						string stdate = DateTimePicker1.Value.Date.ToShortDateString();
						string eddate = DateTimePicker2.Value.Date.ToShortDateString();
						dtgetgeneralsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold,unitsalesprice,amountsold,receiptnumber,entrydate from generalsaleslog where date >='" + stdate + "' and date <='" + eddate + "'");
						if (dtgetgeneralsaleslog.Rows.Count > 0)
						{
							c = dtgetgeneralsaleslog.Rows.Count;
						}
                        txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
						dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog where date >='" + stdate + "' and date <='" + eddate + "'");
						if (dtgetgeneralsaleslog1.Rows.Count > 0)
						{
							for (var j = 0; j < dtgetgeneralsaleslog1.Rows.Count; j++)
							{
								temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[j]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[j]["profit"]);
							}
							c = dtgetgeneralsaleslog.Rows.Count;
                            txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
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
                        drugslog x = new drugslog();
                        dtgetgeneralsaleslog = getdatabase("select * from generalsaleslog order by date");
                        dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
                        // generate another table for necessary calculation
                        dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog");
                        if (dtgetgeneralsaleslog1.Rows.Count > 0)
                        {
                            //to sum the 2 columns
                            for (var k = 0; k < dtgetgeneralsaleslog1.Rows.Count; k++)
                            {
                                temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["amountsold"]);
                                temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["profit"]);
                            }
                        }
                        txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                    }
                    else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && Convert.ToDateTime(DateTimePicker1.Value.Date.ToShortDateString()) == Convert.ToDateTime(DateTimePicker2.Value.Date.ToShortDateString()) && cbocashier.Text != "All Cashiers' Sales")
                    {
                        dtgetgeneralsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                    "unitsalesprice,amountsold,receiptnumber,entrydate from generalsaleslog where  cashiername='" + cbocashier.Text + "' And date='" + Convert.ToDateTime(DateTimePicker1.Value.Date.ToShortDateString()) + "'");
                        dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
                        if (dtgetgeneralsaleslog.Rows.Count > 0)
                        {
                            c = dtgetgeneralsaleslog.Rows.Count;
                        }
                        txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog where cashiername='" + cbocashier.Text + "' And date='" + Convert.ToDateTime(DateTimePicker1.Value.Date.ToShortDateString()) + "'");
                        if (dtgetgeneralsaleslog1.Rows.Count > 0)
                        {
                            for (var k = 0; k < dtgetgeneralsaleslog1.Rows.Count; k++)
                            {
                                temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["amountsold"]);
                                temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["profit"]);
                            }
                            txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        }
                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                    }
                    else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && Convert.ToDateTime(DateTimePicker1.Value.Date.ToShortDateString()) != Convert.ToDateTime(DateTimePicker2.Value.Date.ToShortDateString()) && cbocashier.Text != "All Cashiers' Sales")
                    {
                        DateTime stdate = Convert.ToDateTime(DateTimePicker1.Value.Date.ToShortDateString());
                        DateTime eddate = Convert.ToDateTime(DateTimePicker2.Value.Date.ToShortDateString());
                        dtgetgeneralsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                    "unitsalesprice,amountsold,receiptnumber,entrydate from generalsaleslog where date >='" + stdate + "' and date <='" + eddate + "'and  cashiername='" + cbocashier.Text + "'");
                        if (dtgetgeneralsaleslog.Rows.Count > 0)
                        {
                            c = dtgetgeneralsaleslog.Rows.Count;
                        }
                        txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
                        dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog where date >='" + stdate + "' and date <='" + eddate + "' and cashiername='" + cbocashier.Text + "'");
                        if (dtgetgeneralsaleslog1.Rows.Count > 0)
                        {
                            for (var j = 0; j < dtgetgeneralsaleslog1.Rows.Count; j++)
                            {
                                temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[j]["amountsold"]);
                                temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[j]["profit"]);
                            }
                            txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();

                        }
                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                    }
                    else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && DateTimePicker1.Value.Date.ToShortDateString() == (DateTimePicker2.Value.Date.ToShortDateString()))
					{
						dtgetgeneralsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                    "unitsalesprice,amountsold,receiptnumber,entrydate from generalsaleslog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
						if (dtgetgeneralsaleslog.Rows.Count > 0)
						{
							c = dtgetgeneralsaleslog.Rows.Count;
						}
                        txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
						if (dtgetgeneralsaleslog1.Rows.Count > 0)
						{
							for (var k = 0; k < dtgetgeneralsaleslog1.Rows.Count; k++)
							{
								temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["profit"]);
							}
                            txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        }
                        totalsales = temp;
						totalprofit = temp1;
						txttotalsales.Text = totalsales.ToString();
					}
					else if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString() && cbocashier.Text == "All Cashiers' Sales" && Convert.ToDateTime(DateTimePicker1.Value.Date.ToShortDateString()).ToString() != Convert.ToDateTime(DateTimePicker2.Value.Date.ToShortDateString()).ToString())
					{
						DateTime stdate = Convert.ToDateTime(DateTimePicker1.Value.Date.ToShortDateString());
						DateTime eddate = Convert.ToDateTime(DateTimePicker2.Value.Date.ToShortDateString());
						dtgetgeneralsaleslog_dgv = getdatabase("select * from generalsaleslog where date >='" + stdate + "' and date <='" + eddate + "'");
						if (dtgetgeneralsaleslog.Rows.Count > 0)
						{
							c = dtgetgeneralsaleslog.Rows.Count;
						}
                        txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
                        dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
						dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog where date >='" + stdate + "' and date <='" + eddate + "'");
						if (dtgetgeneralsaleslog1.Rows.Count > 0)
						{
							for (var j = 0; j < dtgetgeneralsaleslog1.Rows.Count; j++)
							{
								temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[j]["amountsold"]);
								temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[j]["profit"]);
							}
                            txtcustomer.Text = dtgetgeneralsaleslog_dgv.Rows.Count.ToString();
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

		private void Label6_Click(object sender, System.EventArgs e)
		{

		}

        private void dgvsaleslog_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dgvsaleslog_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    if (txtadmin.Text == dtgetadmin.Rows[i]["adminpassword"].ToString())
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
                        x.txtquantity.Text= dtgetsales.Rows[0]["quantitysold"].ToString();
                        x.txtreceiptnumber.Text= dtgetsales.Rows[0]["receiptnumber"].ToString();
                        x.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please This Operation is only for the ADMINISTRATOR");

                    }
                }

            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void generalsaleslog_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void generalsaleslog_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                cbocashier.Items.Clear();
                txtadmin.Text = txtpassword1.Text;
                txtpassword1.Visible = false;
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");

                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //            lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                generalsaleslog x = new generalsaleslog();
                double totalsales = 0;
                double totalprofit = 0;
                System.Data.DataTable dtgetgeneralsaleslog = new System.Data.DataTable();
                dtgetgeneralsaleslog = getdatabase("select * from generalsaleslog order by entrydate");
                System.Data.DataTable dtgetgeneralsaleslog1 = new System.Data.DataTable();
                dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog");
                double temp = 0;
                double temp1 = 0;
                int c = 0;
                System.Data.DataTable dtgetcashier = new System.Data.DataTable();
                System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                System.Data.DataTable dtgetgeneralsaleslog_dgv = new System.Data.DataTable();

                dtgetgeneralsaleslog_dgv = getdatabase("select cashiername,salesid,productid,itemsold,quantitysold," +
                    "unitsalesprice,amountsold,receiptnumber,entrydate from generalsaleslog order by entrydate");

                dtgetadmin = getdatabase("select * from administrator");
                for (var i = 0; i < dtgetadmin.Rows.Count; i++)
                {
                    if (txtpassword1.Text == dtgetadmin.Rows[i]["adminpassword"].ToString())
                    {
                        dtgetgeneralsaleslog = getdatabase("select * from generalsaleslog order by date");
                        dgvsaleslog.DataSource = dtgetgeneralsaleslog_dgv;
                        // generate another table for necessary calculation

                        dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog");

                        if (dtgetgeneralsaleslog1.Rows.Count > 0)
                        {
                            //to sum the 2 columns
                            for (var k = 0; k < dtgetgeneralsaleslog1.Rows.Count; k++)
                            {
                                temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["amountsold"]);
                                temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["profit"]);
                            }
                        }
                        c = dtgetgeneralsaleslog1.Rows.Count;
                        txtcustomer.Text = c.ToString();

                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                        txttotaprofit.Text = totalprofit.ToString();
                    }
                }
                for (var i = 0; i < dtgetadmin.Rows.Count; i++)
                {
                    if (txtpassword1.Text != dtgetadmin.Rows[i]["adminpassword"].ToString())
                    {
                        dtgetgeneralsaleslog = getdatabase("select * from generalsaleslog order by date");
                        dgvsaleslog.DataSource = dtgetgeneralsaleslog;
                        // generate another table for necessary calculation

                        dtgetgeneralsaleslog1 = getdatabase("select amountsold,profit from generalsaleslog");

                        if (dtgetgeneralsaleslog1.Rows.Count > 0)
                        {
                            //to sum the 2 columns
                            for (var k = 0; k < dtgetgeneralsaleslog1.Rows.Count; k++)
                            {
                                temp = temp + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["amountsold"]);
                                temp1 = temp1 + Convert.ToDouble(dtgetgeneralsaleslog1.Rows[k]["profit"]);
                            }
                        }
                        c = dtgetgeneralsaleslog1.Rows.Count;
                        txtcustomer.Text = c.ToString();
                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                    }
                }
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