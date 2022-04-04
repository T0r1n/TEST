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
    public partial class Авторизация : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clients.mdb;";

        private OleDbConnection myConnection;

        public Авторизация()
        {
            InitializeComponent();
        }

        public string infi;
        private void button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            string query = "SELECT Log, Pass, Info FROM Login";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((tLogin.Text == Convert.ToString(reader[0])) && (tPass.Text == Convert.ToString(reader[1])))
                {
                    infi = Convert.ToString(reader[2]);
                    w1.Visible = false; w2.Visible = false;
                    this.Hide();
                    MainMenu MMenu = new MainMenu(this);
                    MMenu.Show(this);
                }
                else
                    w1.Visible = true; w2.Visible = true;

            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lPoint1;
        private void pmove2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lPoint1.X;
                this.Top += e.Y - lPoint1.Y;
            }
        }
        private void pmove2_MouseDown(object sender, MouseEventArgs e)
        {
            lPoint1 = new Point(e.X, e.Y);
        }
    }
}
