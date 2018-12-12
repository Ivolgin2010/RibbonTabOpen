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
                InitialDirectory = @"C:\Users\i.geraskin\source\repos",
                Filter = "Файлы txt (*.txt)| *.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog2.FileName;
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    txtText.Text = streamReader.ReadToEnd();
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

        private void MouseHover_Viewer(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "нажмите для выхода из программы";
        }

        private void MouseLeave_Viewer(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Добро пожаловать";
        }

        private void MouseHover_Viewer_Open(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "открыть файл для просмотра";
        }

        private void MouseLeave_Viewer_open(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Добро пожаловать";
        }
    }
}
