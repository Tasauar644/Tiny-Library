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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void DeleteOk_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=librarybookstore");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM managerbookentry WHERE Bookname=@BookName";
            cmd.Parameters.AddWithValue("@BookName", textBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show(textBox1.Text + " was successfully deleted");
            con.Close();
        }

        private void CancelOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
