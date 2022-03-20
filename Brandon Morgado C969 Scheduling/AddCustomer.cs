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
using System.Configuration;




namespace Brandon_Morgado_C969_Scheduling
{
    public partial class AddCustomer : Form
    {
        //public Customer SelectedCustomer { get; set; }

        public DataGridView CustomerGridView { get; set; }

        public AddCustomer()
        {
            InitializeComponent();

            

            //fill city combo box
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from city", con);
                MySqlDataReader dreader = cmd.ExecuteReader();
                dt.Load(dreader);
                //fill command is an alternative

                if (dt.Rows.Count > 0)
                {
                    ComboCity.DataSource = dt;
                    ComboCity.DisplayMember = "city";
                    //countryBox.Text = Convert.ToString(ComboCity.SelectedValue);

                }
                con.Close();
            }

            //fill country combo box
            DataTable dt2 = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from country", con);
                MySqlDataReader dreader2 = cmd.ExecuteReader();
                dt2.Load(dreader2);
                //fill command is an alternative

                if (dt2.Rows.Count > 0)
                {
                    ComboCountry.DataSource = dt2;
                    ComboCountry.DisplayMember = "country";
                }
                con.Close();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nameBox.Text) ||
                string.IsNullOrEmpty(addressBox.Text) ||
                string.IsNullOrEmpty(ComboCity.Text) ||
                string.IsNullOrEmpty(postBox.Text) ||
                string.IsNullOrEmpty(phoneBox.Text) ||
                string.IsNullOrEmpty(ComboCountry.Text))
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                int active = (radioActiveYes.Checked) ? 1 : 0;
              
                //Create Country
                int countryID = Global.createCountry(ComboCountry.Text);
                //Create City
                int cityID = Global.createCity(countryID, ComboCity.Text);
                ////Create Address
                int addressID = Global.createAddress(cityID, addressBox.Text, addressBox2.Text, postBox.Text, phoneBox.Text);
                ////create customer
                Global.createCustomer(Global.getID("customer", "customerId") + 1, nameBox.Text, addressID, active, Global.getDateTime(), Global.currentUserName());
                MessageBox.Show("Customer created successfully!");



                Form1 main = new Form1();
                main.Show();
                this.Hide();




            }

        }



        
    }
}
