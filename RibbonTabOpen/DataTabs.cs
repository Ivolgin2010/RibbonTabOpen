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
    public partial class DataTabs : Form
    {
        //private int n;

        public DataTabs()

        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            AddWindow newFrame2 = new AddWindow();
            newFrame2.Show();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ваши данные сохранены?", "Сообщение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something
            }
        }

        private void NextButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void DataTabs_Load(object sender, EventArgs e)
        {

        }

        private void NextButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void NextButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void NextButton4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void NextButton5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // добавляем сюда проверку значения
            

            {
                textBox1.ForeColor = Color.Red; // меняем цвет текста
                                                //textBox1.BorderColor = Color.Red;
                                                //ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Red, textBoxBorderStyle.Solid);

                // выводим сообщение об ошибке
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(textBox1, "Внимание ошибка! Значение параметра находится вне допустимого диапазона");
            }
        }
    }
}
