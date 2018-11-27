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

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Файлы txt (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog2.FileName;
                //string text = File.ReadAllText(filename);
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    textBox1.Text = streamReader.ReadToEnd();
                }

            }
                       
        }

        private void ПечатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
                dlg.ShowDialog();
        }

        private void ПредварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog pgs = new PrintPreviewDialog();
            pgs.ShowDialog();
        }

        private void НастройкаСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PageSetupDialog PageSetup = new PageSetupDialog();
            //PageSetup.ShowDialog();
            PageSetupDialog pgSetup = new PageSetupDialog
            {
                PageSettings = new System.Drawing.Printing.PageSettings(),
                PrinterSettings = new System.Drawing.Printing.PrinterSettings(),
                ShowNetwork = false
            };

            pgSetup.ShowDialog();
        }

        private void НастройкаПечатиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ВыходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
