﻿
namespace Лабораторная_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPredict = new System.Windows.Forms.Button();
            this.edRateE = new System.Windows.Forms.NumericUpDown();
            this.edRateD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRateE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRateD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btPredict);
            this.panel1.Controls.Add(this.edRateE);
            this.panel1.Controls.Add(this.edRateD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 129);
            this.panel1.TabIndex = 0;
            // 
            // btPredict
            // 
            this.btPredict.Location = new System.Drawing.Point(740, 25);
            this.btPredict.Name = "btPredict";
            this.btPredict.Size = new System.Drawing.Size(175, 67);
            this.btPredict.TabIndex = 4;
            this.btPredict.Text = "старт / стоп";
            this.btPredict.UseVisualStyleBackColor = true;
            this.btPredict.Click += new System.EventHandler(this.btPredict_Click);
            // 
            // edRateE
            // 
            this.edRateE.DecimalPlaces = 2;
            this.edRateE.Location = new System.Drawing.Point(467, 48);
            this.edRateE.Name = "edRateE";
            this.edRateE.Size = new System.Drawing.Size(120, 22);
            this.edRateE.TabIndex = 3;
            this.edRateE.Value = new decimal(new int[] {
            8613,
            0,
            0,
            131072});
            // 
            // edRateD
            // 
            this.edRateD.DecimalPlaces = 2;
            this.edRateD.Location = new System.Drawing.Point(154, 48);
            this.edRateD.Name = "edRateD";
            this.edRateD.Size = new System.Drawing.Size(120, 22);
            this.edRateD.TabIndex = 2;
            this.edRateD.Value = new decimal(new int[] {
            7575,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Курс евро:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Курс доллара:";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 60D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 129);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "C";
            series1.Legend = "Legend1";
            series1.Name = "Курс Доллара";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "C";
            series2.Legend = "Legend1";
            series2.Name = "Курс Евро";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1128, 469);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 598);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRateE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRateD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btPredict;
        private System.Windows.Forms.NumericUpDown edRateE;
        private System.Windows.Forms.NumericUpDown edRateD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

