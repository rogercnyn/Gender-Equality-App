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
using System.IO;

namespace GenderEqualityApp
{
    public partial class RegForm : Form
    {
        SqlConnection conn = new SqlConnection("Server = localhost\\SQLEXPRESS; Database=usersdatabase;Trusted_Connection=True;");
        SqlCommand cmd;
        string imgLoc;
        public static string reg_username;
        public RegForm()
        {
            InitializeComponent();
        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose a file";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                regPic.ImageLocation = imgLoc;
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            bool allFill = tbxUN.Text != string.Empty && tbxPW.Text != string.Empty && tbxFN.Text != string.Empty && tbxMN.Text != string.Empty && tbxLN.Text != string.Empty && tbxG.Text != string.Empty && tbxEA.Text != string.Empty && tbxBday.Text != string.Empty && imgLoc != string.Empty;
            if (allFill)
            {
                conn.Open();
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                var verifyCode = new Random().Next(1000, 9999);
                string emailVerify = "Hello, " + tbxFN.Text + ".\r\nPlease use this verification code to continue your account registration: " + verifyCode + ".\r\n\r\nFor your account's security, do not share this code with anyone.\r\n\r\nThank you.";
                cmd = new SqlCommand("INSERT INTO usersdata VALUES ('" + tbxUN.Text + "','" + tbxPW.Text + "','" + tbxFN.Text + "','" + tbxMN.Text + "','" + tbxLN.Text + "','" + tbxG.SelectedItem.ToString() + "','" + tbxEA.Text + "','" + tbxBday.Text + "', @images,'" + verifyCode + "')", conn);
                cmd.Parameters.Add(new SqlParameter("@images", img));
                cmd.ExecuteNonQuery();
                reg_username = tbxUN.Text;
                var mailhelp = new EmailRegister();
                mailhelp.Send(emailVerify, tbxEA.Text);
                MessageBox.Show("Registered Successfully!");
                tbxUN.Text = string.Empty;
                tbxPW.Text = string.Empty;
                tbxFN.Text = string.Empty;
                tbxMN.Text = string.Empty;
                tbxLN.Text = string.Empty;
                tbxG.Text = string.Empty;
                tbxEA.Text = string.Empty;
                tbxBday.Text = string.Empty;
                regPic.ImageLocation = null;
                
                conn.Close();
                this.Hide();
                Verification verify = new Verification();
                verify.Show();
           }

            if (!allFill)
            {
                MessageBox.Show("Fill up all of the text box.");
            }

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbxMN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
