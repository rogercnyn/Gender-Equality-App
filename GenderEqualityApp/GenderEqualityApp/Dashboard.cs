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
            bunifuPages1.SetPage("Tips");
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

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuLabel51_Click(object sender, EventArgs e)
        {
            Campaign Form = new Campaign();
            Form.Show();
        }

        private void bunifuLabel56_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          
        }

        private void bunifuLabel51_Click_1(object sender, EventArgs e)
        {

        }
    }
}
