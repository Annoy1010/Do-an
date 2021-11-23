
namespace GiaoDien
{
    partial class thongke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartSAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSAM)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSAM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSAM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSAM.Legends.Add(legend1);
            this.chartSAM.Location = new System.Drawing.Point(37, 88);
            this.chartSAM.Name = "chartSAM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Số sách bị mất do không trả";
            series1.Name = "BDTK";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartSAM.Series.Add(series1);
            this.chartSAM.Size = new System.Drawing.Size(573, 350);
            this.chartSAM.TabIndex = 0;
            this.chartSAM.Text = "chart1";
            title1.Name = "Thống kê số sách bị mất không trả";
            title1.Text = "Thống kê số sách bị mất không trả";
            this.chartSAM.Titles.Add(title1);
            // 
            // thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 481);
            this.Controls.Add(this.chartSAM);
            this.Name = "thongke";
            this.Text = "thongke";
            this.Load += new System.EventHandler(this.thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSAM;
    }
}