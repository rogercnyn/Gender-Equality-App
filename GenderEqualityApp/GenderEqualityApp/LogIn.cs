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
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GenderEqualityApp.Properties.Settings.app_usersConnectionString"].ConnectionString);
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username = @paramUN and userpassword = @paramPW", conn);
            cmd.Parameters.AddWithValue("@paramUN", loginTBXUN.Text);
            cmd.Parameters.AddWithValue("@paramPW", loginTBXPW.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Dashboard dashboardform = new Dashboard();
                dashboardform.Show();
            }
            else
            {
                MessageBox.Show("Try again.");
            }
            dr.Close();
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegForm registrationform = new RegForm();
            registrationform.Show();
        }
    }
}
