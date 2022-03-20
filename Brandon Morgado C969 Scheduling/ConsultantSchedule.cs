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
    public partial class Form2 : Form
    {
        public Form2()
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
            this.Close();
            Form1 main = new Form1();
            main.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            string queryX = "select userName from user";
            using (MySqlConnection con1 = new MySqlConnection(Global.cnStr))
            {
                con1.Open();
                MySqlCommand cmd1 = new MySqlCommand(queryX, con1);
                MySqlDataAdapter msda1 = new MySqlDataAdapter(cmd1);
                msda1.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {
                    CustomerCombo.DataSource = dt1;
                    CustomerCombo.DisplayMember = "userName";
                }
                con1.Close();
            }
        }

        private void CustomerCombo_DropDownClosed(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            string comboSelect = CustomerCombo.GetItemText(CustomerCombo.SelectedItem);
            string query1 = "select userId from user where userName = '" + comboSelect + "';";
            using (MySqlConnection con2 = new MySqlConnection(Global.cnStr))
            {
                con2.Open();
                MySqlCommand cmd2 = new MySqlCommand(query1, con2);
                MySqlDataAdapter msda2 = new MySqlDataAdapter(cmd2);
                msda2.Fill(dt2);

                if (dt2.Rows.Count > 0)
                {
                    int report = (int)dt2.Rows[0][0];
                    Global.reportID = report;

                    //MessageBox.Show(appCustId + "");
                }
                con2.Close();
            }

            DataTable dt3 = new DataTable();
            string query2 = "select * from appointment where userId = '" + Global.reportID + "'";
            using (MySqlConnection con3 = new MySqlConnection(Global.cnStr))
            {
                con3.Open();
                MySqlCommand cmd3 = new MySqlCommand(query2, con3);
                MySqlDataAdapter msda2 = new MySqlDataAdapter(cmd3);
                msda2.Fill(dt3);

                if (dt3.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt3;
                }
                con3.Close();

            }


        }
    }
}
