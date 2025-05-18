using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownParcacikSayisi.Value = 10;
            numericUpDownKararDegiskeni.Value = 2;
            numericUpDownMaksIterasyon.Value = 200;
            numericUpDownAltSinir.Value = -5;
            numericUpDownUstSinir.Value = 5;
            numericUpDownC1.Value = 2;
            numericUpDownC2.Value = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int particleCount = (int)numericUpDownParcacikSayisi.Value;
            int dimension = (int)numericUpDownKararDegiskeni.Value;
            int maxIter = (int)numericUpDownMaksIterasyon.Value;
            double lower = (double)numericUpDownAltSinir.Value;
            double upper = (double)numericUpDownUstSinir.Value;
            double c1 = (double)numericUpDownC1.Value;
            double c2 = (double)numericUpDownC2.Value;

            // PSO çalıştır
            PSOAlgorithm pso = new PSOAlgorithm(particleCount, dimension, maxIter, lower, upper, c1, c2);
            pso.Run();

            // Çıktılar
            textBoxBestSolution.Text = string.Join(" , ", pso.GetBestPosition().Select(x => x.ToString("F2")));
            textBoxBestFitness.Text = pso.GetBestFitness().ToString("F4");

            // Grafik çiz
            DrawConvergenceGraph(pso.bestFitnessPerIteration);

        }

        private void DrawConvergenceGraph(List<double> fitnessValues)
        {
            if (fitnessValues == null || fitnessValues.Count < 2)
                return;

            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            int margin = 40;
            Pen axisPen = new Pen(Color.Black, 1);
            Pen linePen = new Pen(Color.Blue, 2);

            // Ekseni çiz
            g.DrawLine(axisPen, margin, height - margin, width - margin, height - margin); // X ekseni
            g.DrawLine(axisPen, margin, height - margin, margin, margin); // Y ekseni

            // LOG ölçekli liste
            var logFitness = fitnessValues
                .Select(v => double.IsNaN(v) || v <= 0 ? -10 : Math.Log10(v + 1e-8))
                .ToList();

            double minVal = logFitness.Min();
            double maxVal = logFitness.Max();
            double range = maxVal - minVal;

            // Eğer sabit değer varsa görünmez → aralık yarat
            if (range < 1e-3)
            {
                minVal -= 1;
                maxVal += 1;
                range = maxVal - minVal;
            }

            for (int i = 1; i < logFitness.Count; i++)
            {
                float x1 = margin + (i - 1) * (width - 2 * margin) / (logFitness.Count - 1);
                float x2 = margin + i * (width - 2 * margin) / (logFitness.Count - 1);

                float y1 = (float)(height - margin - ((logFitness[i - 1] - minVal) / range) * (height - 2 * margin));
                float y2 = (float)(height - margin - ((logFitness[i] - minVal) / range) * (height - 2 * margin));

                if (!float.IsNaN(x1) && !float.IsInfinity(x1) &&
                    !float.IsNaN(y1) && !float.IsInfinity(y1) &&
                    !float.IsNaN(x2) && !float.IsInfinity(x2) &&
                    !float.IsNaN(y2) && !float.IsInfinity(y2))
                {
                    g.DrawLine(linePen, x1, y1, x2, y2);
                }
            }

            pictureBox1.Image = bmp;
        }

    }
}
