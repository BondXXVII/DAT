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
    public partial class Form4 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademyPGH\Visual Studio Projects\ItAintTwitter\Database1.mdf;Integrated Security=True");
        public static int theyID = 0;
        public Form4()
        {
            InitializeComponent();
            label2.Text = " ";
            label6.Text = " ";
            showUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand signin = new SqlCommand("SELECT * FROM Users WHERE Username='"+textBox1.Text+ "' and Password='" + textBox2.Text + "' and Id='" + textBox3.Text + "'", connection);
            SqlDataReader check = signin.ExecuteReader();
            if (check.HasRows)
            {
                label2.Text = "Success";
                connection.Close();
                theyID = Convert.ToInt32(textBox3.Text);
            }
            else
            {
                label2.Text = "Nahhhh";
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "User ID #"+theyID;
        }

        public void showUsers()
        {
            SqlCommand ulist = new SqlCommand("SELECT [Id], [Username], [Password] FROM [Users]", connection);
            SqlDataAdapter reader = new SqlDataAdapter(ulist);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
