using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ItAintTwitter
{
    public partial class Form6 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademyPGH\Visual Studio Projects\ItAintTwitter\Database1.mdf;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
            label2.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form4.theyID != 0)
            {
                string msg = richTextBox1.Text;
                connection.Open();
                SqlCommand tweet = new SqlCommand($"INSERT INTO Posts VALUES ('{msg}', GETDATE(), {Form4.theyID})", connection);
                tweet.ExecuteReader();
                label2.Text = "Tweet has been sent.";
                connection.Close();
            }
            else
            {
                label2.Text = "You must be signed in \n     to make a tweet.";
            }
        }

    }
}
