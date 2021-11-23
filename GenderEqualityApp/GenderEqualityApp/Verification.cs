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
    public partial class Verification : Form
    {

        SqlConnection conn = new SqlConnection("Server = localhost\\SQLEXPRESS; Database=usersdatabase;Trusted_Connection=True;");
        SqlCommand cmd;
        public static string verifyCheck;
        public Verification()
        {
            InitializeComponent();
            
        }

        private void verifySUBMIT_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataReader myReader = null;
            cmd = new SqlCommand("SELECT * FROM usersdata WHERE userName = @paramUN", conn);
            cmd.Parameters.AddWithValue("@paramUN", RegForm.reg_username);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                verifyCheck = myReader["verifyCode"].ToString();
            }
            conn.Close();

            if (verifyCODE.Text == verifyCheck)
            {
                this.Hide();
                LogIn login = new LogIn();
                login.Show();
            }

            if (verifyCODE.Text != verifyCheck)
            {
                MessageBox.Show("Wrong code.");
            }
        }
    }
}
