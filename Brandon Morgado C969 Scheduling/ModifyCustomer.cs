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

    

    public partial class ModifyCustomer : Form
    {
        
       
        public ModifyCustomer()
        {
            //int active = (radioActiveYes.Checked) ? 1 : 0;

            InitializeComponent();

            //get country
            DataTable dt1 = new DataTable();
            using (MySqlConnection cnn = new MySqlConnection(Global.cnStr))
            {
                cnn.Open();
                MySqlCommand comd = new MySqlCommand("select * from customer c, address a, city ci, country co where c.addressId = a.addressId and a.cityId = ci.cityId and ci.countryId = co.countryId and customerId = " + Global.CurrentCustID, cnn);
                MySqlDataAdapter msda = new MySqlDataAdapter(comd);
                msda.Fill(dt1);

                string country = (string)dt1.Rows[0]["country"];
                
                ComboCountryMod.Text = country;
                cnn.Close();
            }

            ////fill country combo box
            //DataTable dtt = new DataTable();
            //using (MySqlConnection cont = new MySqlConnection(Global.cnStr))
            //{
            //    cont.Open();
            //    MySqlCommand cmd = new MySqlCommand("select * from country", cont);
            //    MySqlDataReader dreader2 = cmd.ExecuteReader();
            //    dtt.Load(dreader2);
            //    //fill command is an alternative

            //    if (dtt.Rows.Count > 0)
            //    {
            //        ComboCountryMod.DataSource = dtt;
            //        ComboCountryMod.DisplayMember = "country";



            //    }
            //    cont.Close();
            //}


            //Get city
            DataTable dt2 = new DataTable();
            using (MySqlConnection cn = new MySqlConnection(Global.cnStr))
            {
                cn.Open();
                MySqlCommand cmdd = new MySqlCommand("select * from customer c, address a, city ci, country co where c.addressId = a.addressId and a.cityId = ci.cityId and ci.countryId = co.countryId and customerId = " + Global.CurrentCustID, cn);
                MySqlDataAdapter sdaa = new MySqlDataAdapter(cmdd);
                sdaa.Fill(dt2);


                string city = (string)dt2.Rows[0]["city"];
                ComboCityMod.Text = city;
                cn.Close();
            }

            ////fill city combo box
            //DataTable dtx = new DataTable();
            //using (MySqlConnection conx = new MySqlConnection(Global.cnStr))
            //{
            //    conx.Open();
            //    MySqlCommand cmd = new MySqlCommand("select distinct city from city", conx);
            //    MySqlDataReader dreader = cmd.ExecuteReader();
            //    dtx.Load(dreader);
            //    //fill command is an alternative

            //    if (dtx.Rows.Count > 0)
            //    {
            //        ComboCityMod.DataSource = dtx;
            //        ComboCityMod.DisplayMember = "city";
            //        //countryBox.Text = Convert.ToString(ComboCity.SelectedValue);

            //    }
            //    conx.Close();
            //}

          



            //Get customerName
            DataTable dt3 = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from customer", con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt3);
                string name = (string)dt3.Rows[Global.CurrentCust]["customerName"];
                //string active = (string)dt3.Rows[Global.CurrentCust]["active"];
                
                nameBoxMod.Text = name;

              

                //MessageBox.Show(nameBoxMod.Text);
                con.Close();
            }

            //Get address fields
            DataTable dt4 = new DataTable();
            using (MySqlConnection con1 = new MySqlConnection(Global.cnStr))
            {
                con1.Open();
                MySqlCommand cmd1 = new MySqlCommand("select * from customer c, address a, city ci, country co where c.addressId = a.addressId and a.cityId = ci.cityId and ci.countryId = co.countryId and customerId = " + Global.CurrentCustID, con1);
                MySqlDataAdapter sda1 = new MySqlDataAdapter(cmd1);
                sda1.Fill(dt4);
                string address = (string)dt4.Rows[0]["address"];
                
               
                string zip = (string)dt4.Rows[0]["postalCode"];
                
                string phone = (string)dt4.Rows[0]["phone"];
               
                
                Global.AddressID = (int)dt4.Rows[0]["addressId"];
                //MessageBox.Show("address ID is = " + Global.AddressID + "");
              

                addressBoxMod.Text = address;
                postBoxMod.Text = zip;
                phoneBoxMod.Text = phone;
                con1.Close();
            }


            //Get Country ID
            DataTable dt7 = new DataTable();
            String CountryId = "";
            using (MySqlConnection con7 = new MySqlConnection(Global.cnStr))
            {
                con7.Open();
                MySqlCommand cmd7 = new MySqlCommand("select * from customer c, address a, city ci, country co " +
                " where c.addressId = a.addressId and a.cityId = ci.cityId and ci.countryId = co.countryId and customerId = " + Global.CurrentCustID, con7);
                MySqlDataAdapter sda7 = new MySqlDataAdapter(cmd7);
                sda7.Fill(dt7);

                //CountryId = dt7.Rows[0][0].ToString();
                CountryId = dt7.Rows[0]["CountryId"].ToString();
                //MessageBox.Show(CountryId);

            }
            //MessageBox.Show(CountryId);
            Global.CurrentCountryId = CountryId;




            //Get City ID
            DataTable dt8 = new DataTable();
            String CityId = "";
            using (MySqlConnection con8 = new MySqlConnection(Global.cnStr))
            {
                con8.Open();
                MySqlCommand cmd8 = new MySqlCommand("select * from customer c, address a, city ci, country co " +
                " where c.addressId = a.addressId and a.cityId = ci.cityId and ci.countryId = co.countryId and customerId = " + Global.CurrentCustID, con8);
                MySqlDataAdapter sda8 = new MySqlDataAdapter(cmd8);
                sda8.Fill(dt8);

                
                CityId = dt8.Rows[0]["CityId"].ToString();
                

            }
            //MessageBox.Show(CityId);
            Global.CurrentCityID = CityId;

            //Get Address ID
            DataTable dt9 = new DataTable();
            String AddressId = "";
            using (MySqlConnection con9 = new MySqlConnection(Global.cnStr))
            {
                con9.Open();
                MySqlCommand cmd9 = new MySqlCommand("select * from customer c, address a, city ci, country co " +
                " where c.addressId = a.addressId and a.cityId = ci.cityId and ci.countryId = co.countryId and customerId = " + Global.CurrentCustID, con9);
                MySqlDataAdapter sda9 = new MySqlDataAdapter(cmd9);
                sda9.Fill(dt9);

               
                AddressId = dt9.Rows[0]["addressId"].ToString();

               //MessageBox.Show(AddressId);
            }
            
            




        }












        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBoxMod.Text) ||
                string.IsNullOrEmpty(addressBoxMod.Text) ||
                string.IsNullOrEmpty(ComboCityMod.Text) ||
                string.IsNullOrEmpty(postBoxMod.Text) ||
                string.IsNullOrEmpty(phoneBoxMod.Text) ||
                string.IsNullOrEmpty(ComboCountryMod.Text))
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                try
                {

                    //string CountryCombo = ComboCountryMod.GetItemText(ComboCountryMod.SelectedItem);
                    //string CityCombo = ComboCityMod.GetItemText(ComboCountryMod.SelectedItem);
                    int active = (radioActiveYes.Checked) ? 1 : 0;
                    string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    //UPDATE Country
                    string Query1 = "Update country SET country = '" + ComboCountryMod.Text + "'" +
                      ", lastUpdate = '" + dateTime + "'" +
                      ", lastUpdateBy = '" + Global.CurrUserName + "'" +
                      "WHERE countryId = '" + Global.CurrentCountryId + "';";

                    MySqlConnection con1 = new MySqlConnection(Global.cnStr);
                    MySqlCommand comm = new MySqlCommand(Query1, con1);
                    con1.Open();
                    comm.ExecuteNonQuery();
                    con1.Close();

                    //UPDATE city
                    string Query4 = "Update city SET city = '" + ComboCityMod.Text + "'" +
                    ", countryId = '" + Global.CurrentCountryId + "'" +
                    ", lastUpdate = '" + dateTime + "'" +
                    ", lastUpdateBy = '" + Global.CurrUserName + "'" +
                    "WHERE cityId = '" + Global.CurrentCityID + "';";

                    MySqlConnection con4 = new MySqlConnection(Global.cnStr);
                    MySqlCommand comm4 = new MySqlCommand(Query4, con4);
                    con4.Open();
                    comm4.ExecuteNonQuery();
                    con4.Close();

                    //UPDATE ADDRESS
                    String Query2 = "Update address SET address = '" + addressBoxMod.Text + "'" +
                    ", address2 = '" + addressBox2Mod.Text + "'" +
                    ", cityId = '" + Global.CurrentCityID + "'" +
                    ", postalCode = '" + postBoxMod.Text + "'" +
                    ", phone = '" + phoneBoxMod.Text + "'" +
                    ",lastUpdate = '" + dateTime + "'" +
                    ",lastUpdateBy = '" + Global.CurrUserName + "'" +
                    "WHERE addressId = '" + Global.AddressID + "';";

                    MySqlConnection con2 = new MySqlConnection(Global.cnStr);
                    MySqlCommand comm2 = new MySqlCommand(Query2, con2);
                    con2.Open();
                    comm2.ExecuteNonQuery();

                    con2.Close();





                    ////UPDATECUSTOMER
                    string Query3 = "Update customer SET customerName = '" + nameBoxMod.Text + "'" +
                    ", addressId = '" + Global.AddressID + "'" +
                    ", active = '" + active + "'" +
                    ",lastUpdate = '" + dateTime + "'" +
                    ",lastUpdateBy = '" + Global.CurrUserName + "'" +
                    "WHERE customerId = '" + Global.CurrentCustID + "';";



                    
                    MySqlConnection con3 = new MySqlConnection(Global.cnStr);
                    MySqlCommand comm3 = new MySqlCommand(Query3, con3);
                    con3.Open();
                    comm3.ExecuteNonQuery();

                    con3.Close();



                    this.Hide();
                    Form1 main = new Form1();
                    main.Show();


                    MessageBox.Show("customer successfully modified!");

                    

                }
                catch
                {
                    MessageBox.Show("Could not update customer.", "Error");
                }



            }
        }

        private void ModifyCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
