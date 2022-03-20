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


namespace Brandon_Morgado_C969_Scheduling
{


    public partial class Form1 : Form
    {


        DateTime currentDateCal;
        DataTable dtt2 = new DataTable();
        DateTime currentDate = new DateTime();
        
        


    private void formatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            d.RowHeadersVisible = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView2.ReadOnly = true;
            dataGridView2.AutoGenerateColumns = true;
        }
        public Form1()
        {
            InitializeComponent();

            fillAppTable();
            formatDGV(dataGridView2);
            formatDGV(dataGridView1);
            




            currentDateCal = DateTime.Now;
            



            //Checks appointment timer
            DateTime Current = Convert.ToDateTime(DateTime.UtcNow);
            DateTime CurrentPlus = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(15);
            DataTable dtt = new DataTable();
            string Query1 = "Select * from appointment where userId = '" + Global.UserID + "' AND start between '" + Current.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + CurrentPlus.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            using (MySqlConnection conn1 = new MySqlConnection(Global.cnStr))
            {
                conn1.Open();
                MySqlCommand comm1 = new MySqlCommand(Query1, conn1);
                MySqlDataReader dreader1 = comm1.ExecuteReader();
                dtt.Load(dreader1);
                if (dtt.Rows.Count >= 1)
                {
                    MessageBox.Show("You have a scheduled appointment within the next 15 minutes.", "Alert!");
                }
                conn1.Close();
            }






            //Fill Customer Table
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("select customerId, customerName, lastUpdate from customer", con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt;
                }
                con.Close();

            }

           
        }

       
        private void fillAppTable()
        {
            //Fill Appointment Table
            DataTable dt1 = new DataTable();
            using (MySqlConnection con1 = new MySqlConnection(Global.cnStr))
            {
                con1.Open();
                MySqlCommand command = new MySqlCommand("select appointmentId, customerId, title, start, end from appointment", con1);
                MySqlDataReader dreader1 = command.ExecuteReader();
                dt1.Load(dreader1);

                if (dt1.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt1;
                }
                con1.Close();

            }
        }
         

        //fill customer grid
        private void FillGrid()
        {

            MySqlConnection con = new MySqlConnection(Global.cnStr);
            MySqlDataAdapter da = new MySqlDataAdapter("select customerId, customerName, lastUpdate from customer", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            //dataGridView2.DataBind();
        }

        //fill appointment grid
        private void FillGridApp()
        {

            MySqlConnection con = new MySqlConnection(Global.cnStr);
            MySqlDataAdapter da = new MySqlDataAdapter("select appointmentId, customerId, title, start, end from appointment", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //dataGridView2.DataBind();
        }




        private void DashboardApptDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment addApp = new AddAppointment();
            addApp.Show();
        }

        //Modify Appointment
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow xyz = dataGridView1.Rows[Global.CurrApp];
            // MessageBox.Show(xyz.Cells[0].Value + "");




            Global.CurrentAppID = Convert.ToInt32(xyz.Cells[0].Value.ToString());

            //MessageBox.Show(Global.CurrentAppID + "");

            this.Hide();
            ModifyAppointment modApp = new ModifyAppointment();
            modApp.Show();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer addCust = new AddCustomer();
            addCust.Show();
        }


        
        
        //Modify customer
        private void button5_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(Global.CurrentCust.ToString());


            DataGridViewRow xyz = dataGridView2.Rows[Global.CurrentCust];
           // MessageBox.Show(xyz.Cells[0].Value + "");

            


            Global.CurrentCustID = Convert.ToInt32(xyz.Cells[0].Value.ToString());

            //MessageBox.Show(Global.CurrentCustID + "");

            this.Hide();
            ModifyCustomer modCt = new ModifyCustomer();
            modCt.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.CurrentCust = e.RowIndex;
            

        }

        //Delete Customer
        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(Global.cnStr))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from customer", connection);
                MySqlDataReader dreader = cmd.ExecuteReader();
                dt.Load(dreader);

                connection.Close();
            }
            try
            {
                //This works too to capture row using commented out statement below.
                //DataRow row = (dataGridView2.SelectedRows[0].DataBoundItem as DataRowView).Row;

                int row = (int)dt.Rows[Global.CurrentCust]["customerId"];
                using (MySqlConnection conn = new MySqlConnection(Global.cnStr))
                {
                    conn.Open();

                  
                    using (MySqlCommand sqlCommand = new MySqlCommand("delete from customer where customerId= '" + row + "';", conn))
                    {
                        sqlCommand.ExecuteNonQuery();
                        
                    }
                    conn.Close();
                    dataGridView2.Update();
                    dataGridView2.Refresh();
                    MessageBox.Show("Customer successfully deleted!");
                    FillGrid();

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Customer could not be deleted" + x.Message.ToString());
            }
            

        }

        //Delete Appointment
        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            using (MySqlConnection conn1 = new MySqlConnection(Global.cnStr))
            {
                conn1.Open();
                MySqlCommand cmd1 = new MySqlCommand("select * from appointment", conn1);
                MySqlDataReader dreader = cmd1.ExecuteReader();
                dt1.Load(dreader);

                conn1.Close();
            }
            try
            {
                

                int row1 = (int)dt1.Rows[Global.CurrApp]["appointmentId"];
                using (MySqlConnection conn1 = new MySqlConnection(Global.cnStr))
                {
                    conn1.Open();

                   
                    using (MySqlCommand sqlCommand = new MySqlCommand("delete from appointment where appointmentId = '" + row1 + "';", conn1))
                    {
                        sqlCommand.ExecuteNonQuery();

                    }
                    conn1.Close();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    MessageBox.Show("Appointment successfully deleted!");
                    FillGridApp();

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Appointment could not be deleted" + x.Message.ToString());
            }



        }

        //Appointment datagridview
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.CurrApp = e.RowIndex;
        }



        



        //display UTC time as local time
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime)
            {
                DateTime value = (DateTime)e.Value;
                switch (value.Kind)
                {
                    case DateTimeKind.Local:
                        break;
                    case DateTimeKind.Unspecified:
                        e.Value = DateTime.SpecifyKind(value, DateTimeKind.Utc).ToLocalTime();
                        break;
                    case DateTimeKind.Utc:
                        e.Value = value.ToLocalTime();
                        break;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            HandleWeek();
        }


        private void getSqlData(string s)
        {
            //using (MySqlConnection conx = new MySqlConnection(Global.cnStr))
            //{

            //    conx.Open();
            //    MySqlCommand cmmdx = new MySqlCommand(s, conx);
            //    MySqlDataAdapter adapter = new MySqlDataAdapter(cmmdx);
            //    adapter.Fill(dtt2);

            //    conx.Close();

            //}

        }

        //I have looked at this with a course instructor, Tom Weidner, he suggested that I leave a comment stating that 
        //This handle week toggle will handle the week from the current date, to seven days out.

        private void HandleWeek()
		{
			
            DateTime startDate = currentDateCal;
            DateTime endDate = currentDateCal.AddDays(7);

			//Weekly appts to DGV
			DataTable dv1 = new DataTable();
            using (MySqlConnection cn1 = new MySqlConnection(Global.cnStr))
            {
                cn1.Open();
                MySqlCommand cmd1 = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment where start BETWEEN '" + TimeZoneInfo.ConvertTimeToUtc(startDate).ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + TimeZoneInfo.ConvertTimeToUtc(endDate).ToString("yyyy-MM-dd HH:mm:ss") + "'; ", cn1);
                MySqlDataReader reader = cmd1.ExecuteReader();
                dv1.Load(reader);
                if (dv1.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dv1;
                  
                }
                else if (dv1.Rows.Count < 1)
                    {
                    MessageBox.Show("There are no appointments coming up within the next week.");
                    }

                cn1.Close();
            }
        }

        //I have looked at this with a course instructor, Tom Weidner, he suggested that I leave a comment stating that 
        //This handle month toggle will handle the month from the current date, to the next month out.
        private void handleMonth()
        {
			

			DataTable dv2 = new DataTable();

            DateTime thisMonthStart = currentDateCal;
            DateTime thisMonthEnd = currentDateCal.AddMonths(1);

			using (MySqlConnection cn2 = new MySqlConnection(Global.cnStr))
            {
                cn2.Open();
                MySqlCommand cmd2 = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment where start BETWEEN '" + TimeZoneInfo.ConvertTimeToUtc(thisMonthStart).ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + TimeZoneInfo.ConvertTimeToUtc(thisMonthEnd).ToString("yyyy-MM-dd HH:mm:ss") + "'; ", cn2);
                MySqlDataReader reader = cmd2.ExecuteReader();
                dv2.Load(reader);
                if (dv2.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dv2;
                   
                }
                else if (dv2.Rows.Count < 1)
                {
                    MessageBox.Show("There are no appointments coming up within the next month.");
                }

                cn2.Close();
            }
        }



        //sets DGV display back to default
        private void radSeeAll_CheckedChanged(object sender, EventArgs e)
        {
            fillAppTable();
            formatDGV(dataGridView1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            handleMonth();
        }

        //loads report by month 
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppByMonthReport appMonth = new AppByMonthReport();
            appMonth.Show();
        }

        private void ReportActList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ConsultantSchedule = new Form2();
            ConsultantSchedule.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginTimecard ltc = new LoginTimecard();
            ltc.Show();
        }

        private void checkAppointmentTime()
        {
           //

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
         
        }
    }
}
