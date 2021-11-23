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

        private void bunifuPanel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HeatMap_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap1 = new LiveCharts.WinForms.GeoMap();


            Dictionary<string, double> values = new Dictionary<string, double>();

            //NCR Values
            values["1852"] = 2668;
            values["7000"] = 2668;
            values["7001"] = 2668;
            values["7002"] = 2668;
            values["7003"] = 2668;
            values["7004"] = 2668;
            values["7006"] = 2668;
            values["7007"] = 2668;
            values["7008"] = 2668;
            values["7009"] = 2668;
            values["7010"] = 2668;
            values["7011"] = 2668;
            values["7012"] = 2668;
            values["7013"] = 2668;
            values["7014"] = 2668;
            values["7015"] = 2668;
            values["7016"] = 2668;
            values["7019"] = 2668;

            //CAR Values
            values["2656"] = 65;
            values["2658"] = 65;
            values["2663"] = 65;
            values["2664"] = 65;
            values["2671"] = 65;
            values["6455"] = 65;
            values["7021"] = 65;

            //Region 1 Values
            values["2659"] = 192;
            values["2660"] = 192;
            values["2670"] = 192;
            values["1847"] = 192;
            values["7022"] = 192;

            //Region 4 A Values
            values["2653"] = 65;

            geoMap1.HeatMap = values;
            geoMap1.Source = $"{Application.StartupPath}\\Philippines.xml";

            this.Controls.Add(geoMap1);
            geoMap1.Dock = DockStyle.Fill;

            geoMap1.EnableZoomingAndPanning = true;
        }
    }
}
