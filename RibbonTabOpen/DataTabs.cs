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
            DialogResult dialogResult = MessageBox.Show("Ваши данные были сохранены?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something
            }
        }

        // Проверяем заполнение полей на Первой вкладки

        private void NextButton1_Click(object sender, EventArgs e)
        {
            // задаем значения
            int.TryParse(textBox1.Text, out int TextBox1);
            int.TryParse(textBox2.Text, out int TextBox2);
            int.TryParse(textBox2.Text, out int TextBox3);
            int.TryParse(textBox2.Text, out int TextBox4);
            int.TryParse(textBox2.Text, out int TextBox5);
            int.TryParse(textBox2.Text, out int TextBox6);
            int.TryParse(textBox2.Text, out int TextBox7);
            int.TryParse(textBox2.Text, out int TextBox8);
            int.TryParse(textBox2.Text, out int TextBox9);

            // проверяем
            if (string.IsNullOrEmpty(textBox1.Text)
                || string.IsNullOrEmpty(textBox2.Text)
                || string.IsNullOrEmpty(textBox3.Text)
                || string.IsNullOrEmpty(textBox4.Text)
                || string.IsNullOrEmpty(textBox5.Text)
                || string.IsNullOrEmpty(textBox6.Text)
                || string.IsNullOrEmpty(textBox7.Text)
                || string.IsNullOrEmpty(textBox8.Text)
                || string.IsNullOrEmpty(textBox9.Text)
                )              
            {
                MessageBox.Show("Для перехода к следующей вкладке, пожалуйста, заполните все пустые поля", "Ошибка заполнения поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // переключаемся на вторую вкладку
                tabControl1.SelectedIndex = 1;
            }            
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

        // Делаем проверку первого поля

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // добавляем проверку значения

           int.TryParse(textBox1.Text, out int TextBox1); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // очищаем ErrorProvider
                errorProvider1.Clear();
            }       
            else 
            {
                // проверяем значение в поле 
                if (TextBox1 >= 0 && TextBox1 <= 5000)
                {
                    textBox1.ForeColor = Color.Black; // делаем черный
                }
                else
                {
                    textBox1.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider1.SetError(textBox1, "Внимание ошибка! Значение глубины находится вне допустимого диапазона!");                
                }
            }
        }
    }
}
