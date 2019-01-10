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
            this.Close();
        }

        private void ТаблицаРасчетныхПараметровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Show();
        }

        /// <summary>
        /// строим график
        /// </summary>        
        private void BtnPlot_Click(object sender, EventArgs e)
        {            
            // Set chart data source
            chart1.DataSource = dataGridViewData.DataSource;

            // Set series members names for the X and Y values
            // строим термограмму скважины
            chart1.Series["graph"].XValueMember = "Depth";
            chart1.Series["graph"].YValueMembers = "Termogramma";

            // Data bind to the selected data source
            chart1.DataBind();
        }

        /// <summary>
        /// загружаем данные
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
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вставляем сюда код
        }
    }
}
