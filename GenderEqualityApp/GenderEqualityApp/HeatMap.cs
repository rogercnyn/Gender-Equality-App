using LiveCharts.Maps;
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
    public partial class HeatMap : Form
    {
        public HeatMap()
        {
            InitializeComponent();
        }

        private void HeatMap_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap1 = new LiveCharts.WinForms.GeoMap();

            Random r = new Random();

            Dictionary<string, double> values = new Dictionary<string, double>();

            values["4218"] = r.Next(0, 100);
            values["2636"] = r.Next(0, 100);
            values["2600"] = r.Next(0, 100);
            values["2610"] = r.Next(0, 100);
            values["2611"] = r.Next(0, 100);
            values["2612"] = r.Next(0, 100);
            values["6989"] = r.Next(0, 100);
            values["2607"] = r.Next(0, 100);
            values["2637"] = r.Next(0, 100);
            values["1848"] = r.Next(0, 100);
            values["7000"] = r.Next(0, 100);
            values["1852"] = r.Next(0, 100);
            values["7002"] = r.Next(0, 100);
            values["7001"] = r.Next(0, 100);
            values["7010"] = r.Next(0, 100);
            values["7015"] = r.Next(0, 100);

            geoMap1.HeatMap = values;
            geoMap1.Source = $"{Application.StartupPath}\\Philippines.xml";

            this.Controls.Add(geoMap1);
            geoMap1.EnableZoomingAndPanning = true;
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            


        }

        private void bunifuPanel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel5_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AppName_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click_1(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap1 = new LiveCharts.WinForms.GeoMap();

            Random r = new Random();

            Dictionary<string, double> values = new Dictionary<string, double>();

            values["4218"] = r.Next(0, 100);
            values["2636"] = r.Next(0, 100);
            values["2600"] = r.Next(0, 100);
            values["2610"] = r.Next(0, 100);
            values["2611"] = r.Next(0, 100);
            values["2612"] = r.Next(0, 100);
            values["6989"] = r.Next(0, 100);
            values["2607"] = r.Next(0, 100);
            values["2637"] = r.Next(0, 100);
            values["1848"] = r.Next(0, 100);
            values["7000"] = r.Next(0, 100);
            values["1852"] = r.Next(0, 100);
            values["7002"] = r.Next(0, 100);
            values["7001"] = r.Next(0, 100);
            values["7010"] = r.Next(0, 100);
            values["7015"] = r.Next(0, 100);

            geoMap1.HeatMap = values;
            geoMap1.Source = $"{Application.StartupPath}\\Philippines.xml";

            this.Controls.Add(geoMap1);
            geoMap1.Dock = DockStyle.Fill;
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
