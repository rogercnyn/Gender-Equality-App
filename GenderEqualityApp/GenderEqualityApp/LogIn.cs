using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GenderEqualityApp
{
    public partial class LogIn : Form
    {
        /*SqlConnection conn = new SqlConnection("Server = localhost\\SQLEXPRESS; Database=usersdatabase;Trusted_Connection=True;");
        SqlCommand cmd;
        public static string username;*/
        public LogIn()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

           /* conn.Open();
            cmd = new SqlCommand("SELECT * FROM usersdata WHERE userName = @paramUN and userPassword = @paramPW", conn);
            cmd.Parameters.AddWithValue("@paramUN", loginTBXUN.Text);
            cmd.Parameters.AddWithValue("@paramPW", loginTBXPW.Text);
            username = loginTBXUN.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {*/
                this.Hide();
                Dashboard dashboardform = new Dashboard();
                dashboardform.Show();
            /*}
            else
            {
                MessageBox.Show("Try again.");
            }
            dr.Close();
            conn.Close();*/
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegForm registrationform = new RegForm();
            registrationform.Show();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
