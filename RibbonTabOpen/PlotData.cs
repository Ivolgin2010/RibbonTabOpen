using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // Set series members names for the X and Y values
            
            chart1.Series["геотерма"].XValueMember = "Depth";                 // строим глубина скважины с шагом 1 м;
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
            Close();
        }

        private void СохранитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                // код для сохранения 
                //string path = "";

                // выводим сообщение об успешном сохранении
                MessageBox.Show("График успешно сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
