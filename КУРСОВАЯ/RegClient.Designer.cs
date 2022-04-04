namespace КУРСОВАЯ
{
    partial class RegClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.nomk = new System.Windows.Forms.Label();
            this.nDesk = new System.Windows.Forms.Label();
            this.bPay = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bok = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.war = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.checkPay = new System.Windows.Forms.CheckBox();
            this.lday = new System.Windows.Forms.Label();
            this.pone = new System.Windows.Forms.Label();
            this.cjob = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ф.И.О :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Паспорт :";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(6, 128);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Серия";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.Gray;
            this.textBox3.Location = new System.Drawing.Point(55, 128);
            this.textBox3.MaxLength = 6;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Номер";
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 173);
            this.monthCalendar1.MaxSelectionCount = 15;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Период проживания:";
            // 
            // nomk
            // 
            this.nomk.AutoSize = true;
            this.nomk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomk.ForeColor = System.Drawing.Color.White;
            this.nomk.Location = new System.Drawing.Point(93, 47);
            this.nomk.Name = "nomk";
            this.nomk.Size = new System.Drawing.Size(15, 20);
            this.nomk.TabIndex = 12;
            this.nomk.Text = "-";
            // 
            // nDesk
            // 
            this.nDesk.AutoSize = true;
            this.nDesk.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nDesk.ForeColor = System.Drawing.Color.White;
            this.nDesk.Location = new System.Drawing.Point(3, 45);
            this.nDesk.Name = "nDesk";
            this.nDesk.Size = new System.Drawing.Size(94, 22);
            this.nDesk.TabIndex = 13;
            this.nDesk.Text = "Ваш номер:";
            // 
            // bPay
            // 
            this.bPay.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPay.Location = new System.Drawing.Point(7, 476);
            this.bPay.Name = "bPay";
            this.bPay.Size = new System.Drawing.Size(75, 23);
            this.bPay.TabIndex = 14;
            this.bPay.Text = "Оформить";
            this.bPay.UseVisualStyleBackColor = true;
            this.bPay.Visible = false;
            this.bPay.Click += new System.EventHandler(this.bPay_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 372);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(128, 20);
            this.textBox4.TabIndex = 15;
            // 
            // bok
            // 
            this.bok.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bok.Location = new System.Drawing.Point(6, 343);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(89, 23);
            this.bok.TabIndex = 16;
            this.bok.Text = "Выбрать дату";
            this.bok.UseVisualStyleBackColor = true;
            this.bok.Click += new System.EventHandler(this.bok_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(140, 372);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(67, 20);
            this.textBox5.TabIndex = 17;
            // 
            // war
            // 
            this.war.AutoSize = true;
            this.war.ForeColor = System.Drawing.Color.Red;
            this.war.Location = new System.Drawing.Point(88, 481);
            this.war.Name = "war";
            this.war.Size = new System.Drawing.Size(119, 13);
            this.war.TabIndex = 18;
            this.war.Text = "Форма не заполнена.";
            this.war.Visible = false;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(5, 423);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(16, 22);
            this.price.TabIndex = 19;
            this.price.Text = "-";
            // 
            // checkPay
            // 
            this.checkPay.AutoSize = true;
            this.checkPay.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPay.ForeColor = System.Drawing.Color.White;
            this.checkPay.Location = new System.Drawing.Point(9, 448);
            this.checkPay.Name = "checkPay";
            this.checkPay.Size = new System.Drawing.Size(83, 22);
            this.checkPay.TabIndex = 20;
            this.checkPay.Text = "Оплачено";
            this.checkPay.UseVisualStyleBackColor = true;
            this.checkPay.CheckedChanged += new System.EventHandler(this.checkPay_CheckedChanged);
            // 
            // lday
            // 
            this.lday.AutoSize = true;
            this.lday.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lday.ForeColor = System.Drawing.Color.White;
            this.lday.Location = new System.Drawing.Point(5, 395);
            this.lday.Name = "lday";
            this.lday.Size = new System.Drawing.Size(16, 22);
            this.lday.TabIndex = 21;
            this.lday.Text = "-";
            // 
            // pone
            // 
            this.pone.AutoSize = true;
            this.pone.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pone.ForeColor = System.Drawing.Color.White;
            this.pone.Location = new System.Drawing.Point(136, 395);
            this.pone.Name = "pone";
            this.pone.Size = new System.Drawing.Size(16, 22);
            this.pone.TabIndex = 22;
            this.pone.Text = "-";
            // 
            // cjob
            // 
            this.cjob.AutoSize = true;
            this.cjob.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic);
            this.cjob.ForeColor = System.Drawing.Color.White;
            this.cjob.Location = new System.Drawing.Point(111, 347);
            this.cjob.Name = "cjob";
            this.cjob.Size = new System.Drawing.Size(78, 19);
            this.cjob.TabIndex = 23;
            this.cjob.Text = "По работе";
            this.cjob.UseVisualStyleBackColor = true;
            // 
            // RegClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(286, 504);
            this.Controls.Add(this.cjob);
            this.Controls.Add(this.pone);
            this.Controls.Add(this.lday);
            this.Controls.Add(this.checkPay);
            this.Controls.Add(this.price);
            this.Controls.Add(this.war);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.bok);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.bPay);
            this.Controls.Add(this.nDesk);
            this.Controls.Add(this.nomk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegClient";
            this.Text = "Регистрация Клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegClient_FormClosing);
            this.Load += new System.EventHandler(this.RegClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label nomk;
        private System.Windows.Forms.Label nDesk;
        private System.Windows.Forms.Button bPay;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button bok;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label war;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.CheckBox checkPay;
        private System.Windows.Forms.Label lday;
        private System.Windows.Forms.Label pone;
        private System.Windows.Forms.CheckBox cjob;
    }
}