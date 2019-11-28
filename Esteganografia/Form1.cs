using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Math;
using Image = AForge.Imaging.Image;

namespace Esteganografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.Series.Clear();
                chart2.Series.Clear();
                chart3.Series.Clear();

                Bitmap image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;

                //ComplexImage complex = ComplexImage.FromBitmap(image);
                //complex.ForwardFourierTransform();

                ImageStatistics statistics = new ImageStatistics(image);
                var pxCount = statistics.PixelsCount;

                MessageBox.Show("Pixeles: " + pxCount + "\nB/N: " + (statistics.IsGrayscale ? "Yes" : "No"), "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification);
                if (statistics.IsGrayscale)
                {
                    Histogram histogram = statistics.Gray;
                    chart1.Series.Add("Histograma").Color = Color.Gray;

                    for (int i = 0; i < histogram.Values.Length; i++)
                    {
                        chart1.Series["Histograma"].Points.AddXY(i, histogram.Values[i]);
                    }
                }
                else
                {
                    Histogram histR = statistics.Red;
                    Histogram histG = statistics.Green;
                    Histogram histB = statistics.Blue;

                    chart1.Series.Add("Red").Color = Color.Red;
                    chart2.Series.Add("Green").Color = Color.Green;
                    chart3.Series.Add("Blue").Color = Color.Blue;
                    for (int i = 0; i < histR.Values.Length; i++)
                    {
                        chart1.Series["Red"].Points.AddXY(i, histR.Values[i]);
                        chart2.Series["Green"].Points.AddXY(i, histG.Values[i]);
                        chart3.Series["Blue"].Points.AddXY(i, histB.Values[i]);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();
        }
    }
}
