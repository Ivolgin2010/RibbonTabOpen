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
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Файлы txt (*.txt)| *.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                ;
            }

            {
                using (StreamReader sr = new StreamReader(openFileDialog2.FileName))
                {
                    txtText.Text = sr.ReadToEnd();
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
