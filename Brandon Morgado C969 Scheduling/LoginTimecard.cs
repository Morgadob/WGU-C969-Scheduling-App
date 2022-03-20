using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity;



namespace Brandon_Morgado_C969_Scheduling
{
    public partial class LoginTimecard : Form
    {
        public LoginTimecard()
        {
            InitializeComponent();
           formatDGV(dataGridView1);
        }

        private void formatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            d.RowHeadersVisible = false;
            this.dataGridView1.ReadOnly = true;
            
        }

        private void LoginTimecard_Load(object sender, EventArgs e)
        {
            table.Columns.Add("User", typeof(string));
            table.Columns.Add("Time", typeof(string));

   
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        DataTable table = new DataTable();

        public void button2_Click(object sender, EventArgs e)
        {
            string docuPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string path = Path.Combine(docuPath, "Logfile.txt");

          
            
            //Lambda statement reduces the number of lines of code, is easier to read, and more efficient.
            //The lambda reads all the lines of the logfile and splits them at the comma into the two columns.
            var query3 = File.ReadAllLines(path).Select(x => x.Split(',')).ToList();
            

            List<string> listStrings = new List<string>();

            foreach (string[] s in query3)
            {
                table.Rows.Add(s);
            }

            

            dataGridView1.DataSource = table;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //
        }

      
    }
}
