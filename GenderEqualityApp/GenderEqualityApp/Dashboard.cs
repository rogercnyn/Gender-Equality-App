using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenderEqualityApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Dashboard");
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Heat Map");
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Articles");
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Info");
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("About");
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Profile");
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Profile");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
