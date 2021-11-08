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
    public partial class RegForm : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GenderEqualityApp.Properties.Settings.app_usersConnectionString"].ConnectionString);
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                SqlCommand register = new SqlCommand(@"INSERT INTO users VALUES ('" + tbxUN.Text + "', '" + tbxPW.Text + "', '" + tbxFN.Text + "', '" + tbxMN.Text + "', '" + tbxLN.Text + "', '" + tbxG.SelectedItem.ToString() + "','" + tbxEA.Text + "')", conn);
                conn.Open();
                register.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registered Successfully!");
                this.Hide();
                LogIn loginform = new LogIn();
                loginform.Show();
            }

            catch
            {
                MessageBox.Show("Fill up all of the text box.");
            }*/
                

        }
    }
}
