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
    public partial class MainMenu : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clients.mdb;";

        private OleDbConnection myConnection;

        public int k;
        Авторизация aut;
        public MainMenu(Авторизация owner)
        {
            aut = owner;
            InitializeComponent();

        }

        public void LoadButton()
        {
            bReg.Visible = true;
            brest.Visible = true;
            pmove1.Visible = true;
            this.Width = 691;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbFloor2.Visible = true;
            gbFloorVIP.Visible = false;
            gbFloor3.Visible = false;
            gbFloorVIPP.Visible = false;
            LoadButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbFloor2.Visible = false;
            gbFloorVIP.Visible = false;
            gbFloorVIPP.Visible = false;
            gbFloor3.Visible = true;
            LoadButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbFloor2.Visible = false;
            gbFloor3.Visible = false;
            gbFloorVIPP.Visible = false;
            gbFloorVIP.Visible = true;
            LoadButton();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            gbFloor2.Visible = false;
            gbFloor3.Visible = false;
            gbFloorVIP.Visible = false;
            gbFloorVIPP.Visible = true;
            LoadButton();
        }
        private void panel12_Click(object sender, EventArgs e)
        {
            gpDesc.Visible = false;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            gpDesc2.Visible = false;
        }

        private void p201_Click(object sender, EventArgs e)
        {
            gpDesc.Text = "201"; gpDesc.Visible = true;k = 201;
            Desc.Text = "🔹2 кровати\n" + "🔹Обед\n" + "🔹Посещение бассейна";
        }

        private void p202_Click(object sender, EventArgs e)
        {
            gpDesc.Text = "202"; gpDesc.Visible = true; k = 202;
            Desc.Text = "🔹2 кровати\n" + "🔹Обед\n" + "🔹Посещение бассейна";
        }

        private void p203_Click(object sender, EventArgs e)
        {
            gpDesc.Text = "203"; gpDesc.Visible = true; k = 203;
            Desc.Text = "🔹2 кровати\n" + "🔹Обед\n" + "🔹Посещение бассейна";
        }

        private void p204_Click(object sender, EventArgs e)
        {
            gpDesc.Text = "204"; gpDesc.Visible = true; k = 204;
            Desc.Text = "🔹2 кровати\n" + "🔹Обед\n" + "🔹Посещение бассейна";
        }

        private void p205_Click(object sender, EventArgs e)
        {
            gpDesc.Text = "205"; gpDesc.Visible = true; k = 205;
            Desc.Text = "🔹2 кровати\n" + "🔹Обед\n" + "🔹Посещение бассейна";
        }

        private void p206_Click(object sender, EventArgs e)
        {
            gpDesc.Text = "206"; gpDesc.Visible = true; k = 206;
            Desc.Text = "🔹2 кровати\n" + "🔹Обед\n" + "🔹Посещение бассейна";
        }

        private void p207_Click(object sender, EventArgs e)
        {
            gpDesc.Text = "207"; gpDesc.Visible = true; k = 207;
            Desc.Text = "🔹2 кровати\n" + "🔹Обед\n" + "🔹Посещение бассейна";
        }

        private void p208_Click(object sender, EventArgs e)
        {
            gpDesc.Text = "208"; gpDesc.Visible = true; k = 208;
            Desc.Text = "🔹2 Спальни\n" + "🔹Обед\n" + "🔹Посещение бассейна\n" + "🔹Бар";
        }

        private void p209_Click(object sender, EventArgs e)
        {
            gpDesc.Text = "209"; gpDesc.Visible = true; k = 209;
            Desc.Text = "🔹2 Спальни\n" + "🔹Обед\n" + "🔹Посещение бассейна\n" + "🔹Бар";
        }

        private void p301_Click(object sender, EventArgs e)
        {
            gpDesc2.Text = "301"; gpDesc2.Visible = true; k = 301;
            Desc2.Text = "🔹2 Спальни\n" + "🔹Обед\n" + "🔹Посещение бассейна\n" + "🔹Бар";
        }

        private void p302_Click(object sender, EventArgs e)
        {
            gpDesc2.Text = "302"; gpDesc2.Visible = true; k = 302;
            Desc2.Text = "🔹2 Спальни\n" + "🔹Обед\n" + "🔹Посещение бассейна\n" + "🔹Бар";
        }

        private void p303_Click(object sender, EventArgs e)
        {
            gpDesc2.Text = "303"; gpDesc2.Visible = true; k = 303;
            Desc2.Text = "🔹2 Спальни\n" + "🔹Обед\n" + "🔹Посещение бассейна\n" + "🔹Бар";
        }

        private void p304_Click(object sender, EventArgs e)
        {
            gpDesc2.Text = "304"; gpDesc2.Visible = true; k = 304;
            Desc2.Text = "🔹2 Спальни\n" + "🔹Обед\n" + "🔹Посещение бассейна\n" + "🔹Бар";
        }

        private void p305_Click(object sender, EventArgs e)
        {
            gpDesc2.Text = "305"; gpDesc2.Visible = true; k = 305;
            Desc2.Text = "🔹2 Спальни\n" + "🔹Обед\n" + "🔹Посещение бассейна\n" + "🔹Бар\n" + "🔹2 Ванные комнаты\n" + "🔹Домашний кинотеатр";
        }

        private void pVIP1_Click(object sender, EventArgs e)
        {
            gpDescV.Text = "VIP_1"; gpDescV.Visible = true; k = 401;
            DescV.Text = "🔹3 Спальни\n" + "🔹Обед\n" + "🔹Посещение бассейна\n" + "🔹Бар\n" + "🔹2 Ванные комнаты\n" + "🔹Домашний кинотеатр\n" + "🔹Красивый вид";
        }

        private void pVIP2_Click(object sender, EventArgs e)
        {
            gpDescV.Text = "VIP_2"; gpDescV.Visible = true; k = 402;
            DescV.Text = "🔹3 Спальни\n" + "🔹Обед\n" + "🔹Посещение бассейна\n" + "🔹Бар\n" + "🔹2 Ванные комнаты\n" + "🔹Домашний кинотеатр\n" + "🔹Красивый вид";
        }

        private void pVIP_Click(object sender, EventArgs e)
        {
            gpDescVP.Text = "VIP+"; gpDescVP.Visible = true; k = 500;
            DescVV.Text = "🔹5 Спальни\n" + "🔹Обед\n" + "🔹Личный бассейна\n" + "🔹Бар\n" + "🔹2 Ванные комнаты\n" + "🔹2 Домашних кинотеатра\n" + "🔹Красивый вид";
        }

        public void LoadForm()
        {

            label1.Text = aut.infi;

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            string query = "SELECT w_nom, w_stat FROM Client ";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                if (Convert.ToString(reader[0]) == "201" && Convert.ToInt32(reader[1]) == 1)
                    p201.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "202" && Convert.ToInt32(reader[1]) == 1)
                    p202.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "203" && Convert.ToInt32(reader[1]) == 1)
                    p203.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "204" && Convert.ToInt32(reader[1]) == 1)
                    p204.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "205" && Convert.ToInt32(reader[1]) == 1)
                    p205.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "206" && Convert.ToInt32(reader[1]) == 1)
                    p206.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "207" && Convert.ToInt32(reader[1]) == 1)
                    p207.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "208" && Convert.ToInt32(reader[1]) == 1)
                    p208.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "209" && Convert.ToInt32(reader[1]) == 1)
                    p209.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "301" && Convert.ToInt32(reader[1]) == 1)
                    p301.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "302" && Convert.ToInt32(reader[1]) == 1)
                    p302.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "303" && Convert.ToInt32(reader[1]) == 1)
                    p303.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "304" && Convert.ToInt32(reader[1]) == 1)
                    p304.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "305" && Convert.ToInt32(reader[1]) == 1)
                    p305.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "401" && Convert.ToInt32(reader[1]) == 1)
                    pVIP1.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "402" && Convert.ToInt32(reader[1]) == 1)
                    pVIP2.BackColor = Color.Salmon;
                else if (Convert.ToString(reader[0]) == "500" && Convert.ToInt32(reader[1]) == 1)
                    pVIP.BackColor = Color.Salmon;
            }
            reader.Close();
        }


        private void bTEST_Click(object sender, EventArgs e)
        {
            RegClient RClient = new RegClient(this);///
            if (k == 0)
                push.Visible = true;
            else if ((k == 201) && (p201.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 202) && (p202.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 203) && (p203.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 204) && (p204.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 205) && (p205.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 206) && (p206.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 207) && (p207.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 208) && (p208.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 209) && (p209.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 301) && (p301.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 302) && (p302.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 303) && (p303.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 304) && (p304.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 305) && (p305.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 401) && (pVIP1.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 402) && (pVIP2.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else if ((k == 500) && (pVIP.BackColor == Color.Salmon))
                MessageBox.Show("Данный номер уже занят", "Внимание");
            else
            {
                push.Visible = false;
                RClient.Show(this); ///
                RClient.nomk.Text = Convert.ToString(k);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация Auto = new Авторизация();
            Auto.Show(); 

        }

        private void bAdm_Click(object sender, EventArgs e)
        {
            AdminPnl APnl = new AdminPnl();
            APnl.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

            this.Width = 166;
            this.Height = 326;

         myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            string query = "SELECT w_nom, w_stat FROM Client ";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                LoadForm();
            }
            reader.Close();


        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void pVIP_DoubleClick(object sender, EventArgs e)
        {
            pVIP.BackColor = Color.SpringGreen;

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = "+k;
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void p201_DoubleClick(object sender, EventArgs e)
        {
            p201.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p202_DoubleClick(object sender, EventArgs e)
        {
            p202.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p203_DoubleClick(object sender, EventArgs e)
        {
            p203.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p204_DoubleClick(object sender, EventArgs e)
        {
            p204.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p205_DoubleClick(object sender, EventArgs e)
        {
            p205.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p206_DoubleClick(object sender, EventArgs e)
        {
            p206.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p207_DoubleClick(object sender, EventArgs e)
        {
            p207.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p208_DoubleClick(object sender, EventArgs e)
        {
            p208.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p209_DoubleClick(object sender, EventArgs e)
        {
            p209.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p301_DoubleClick(object sender, EventArgs e)
        {
            p301.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p302_DoubleClick(object sender, EventArgs e)
        {
            p302.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p303_DoubleClick(object sender, EventArgs e)
        {
            p303.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p304_DoubleClick(object sender, EventArgs e)
        {
            p304.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void p305_DoubleClick(object sender, EventArgs e)
        {
            p305.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void pVIP1_DoubleClick(object sender, EventArgs e)
        {
            pVIP1.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        private void pVIP2_DoubleClick(object sender, EventArgs e)
        {
            pVIP2.BackColor = Color.SpringGreen;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "UPDATE Client SET w_stat = 0 WHERE w_nom = " + k;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }


        Point lPoint;
        private void pmove1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lPoint.X;
                this.Top += e.Y - lPoint.Y;
            }
        }
        private void pmove1_MouseDown(object sender, MouseEventArgs e)
        {
            lPoint = new Point(e.X, e.Y);
        }

        private void binfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение разработал студент \n" +"группы МОАИС-20\n" +"Смородин В.Р", "О приложении");
        }

        private void brest_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lPoint.X;
                this.Top += e.Y - lPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lPoint = new Point(e.X, e.Y);
        }
    }
}
