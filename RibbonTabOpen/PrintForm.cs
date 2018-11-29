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
        private string stringToPrint;

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
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    textPrint.Text = streamReader.ReadToEnd();
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
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void НастройкаСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            PageSetupDialog pgSetup = new PageSetupDialog
            {
                PageSettings = new System.Drawing.Printing.PageSettings(),
                PrinterSettings = new System.Drawing.Printing.PrinterSettings(),
                ShowNetwork = false
            };

            pgSetup.ShowDialog();
        }
        
        private void ВыходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //int charactersOnPage = 0;
            //int linesPerPage = 0;
            
            //e.Graphics.MeasureString(stringToPrint, this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);

            e.Graphics.DrawString(textPrint.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(100, 100));

            //// Remove the portion of the string that has been printed.
            //stringToPrint = stringToPrint.Substring(charactersOnPage);

            //// Check to see if more pages are to be printed.
            //e.HasMorePages = (stringToPrint.Length > 0);

        }

        private void textPrint_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
