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
            int.TryParse(textBox3.Text, out int TextBox3);
            int.TryParse(textBox4.Text, out int TextBox4);
            int.TryParse(textBox5.Text, out int TextBox5);
            int.TryParse(textBox6.Text, out int TextBox6);
            int.TryParse(textBox7.Text, out int TextBox7);
            int.TryParse(textBox8.Text, out int TextBox8);
            int.TryParse(textBox9.Text, out int TextBox9);

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
                MessageBox.Show("Для перехода к следующей вкладке необходимо заполнить все пустые поля", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // задаем значения второй вкладки
            int.TryParse(textBox10.Text, out int TextBox10);
            int.TryParse(textBox11.Text, out int TextBox11);
            int.TryParse(textBox12.Text, out int TextBox12);
            int.TryParse(textBox13.Text, out int TextBox13);

            // проверяем
            if (string.IsNullOrEmpty(textBox10.Text)
                || string.IsNullOrEmpty(textBox11.Text)
                || string.IsNullOrEmpty(textBox12.Text)
                || string.IsNullOrEmpty(textBox13.Text)
                )
            {
                MessageBox.Show("Для перехода к следующей вкладке необходимо заполнить все пустые поля", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // переключаемся на вторую вкладку
                tabControl1.SelectedIndex = 2;
            }
        }

        private void NextButton3_Click(object sender, EventArgs e)
        {
            // задаем значения
            int.TryParse(textBox14.Text, out int TextBox14);
            int.TryParse(textBox15.Text, out int TextBox15);
            int.TryParse(textBox16.Text, out int TextBox16);
            int.TryParse(textBox17.Text, out int TextBox17);
            int.TryParse(textBox18.Text, out int TextBox18);

            // проверяем
            if (string.IsNullOrEmpty(textBox14.Text)
                || string.IsNullOrEmpty(textBox15.Text)
                || string.IsNullOrEmpty(textBox16.Text)
                || string.IsNullOrEmpty(textBox17.Text)
                || string.IsNullOrEmpty(textBox18.Text)
               )
            {
                MessageBox.Show("Для перехода к следующей вкладке необходимо заполнить все пустые поля", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // переключаемся на вторую вкладку
                tabControl1.SelectedIndex = 3;
            }
        }

        private void NextButton4_Click(object sender, EventArgs e)
        {
            // задаем значения
            int.TryParse(textBox19.Text, out int TextBox19);
            int.TryParse(textBox20.Text, out int TextBox20);
            int.TryParse(textBox21.Text, out int TextBox21);
            int.TryParse(textBox22.Text, out int TextBox22);
            int.TryParse(textBox23.Text, out int TextBox23);
            int.TryParse(textBox24.Text, out int TextBox24);
            int.TryParse(textBox25.Text, out int TextBox25);
            int.TryParse(textBox26.Text, out int TextBox26);
            int.TryParse(textBox27.Text, out int TextBox27);
            int.TryParse(textBox28.Text, out int TextBox28);

            // проверяем
            if (string.IsNullOrEmpty(textBox19.Text)
                || string.IsNullOrEmpty(textBox20.Text)
                || string.IsNullOrEmpty(textBox21.Text)
                || string.IsNullOrEmpty(textBox22.Text)
                || string.IsNullOrEmpty(textBox23.Text)
                || string.IsNullOrEmpty(textBox24.Text)
                || string.IsNullOrEmpty(textBox25.Text)
                || string.IsNullOrEmpty(textBox26.Text)
                || string.IsNullOrEmpty(textBox27.Text)
                || string.IsNullOrEmpty(textBox28.Text)
                )
            {
                MessageBox.Show("Для перехода к следующей вкладке необходимо заполнить все пустые поля", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // переключаемся на вторую вкладку
                tabControl1.SelectedIndex = 4;
            }
        }

        private void NextButton5_Click(object sender, EventArgs e)
        {
            // задаем значения
            int.TryParse(textBox29.Text, out int TextBox29);
            int.TryParse(textBox30.Text, out int TextBox30);
            int.TryParse(textBox31.Text, out int TextBox31);
            int.TryParse(textBox32.Text, out int TextBox32);
            int.TryParse(textBox33.Text, out int TextBox33);
            int.TryParse(textBox34.Text, out int TextBox34);
            int.TryParse(textBox35.Text, out int TextBox35);
            int.TryParse(textBox36.Text, out int TextBox36);
            int.TryParse(textBox37.Text, out int TextBox37);
            int.TryParse(textBox38.Text, out int TextBox38);

            // проверяем
            if (string.IsNullOrEmpty(textBox29.Text)
                || string.IsNullOrEmpty(textBox30.Text)
                || string.IsNullOrEmpty(textBox31.Text)
                || string.IsNullOrEmpty(textBox32.Text)
                || string.IsNullOrEmpty(textBox33.Text)
                || string.IsNullOrEmpty(textBox34.Text)
                || string.IsNullOrEmpty(textBox35.Text)
                || string.IsNullOrEmpty(textBox36.Text)
                || string.IsNullOrEmpty(textBox37.Text)
                || string.IsNullOrEmpty(textBox38.Text)
                )
            {
                MessageBox.Show("Для перехода к следующей вкладке необходимо заполнить все пустые поля", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tabControl1.SelectedIndex = 5;
            }
        }

        //***********************************************************************
        //Проверяем первое поле. 1.4 Глубина забоя. 

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int TextBox1); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                //string text = textBox1.Text;
                tool.SetToolTip(this.textBox1, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox1 < 0)
                {
                    textBox1.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider1.SetError(textBox1, "Внимание ошибка! Введено отрицательное значение глубины забоя");
                }

                else if (TextBox1 >= 0 && TextBox1 <= 5000)
                {
                    textBox1.ForeColor = Color.Black; // делаем черный
                    errorProvider1.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox1.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider1.SetError(textBox1, "Внимание ошибка! Значение глубины находится вне допустимого диапазона");
                }
            }
        }

        private void Label92_Click(object sender, EventArgs e)
        {

        }

        //***************************************************************************
        // Проверяем второе поле. 1.5 Длина эксплуатационной колонны.

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // добавляем проверку значения

            int.TryParse(textBox2.Text, out int TextBox2); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой
            int.TryParse(textBox1.Text, out int TextBox1);

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider2.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox2, "введите значение");
            }
            else
            {
                if (TextBox2 < 0)
                {
                    textBox2.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider2.SetError(textBox2, "Внимание ошибка! Введено отрицательное значение длины");
                }

                else if (TextBox2 >= 0 && TextBox2 >= TextBox1)
                {
                    textBox2.ForeColor = Color.Black; // делаем черный                    
                    errorProvider2.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox2.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider2.SetError(textBox2, "Внимание ошибка! Значение длины находится вне допустимого диапазона");
                }
            }

        }
        //**********************************************************************
        // Проверяем третье поле. 1.6 Диаметр эксплуатационной колонны.

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int TextBox3); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                // очищаем ErrorProvider
                errorProvider3.Clear();

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox3, "введите значение");
            }
            else
            {
                // проверяем значение в поле 
                if (TextBox3 < 0)
                {
                    textBox3.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider3.SetError(textBox3, "Внимание ошибка! Введено отрицательное значение диаметра");
                }

                else if (TextBox3 >= 140 && TextBox3 <= 180)
                {
                    textBox3.ForeColor = Color.Black; // делаем черный
                    errorProvider3.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox3.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider3.SetError(textBox3, "Внимание ошибка! Значение диаметра находится вне допустимого диапазона");
                }
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        //**********************************************************************
        // Проверяем четвертое поле. 1.7 Длина колонны НКТ. 

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox4.Text, out int TextBox4); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой
            int.TryParse(textBox2.Text, out int TextBox2);

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider4.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();                
                tool.SetToolTip(this.textBox4, "введите значение");
            }
            else
            {
                if (TextBox4 < 0)
                {
                    textBox4.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider4.SetError(textBox4, "Внимание ошибка! Введено отрицательное значение диаметра");
                }

                else if (TextBox4 > 0 && TextBox4 < TextBox2)
                {
                    textBox4.ForeColor = Color.Black; // делаем черный                    
                    errorProvider4.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox4.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider4.SetError(textBox4, "Внимание ошибка!  Длина НКТ больше длины обсадной колонны");
                }
            }
        }

        //*******************************************************************************
        // Проверяем пятое поле. 1.8 Диаметр колонны НКТ 

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox5.Text, out int TextBox5); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой
            int.TryParse(textBox3.Text, out int TextBox3);

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider5.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();                
                tool.SetToolTip(this.textBox5, "введите значение");
            }
            else
            {
                if (TextBox5 < 0)
                {
                    textBox5.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider5.SetError(textBox5, "Внимание ошибка! Введено отрицательное значение диаметра");
                }
                else if (TextBox5 > 0 && TextBox5 < TextBox3)
                {
                    textBox5.ForeColor = Color.Black; // делаем черный                    
                    errorProvider5.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox5.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider5.SetError(textBox5, "Внимание ошибка! Значение диаметра НКТ больше диаметра обсадной колонны");
                }
            }
        }

        //************************************************************************
        // Проверяем шестое поле. 1.9 Статический уровень флюида в скважине

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox6.Text, out int TextBox6); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                errorProvider6.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();                
                tool.SetToolTip(this.textBox6, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox6 < 0)
                {
                    textBox6.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider6.SetError(textBox6, "Внимание ошибка! Введено отрицательное значение статического уровня");
                }

                else if (TextBox6 >= 0)
                {
                    textBox6.ForeColor = Color.Black; // делаем черный
                    errorProvider6.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox6.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider6.SetError(textBox6, "Внимание ошибка! Значение статического уровня находится вне допустимого диапазона");
                }
            }
        }

        //*********************************************************************************
        // Проверяем седьмое поле. 6.2 Напряжение питания ПЭД.

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox7.Text, out int TextBox7); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                errorProvider7.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();                
                tool.SetToolTip(this.textBox7, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox7 < 0)
                {
                    textBox7.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider7.SetError(textBox7, "Внимание ошибка! Введено отрицательное значение напряжения");
                }

                else if (TextBox7 > 600 && TextBox7 < 3500)
                {
                    textBox7.ForeColor = Color.Black; // делаем черный
                    errorProvider7.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox7.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider7.SetError(textBox7, "Внимание ошибка! Значение напряжение находится вне допустимого диапазона");
                }
            }
        }

        //***********************************************************************************
        // Проверяем восьмое поле. 6.3 Частота питающего напряжения. 

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox8.Text, out int TextBox8); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox8.Text))
            {
                errorProvider8.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();               
                tool.SetToolTip(this.textBox8, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox8 < 0)
                {
                    textBox8.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider8.SetError(textBox8, "Внимание ошибка! Введено отрицательное значение частоты");
                }

                else if (TextBox8 > 0 && TextBox8 > 40 && TextBox8 < 60)
                {
                    textBox8.ForeColor = Color.Black; // делаем черный
                    errorProvider8.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox8.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider8.SetError(textBox8, "Внимание ошибка! Значение частоты находится вне допустимого диапазона");
                }
            }
        }

        //**************************************************************************************
        // Проверяем девятое поле. 6.4 Ток потребления ПЭД.

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox9.Text, out int TextBox9); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox9.Text))
            {
                errorProvider9.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();                
                tool.SetToolTip(this.textBox9, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox9 < 0)
                {
                    textBox9.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider9.SetError(textBox9, "Внимание ошибка! Введено отрицательное значение тока");
                }

                else if (TextBox9 > 0 && TextBox9 > 10 && TextBox9 < 100)
                {
                    textBox9.ForeColor = Color.Black; // делаем черный
                    errorProvider9.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox9.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider9.SetError(textBox9, "Внимание ошибка! Значение тока находится вне допустимого диапазона");
                }
            }
        }

        //*******************************************************************************************
        // Проверяем первое поле. 2.1 Температура нефтяного пласта.

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox10.Text, out int TextBox10); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой
            int.TryParse(textBox1.Text, out int TextBox1);

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox10.Text))
            {
                errorProvider10.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox10, "введите значение");
            }
            else
            {
                if (TextBox10 < 0)
                {
                    textBox10.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider10.SetError(textBox10, "Внимание ошибка! Введено отрицательное значение температуры");
                }

                else if (TextBox10 >= 0 && TextBox10 > (0.01 * TextBox1) && TextBox10 < (0.03 * TextBox1))
                {
                    textBox10.ForeColor = Color.Black; // делаем черный                    
                    errorProvider10.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox10.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider10.SetError(textBox10, "Внимание ошибка! Значение температуры находится вне допустимого диапазона");
                }
            }


        }

        //************************************************************************************
        // Проверяем первое поле. 2.1 Температура нефтяного пласта.

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox11.Text, out int TextBox11); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox11.Text))
            {
                errorProvider1.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox11, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox11 < 0)
                {
                    textBox11.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider1.SetError(textBox11, "Внимание ошибка! Введено отрицательное значение глубины");
                }

                else if (TextBox11 >= 0)
                {
                    textBox11.ForeColor = Color.Black; // делаем черный
                    errorProvider11.Clear(); // очищаем ErrorProvider
                }
            }
        }
        //******************************************************************************
        // Проверяем третье поле. 2.3 Средняя температура наиболее холодного месяца.

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox12.Text, out int TextBox12); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox12.Text))
            {
                errorProvider12.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox12, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox12 <= 0)
                {
                    textBox12.ForeColor = Color.Black; // делаем черный
                    errorProvider12.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox12.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider12.SetError(textBox12, "Внимание ошибка! Введено положительное значение температуры");
                }
            }
        }

        //***************************************************************************
        // Проверяем четвертое поле. 2.4 Максимальная температура наиболее теплого месяца.

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox13.Text, out int TextBox13); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox13.Text))
            {
                errorProvider13.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox13, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox13 < 0)
                {
                    textBox13.ForeColor = Color.Red; // делаем шрифт красным
                    errorProvider13.SetError(textBox13, "Внимание ошибка! Введено отрицательное значение температуры");                    
                }
                else
                {                    
                    textBox13.ForeColor = Color.Black; // делаем черный
                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider13.Clear(); // очищаем ErrorProvider
                }
            }
        }

        //*********************************************************************************
        // Проверяем первое поле. 3.1 Плотность нефтяного флюида в условиях пласта. 

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox14.Text, out int TextBox14); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox14.Text))
            {
                errorProvider14.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();                
                tool.SetToolTip(this.textBox14, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox14 < 0)
                {
                    textBox14.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider14.SetError(textBox14, "Внимание ошибка! Введено отрицательное значение плотности");
                }

                else if (TextBox14 >= 600 && TextBox14 <= 950)
                {
                    textBox14.ForeColor = Color.Black; // делаем черный
                    errorProvider14.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox14.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider14.SetError(textBox14, "Внимание ошибка! Значение плотности находится вне допустимого диапазона");
                }
            }
        }

        //**************************************************************************************
        // Проверяем второе поле. 3.2 Вязкость нефтяного флюида в условиях пласта. 

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox15.Text, out int TextBox15); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox15.Text))
            {
                errorProvider15.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox15, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox15 < 0)
                {
                    textBox15.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider15.SetError(textBox15, "Внимание ошибка! Введено отрицательное значение вязкости");
                }

                else if (TextBox15 >= 1 && TextBox15 <= 200)
                {
                    textBox15.ForeColor = Color.Black; // делаем черный
                    errorProvider15.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox15.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider15.SetError(textBox15, "Внимание ошибка! Значение вязкости находится вне допустимого диапазона");
                }
            }
        }

        //******************************************************************************
        // Проверяем второе поле. 3.3 Давление насыщения в условиях пласта. 

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox16.Text, out int TextBox16); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox16.Text))
            {
                errorProvider16.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox16, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox16 < 0)
                {
                    textBox16.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider16.SetError(textBox16, "Внимание ошибка! Введено отрицательное значение давления насыщения");
                }

                else if (TextBox16 > 0 && TextBox16 < 30)
                {
                    textBox16.ForeColor = Color.Black; // делаем черный
                    errorProvider16.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox16.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider16.SetError(textBox16, "Внимание ошибка! Значение давления насыщения находится вне допустимого диапазона");
                }
            }

        }

        //***************************************************************************
        // Проверяем четвертое поле. 3.4 Температурный коэффициент давления насыщения. 

        private void TextBox17_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox17.Text, out int TextBox17); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox17.Text))
            {
                errorProvider17.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox17, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox17 < 0)
                {
                    textBox17.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider17.SetError(textBox17, "Внимание ошибка! Введено отрицательное значение коэффициента");
                }

                else if (TextBox17 > 0 && TextBox17 <= 0.005)
                {
                    textBox17.ForeColor = Color.Black; // делаем черный
                    errorProvider17.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox17.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider17.SetError(textBox17, "Внимание ошибка! Значение коэффициента находится вне допустимого диапазона");
                }
            }

        }

        //***************************************************************************
        // Проверяем пятое поле. 3.5 Газосодержание пластовой жидкости.

        private void TextBox18_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox18.Text, out int TextBox18); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox18.Text))
            {
                errorProvider18.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox18, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox18 < 0)
                {
                    textBox18.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider18.SetError(textBox18, "Внимание ошибка! Введено отрицательное значение газосодержания");
                }

                else if (TextBox18 > 0 && TextBox18 < 200)
                {
                    textBox18.ForeColor = Color.Black; // делаем черный
                    errorProvider18.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox18.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider18.SetError(textBox18, "Внимание ошибка! Значение газосодержания находится вне допустимого диапазона");
                }
            }
        }

        //**************************************************************************************
        // Проверяем первое поле. 4.1 Дебит по жидкости (с чистой НКТ).

        private void TextBox19_TextChanged(object sender, EventArgs e)
        {

        }
    }
}