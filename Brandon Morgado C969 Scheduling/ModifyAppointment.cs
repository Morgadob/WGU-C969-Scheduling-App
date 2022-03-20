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
    public partial class ModifyAppointment : Form
    {
        public ModifyAppointment()
        {
            InitializeComponent();

            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
           




            AppModCusText.Enabled = false;

            //populate fields
            DataTable dt1 = new DataTable();
            using (MySqlConnection con1 = new MySqlConnection(Global.cnStr))
            {
                con1.Open();
                MySqlCommand cmd1 = new MySqlCommand("select * from appointment where appointmentId = " + Global.CurrentAppID , con1);
                MySqlDataAdapter sda1 = new MySqlDataAdapter(cmd1);
                sda1.Fill(dt1);

                

                //MessageBox.Show(customer + "");

                string customer = dt1.Rows[0]["customerId"].ToString();
                string type = (string)dt1.Rows[0]["type"];
                string title = (string)dt1.Rows[0]["title"];
                string description = (string)dt1.Rows[0]["description"];
                string location = (string)dt1.Rows[0]["location"];
                string contact = (string)dt1.Rows[0]["contact"];
                string url = (string)dt1.Rows[0]["url"];
                DateTime start = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt1.Rows[0]["start"], TimeZoneInfo.Local);
                DateTime end = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt1.Rows[0]["end"], TimeZoneInfo.Local);

                AppModCusText.Text = customer;
                TypeAppMod.Text = type;
                AppModCusTitle.Text = title;
                AppModDescBox.Text = description;
                AppModLocat.Text = location;
                AppContactMod.Text = contact;
                AppUrlBoxMod.Text = url;
                StartAppModPick.Value = (DateTime)start;
                EndAppModPick.Value = (DateTime)end;

                con1.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        //save update
        private void button1_Click(object sender, EventArgs e)
        {
            //string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {

                //string typeCombo = TypeAppMod.GetItemText(TypeAppMod.SelectedItem);

                

                //UPDATE appointment
                string Query1 = "Update appointment SET title = '" + AppModCusTitle.Text + "'" +
                  ", description = '" + AppModDescBox.Text + "'" +
                  ", location = '" + AppModLocat.Text + "'" +
                   ", contact = '" + AppContactMod.Text + "'" +
                   ", type = '" + TypeAppMod.Text + "'" +
                   ", url = '" + AppUrlBoxMod.Text + "'" +
                   ", start = '" + TimeZoneInfo.ConvertTimeToUtc(StartAppModPick.Value).ToString("yyyy-MM-dd HH:mm:ss") + "'" +
                   ", end = '" + TimeZoneInfo.ConvertTimeToUtc(EndAppModPick.Value).ToString("yyyy-MM-dd HH:mm:ss") + "'" +
                   ", lastUpdate = '" + TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "'" +
                  ", lastUpdateBy = '" + Global.CurrUserName + "'" +
                  "WHERE appointmentId = '" + Global.CurrentAppID + "';";

                MySqlConnection con1 = new MySqlConnection(Global.cnStr);
                MySqlCommand comm = new MySqlCommand(Query1, con1);
                con1.Open();
                comm.ExecuteNonQuery();
                con1.Close();

                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not update Appointment.", "Error");
            }

            


        }

        
    }
}
