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
    public partial class RegClient : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clients.mdb;";

        private OleDbConnection myConnection;

        MainMenu mm1;
        public RegClient(MainMenu own)
        {
            mm1 = own;
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }
        private void RegClient_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Today;

        }

        private void bPay_Click(object sender, EventArgs e)
        {
            if ((textBox4.Text == "") || (textBox1.Text == ""))
                war.Visible = true;
            else
            {
                string dname = textBox1.Text;
                string dpass = textBox2.Text + " " + textBox3.Text;
                string ddate1 = textBox4.Text;
                string ddate2 = textBox5.Text;
                int dstat = 1;
                int dnom = Convert.ToInt16(nomk.Text);


                string query = "INSERT INTO Client (w_name, w_pass, w_date1, w_date2, w_nom, w_stat) VALUES ('" + dname + "', '" + dpass + "', '" + ddate1 + "', '" + ddate2 + "', '" + dnom + "', '" + dstat + "')";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                this.Hide(); 
            }

            if (cjob.Checked == true)
            {
                var helper = new WordHelper("forma.docx");

                var items = new Dictionary<string, string>
            {
                {"<NAME>", textBox1.Text },
                {"<NOM>", nomk.Text },
                {"<DATE1>", textBox5.Text },
                {"<DATE2>", textBox4.Text },
                {"<KOL>", p1 },
                {"<PRICE>", Convert.ToString(kop) },
                {"<ITOG>", Convert.ToString(p2) },
            };
                helper.Process(items);
            }

        }

        private void RegClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        int kop;
        string p1;
        int p2;
        private void bok_Click(object sender, EventArgs e)
        {
            textBox4.Text = monthCalendar1.SelectionRange.Start.ToShortDateString()+" - "+monthCalendar1.SelectionRange.End.ToShortDateString();
            textBox5.Text = monthCalendar1.TodayDate.ToShortDateString();

            DateTime data1 = monthCalendar1.SelectionRange.Start;
            DateTime data2 = monthCalendar1.SelectionRange.End;

           if ((nomk.Text == "202") || (nomk.Text == "204") || (nomk.Text == "205") || (nomk.Text == "206") || (nomk.Text == "207"))
                kop = 2000;
            else if ((nomk.Text == "201") || (nomk.Text == "203"))
                kop = 4200;
            else if ((nomk.Text == "208") || (nomk.Text == "209") || (nomk.Text == "301") || (nomk.Text == "302") || (nomk.Text == "303") || (nomk.Text == "304"))
                kop = 10000;
            else if ((nomk.Text == "305"))
                kop = 13000;
            else if ((nomk.Text == "401") || (nomk.Text == "402"))
                kop = 30000;
            else if ((nomk.Text == "500"))
                kop = 80000;

            p1 = Convert.ToString(data2.Subtract(data1).Days);


            if (Convert.ToInt16(p1) == 0)
            {
                p1 = "1";
                p2 = Convert.ToInt16(p1) * kop;
                price.Text = Convert.ToString(p2) + " " + "рублей";
            }
            else
            {
                p2 = Convert.ToInt16(p1) * kop;
                price.Text = Convert.ToString(p2) + " " + "рублей";
            }

            lday.Text = p1 + " " + "ночь/ночей";
            pone.Text = Convert.ToString(kop) + " " + "руб за ночь";

        }

        private void checkPay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPay.Checked == true)
                bPay.Visible = true;
            else
                bPay.Visible = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char numbe = e.KeyChar;
            if (!Char.IsDigit(numbe))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char numbe = e.KeyChar;
            if (!Char.IsDigit(numbe))
            {
                e.Handled = true;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = null;
            textBox3.ForeColor = Color.Black;
        }
    }
}
