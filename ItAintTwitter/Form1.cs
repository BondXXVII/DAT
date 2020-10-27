using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItAintTwitter
{
    public partial class Form1 : Form
    {
        public static string test;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;

            Form3 fm3 = new Form3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(fm3);
            fm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            Form2 fm2 = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(fm2);
            fm2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;

            Form4 fm4 = new Form4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(fm4);
            fm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;

            Form5 fm5 = new Form5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(fm5);
            fm5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;

            Form6 fm6 = new Form6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(fm6);
            fm6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4.theyID = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "This button don't do NOOOTHIN.. get over it.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
         
        }
    }
}
