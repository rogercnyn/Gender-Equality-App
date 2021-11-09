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
        SqlConnection conn = new SqlConnection("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog = gender_equality_users;Integrated Security = True;");
        SqlCommand cmd; 
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO RegistrationData VALUES ('" + tbxUN.Text + "', '" + tbxPW.Text + "', '" + tbxFN.Text + "', '" + tbxMN.Text + "', '" + tbxLN.Text + "', '" + tbxG.SelectedItem.ToString() + "','" + tbxEA.Text + "', '" + tbxCalendar.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully!");
                this.Hide();
                LogIn loginform = new LogIn();
                loginform.Show();
                conn.Close();
            }

            catch
            {
                MessageBox.Show("Fill up all of the text box.");
            }
}
    }
}
