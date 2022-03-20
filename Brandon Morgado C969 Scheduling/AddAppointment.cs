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
    public partial class AddAppointment : Form
    {

        

        
        public AddAppointment()
        {
            InitializeComponent();

            this.AppStartPicker.Value = DateTime.Now;
            this.AppEndPicker.Value = DateTime.Now;
            AppTypeText.Items.Add("Prsentation");
            AppTypeText.Items.Add("Scrum");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 main = new Form1();
            main.Show();
        }


        //save appointment
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = TimeZoneInfo.ConvertTimeToUtc(AppStartPicker.Value);
            DateTime end = TimeZoneInfo.ConvertTimeToUtc(AppEndPicker.Value);

            DateTime now = DateTime.Now;
            TimeSpan businessStart = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0).TimeOfDay;
            TimeSpan businessEnd = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0).TimeOfDay;

            DateTime selectedStart = AppStartPicker.Value;
            DateTime selectedEnd = AppEndPicker.Value;
            DateTime AppStart = TimeZoneInfo.ConvertTimeToUtc(AppStartPicker.Value);
            DateTime AppEnd = TimeZoneInfo.ConvertTimeToUtc(AppEndPicker.Value);



            


            //Checks for appointment schedule conflicts 
            DataTable dt1 = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(Global.cnStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from appointment", conn);
                MySqlDataReader dreader = cmd.ExecuteReader();
                dt1.Load(dreader);
                if (dt1.Rows.Count > 0)
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        DateTime bappStart = Convert.ToDateTime(dt1.Rows[i]["start"]);
                        DateTime bappEnd = Convert.ToDateTime(dt1.Rows[i]["end"]);

                        
                        if (AppStart < bappEnd && bappStart < AppEnd)
                        {
                            MessageBox.Show("There is already an appointment booked at the timeslot you have selected. Please choose a new time.");
                            return;
                        }
                        conn.Close();
                    }
                }

               

                Global.createAppointment(Global.custAppComboId, Global.UserID, AppCusTitle.Text, AppDescBox.Text, AppLocat.Text, AppContact.Text, AppTypeText.Text.ToString(), AppUrlBox.Text, start, end);
                this.Close();
                Form1 main = new Form1();
                main.Show();


            }
        }

        //Fill customer Combo Box
        private void AppCusText_Click(object sender, EventArgs e)
        {
            
            DataTable dt1 = new DataTable();
            
            using (MySqlConnection con1 = new MySqlConnection(Global.cnStr))
            {
                con1.Open();
                MySqlCommand cmd1 = new MySqlCommand("select * from customer", con1);
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd1);
                msda.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {
                    AppCusText.DataSource = dt1;
                    AppCusText.DisplayMember = "customerName";
                }
                con1.Close();
            }
        }




        private void AppCusText_SelectedValueChanged(object sender, EventArgs e)
        {
            //Global.AppCustText = AppCustText.Text;
        }



        private void AppTypeText_DropDownClosed(object sender, EventArgs e)
        {
           
//

        }

        private void AppCusText_DropDownClosed(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();

            string comboSelect = AppCusText.GetItemText(AppCusText.SelectedItem);
            using (MySqlConnection con2 = new MySqlConnection(Global.cnStr))
            {
                con2.Open();
                MySqlCommand cmd2 = new MySqlCommand("select customerId from customer where customername = '"+ comboSelect +"';", con2);
                MySqlDataAdapter msda2 = new MySqlDataAdapter(cmd2);
                msda2.Fill(dt2);

                if (dt2.Rows.Count > 0)
                {
                    int appCustId = (int)dt2.Rows[0][0];
                    Global.custAppComboId = appCustId;

                    //MessageBox.Show(appCustId + "");
                }
                con2.Close();
            }
        }

        //fill type box
        private void AppTypeText_Click(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();

            using (MySqlConnection con3= new MySqlConnection(Global.cnStr))
            {
                con3.Open();
                MySqlCommand cmd3 = new MySqlCommand("select distinct type from appointment", con3);
                MySqlDataAdapter msda3 = new MySqlDataAdapter(cmd3);
                msda3.Fill(dt3);

                if (dt3.Rows.Count > 0)
                {
                    AppTypeText.DataSource = dt3;
                    AppTypeText.DisplayMember = "type";
                }
                con3.Close();
            }
        }
    }
}
