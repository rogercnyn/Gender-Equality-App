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
using userReport;
using System.Data.SqlClient;

namespace GenderEqualityApp
{
    public partial class Dashboard : Form
    {
        List<reportOfUser> m_report = new List<reportOfUser>();
        public Dashboard()
        {
            InitializeComponent();
           
            AddUser(m_report);
        }

        /*
        void InitDb()
        {

            reportOfUser n = new reportOfUser
            {

                username = "Alpha",
                experiences = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",

            };
            m_report.Add(n);

        }*/
        
         void AddUser(List<reportOfUser> list)
        {
            int y = 0;
            int i = 0;
            foreach (reportOfUser s in list)
            {

                UserControlDb u = new UserControlDb();
                u.Location = new System.Drawing.Point(3, 3);
                u.Name = "user_Report1";
                u.Size = new System.Drawing.Size(571, 304);
                u.TabIndex = i++;
                u.AddUser(s);
                flowLayoutPanel4.Controls.Add(u);
                y += u.Height;
            }
            flowLayoutPanel4.Height = y;
            // this.Height = y + 80;
        }
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Home");
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Heat Map");
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Report");
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          
        }

        private void lblCamp_Click(object sender, EventArgs e)
        {
            Campaign Form = new Campaign();
            Form.Show();
        }

        private void bunifuShadowPanel18_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void entrySUBMIT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server = LAPTOP-JCHQ9QRE; Database= userReportsTest;Trusted_Connection=True;");


            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO freedomWall (Username, Experiences) VALUES(@Username, @Experiences);", con);

            cmd.Parameters.AddWithValue("Username", reportUN.Text);
            cmd.Parameters.AddWithValue("Experiences",bunifuTextBox1.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            reportOfUser n1 = new reportOfUser
            {
                username = reportUN.Text,
                experiences = bunifuTextBox1.Text,


            };
            m_report.Add(n1);

            AddUser(m_report);
        }
    }
}
