﻿namespace Lab8_3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.prob1Num = new System.Windows.Forms.NumericUpDown();
            this.prob2Num = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.prob3Num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.prob4Num = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.prob5Num = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nNum = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prob1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob5Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вероятность 1";
            // 
            // prob1Num
            // 
            this.prob1Num.DecimalPlaces = 2;
            this.prob1Num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob1Num.Location = new System.Drawing.Point(99, 7);
            this.prob1Num.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prob1Num.Name = "prob1Num";
            this.prob1Num.Size = new System.Drawing.Size(71, 20);
            this.prob1Num.TabIndex = 1;
            this.prob1Num.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // prob2Num
            // 
            this.prob2Num.DecimalPlaces = 2;
            this.prob2Num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob2Num.Location = new System.Drawing.Point(99, 37);
            this.prob2Num.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prob2Num.Name = "prob2Num";
            this.prob2Num.Size = new System.Drawing.Size(71, 20);
            this.prob2Num.TabIndex = 3;
            this.prob2Num.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вероятность 2";
            // 
            // prob3Num
            // 
            this.prob3Num.DecimalPlaces = 2;
            this.prob3Num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob3Num.Location = new System.Drawing.Point(99, 68);
            this.prob3Num.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prob3Num.Name = "prob3Num";
            this.prob3Num.Size = new System.Drawing.Size(71, 20);
            this.prob3Num.TabIndex = 5;
            this.prob3Num.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вероятность 3";
            // 
            // prob4Num
            // 
            this.prob4Num.DecimalPlaces = 2;
            this.prob4Num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob4Num.Location = new System.Drawing.Point(99, 97);
            this.prob4Num.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prob4Num.Name = "prob4Num";
            this.prob4Num.Size = new System.Drawing.Size(71, 20);
            this.prob4Num.TabIndex = 7;
            this.prob4Num.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вероятность 4";
            // 
            // prob5Num
            // 
            this.prob5Num.DecimalPlaces = 2;
            this.prob5Num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob5Num.Location = new System.Drawing.Point(99, 126);
            this.prob5Num.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prob5Num.Name = "prob5Num";
            this.prob5Num.Size = new System.Drawing.Size(71, 20);
            this.prob5Num.TabIndex = 9;
            this.prob5Num.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вероятность 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Количество испытаний";
            // 
            // nNum
            // 
            this.nNum.Location = new System.Drawing.Point(142, 157);
            this.nNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNum.Name = "nNum";
            this.nNum.Size = new System.Drawing.Size(91, 20);
            this.nNum.TabIndex = 11;
            this.nNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 264);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(103, 43);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(250, 7);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(538, 300);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.Location = new System.Drawing.Point(11, 196);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(192, 40);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.Text = "Сумма вероятностей \r\nдолжна быть 1!";
            this.errorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prob5Num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prob4Num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prob3Num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prob2Num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prob1Num);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.prob1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob5Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown prob1Num;
        private System.Windows.Forms.NumericUpDown prob2Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown prob3Num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown prob4Num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown prob5Num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nNum;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label errorLabel;
    }
}

