using CsvHelper;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RibbonTabOpen
{
    public partial class PlotData : Form
    {
        public PlotData()
        {
            InitializeComponent();
        }        

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ТаблицаРасчетныхПараметровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Show();
        }

        /// <summary>
        /// Строим графики
        /// </summary>        
        private void BtnPlot_Click(object sender, EventArgs e)
        {            
            // Set chart data source
            chart1.DataSource = dataGridViewData.DataSource;
            chart1.Series[0].Points.Clear();

            //---------------- программная настройка свойств графика -----------------------//

            // задаем интервал по главным осям           
            chart1.ChartAreas[0].AxisX.Interval = 500;            
            chart1.ChartAreas[0].AxisY.Interval = 10;

            // задаем интервал по доп. осям            
            chart1.ChartAreas[0].AxisX.MajorTickMark.Interval = 100;
            chart1.ChartAreas[0].AxisY.MajorTickMark.Interval = 2;

            //chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 30);            

            //-----------------------------------------------------------------------------//

            // Set series members names for the X and Y values
            chart1.Series["геотерма"].XValueMember = "Depth";                //строим глубина скважины с шагом 1 м;
            chart1.Series["геотерма"].YValueMembers = "Termogramma";          // строим термограмму скважины;
            chart1.Series["парафины"].YValueMembers = "Paraffins";            // строим распределение парафинов;            
            chart1.Series["ном. дебит"].YValueMembers = "Nom_debit";          // скважина без обогрева;
            chart1.Series["температура нефти"].YValueMembers = "Temp_oil";    // скважина с обогревом;
            chart1.Series["температура жилы"].YValueMembers = "Temp_wire";    // строим распределение температуры центральной жилы нагревателя;

            // Data bind to the selected data source
            chart1.DataBind();
        }

        /// <summary>
        /// Загружаем данные в таблицу
        /// </summary>        
        private void BtnLoad_Click(object sender, EventArgs e)
        {            
            // открываем диалоговое окно и фильтруем файлы
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    CsvReader csv = new CsvReader(sr);                    

                    // считываем данные
                    dataBindingSource.DataSource = csv.GetRecords<Data>();

                    // закрываем процесс чтения
                    sr.Close();
                }
            }
            btnNext.Enabled = true;            
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вставляем сюда код
            MessageBox.Show("Здесь будет окно со справкой", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // переключаемся на вкладку 'График'
            tabControlPlot.SelectedIndex = 1;

            // делаем кнопку 'Построить график' доступной
            btnPlot.Enabled = true;
        }

        private void BtnClosePlot_Click(object sender, EventArgs e)
        {
            // закрываем вкладку
            Close();
        }

        private void СохранитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // выводим сообщение
            MessageBox.Show("Изображение сохранено успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
        }
    }
}
