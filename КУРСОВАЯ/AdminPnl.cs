using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КУРСОВАЯ
{
    public partial class AdminPnl : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clients.mdb;";

        private OleDbConnection myConnection;

        public AdminPnl()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT w_id, w_name, w_pass, w_date1, day(w_date2),month(w_date2),year(w_date2), w_nom, w_stat FROM Client ORDER BY w_date2 ";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            listBox1.Items.Clear();
            while(reader.Read())
            {
                if (Convert.ToString(reader[8]) == "1")
                {
                    listBox1.Items.Add(reader[0].ToString() + " | " + reader[1].ToString() + " | " + reader[2].ToString() + " | " + reader[3].ToString() + " | " + reader[4].ToString() + "." + reader[5].ToString() + "." + reader[6].ToString() + " | " + reader[7].ToString());
                    listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------");
                }
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT w_id, w_name, w_pass, w_date1, day(w_date2),month(w_date2),year(w_date2), w_nom, w_stat FROM Client ORDER BY w_date2 ";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            listBox1.Items.Clear();
            while (reader.Read())
            {
                if (Convert.ToString(reader[8]) == "0")
                {
                    listBox1.Items.Add(reader[0].ToString() + " | " + reader[1].ToString() + " | " + reader[2].ToString() + " | " + reader[3].ToString() + " | " + reader[4].ToString() + "." + reader[5].ToString() + "." + reader[6].ToString() + " | " + reader[7].ToString());
                    listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------");
                }
            }
            reader.Close();
        }

        private void bsear1_Click(object sender, EventArgs e)
        {
            string query = "SELECT w_id, w_name, w_pass, w_date1, day(w_date2),month(w_date2),year(w_date2), w_nom, w_stat FROM Client ORDER BY w_date2 ";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            string s1 = textBox1.Text;
            listBox1.Items.Clear();
            while (reader.Read())
            {
                if (Convert.ToString(reader[8]) == "1" && Convert.ToString(reader[1]) == s1)
                {
                    listBox1.Items.Add(reader[0].ToString() + " | " + reader[1].ToString() + " | " + reader[2].ToString() + " | " + reader[3].ToString() + " | " + reader[4].ToString() + "." + reader[5].ToString() + "." + reader[6].ToString() + " | " + reader[7].ToString());
                    listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------");
                }
            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT w_id, w_name, w_pass, w_date1, day(w_date2),month(w_date2),year(w_date2), w_nom, w_stat FROM Client ORDER BY w_date2 ";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            string s2 = textBox2.Text;
            listBox1.Items.Clear();
            while (reader.Read())
            {
                if (Convert.ToString(reader[8]) == "0" && Convert.ToString(reader[1]) == s2)
                {
                    listBox1.Items.Add(reader[0].ToString() + " | " + reader[1].ToString() + " | " + reader[2].ToString() + " | " + reader[3].ToString() + " | " + reader[4].ToString() + "." + reader[5].ToString() + "." + reader[6].ToString() + " | " + reader[7].ToString());
                    listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------");
                }
            }
            reader.Close();
        }

        private void AdminPnl_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void AdminPnl_Load(object sender, EventArgs e)
        {
                
        }


    }
}
