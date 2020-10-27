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
    public partial class Form5 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademyPGH\Visual Studio Projects\ItAintTwitter\Database1.mdf;Integrated Security=True");

        public Form5()
        {
            InitializeComponent();
            showTweets();
        }
        public void showTweets()
        {
            SqlCommand tlist = new SqlCommand($"SELECT [UserId],[Username],[Tweets], [Date] FROM Users JOIN Posts ON Posts.UserID = Users.Id", connection);
            SqlDataAdapter reader = new SqlDataAdapter(tlist);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int sort = Convert.ToInt32('"+textBox1.Text+"');
            SqlCommand tlist = new SqlCommand($"SELECT [UserId],[Username],[Tweets],[Date] FROM Users JOIN Posts ON Posts.UserID ='" + textBox1.Text + "' and Users.Id='" + textBox1.Text + "'", connection);
            SqlDataAdapter reader = new SqlDataAdapter(tlist);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand tlist = new SqlCommand($"SELECT [UserId],[Username],[Tweets], [Date] FROM Users JOIN Posts ON Posts.UserID = Users.Id", connection);
            SqlDataAdapter reader = new SqlDataAdapter(tlist);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //System.Data.SqlClient.SqlException: 'Cannot call methods on nvarchar.'
    }
}
