using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace userReport
{
    public partial class UserControlDb : UserControl
    {
        public UserControlDb()
        {
            InitializeComponent();
        }

        public void AddUser(reportOfUser s)
        {
            label1.Text = s.username.ToString();
            label2.Text = s.experiences.ToString();


        }
    }
}
