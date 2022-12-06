using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tiny_Library
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void NewBookOk_Click(object sender, EventArgs e)
        {
            if(NewBooKText.Text=="" || Bookpublish.Text=="" || Writer.Text=="" || Quantity.Text==""|| Catagory.Text=="" || EntryDate.Text=="")
            {
                MessageBox.Show("Please fill up all the boxes.");
            }
            else
            {
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=librarybookstore");
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO managerbookentry (BookName,BookPublishYear,WriterName,QuantityOfBook,CatagoryName,EntryDate) VALUES(@BookName,@BookPublish,@WriterName,@Quantity,@Catagory,@EntryDate)";
                cmd.Parameters.AddWithValue("@BookName", NewBooKText.Text);
                cmd.Parameters.AddWithValue("@BookPublish", Bookpublish.Text);
                cmd.Parameters.AddWithValue("@WriterName", Writer.Text);
                cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                cmd.Parameters.AddWithValue("@Catagory", Catagory.Text);
                cmd.Parameters.AddWithValue("@EntryDate", EntryDate.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("The book Entry was Created");
                con.Close();

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
