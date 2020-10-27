using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ItAintTwitter
{
    public partial class Form3 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademyPGH\Visual Studio Projects\ItAintTwitter\Database1.mdf;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
            label1.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////connection.Open();
            SqlCommand create = new SqlCommand($"INSERT INTO Users VALUES ('"+ textBox1.Text +"', '"+ textBox2.Text +"', GETDATE())", connection);
            ////try
            ////{
            ////    create.ExecuteNonQuery();
            ////    label1.Text = "Yes";
            ////}
            ////catch
            ////{
            ////    label1.Text = "Nope";
            ////}
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = create.ExecuteReader();      //  this whole button code can be maaaaajorly refactored similarly to form6!!!!!!!!!!!!!....but I aint doin it -_-

                label1.Text = "Success.";
                while (reader.Read()) { }
                reader.Close();

            }
            catch //(Exception)
            {
                label1.Text = "Try again.";
            }
            connection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    connection.Open();
        //    SqlCommand create = new SqlCommand($"INSERT INTO Users VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', GETDATE())", connection);
        //    int i = create.ExecuteNonQuery();
        //    if (i != 0)
        //    {
        //        label1.Text = "Yuup";
        //    }
        //    else
        //    {
        //        label1.Text = "Nooope";
        //    }
        //    connection.Close();
        //}
    }
}
