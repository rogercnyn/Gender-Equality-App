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


            Dictionary<string, double> keyValues = new Dictionary<string, double>();

            //NCR Values
            keyValues["1852"] = 2668;
            keyValues["7000"] = 2668;
            keyValues["7001"] = 2668;
            keyValues["7002"] = 2668;
            keyValues["7003"] = 2668;
            keyValues["7004"] = 2668;
            keyValues["7006"] = 2668;
            keyValues["7007"] = 2668;
            keyValues["7008"] = 2668;
            keyValues["7009"] = 2668;
            keyValues["7010"] = 2668;
            keyValues["7011"] = 2668;
            keyValues["7012"] = 2668;
            keyValues["7013"] = 2668;
            keyValues["7014"] = 2668;
            keyValues["7015"] = 2668;
            keyValues["7016"] = 2668;
            keyValues["7019"] = 2668;

            //CAR Values
            keyValues["2656"] = 21;
            keyValues["2658"] = 21;
            keyValues["2663"] = 21;
            keyValues["2664"] = 21;
            keyValues["2671"] = 21;
            keyValues["6455"] = 21;
            keyValues["7021"] = 21;

            //Region 1 Values
            keyValues["2659"] = 192;
            keyValues["2660"] = 192;
            keyValues["2670"] = 192;
            keyValues["1847"] = 192;
            keyValues["7022"] = 192;

            //Region 2 Values
            keyValues["2674"] = 121;
            keyValues["2657"] = 121;
            keyValues["2662"] = 121;
            keyValues["6458"] = 121;
            keyValues["2665"] = 121;
            keyValues["2666"] = 121;
            keyValues["7020"] = 121;

            //Region 3 Values
            keyValues["2661"] = 294;
            keyValues["2667"] = 294;
            keyValues["2668"] = 294;
            keyValues["2669"] = 294;
            keyValues["2670"] = 294;
            keyValues["1849"] = 294;
            keyValues["7017"] = 294;
            keyValues["7018"] = 294;

            //Region 4 A Values
            keyValues["1848"] = 337;
            keyValues["1782"] = 337;
            keyValues["1850"] = 337;
            keyValues["1851"] = 337;
            keyValues["2653"] = 337;

            //Mimaropa Values
            keyValues["2604"] = 43;
            keyValues["2647"] = 43;
            keyValues["1781"] = 43;
            keyValues["1784"] = 43;
            keyValues["2651"] = 43;
            keyValues["6996"] = 43;

            //Region 5 Values
            keyValues["2650"] = 266;
            keyValues["2654"] = 266;
            keyValues["3606"] = 266;
            keyValues["2652"] = 266;
            keyValues["2649"] = 266;
            keyValues["2655"] = 266;
            keyValues["6999"] = 266;

            //Region 6 Values
            keyValues["2636"] = 485;
            keyValues["2641"] = 485;
            keyValues["2640"] = 485;
            keyValues["2642"] = 485;
            keyValues["2643"] = 485;
            keyValues["6986"] = 485;
            keyValues["2632"] = 485;
            keyValues["2632"] = 485;

            //Region 7 Values
            keyValues["2607"] = 1187;
            keyValues["2637"] = 1187;
            keyValues["6983"] = 1187;
            keyValues["2635"] = 1187;
            keyValues["2606"] = 1187;
            keyValues["6984"] = 1187;
            keyValues["6985"] = 1187;

            //Region 8 Values
            keyValues["2638"] = 138;
            keyValues["2631"] = 138;
            keyValues["2639"] = 138;
            keyValues["2633"] = 138;
            keyValues["2648"] = 138;
            keyValues["2630"] = 138;
            keyValues["6997"] = 138;
            keyValues["6998"] = 138;

            //Region 9 Values
            keyValues["2610"] = 267;
            keyValues["2603"] = 267;
            keyValues["2611"] = 267;

            //Region 10 Values
            keyValues["2622"] = 243;
            keyValues["2605"] = 243;
            keyValues["2625"] = 243;
            keyValues["6992"] = 243;
            keyValues["6991"] = 243;

            //Region 11 Values
            keyValues["2602"] = 125;
            keyValues["2597"] = 125;
            keyValues["2626"] = 125;
            keyValues["2623"] = 125;

            //Region 12 Values
            keyValues["6988"] = 125;
            keyValues["6990"] = 125;
            keyValues["2619"] = 125;
            keyValues["2627"] = 125;
            keyValues["2628"] = 125;

            //Region 13 Values
            keyValues["2620"] = 323;
            keyValues["2621"] = 323;
            keyValues["2609"] = 323;
            keyValues["2624"] = 323;
            keyValues["6995"] = 323;

            geoMap1.HeatMap = keyValues;
            geoMap1.Source = $"{Application.StartupPath}\\Philippines.xml";

            this.Controls.Add(geoMap1);
            geoMap1.Dock = DockStyle.Fill;

            geoMap1.EnableZoomingAndPanning = true;
            geoMap1.Hoverable = true;
 
        }
    }
}
