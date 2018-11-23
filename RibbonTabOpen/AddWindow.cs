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
    public partial class AddWindow : Form
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Файлы txt (*.txt)| *.txt",
                //openFileDialog2.FilterIndex = 2;
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ;
            }

            {               
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(saveFileDialog1.FileName);
                    MessageBox.Show("Данные были успешно сохранены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
