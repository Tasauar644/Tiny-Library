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
    public partial class Form1 : Form
    {
     
        string adminInput, AdminPass;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.UserName.Visible = true;
            this.Password.Visible = true;
            this.UserNameBox.Visible = true;
            this.PasswordBox.Visible = true;
            this.OK.Visible = true;
            this.Cancel.Visible = true;
         
            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            AdminChecker();
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {
            adminInput = UserNameBox.Text;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            AdminPass = PasswordBox.Text;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.UserName.Visible = false;
            this.Password.Visible = false;
            this.UserNameBox.Visible = false;
            this.PasswordBox.Visible = false;
            this.OK.Visible = false;
            this.Cancel.Visible = false;
            this.ManagerOk.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.UserName.Visible = true;
            this.Password.Visible = true;
            this.UserNameBox.Visible = true;
            this.PasswordBox.Visible = true;
            this.ManagerOk.Visible = true;
            this.Cancel.Visible = true;
        }

      

        private void ManagerOk_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=librarybookstore");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM login WHERE UserName='" + UserNameBox.Text + "'AND Password='" + PasswordBox.Text + "'", con);

            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Wrong UserName And Password");
            }
            else
            {
                Form7 f7 = new Form7();
                f7.Show();

            }

        }

        public void AdminChecker()
        {
            if ((adminInput == "admin") && (AdminPass == "admin"))
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Wrong input or password or both!!");
            }
        }
    }
}
