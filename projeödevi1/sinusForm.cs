using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace projeödevi1
{
 

    public partial class sinusForm : Form
    {
        private bool checkedsin;
        private double bas;
        private double bitis;
        private double y;
        public sinusForm(Boolean checkedsin, string bas, string bitis)
        {
            this.checkedsin = checkedsin;
            this.bas = Convert.ToDouble(bas);
            this.bitis = Convert.ToDouble(bitis);

            
            InitializeComponent();
            DrawSineWave();

        }

        private void sinusForm_Load(object sender, EventArgs e)
        {

        }

        private void DrawSineWave()
        {
   
            Chart chart1 = new Chart();
            chart1.Parent = this;
            chart1.Size = new System.Drawing.Size(500, 300);
            chart1.Location = new System.Drawing.Point(10, 10);

            // Grafik alanı oluştur
            ChartArea chartArea1 = new ChartArea();
            chart1.ChartAreas.Add(chartArea1);

            // Sinüs serisi oluştur
            Series series1 = new Series();
            series1.ChartType = SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.BorderWidth = 2;
            series1.LegendText = "Sin(x)";
            chart1.Series.Add(series1);


            // Sinüs değerlerini ekle
            for (double x = bas; x <= bitis; x += 10)
            {
                y = checkedsin ? Matematik.sincosHesapla(x * Math.PI / 180) : Matematik.sincosHesapla((90-x) * Math.PI / 180);


                series1.Points.AddXY(x, y);
            }

            // Grafik kontrollerini göster
            chart1.Dock = DockStyle.Fill;
            Controls.Add(chart1);
        }
    }
}
