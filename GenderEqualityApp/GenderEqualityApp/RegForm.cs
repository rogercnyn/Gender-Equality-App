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

        }
    }
}
