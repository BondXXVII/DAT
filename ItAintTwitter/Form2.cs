using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ItAintTwitter
{
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademyPGH\Visual Studio Projects\ItAintTwitter\Database1.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
            showUsers();
        }

        public void showUsers()
        {
            SqlCommand ulist = new SqlCommand("SELECT [Username], [Id] FROM [Users]", connection);
            SqlDataAdapter reader = new SqlDataAdapter(ulist);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.test);
        }
    }
}
//private void button1_Click(object sender, EventArgs e)
//{
//    connection.Open();
//    SqlCommand ulist = new SqlCommand("SELECT * FROM [Users]", connection);
//    SqlDataReader reader = ulist.ExecuteReader();
//    while (reader.Read())
//    {
//        MessageBox.Show($"{reader["Id"]}: {reader["Usernames"]}");
//    }
//    reader.Close();
//    connection.Close();
//}

//private void button2_Click(object sender, EventArgs e)
//{
//    connection.Open();
//    SqlCommand ulist = new SqlCommand("SELECT [Usernames], [Id] FROM [Users]", connection);
//    SqlDataAdapter reader = new SqlDataAdapter(ulist);
//    DataTable dt = new DataTable();
//    reader.Fill(dt);
//    dataGridView1.DataSource = dt;
//    connection.Close();
//}
