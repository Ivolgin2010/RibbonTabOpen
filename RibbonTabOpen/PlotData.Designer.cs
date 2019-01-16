namespace RibbonTabOpen
{
    partial class PlotData
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыРасчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаРасчетныхПараметровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьШаблонОтчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlPlot = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPlot = new System.Windows.Forms.Button();
            this.btnClosePlot = new System.Windows.Forms.Button();
            this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termogrammaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paraffinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomdebitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempwireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControlPlot.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.результатыРасчетаToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // результатыРасчетаToolStripMenuItem
            // 
            this.результатыРасчетаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаРасчетныхПараметровToolStripMenuItem,
            this.открытьШаблонОтчетаToolStripMenuItem,
            this.сохранитьГрафикToolStripMenuItem});
            this.результатыРасчетаToolStripMenuItem.Name = "результатыРасчетаToolStripMenuItem";
            this.результатыРасчетаToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.результатыРасчетаToolStripMenuItem.Text = "Результаты расчета";
            // 
            // таблицаРасчетныхПараметровToolStripMenuItem
            // 
            this.таблицаРасчетныхПараметровToolStripMenuItem.Name = "таблицаРасчетныхПараметровToolStripMenuItem";
            this.таблицаРасчетныхПараметровToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.таблицаРасчетныхПараметровToolStripMenuItem.Text = "Таблица расчетных параметров";
            this.таблицаРасчетныхПараметровToolStripMenuItem.Click += new System.EventHandler(this.ТаблицаРасчетныхПараметровToolStripMenuItem_Click);
            // 
            // открытьШаблонОтчетаToolStripMenuItem
            // 
            this.открытьШаблонОтчетаToolStripMenuItem.Name = "открытьШаблонОтчетаToolStripMenuItem";
            this.открытьШаблонОтчетаToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.открытьШаблонОтчетаToolStripMenuItem.Text = "Шаблон отчета";
            // 
            // сохранитьГрафикToolStripMenuItem
            // 
            this.сохранитьГрафикToolStripMenuItem.Name = "сохранитьГрафикToolStripMenuItem";
            this.сохранитьГрафикToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.сохранитьГрафикToolStripMenuItem.Text = "Сохранить график";
            this.сохранитьГрафикToolStripMenuItem.Click += new System.EventHandler(this.СохранитьГрафикToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.СправкаToolStripMenuItem_Click);
            // 
            // tabControlPlot
            // 
            this.tabControlPlot.Controls.Add(this.tabPage1);
            this.tabControlPlot.Controls.Add(this.tabPage2);
            this.tabControlPlot.Location = new System.Drawing.Point(12, 27);
            this.tabControlPlot.Name = "tabControlPlot";
            this.tabControlPlot.SelectedIndex = 0;
            this.tabControlPlot.Size = new System.Drawing.Size(931, 668);
            this.tabControlPlot.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.dataGridViewData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(923, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(589, 593);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Следующая >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depthDataGridViewTextBoxColumn,
            this.termogrammaDataGridViewTextBoxColumn,
            this.paraffinsDataGridViewTextBoxColumn,
            this.nomdebitDataGridViewTextBoxColumn,
            this.tempoilDataGridViewTextBoxColumn,
            this.tempwireDataGridViewTextBoxColumn});
            this.dataGridViewData.DataSource = this.dataBindingSource;
            this.dataGridViewData.Location = new System.Drawing.Point(36, 22);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(834, 544);
            this.dataGridViewData.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(923, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            this.chart1.BorderlineWidth = 2;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisX.Title = "Глубина скважины, м";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisX2.Title = "ghhfh";
            chartArea1.AxisY.MajorTickMark.Interval = 0D;
            chartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY.Title = "Температура, °С";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisY2.Title = "sfghfgj";
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.BackSecondaryColor = System.Drawing.Color.White;
            legend1.BorderColor = System.Drawing.Color.White;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "геотерма";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "парафины";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "ном. дебит";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "температура нефти";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "температура жилы";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(917, 636);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "График";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.DarkRed;
            title1.Name = "Title";
            title1.Text = "Распределение температуры по глубине скважины";
            this.chart1.Titles.Add(title1);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(78, 701);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(113, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить данные";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.Enabled = false;
            this.btnPlot.Location = new System.Drawing.Point(232, 701);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(110, 23);
            this.btnPlot.TabIndex = 4;
            this.btnPlot.Text = "Построить график";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.BtnPlot_Click);
            // 
            // btnClosePlot
            // 
            this.btnClosePlot.Location = new System.Drawing.Point(791, 701);
            this.btnClosePlot.Name = "btnClosePlot";
            this.btnClosePlot.Size = new System.Drawing.Size(75, 23);
            this.btnClosePlot.TabIndex = 5;
            this.btnClosePlot.Text = "Закрыть";
            this.btnClosePlot.UseVisualStyleBackColor = true;
            this.btnClosePlot.Click += new System.EventHandler(this.BtnClosePlot_Click);
            // 
            // depthDataGridViewTextBoxColumn
            // 
            this.depthDataGridViewTextBoxColumn.DataPropertyName = "Depth";
            this.depthDataGridViewTextBoxColumn.HeaderText = "Depth";
            this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            this.depthDataGridViewTextBoxColumn.ToolTipText = "глубина скважины";
            // 
            // termogrammaDataGridViewTextBoxColumn
            // 
            this.termogrammaDataGridViewTextBoxColumn.DataPropertyName = "Termogramma";
            this.termogrammaDataGridViewTextBoxColumn.HeaderText = "Termogramma";
            this.termogrammaDataGridViewTextBoxColumn.Name = "termogrammaDataGridViewTextBoxColumn";
            this.termogrammaDataGridViewTextBoxColumn.ToolTipText = "температура грунта";
            // 
            // paraffinsDataGridViewTextBoxColumn
            // 
            this.paraffinsDataGridViewTextBoxColumn.DataPropertyName = "Paraffins";
            this.paraffinsDataGridViewTextBoxColumn.HeaderText = "Paraffins";
            this.paraffinsDataGridViewTextBoxColumn.Name = "paraffinsDataGridViewTextBoxColumn";
            this.paraffinsDataGridViewTextBoxColumn.ToolTipText = "содежание парафинов";
            // 
            // nomdebitDataGridViewTextBoxColumn
            // 
            this.nomdebitDataGridViewTextBoxColumn.DataPropertyName = "Nom_debit";
            this.nomdebitDataGridViewTextBoxColumn.HeaderText = "Nom_debit";
            this.nomdebitDataGridViewTextBoxColumn.Name = "nomdebitDataGridViewTextBoxColumn";
            this.nomdebitDataGridViewTextBoxColumn.ToolTipText = "температура скважины без обогрева";
            // 
            // tempoilDataGridViewTextBoxColumn
            // 
            this.tempoilDataGridViewTextBoxColumn.DataPropertyName = "Temp_oil";
            this.tempoilDataGridViewTextBoxColumn.HeaderText = "Temp_oil";
            this.tempoilDataGridViewTextBoxColumn.Name = "tempoilDataGridViewTextBoxColumn";
            this.tempoilDataGridViewTextBoxColumn.ToolTipText = "температура скважины с обогревом";
            // 
            // tempwireDataGridViewTextBoxColumn
            // 
            this.tempwireDataGridViewTextBoxColumn.DataPropertyName = "Temp_wire";
            this.tempwireDataGridViewTextBoxColumn.HeaderText = "Temp_wire";
            this.tempwireDataGridViewTextBoxColumn.Name = "tempwireDataGridViewTextBoxColumn";
            this.tempwireDataGridViewTextBoxColumn.ToolTipText = "температура жилы нагревателя";
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = typeof(RibbonTabOpen.Data);
            // 
            // PlotData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 732);
            this.Controls.Add(this.btnClosePlot);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.tabControlPlot);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlotData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результирующий график";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlPlot.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыРасчетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаРасчетныхПараметровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьШаблонОтчетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlPlot;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termogrammaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paraffinsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomdebitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempwireDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClosePlot;
        private System.Windows.Forms.ToolStripMenuItem сохранитьГрафикToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}