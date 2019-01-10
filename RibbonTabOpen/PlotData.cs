using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        //private void chart1_Click(object sender, EventArgs e)
        //{

        //}

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
            // вставляем сюда код
        }

        /// <summary>
        /// загружаем данные
        /// </summary>        
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            // вставляем сюда код
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вставляем сюда код
        }
    }
}
