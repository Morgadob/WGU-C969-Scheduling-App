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
    public partial class AppByMonthReport : Form
    {
        public AppByMonthReport()
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
            dataGridView1.AutoGenerateColumns = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        //October
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                String Query1 = "select count(*), type from appointment where start LIKE '2021-10%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-10%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(Query1, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }


        }

    
        //September
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                String QueryX = "select count(*), type from appointment where start LIKE '2021-09%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-09%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(QueryX, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }

        }

        //November
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                string QueryX = "select count(*), type from appointment where start LIKE '2021-11%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-11%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(QueryX, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }
        }

        //December
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                String Query2 = "select count(*), type from appointment where start LIKE '2021-12%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-12%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(Query2, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }
        }
        //August
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                String Query3 = "select count(*), type from appointment where start LIKE '2021-08%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-08%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(Query3, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }
        }

        //July
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                String Query4 = "select count(*), type from appointment where start LIKE '2021-07%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-07%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(Query4, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }
        }

        //June
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                String Query5 = "select count(*), type from appointment where start LIKE '2021-06%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-06%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(Query5, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }
        }

        //May
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                String Query6 = "select count(*), type from appointment where start LIKE '2021-05%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-05%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(Query6, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }
        }

        //April
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                String Query7 = "select count(*), type from appointment where start LIKE '2021-04%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-04%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(Query7, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }
        }

        //March
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                String Query8 = "select count(*), type from appointment where start LIKE '2021-03%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-03%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(Query8, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }
        }
        
        //February
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                String Query9 = "select count(*), type from appointment where start LIKE '2021-02%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-02%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(Query9, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }
        }

        //January
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Global.cnStr))
            {
                con.Open();
                String Query7 = "select count(*), type from appointment where start LIKE '2021-01%' AND type = 'scrum' group by type union select count(*), type from appointment where start like '2021-01%' AND type = 'presentation' group by type;";
                MySqlCommand command = new MySqlCommand(Query7, con);
                MySqlDataReader dreader = command.ExecuteReader();
                dt.Load(dreader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();

            }
        }
    }
}
