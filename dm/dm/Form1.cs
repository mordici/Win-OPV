using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
            string inr = System.IO.File.ReadAllText("lang.ini");
            string thr = System.IO.File.ReadAllText("theme.ini");
            switch (inr)
            {
                case "lang=be":
                    toolStripButton1.Text = "Пачаць";
                    toolStripButton2.Text = "Падлік";
                    toolStripButton3.Text = "Ачысьціць";
                    toolStripButton4.Text = "Закрыць";
                    toolStripButton5.Text = "Адзінкі";
                    label6.Text = "л/хв";
                    label1.Text = "Сэкунды";
                    label3.Text = "Дэбіт";
                    break;
                case "lang=bl":
                    toolStripButton1.Text = "Pačać";
                    toolStripButton2.Text = "Padlik";
                    toolStripButton3.Text = "Ačyścić";
                    toolStripButton4.Text = "Zakryć";
                    toolStripButton5.Text = "Aďinki";
                    label6.Text = "l/hv";
                    label5.Text = "s";
                    лминToolStripMenuItem.Text = "l/s";
                    label1.Text = "Sékundy";
                    label3.Text = "Débit";
                    break;
                case "lang=en":
                    toolStripButton1.Text = "Start";
                    toolStripButton2.Text = "Count";
                    toolStripButton3.Text = "Clear";
                    toolStripButton4.Text = "Close";
                    toolStripButton5.Text = "Units";
                    label6.Text = "l/s";
                    label5.Text = "s";
                    лминToolStripMenuItem.Text = "l/s";
                    label1.Text = "Seconds";
                    label3.Text = "Debit";
                    break;
                case "lang=uk":
                    toolStripButton1.Text = "Почати";
                    toolStripButton2.Text = "Личити";
                    toolStripButton3.Text = "Очистити";
                    toolStripButton4.Text = "Закрити";
                    toolStripButton5.Text = "Одиницi";
                    label6.Text = "л/с";
                    label5.Text = "с";
                    лминToolStripMenuItem.Text = "л/с";
                    label1.Text = "Секунди";
                    label3.Text = "Дебіт";
                    break;
            }
            if (thr == "theme=std")
            {
                toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            }
            else
            {
                toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            double d;
            timer1.Stop();
            d = 60 / (float)s;
            label4.Text = d.ToString();
            toolStripButton5.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            label2.Text = s.ToString();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            s = 0;
            timer1.Stop();
            timer1.Enabled = false;
            label2.Text = "0";
            label4.Text = "0";
        }

        private void лминToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a, b;
            a = System.Convert.ToDouble(label4.Text);
            b = a * 0.01666666666667;
            label4.Text = System.Convert.ToString(b);
            label6.Text = "л/с";
            label6.Location = new System.Drawing.Point(277, 154);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}