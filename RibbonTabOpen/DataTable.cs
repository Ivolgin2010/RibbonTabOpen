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
            dataGridView1.Rows.Add(1, "Stream Tracer 1.0/50-35/50-1120-480-25", "1 шт.");
            dataGridView1.Rows.Add(2, "Длина, м", 1625);
            dataGridView1.Rows.Add(3, "Количество зон разной мощности обогрева", 2);
            dataGridView1.Rows.Add(4, "Длина надземного участка, м", 20);
            dataGridView1.Rows.Add(5, "Питающее напряжение, В", 680);
            dataGridView1.Rows.Add(6, "Ток, А", 211);
            dataGridView1.Rows.Add(7, "Длина горячей (верхней) зоны кабеля, м", 450);
            dataGridView1.Rows.Add(8, "Линейная мощность горячей зоны, Вт/м", 119.1);
            dataGridView1.Rows.Add(9, "Длина участка пониженной мощности, м", 1050);
            dataGridView1.Rows.Add(10, "Линейная мощность холодной зоны, Вт/м", 85.7);
            dataGridView1.Rows.Add(11, "Полная мощность, кВт", 143.6);
            dataGridView1.Rows.Add(12, "Устьевая температура жидкости не менее, °С", 42.5);
            dataGridView1.Rows.Add(13, "Максимальная температура внутри кабеля, °С", 172);
        }
                
    }
}
