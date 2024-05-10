namespace Simulation_Lab_11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ed1 = new System.Windows.Forms.NumericUpDown();
            this.ed2 = new System.Windows.Forms.NumericUpDown();
            this.edN = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbAv = new System.Windows.Forms.TextBox();
            this.tbVar = new System.Windows.Forms.TextBox();
            this.tbEAr = new System.Windows.Forms.TextBox();
            this.tbEVar = new System.Windows.Forms.TextBox();
            this.tbv = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mean";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(88, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sample size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(88, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Varience";
            // 
            // ed1
            // 
            this.ed1.DecimalPlaces = 2;
            this.ed1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ed1.Location = new System.Drawing.Point(236, 76);
            this.ed1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed1.Name = "ed1";
            this.ed1.Size = new System.Drawing.Size(103, 30);
            this.ed1.TabIndex = 3;
            this.ed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ed2
            // 
            this.ed2.DecimalPlaces = 2;
            this.ed2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ed2.Location = new System.Drawing.Point(236, 129);
            this.ed2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed2.Name = "ed2";
            this.ed2.Size = new System.Drawing.Size(103, 30);
            this.ed2.TabIndex = 4;
            this.ed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed2.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // edN
            // 
            this.edN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edN.Location = new System.Drawing.Point(237, 180);
            this.edN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.edN.Name = "edN";
            this.edN.Size = new System.Drawing.Size(103, 30);
            this.edN.TabIndex = 5;
            this.edN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edN.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(51, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(48, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Varience:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(253, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "error = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(255, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "error = ";
            // 
            // chart1
            // 
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(472, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series5.IsValueShownAsLabel = true;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(801, 378);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // tbAv
            // 
            this.tbAv.BackColor = System.Drawing.SystemColors.Menu;
            this.tbAv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAv.Location = new System.Drawing.Point(142, 366);
            this.tbAv.Name = "tbAv";
            this.tbAv.ReadOnly = true;
            this.tbAv.Size = new System.Drawing.Size(94, 23);
            this.tbAv.TabIndex = 11;
            // 
            // tbVar
            // 
            this.tbVar.BackColor = System.Drawing.SystemColors.Menu;
            this.tbVar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVar.Location = new System.Drawing.Point(142, 414);
            this.tbVar.Name = "tbVar";
            this.tbVar.ReadOnly = true;
            this.tbVar.Size = new System.Drawing.Size(94, 23);
            this.tbVar.TabIndex = 12;
            // 
            // tbEAr
            // 
            this.tbEAr.BackColor = System.Drawing.SystemColors.Menu;
            this.tbEAr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEAr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEAr.Location = new System.Drawing.Point(330, 366);
            this.tbEAr.Name = "tbEAr";
            this.tbEAr.ReadOnly = true;
            this.tbEAr.Size = new System.Drawing.Size(79, 23);
            this.tbEAr.TabIndex = 13;
            // 
            // tbEVar
            // 
            this.tbEVar.BackColor = System.Drawing.SystemColors.Menu;
            this.tbEVar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEVar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEVar.Location = new System.Drawing.Point(330, 412);
            this.tbEVar.Name = "tbEVar";
            this.tbEVar.ReadOnly = true;
            this.tbEVar.Size = new System.Drawing.Size(79, 23);
            this.tbEVar.TabIndex = 14;
            // 
            // tbv
            // 
            this.tbv.BackColor = System.Drawing.SystemColors.Menu;
            this.tbv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbv.Location = new System.Drawing.Point(472, 433);
            this.tbv.Multiline = true;
            this.tbv.Name = "tbv";
            this.tbv.ReadOnly = true;
            this.tbv.Size = new System.Drawing.Size(798, 40);
            this.tbv.TabIndex = 15;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(93, 259);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(247, 50);
            this.btStart.TabIndex = 16;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 513);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbv);
            this.Controls.Add(this.tbEVar);
            this.Controls.Add(this.tbEAr);
            this.Controls.Add(this.tbVar);
            this.Controls.Add(this.tbAv);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edN);
            this.Controls.Add(this.ed2);
            this.Controls.Add(this.ed1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ed1;
        private System.Windows.Forms.NumericUpDown ed2;
        private System.Windows.Forms.NumericUpDown edN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox tbAv;
        private System.Windows.Forms.TextBox tbVar;
        private System.Windows.Forms.TextBox tbEAr;
        private System.Windows.Forms.TextBox tbEVar;
        private System.Windows.Forms.TextBox tbv;
        private System.Windows.Forms.Button btStart;
    }
}

