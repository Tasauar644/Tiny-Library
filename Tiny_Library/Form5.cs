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
    public partial class Form5 : Form
    {
        public Form5()
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
            cmd.CommandText = "SELECT * FROM managerbookentry";

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;

        }

        private void SearchOK_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=librarybookstore");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT BookName,BookPublishYear,WriterName,CatagoryName,QuantityOfBook FROM managerbookentry WHERE BookName=@Giveninput2 OR BookPublishYear=@GivenInput2 OR WriterName=@GivenInput2 OR CataGoryName=@GivenInput2";
            cmd.Parameters.AddWithValue("@Giveninput2", textBox1.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }
    }
}
