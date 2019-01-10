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
    }
}
