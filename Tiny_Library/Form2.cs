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
    
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            DataGridView();   
        }

        public void DataGridView()
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=librarybookstore");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM login";

            MySqlDataReader reader=cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
           

        }
      

        private void AddManager_Click(object sender, EventArgs e)
        {
            if(NewManagerBox.Text== "" || NewPassBox.Text == "")
            {
                MessageBox.Show("Please enter Name and Password");
            }
            else
            {
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=librarybookstore");
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO login values(@newManager,@newPass)";
                cmd.Parameters.AddWithValue("@newManager", NewManagerBox.Text);
                cmd.Parameters.AddWithValue("@newPass", NewPassBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=librarybookstore");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM login WHERE UserName=@UserName";
            cmd.Parameters.AddWithValue("@Username",DeleteManagerText.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show(DeleteManagerText + " was successfully deleted");
            con.Close();
        }
    }
}
