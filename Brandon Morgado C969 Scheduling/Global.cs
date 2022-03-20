using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Brandon_Morgado_C969_Scheduling
{
    class Global
    {
        


        public static DateTime getDateTime()
        {
            return DateTime.Now.ToUniversalTime();

        }
        private static string userName;

        //public static int getCurrentUserId()
        //{
        //    //return userID;
        //}

        public static int UserID = 1;


        public static int CityID { get; set; }

        public static string CurrentCityID { get; set; }
        public static int AddressID { get; set; }

        public static string currentUserName()
        {
            return userName;
        }
        public static int CountryID { get; set; }
        public static int CurrCustomerIndex { get; set; }
        public static int AddID { get; set; }

        public static string CurrUserName = "test";


        public static int CurrentCust { get; set; }

        public static int CurrentCustID { get; set; }

        public static int CurrentAppID { get; set; }



        public static int reportID { get; set; }

        public static string ApptTypeCombo { get; set; }

        public static int CurrApp { get; set; }

        public static int custAppComboId { get; set; }

        public static string CurrentCountryId { get; set; }

        public static string cnStr = @"Host=localhost;Port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!;SslMode=Required;Convert Zero Datetime=True";

        
        //pulls data from user and puts into list for Lambda
        public static List<User>pullAllUsers()
        {
            List<User> userList = new List<User>();


            using (MySqlConnection con = new MySqlConnection(cnStr))
            {
                con.Open();
                String queryX = "Select * from user;";
                MySqlCommand command = new MySqlCommand(queryX, con);
                MySqlDataReader dreader = command.ExecuteReader();
                
                while (dreader.Read())
                {
                    int userID = Convert.ToInt32(dreader[0]);
                    string userName = dreader[1].ToString();
                    string password = dreader[2].ToString();
                    int active = Convert.ToInt32(dreader[3]);

                    DateTime createDate = Convert.ToDateTime(dreader[4]).ToLocalTime();
                    string createdBy = dreader[5].ToString();


                    DateTime lastUpdate = Convert.ToDateTime(dreader[6]).ToLocalTime();
                    string lastUpdateBy = dreader[7].ToString();

                    userList.Add(new User(userID, userName, password, active, createDate, createdBy, lastUpdate, lastUpdateBy));
                }
                con.Close();
            }
            return userList;
        }

        //pulls all appointments and puts them into a list
        public static List<appointment> pullAllApps15()
        {
            List<appointment> app15List = new List<appointment>();



            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                DateTime Current = Convert.ToDateTime(DateTime.UtcNow);
                DateTime CurrentPlus = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(15);
                String queryXL = "Select * from appointment'";
                MySqlCommand command = new MySqlCommand(queryXL, con);
                MySqlDataReader dreader = command.ExecuteReader();

                while (dreader.Read())
                {
                    int appointmentId = Convert.ToInt32(dreader[0]);
                    int customerID = Convert.ToInt32(dreader[1]);
                    int userID = Convert.ToInt32(dreader[2]);

                    string title = dreader[3].ToString();
                    string description = dreader[4].ToString();
                    string location = dreader[5].ToString();
                    string contact = dreader[6].ToString();
                    string type = dreader[7].ToString();
                    string url = dreader[8].ToString();
                    DateTime startTime = Convert.ToDateTime(dreader[9]).ToLocalTime();
                    DateTime endTime = Convert.ToDateTime(dreader[10]).ToLocalTime();


                    app15List.Add(new appointment(appointmentId, customerID, userID, title, description, location, contact, type, url, startTime, endTime));
                }
                con.Close();

            }
            return app15List;
        }

       


        //gets ID
        public static int getID(string table, string id)
        {

            using (MySqlConnection connect = new MySqlConnection(cnStr))
            {
                connect.Open();
                MySqlCommand comm = new MySqlCommand($"SELECT max({id}) FROM {table}", connect);
                MySqlDataReader rdr;
                rdr = comm.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();
                    if (rdr[0] == DBNull.Value)
                    {

                        return 0;
                    }
                    return Convert.ToInt32(rdr[0]);
                }
                return 0;
            }
        }

       


        public static DateTime dateTimeUTC()
        {
            return DateTime.Now.ToUniversalTime();
        }

        public static string dateTimeSQLFormat(DateTime date)
        {
            string formatSql = date.ToString("yyyy-MM-dd HH:mm");

            return formatSql;
        }

        //insert country
        public static int createCountry(string country)
        {

            int countryID = getID("country", "countryID") + 1;
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


            using (MySqlConnection connect = new MySqlConnection(cnStr))
            {
                connect.Open();



                MySqlCommand cmd = new MySqlCommand("INSERT into country (countryID, country, createDate, createdBy, lastUpdateBy) " +
                            $"VALUES ('{countryID}', '{country}', '{dateTime}','test', 'test')", connect);
                cmd.ExecuteNonQuery();
                connect.Close();

                return countryID;
            }
        }

        //Insert City 
        public static int createCity(int countryID, string city)
        {
            int cityID = getID("city", "cityId") + 1;
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            using (MySqlConnection connect = new MySqlConnection(cnStr))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT into city (cityId, city, countryId, createDate, createdBy, lastUpdateBy) " +
                            $"VALUES ('{cityID}', '{city}', '{countryID}', '{dateTime}','test', 'test')", connect);
                cmd.ExecuteNonQuery();
                connect.Close();

                return cityID;
            }
        }

        //Insert Address
        public static int createAddress(int cityID, string address, string address2, string postalCode, string phone)
        {

            int addressID = getID("address", "addressId") + 1;

            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            using (MySqlConnection connect = new MySqlConnection(cnStr))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT into address (addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy) " +
                            $"VALUES ('{addressID}', '{address}', '{address2}', '{cityID}', '{postalCode}', '{phone}', '{dateTime}','test', 'test')", connect);
                cmd.ExecuteNonQuery();
                connect.Close();

                return addressID;
            }
        }

        //Insert Customer
        public static void createCustomer(int id, string name, int addressId, int active, DateTime dateTime, string user)
        {

            string dateTime2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //MessageBox.Show(radioActiveYes.Checked + " " + active);

            using (MySqlConnection connect = new MySqlConnection(cnStr))
            {
                connect.Open();


                MySqlCommand cmd = new MySqlCommand("INSERT into customer (customerId, customerName, addressId,active, createDate, createdBy, lastUpdateBy) " +
                            $"VALUES ('{id}', '{name}',  '{addressId}', '{active}', '{dateTime2}', 'test', 'test')", connect);

                cmd.ExecuteNonQuery();
                connect.Close();
            }

        }

        //Updates customer
        public static void updateCustomer()
        {
            //
        }

        public static void createAppointment(int custID, int userId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end)
        {
            int appointID = getID("appointment", "appointmentId") + 1;

            string dateTime2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime utcTime = dateTimeUTC();

            MySqlConnection conn = new MySqlConnection(cnStr);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction(); 

            var query = "INSERT into appointment (appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{appointID}', '{custID}', '{userId}', '{title}', '{description}', '{location}', '{contact}',  '{type}', '{url}', '{dateTimeSQLFormat(start)}','{dateTimeSQLFormat(end)}','{dateTimeSQLFormat(utcTime)}','test','test')";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();

        }
    }

   

    











}
