using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace табулирование
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] hor_w = new string[5];
            string[] ver_w = new string[5];
            string s = "";
            dataGridView1.Rows.Clear();
            for(int i = 0; i < 5; i++)
            {
                dataGridView1.Rows.Add((char)rnd.Next(68, 96), (char)rnd.Next(68, 96), (char)rnd.Next(68, 96), (char)rnd.Next(68, 96), (char)rnd.Next(68, 96));
            }
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    s += dataGridView1.Rows[i].Cells[j].Value;
                }
                hor_w[i] = s;
                s = "";
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    s += dataGridView1.Rows[j].Cells[i].Value;
                }
                ver_w[i] = s;
                s = "";
            }
            label1.Text = hor_w[0];
            label2.Text = hor_w[1];
            label3.Text = hor_w[2];
            label4.Text = hor_w[3];
            label5.Text = hor_w[4];
            label6.Text = ver_w[0];
            label7.Text = ver_w[1];
            label8.Text = ver_w[2];
            label9.Text = ver_w[3];
            label10.Text = ver_w[4];
        }
    }
}