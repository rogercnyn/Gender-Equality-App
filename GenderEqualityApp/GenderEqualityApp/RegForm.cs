using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GenderEqualityApp
{
    public partial class RegForm : Form
    {
        /*SqlConnection conn = new SqlConnection("Server = localhost\\SQLEXPRESS; Database=usersdatabase;Trusted_Connection=True;");
        SqlCommand cmd;*/
        public RegForm()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            /*bool allFill = tbxUN.Text != string.Empty && tbxPW.Text != string.Empty && tbxFN.Text != string.Empty && tbxMN.Text != string.Empty && tbxLN.Text != string.Empty && tbxG.Text != string.Empty && tbxEA.Text != string.Empty && tbxBday.Text != string.Empty;
            if  (allFill)
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO usersdata VALUES ('" + tbxUN.Text + "','" + tbxPW.Text + "','" + tbxFN.Text + "','" + tbxMN.Text + "','" + tbxLN.Text + "','" + tbxG.SelectedItem.ToString() + "','" + tbxEA.Text + "','" + tbxBday.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully!");
                tbxUN.Text = string.Empty;
                tbxPW.Text = string.Empty;
                tbxFN.Text = string.Empty;
                tbxMN.Text = string.Empty;
                tbxLN.Text = string.Empty;
                tbxG.Text = string.Empty;
                tbxEA.Text = string.Empty;
                tbxBday.Text = string.Empty;
                conn.Close();
                this.Hide();
                LogIn loginform = new LogIn();
                loginform.Show();
            }
                
                
            if (!allFill)
            {
                MessageBox.Show("Fill up all of the text box.");
            }*/

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
