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
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog2.InitialDirectory = "c:\\";
            openFileDialog2.Filter = "Файлы txt (*.txt)|*.txt";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog2.FileName;
                string text = File.ReadAllText(filename);

            }
        }

        private void печатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
                dlg.ShowDialog();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog pgs = new PrintPreviewDialog();
            pgs.ShowDialog();
        }

        private void настройкаСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PageSetupDialog PageSetup = new PageSetupDialog();
            //PageSetup.ShowDialog();
            PageSetupDialog pgSetup = new PageSetupDialog();
            pgSetup.PageSettings = new System.Drawing.Printing.PageSettings();
            pgSetup.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            pgSetup.ShowNetwork = false;

            pgSetup.ShowDialog();
        }

        private void настройкаПечатиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
