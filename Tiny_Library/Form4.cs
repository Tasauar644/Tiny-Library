using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Tiny_Library
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void EntryUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateBookName.Text == "" || UpdatePublishYear.Text == "" || New_Writer.Text == "" || EntryDate.Text == "" || OldQuantity.Text == "" || NewQuantity.Text == "")
            {
                MessageBox.Show("Please Fill up all the box.");
            }

            else
            {
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=librarybookstore");
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText= "UPDATE managerbookentry SET QuantityOfBook=@NewQuantity WHERE BookName=@BookName";
                cmd.Parameters.AddWithValue("@BookName", UpdateBookName.Text);
                //cmd.Parameters.AddWithValue("@BookPublishYear",UpdatePublishYear.Text);
               // cmd.Parameters.AddWithValue("@WriterName", New_Writer.Text);
               // cmd.Parameters.AddWithValue("@CatagoryName", UpdateCatagory.Text);
                int a = Convert.ToInt32(OldQuantity.Text);
                int b = Convert.ToInt32(NewQuantity.Text);
                cmd.Parameters.AddWithValue("@NewQuantity",a+b);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book Stock was updated");

            }

        }
       
        
     
    }
}
