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
    public partial class DataTable : Form
    {
        
        public DataTable()
        {
            InitializeComponent();
        }

        private void DataTable_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();
            //row.CreateCells(dataGridView1);  // this line was missing
            //row.Cells[0].Value = "Cell1";
            //row.Cells[1].Value = "Cell2";
            //dataGridView1.Rows.Add(row);
        }
    }
}
