using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AForge.Imaging;
using AForge.Math;
using Image = System.Drawing.Image;

namespace Esteganografia.Views
{
    public partial class formDetails : Form
    {
        private Image _original;
        private Image _mod;
        private bool _isMod;

        public formDetails(Image original)
        {
            _original = original;
            _isMod = false;
            InitializeComponent();
        }

        public formDetails(Image original, Image mod)
        {
            _original = original;
            _mod = mod;
            _isMod = true;
            InitializeComponent();
        }

        private void formDetails_Load(object sender, EventArgs e)
        {
            splitCont.Panel2Collapsed = !_isMod;

            detallesImagen(_original,
                new List<Chart>() {chartOriginalR, chartOriginalG, chartOriginalB, chartOriginalAll});

            if (_isMod)
            {
                detallesImagen(_mod, new List<Chart>() {chartModR, chartModG, chartModB, chartModAll});
            }
        }

        private void detallesImagen(Image image, List<Chart> graficas)
        {
            Bitmap bitmap = new Bitmap(image);
            ImageStatistics statistics = new ImageStatistics(bitmap);

            Histogram histR = statistics.Red;
            Histogram histG = statistics.Green;
            Histogram histB = statistics.Blue;

            graficas.ForEach(x => x.Series.Clear());
            graficas[0].Series.Add("Red").Color = Color.Red;
            graficas[1].Series.Add("Green").Color = Color.Green;
            graficas[2].Series.Add("Blue").Color = Color.Blue;
            graficas[3].Series.Add("Red").Color = Color.Red;
            graficas[3].Series.Add("Green").Color = Color.Green;
            graficas[3].Series.Add("Blue").Color = Color.Blue;

            for (int i = 0; i < 3; i++)
            {
                graficas[3].Series[i].ChartType = SeriesChartType.Spline;
                graficas[3].Series[i].BorderWidth = 3;
            }

            for (int i = 0; i < 256; i++)
            {
                graficas[0].Series["Red"].Points.AddXY(i, histR.Values[i]);
                graficas[1].Series["Green"].Points.AddXY(i, histG.Values[i]);
                graficas[2].Series["Blue"].Points.AddXY(i, histB.Values[i]);
                graficas[3].Series["Red"].Points.AddXY(i, histR.Values[i]);
                graficas[3].Series["Green"].Points.AddXY(i, histG.Values[i]);
                graficas[3].Series["Blue"].Points.AddXY(i, histB.Values[i]);
            }

            //graficas[3].ChartAreas.Add("ChartAll");
            //for (int i = 0; i < 3; i++)
            //{
            //    graficas[3].Series.Add(graficas[i].Series[0]);
            //    graficas[3].Series[i].ChartArea = graficas[3].ChartAreas[1].Name;
            //    graficas[3].Series[i].ChartType = SeriesChartType.Spline;
            //    graficas[3].Series[i].BorderWidth = 3;
            //}
        }
    }
}
