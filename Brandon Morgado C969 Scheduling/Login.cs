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
using System.Globalization;
using System.IO;

namespace Brandon_Morgado_C969_Scheduling
{


    public partial class Login : Form
    {
        public string user1 = Global.CurrUserName;
        public string errorMessage = "The username and password did not match. Please verify your credentials";

        public List<User> users;

       


        public Login()
        {
            InitializeComponent();
            users = Global.pullAllUsers();

            //CultureInfo fr = CultureInfo.CurrentCulture;

          

            if (CultureInfo.CurrentUICulture.LCID == 3084)
            {
                label2.Text = "Nom d'utilisateur";
                label3.Text = "Mot de passe";
                button1.Text = "Connecter";
                button2.Text = "Quitter";
                errorMessage = "Le nom d'utilisateur et le mot de passe ne correspondent pas. Veuillez vérifier vos identifiants";
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            string userName = textBox1.Text;
            string password = textBox2.Text;

            //Using Lambdas for readability & efficiency
            //The lambdas are being used to determine if the user name entered matches the username returned from the database that is sitting in the list.
            
            List<User> userX = users.Where(user => user.UserName == userName).ToList();

            


            if (userName != null)
            {
              
                if (userX.Count < 1 || userX[0].Password != password)
                {
                    if (CultureInfo.CurrentUICulture.LCID == 3084)
                    {
                        
                        MessageBox.Show("Le nom d'utilisateur et le mot de passe ne correspondent pas. Veuillez vérifier vos identifiants");
                    }
                    else
                    {
                        MessageBox.Show("The username & password combination doesn't exist");
                    }
                    
                }
                else
                {
                    LogFile();
                    this.Hide();
                    Form1 main = new Form1();
                    main.ShowDialog();
                }
            }
         
        }


        public void LogFile()
        {
            string line = textBox1.Text;
            string docuPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter (Path.Combine(docuPath, "Logfile.txt"), true))
            {

              
                outputFile.Write(line + "," + " " + DateTime.Now + Environment.NewLine);
                
            }
        }
    }
}
