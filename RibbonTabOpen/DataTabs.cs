using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RibbonTabOpen
{

    public partial class DataTabs : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        public DataTabs()

        {
            InitializeComponent();
        }

        // ******************************************************************************
        // создаем переменную значения первого поля
        private int TextBox1;
        private string getvalue;

        // аксессор для первого поля
        public string GetValue
        {
            get => getvalue;
            set => getvalue = value;
        }

        //
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

        //***********************************************************************
        // Проверяем первое поле. 6.1 Допустимое газосодержание при откачке нефтегазовой смеси по объему.

        private void TextBox39_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox39.Text, out int TextBox39); // допустимое газосодержание при откачке нефтегазовой смеси по объему


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox39.Text))
            {
                errorProvider39.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox39, "введите значение");
            }
            else
            {
                if (TextBox39 < 0)
                {
                    textBox39.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider39.SetError(textBox39, "Внимание ошибка! Введено отрицательное значение плотности");
                }

                else if (TextBox39 > 0 && TextBox39 <= 75)
                {
                    textBox39.ForeColor = Color.Black; // делаем черный                    
                    errorProvider39.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox39.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider39.SetError(textBox39, "Внимание ошибка! Значение находится вне допустимого диапазона");
                }
            }
        }

        //private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        //{

        //}

        //private void Button1_Click(object sender, EventArgs e)
        //{

        //}

        
        /// <summary>
        /// Сохраняем текстовый файл
        /// </summary>
        
        private void Button13_Click(object sender, EventArgs e)
        {

            SaveDataToFile();
            SaveDataInDatabase();
        }    

        /// <summary>
        /// Сохраняем данные в базе данных
        /// </summary>
        public void SaveDataInDatabase()
        {
            // устанавливаем подключение
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\i.geraskin\Documents\GitHub\RibbonTabOpen\RibbonTabOpen\Database.mdf;Integrated Security=True");

            // открываем для записи
            con.Open();

            // отправка запроса записи полей формы
            string sql = "INSERT INTO [Database] (Company, Name, Number, Label) VALUES (@Company, @Name, @Number, @Label)";

            cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@textBox52", value: textBox52.Text);
            cmd.Parameters.AddWithValue("@textBox2", value: textBox53.Text);
            cmd.Parameters.AddWithValue("@textBox3", value: textBox54.Text);
            cmd.Parameters.AddWithValue("@Value1", value: textBox55.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Данные успешно сохранены в БД", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Сохраняем данные вкладок в текстовый файл
        /// </summary>
        public void SaveDataToFile()
        {
            // Объявляем строковую переменную "path", которая описывает путь к файлу            

            Stream myStream;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = @"C:\Users\i.geraskin\source\repos",
                Filter = "Файлы txt (*.txt)| *.txt",
                RestoreDirectory = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }

            /* В аргументах инициализатора нового экземпляра класса, наряду с
             * переменной "path", нужно указать свойство "true" - разрешена
               дозапись в существующий файл или "false" - переписать файл*/

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

            // добавляем элементы заголовочного файла

            string div1 = "************************************* Конец заголовка ********************************************";

            // добавляем промежуточный разделитель

            string div2 = "**************************************************************************************************";

            // добавляем вставку конца файла

            string div3 = "**************************************** Конец файла ***********************************************";

            //--------------------------- Определяем переменные ---------------------------------------//

            // Данные заголовка

            string company = textBox52.Text;      // оператор
            string name = textBox53.Text;         // наименование месторождения
            string number = textBox54.Text;       // номер скважины
            string label = textBox55.Text;        // марка ЭЦН

            // Данные первой вкладки            

            string h_bhole = textBox1.Text;       // Глубина забоя, м
            string h_obs = textBox2.Text;         // Длина эксплуатационной колонны (с хвостовиком), м
            string d_vnesh_obs = textBox3.Text;   // Диаметр эксплуатационной колонны, мм
            string h_nkt = textBox4.Text;         // Длина колонны НКТ, м
            string d_vnesh_nkt = textBox5.Text;   // Диаметр колонны НКТ, мм
            string h_stat = textBox6.Text;        // Статический уровень флюида в скважине, м

            // Данные второй вкладки

            string t_bhole = textBox10.Text;      // Температура нефтяного пласта, °С
            string h_ice = textBox11.Text;        // Глубина вечномерзлых грунтов, м
            string t_month = textBox12.Text;      // Средняя температура наиболее холодного месяца, °С
            string t_maxh = textBox13.Text;       // Максимальная температура наиболее теплого месяца, °С 

            //// Данные третьей вкладки

            string ro = textBox14.Text;           // Плотность нефтяного флюида в условиях пласта, кг/м3
            string visc_plast = textBox15.Text;   // Вязкость нефтяного флюида в условиях пласта, мПа*с
            string pn_plast = textBox16.Text;     // Давление насыщения в условиях пласта, МПа
            string tkpn = textBox17.Text;         // Температурный коэффициент давления насыщения
            string g_plast = textBox18.Text;      // Газосодержание пластовой жидкости, м3/м3 

            //// Данные четвертой вкладки

            string nomdebit = textBox19.Text;     // Дебит по жидкости (с чистой НКТ), м3/сут
            string debit_oil = textBox20.Text;    // Дебит по нефти, т/сут
            string g = textBox21.Text;            // Газовый фактор, м3/м3 
            string water = textBox22.Text;        // Содержание воды, массовая доля, проц. по массе
            string h_din = textBox23.Text;        // Динамический уровень, м от устья
            string p_wellhead = textBox24.Text;   // Давление на устье, МПа
            string t_wellhead = textBox25.Text;   // Температура жидкости на выходе из скважины, °С
            string debit = textBox26.Text;        // Минимальный дебит по жидкости м3/сут
            string scraper = textBox27.Text;      // Глубина спуска скребка при механической очистке, м
            string h_aspo = textBox28.Text;       // Максимальная глубина отложения АСПО (по данным КРС), м

            //// Данные пятой вкладки

            string ro_oil = textBox29.Text;        // Плотность дегазированной нефти в норм. условиях,кг/м3
            string visc_oil = textBox30.Text;      // Вязкость дегазированной нефти, мПа*с
            string cp = textBox31.Text;            // Содержание парафина, массовая доля, проц.
            string asf = textBox32.Text;           // Содержание асфальтенов, массовая доля, проц.
            string silica_gel = textBox33.Text;    // Содержание смол силикагелевых, массовая доля, проц.
            string freezing_oil = textBox34.Text;  // Температура застывания нефти, °С
            string t_0 = textBox35.Text;           // Температура насыщения нефти парафином, °С
            string melting = textBox36.Text;       // Температура плавления парафинов, град С
            string ro_gas = textBox37.Text;        // Плотность сопутствующего газа, кг/м3
            string ro_water = textBox38.Text;      // Плотность сопутствующей воды, кг/м3 

            //// Данные шестой вкладки

            string ESP_gas = textBox39.Text;       // Допустимое газосодержание при откачке нефтегазовой смеси по объему, проц.
            string u_ESP = textBox7.Text;          // Напряжение питания ПЭД, В
            string f_ESP = textBox8.Text;          // Частота питающего напряжения, Гц
            string i_ESP = textBox9.Text;          // Ток потребления ПЭД, А
            string d_vnut_nkt = textBox40.Text;    // Толщина стенки НКТ, мм
            string d_vnut_obs = textBox41.Text;    // Толщина стенки ОК, мм
            string c_neft = textBox42.Text;        // Теплоемкость нефти, Дж/кг·К
            string kll = textBox43.Text;           // Отношение длины верхней части к полной. 1 = одна ступень
            string holkon = textBox44.Text;        // Длина холодного конца, м
            string sh_gr = textBox45.Text;         // Толщина термического сопротивления грунта, м
            string glub_zap = textBox46.Text;      // Запас по длине обогрева, м
            string min_T_zap = textBox47.Text;     // Запас по минимальной температуре на выходе, °С
            string ustavka = textBox51.Text;       // Диапазон регулирования по температуре на выходе, °С
            string d_kab = textBox48.Text;         // Диаметр кабеля, мм
            string long_ = textBox49.Text;         // Ручной выбор длины обогрева, м
            string u_u = textBox50.Text;           // Ручной выбор напряжения питания кабеля, В

            //-------------------------------- создаем заголовок файла -------------------------------------------//

            sw.WriteLine(div2.ToString());
            //sw.WriteLine("\n");
            sw.WriteLine("Название: Сохраненные анкетные данные");
            //sw.WriteLine("\n");
            //sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");
            sw.WriteLine("Разработчик: ООО ОКБ 'Гамма' ");
            sw.WriteLine("\n");
            sw.WriteLine("Дата сохранения: " + DateTime.Now);
            sw.WriteLine("\n");
            sw.WriteLine("Оператор : " + company);
            sw.WriteLine("\n");
            sw.WriteLine("Наименование месторождения: " + name);
            sw.WriteLine("\n");
            sw.WriteLine("Номер скважины №: " + number);
            sw.WriteLine("\n");
            sw.WriteLine("Марка ЭЦН: " + label);
            sw.WriteLine("\n");
            sw.WriteLine(div1.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные первой вкладки ---------------------------------------------//

            sw.WriteLine("Глубина забоя, м: " + h_bhole);
            sw.WriteLine("\n");
            sw.WriteLine("Длина эксплуатационной колонны (с хвостовиком), м: " + h_obs);
            sw.WriteLine("\n");
            sw.WriteLine("Диаметр эксплуатационной колонны, мм: " + d_vnesh_obs);
            sw.WriteLine("\n");
            sw.WriteLine("Длина колонны НКТ, м: " + h_nkt);
            sw.WriteLine("\n");
            sw.WriteLine("Диаметр колонны НКТ, мм: " + d_vnesh_nkt);
            sw.WriteLine("\n");
            sw.WriteLine("Статический уровень флюида в скважине, м: " + h_stat);
            sw.WriteLine("\n");
            sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные второй вкладки ---------------------------------------------//

            sw.WriteLine("Температура нефтяного пласта, °С: " + t_bhole);
            sw.WriteLine("\n");
            sw.WriteLine("Глубина вечномерзлых грунтов, м: " + h_ice);
            sw.WriteLine("\n");
            sw.WriteLine("Средняя температура наиболее холодного месяца, °С: " + t_month);
            sw.WriteLine("\n");
            sw.WriteLine("Максимальная температура наиболее теплого месяца, °С: " + t_maxh);
            sw.WriteLine("\n");
            sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные третьей вкладки ---------------------------------------------//

            sw.WriteLine("Плотность нефтяного флюида в условиях пласта, кг/м3: " + ro);
            sw.WriteLine("\n");
            sw.WriteLine("Вязкость нефтяного флюида в условиях пласта, мПа*с: " + visc_plast);
            sw.WriteLine("\n");
            sw.WriteLine("Давление насыщения в условиях пласта, МПа: " + pn_plast);
            sw.WriteLine("\n");
            sw.WriteLine("Температурный коэффициент давления насыщения: " + tkpn);
            sw.WriteLine("\n");
            sw.WriteLine("Газосодержание пластовой жидкости, м3/м3: " + g_plast);
            sw.WriteLine("\n");
            sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные четвертой вкладки ---------------------------------------------//
            sw.WriteLine("Дебит по жидкости (с чистой НКТ), м3/сут: " + nomdebit);
            sw.WriteLine("\n");
            sw.WriteLine("Дебит по нефти, т/сут: " + debit_oil);
            sw.WriteLine("\n");
            sw.WriteLine("Газовый фактор, м3/м3: " + g);
            sw.WriteLine("\n");
            sw.WriteLine("Содержание воды, массовая доля, проц. по массе: " + water);
            sw.WriteLine("\n");
            sw.WriteLine("Динамический уровень, м от устья: " + h_din);
            sw.WriteLine("\n");
            sw.WriteLine("Давление на устье, МПа: " + p_wellhead);
            sw.WriteLine("\n");
            sw.WriteLine("Температура жидкости на выходе из скважины, °С: " + t_wellhead);
            sw.WriteLine("\n");
            sw.WriteLine("Минимальный дебит по жидкости м3/сут: " + debit);
            sw.WriteLine("\n");
            sw.WriteLine("Глубина спуска скребка при механической очистке, м: " + scraper);
            sw.WriteLine("\n");
            sw.WriteLine("Максимальная глубина отложения АСПО (по данным КРС), м: " + h_aspo);
            sw.WriteLine("\n");
            sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные пятой вкладки ---------------------------------------------//

            sw.WriteLine("Плотность дегазированной нефти в норм. условиях, кг/м3: " + ro_oil);
            sw.WriteLine("\n");
            sw.WriteLine("Вязкость дегазированной нефти, мПа*с: " + visc_oil);
            sw.WriteLine("\n");
            sw.WriteLine("Содержание парафина, массовая доля, %: " + cp);
            sw.WriteLine("\n");
            sw.WriteLine("Содержание асфальтенов, массовая доля, %: " + asf);
            sw.WriteLine("\n");
            sw.WriteLine("Содержание смол силикагелевых, массовая доля, %: " + silica_gel);
            sw.WriteLine("\n");
            sw.WriteLine("Температура застывания нефти, °С: " + freezing_oil);
            sw.WriteLine("\n");
            sw.WriteLine("Температура насыщения нефти парафином, °С: " + t_0);
            sw.WriteLine("\n");
            sw.WriteLine("Температура плавления парафинов, °С: " + melting);
            sw.WriteLine("\n");
            sw.WriteLine("Плотность сопутствующего газа, кг/м3: " + ro_gas);
            sw.WriteLine("\n");
            sw.WriteLine("Плотность сопутствующей воды, кг/м3: " + ro_water);
            sw.WriteLine("\n");
            sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные шестой вкладки ---------------------------------------------//

            sw.WriteLine("Допустимое газосодержание при откачке нефтегазовой смеси по объему, %: " + ESP_gas);
            sw.WriteLine("\n");
            sw.WriteLine("Напряжение питания ПЭД, В: " + u_ESP);
            sw.WriteLine("\n");
            sw.WriteLine("Частота питающего напряжения, Гц: " + f_ESP);
            sw.WriteLine("\n");
            sw.WriteLine("Ток потребления ПЭД, А: " + i_ESP);
            sw.WriteLine("\n");
            sw.WriteLine("Толщина стенки НКТ, мм: " + d_vnut_nkt);
            sw.WriteLine("\n");
            sw.WriteLine("Толщина стенки ОК, мм: " + d_vnut_obs);
            sw.WriteLine("\n");
            sw.WriteLine("Теплоемкость нефти, Дж/кг·К: " + c_neft);
            sw.WriteLine("\n");
            sw.WriteLine("Отношение длины верхней части к полной. 1 = одна ступень: " + kll);
            sw.WriteLine("\n");
            sw.WriteLine("Длина холодного конца, м: " + holkon);
            sw.WriteLine("\n");
            sw.WriteLine("Толщина термического сопротивления грунта, м: " + sh_gr);
            sw.WriteLine("\n");
            sw.WriteLine("Запас по длине обогрева, м: " + glub_zap);
            sw.WriteLine("\n");
            sw.WriteLine("Запас по минимальной температуре на выходе, °С: " + min_T_zap);
            sw.WriteLine("\n");
            sw.WriteLine("Диапазон регулирования по температуре на выходе, °С: " + ustavka);
            sw.WriteLine("\n");
            sw.WriteLine("Диаметр кабеля, мм: " + d_kab);
            sw.WriteLine("\n");
            sw.WriteLine("Ручной выбор длины обогрева, м: " + long_);
            sw.WriteLine("\n");
            sw.WriteLine("Ручной выбор напряжения питания кабеля, В: " + u_u);
            sw.WriteLine("\n");
            sw.WriteLine(div3.ToString());

            /* Перед выходом из приложения не забываем закрывать файл */
            sw.Close();

            // выводим сообщение об успешности сохранения данных
            MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ваши данные были сохранены?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                //ribbonButton2.Visual = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        // Проверяем заполнение полей на Первой вкладке

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
                tabControl1.SelectedIndex = 2;
            }
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
                tabControl1.SelectedIndex = 3;
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
                tabControl1.SelectedIndex = 4;
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
                tabControl1.SelectedIndex = 5;
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
                tabControl1.SelectedIndex = 6;
            }
        }

        //***********************************************************************
        //Проверяем первое поле. 1.4 Глубина забоя. 

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // TryParse - метод передачи алфавитных символов вместо числовых
            // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой
            int.TryParse(textBox1.Text, out TextBox1);

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
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

            getvalue = textBox1.Text;

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
            int.TryParse(textBox19.Text, out int TextBox19); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox19.Text))
            {
                errorProvider19.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox19, "введите значение");
            }
            else
            {
                // проверяем значение в поле на отрицательность
                if (TextBox19 < 0)
                {
                    textBox19.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider19.SetError(textBox19, "Внимание ошибка! Введено отрицательное значение дебита");
                }

                else if (TextBox19 >= 0)
                {
                    textBox19.ForeColor = Color.Black; // делаем черный
                    errorProvider19.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox19.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider19.SetError(textBox19, "Внимание ошибка! Значение дебита вне допустимого диапазона");
                }

            }
        }

        //********************************************************************************************
        // Проверяем второе поле. 4.2 Дебит по нефти.

        private void TextBox20_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox20.Text, out int TextBox20); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой
            int.TryParse(textBox19.Text, out int TextBox19);

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox20.Text))
            {
                errorProvider20.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox20, "введите значение");
            }
            else
            {
                if (TextBox20 < 0)
                {
                    textBox20.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider20.SetError(textBox20, "Внимание ошибка! Введено отрицательное значение дебита");
                }

                else if (TextBox20 > 0 && TextBox20 <= TextBox19)
                {
                    textBox20.ForeColor = Color.Black; // делаем черный                    
                    errorProvider20.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox20.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider20.SetError(textBox20, "Внимание ошибка! Значение дебита находится вне допустимого диапазона");
                }
            }
        }

        //*******************************************************************************************
        // Проверяем третье поле. 4.3 Газовый фактор.

        private void TextBox21_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox21.Text, out int TextBox21); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой
            int.TryParse(textBox18.Text, out int TextBox18);

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox21.Text))
            {
                errorProvider21.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox21, "введите значение");
            }
            else
            {
                if (TextBox21 < 0)
                {
                    textBox21.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider21.SetError(textBox21, "Внимание ошибка! Введено отрицательное значение газового фактора");
                }

                else if (TextBox21 > 0 && TextBox21 <= TextBox18)
                {
                    textBox21.ForeColor = Color.Black; // делаем черный                    
                    errorProvider21.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox21.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider21.SetError(textBox21, "Внимание ошибка! Значение газового фактора находится вне допустимого диапазона");
                }
            }
        }

        //***********************************************************************************
        // Проверяем четвертое поле. 4.4 Содержание воды, массовая доля.

        private void TextBox22_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox22.Text, out int TextBox22); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox22.Text))
            {
                errorProvider22.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox22, "введите значение");
            }
            else
            {
                if (TextBox22 < 0)
                {
                    textBox22.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider22.SetError(textBox22, "Внимание ошибка! Введено отрицательное значение обводненности");
                }

                else if (TextBox22 > 0 && TextBox22 < 80)
                {
                    textBox22.ForeColor = Color.Black; // делаем черный                    
                    errorProvider22.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox22.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider22.SetError(textBox22, "Внимание ошибка! Значение обводненности находится вне допустимого диапазона");
                }
            }
        }


        /*private void TextBox23_TextChanged(object sender, EventArgs e)
        {
            
        }*/

        //************************************************************************************
        // Проверяем пятое поле. 4.5 Динамический уровень.

        private void TextBox23_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox23.Text, out int TextBox23); // динамический уровень
            int.TryParse(textBox4.Text, out int TextBox4);   // длина колонны НКТ 
            int.TryParse(textBox6.Text, out int TextBox6);   // статический уровень флюида в скважине 

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox23.Text))
            {
                errorProvider23.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox23, "введите значение");
            }
            else
            {
                if (TextBox23 < 0)
                {
                    textBox23.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider23.SetError(textBox23, "Внимание ошибка! Введено отрицательное значение динамического уровня");
                }

                else if (TextBox23 > TextBox6 && TextBox23 < TextBox4)
                {
                    textBox23.ForeColor = Color.Black; // делаем черный                    
                    errorProvider23.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox23.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider23.SetError(textBox23, "Внимание ошибка! Значение динамического уровня находится вне допустимого диапазона");
                }
            }
        }

        //*****************************************************************************
        // Проверяем шестое поле. 4.6 Давление на устье.

        private void TextBox24_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox24.Text, out int TextBox24); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox24.Text))
            {
                errorProvider24.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox24, "введите значение");
            }
            else
            {
                if (TextBox24 < 0)
                {
                    textBox24.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider24.SetError(textBox24, "Внимание ошибка! Введено отрицательное значение давления");
                }

                else if (TextBox24 > 1)
                {
                    textBox24.ForeColor = Color.Black; // делаем черный                    
                    errorProvider24.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox24.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider24.SetError(textBox24, "Внимание ошибка! Значение давления находится вне допустимого диапазона");
                }
            }
        }

        //******************************************************************************
        // Проверяем седьмое поле. 4.7 Температура жидкости на выходе из скважины.

        private void TextBox25_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox25.Text, out int TextBox25); // преобразуем строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой
            int.TryParse(textBox10.Text, out int TextBox10); // температура нефтяного пласта

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox25.Text))
            {
                errorProvider25.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox25, "введите значение");
            }
            else
            {
                if (TextBox25 < 0)
                {
                    textBox25.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider25.SetError(textBox25, "Внимание ошибка! Введено отрицательное значение температуры");
                }

                else if (TextBox25 < TextBox10)
                {
                    textBox25.ForeColor = Color.Black; // делаем черный                    
                    errorProvider25.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox25.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider25.SetError(textBox25, "Внимание ошибка! Значение температуры находится вне допустимого диапазона");
                }
            }
        }

        //**************************************************************************
        // Проверяем восьмое поле. 4.8 Минимальный дебит по жидкости.

        private void TextBox26_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox26.Text, out int TextBox26); // 
            int.TryParse(textBox19.Text, out int TextBox19); // 

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox26.Text))
            {
                errorProvider26.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox26, "введите значение");
            }
            else
            {
                if (TextBox26 < 0)
                {
                    textBox26.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider26.SetError(textBox26, "Внимание ошибка! Введено отрицательное значение дебита");
                }

                else if (TextBox26 <= TextBox19)
                {
                    textBox26.ForeColor = Color.Black; // делаем черный                    
                    errorProvider26.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox26.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider26.SetError(textBox26, "Внимание ошибка! Значение дебита находится вне допустимого диапазона");
                }
            }
        }

        //**************************************************************************
        // Проверяем девятое поле. 4.9 Глубина спуска скребка при механической очистке.

        private void TextBox27_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox27.Text, out int TextBox27); // 
            int.TryParse(textBox4.Text, out int TextBox4); // 

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox27.Text))
            {
                errorProvider27.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox27, "введите значение");
            }
            else
            {
                if (TextBox27 < 0)
                {
                    textBox27.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider27.SetError(textBox27, "Внимание ошибка! Введено отрицательное значение глубины");
                }

                else if (TextBox27 < TextBox4)
                {
                    textBox27.ForeColor = Color.Black; // делаем черный                    
                    errorProvider27.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox27.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider27.SetError(textBox27, "Внимание ошибка! Значение глубины находится вне допустимого диапазона");
                }
            }
        }

        //***************************************************************************
        // Проверяем десятое поле. 4.10 Максимальная глубина отложения АСПО.

        private void TextBox28_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox28.Text, out int TextBox28); // 
            int.TryParse(textBox4.Text, out int TextBox4); // 

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox28.Text))
            {
                errorProvider28.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox28, "введите значение");
            }
            else
            {
                if (TextBox28 < 0)
                {
                    textBox28.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider28.SetError(textBox28, "Внимание ошибка! Введено отрицательное значение глубины");
                }

                else if (TextBox28 < TextBox4)
                {
                    textBox28.ForeColor = Color.Black; // делаем черный                    
                    errorProvider28.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox28.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider28.SetError(textBox28, "Внимание ошибка! Значение глубины находится вне допустимого диапазона");
                }
            }
        }

        //*******************************************************************
        // Проверяем первое поле. 5.1 Плотность дегазированной нефти в нормальных условиях.

        private void TextBox29_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox29.Text, out int TextBox29); // 
            int.TryParse(textBox14.Text, out int TextBox14); // 

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox29.Text))
            {
                errorProvider29.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox29, "введите значение");
            }
            else
            {
                if (TextBox29 < 0)
                {
                    textBox29.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider29.SetError(textBox29, "Внимание ошибка! Введено отрицательное значение плотности");
                }

                else if (TextBox29 >= 700 && TextBox29 <= 1020 && TextBox29 > TextBox14)
                {
                    textBox29.ForeColor = Color.Black; // делаем черный                    
                    errorProvider29.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox29.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider29.SetError(textBox29, "Внимание ошибка! Значение плотности находится вне допустимого диапазона");
                }
            }
        }

        //*******************************************************************************
        // Проверяем второе поле. 5.2 Вязкость дегазированной нефти. 

        private void TextBox30_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox30.Text, out int TextBox30); // вязкость дегазированной нефти
            int.TryParse(textBox15.Text, out int TextBox15); // вязкость нефтяного флюида

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox30.Text))
            {
                errorProvider30.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox30, "введите значение");
            }
            else
            {
                if (TextBox30 < 0)
                {
                    textBox30.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider30.SetError(textBox30, "Внимание ошибка! Введено отрицательное значение плотности");
                }

                else if (TextBox30 > 1 && TextBox30 > TextBox15)
                {
                    textBox30.ForeColor = Color.Black; // делаем черный                    
                    errorProvider30.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox30.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider30.SetError(textBox30, "Внимание ошибка! Значение плотности находится вне допустимого диапазона");
                }
            }
        }

        //*************************************************************************
        // Проверяем третье поле. 5.3 Содержание парафина, массовая доля. 

        private void TextBox31_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox31.Text, out int TextBox31); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox31.Text))
            {
                errorProvider31.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox31, "введите значение");
            }
            else
            {
                if (TextBox31 < 0)
                {
                    textBox31.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider31.SetError(textBox31, "Внимание ошибка! Введено отрицательное значение концентрации парафина");
                }

                else if (TextBox31 <= 0 && TextBox31 < 25)
                {
                    textBox31.ForeColor = Color.Black; // делаем черный                    
                    errorProvider31.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox31.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider31.SetError(textBox31, "Внимание ошибка! Значение концентрации парафина находится вне допустимого диапазона");
                }
            }
        }

        //*******************************************************************************
        // Проверяем четвертое поле. 5.4 Содержание асфальтенов, массовая доля.

        private void TextBox32_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox32.Text, out int TextBox32); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox32.Text))
            {
                errorProvider32.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox32, "введите значение");
            }
            else
            {
                if (TextBox32 < 0)
                {
                    textBox32.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider31.SetError(textBox32, "Внимание ошибка! Введено отрицательное значение концентрации асфальтенов");
                }

                else if (TextBox32 >= 0 && TextBox32 <= 30)
                {
                    textBox32.ForeColor = Color.Black; // делаем черный                    
                    errorProvider32.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox32.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider32.SetError(textBox32, "Внимание ошибка! Значение концентрации асфальтенов находится вне допустимого диапазона");
                }
            }
        }

        //***********************************************************************
        // Проверяем пятое поле. 5.5 Содержание силикагелевых смол, массовая доля.

        private void TextBox33_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox33.Text, out int TextBox33); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox33.Text))
            {
                errorProvider33.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox33, "введите значение");
            }
            else
            {
                if (TextBox33 < 0)
                {
                    textBox33.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider33.SetError(textBox33, "Внимание ошибка! Введено отрицательное значение концентрации смол");
                }

                else if (TextBox33 >= 0 && TextBox33 <= 30)
                {
                    textBox33.ForeColor = Color.Black; // делаем черный                    
                    errorProvider33.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox33.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider33.SetError(textBox33, "Внимание ошибка! Значение концентрации смол находится вне допустимого диапазона");
                }
            }
        }

        //***********************************************************************************
        // Проверяем шестое поле. 5.6 Температура застывания нефти.

        private void TextBox34_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox34.Text, out int TextBox34); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox34.Text))
            {
                errorProvider34.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox34, "введите значение");
            }
            else
            {
                if (TextBox34 < 0)
                {
                    textBox34.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider34.SetError(textBox34, "Внимание ошибка! Введено отрицательное значение температуры");
                }

                else if (TextBox34 != 0 && TextBox34 <= 60)
                {
                    textBox34.ForeColor = Color.Black; // делаем черный                    
                    errorProvider34.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox34.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider34.SetError(textBox34, "Внимание ошибка! Значение температуры находится вне допустимого диапазона");
                }
            }
        }

        //******************************************************************************
        // Проверяем седьмое поле. 5.7 Температура насыщения нефти парафином.

        private void TextBox35_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox35.Text, out int TextBox35); // 
            int.TryParse(textBox34.Text, out int TextBox34); //


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox35.Text))
            {
                errorProvider35.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox35, "введите значение");
            }
            else
            {
                if (TextBox35 < 0)
                {
                    textBox35.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider35.SetError(textBox35, "Внимание ошибка! Введено отрицательное значение температуры");
                }

                else if (TextBox35 != 0 && TextBox35 != TextBox34 && TextBox35 <= 60)
                {
                    textBox35.ForeColor = Color.Black; // делаем черный                    
                    errorProvider35.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox35.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider35.SetError(textBox35, "Внимание ошибка! Значение температуры равно нулю");
                }
            }
        }

        //*****************************************************************************
        // Проверяем шестое поле. 5.8 Температура плавления парафинов.

        private void TextBox36_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox36.Text, out int TextBox36); // температура плавления парафинов 
            int.TryParse(textBox35.Text, out int TextBox35); // температура насыщения нефти парафином
            int.TryParse(textBox34.Text, out int TextBox34); // температура застывания нефти

            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox36.Text))
            {
                errorProvider36.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox36, "введите значение");
            }
            else
            {
                if (TextBox36 < 0)
                {
                    textBox36.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider36.SetError(textBox36, "Внимание ошибка! Введено отрицательное значение температуры");
                }

                else if (TextBox36 > TextBox35 && TextBox36 > TextBox34)
                {
                    textBox36.ForeColor = Color.Black; // делаем черный                    
                    errorProvider36.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox36.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider36.SetError(textBox36, "Внимание ошибка! Значение температуры вне допустимого диапазона");
                }
            }
        }

        //******************************************************************************
        // Проверяем девятое поле. 5.9 Плотность сопутствующего газа.

        private void TextBox37_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox37.Text, out int TextBox37); // плотность сопутствующего газа


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox37.Text))
            {
                errorProvider37.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox37, "введите значение");
            }
            else
            {
                if (TextBox37 < 0)
                {
                    textBox37.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider37.SetError(textBox37, "Внимание ошибка! Введено отрицательное значение плотности");
                }

                else if (TextBox37 > 0.65 && TextBox37 < 1.3)
                {
                    textBox37.ForeColor = Color.Black; // делаем черный                    
                    errorProvider37.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox37.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider37.SetError(textBox37, "Внимание ошибка! Значение плотности находится вне допустимого диапазона");
                }
            }
        }

        //*****************************************************************
        // Проверяем десятое поле. 5.10 Плотность сопутствующей воды.

        private void TextBox38_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox38.Text, out int TextBox38); // плотность сопутствующей воды


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox38.Text))
            {
                errorProvider38.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox38, "введите значение");
            }
            else
            {
                if (TextBox38 < 0)
                {
                    textBox38.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider38.SetError(textBox38, "Внимание ошибка! Введено отрицательное значение плотности");
                }

                else if (TextBox38 >= 1000 && TextBox38 <= 1300)
                {
                    textBox38.ForeColor = Color.Black; // делаем черный                    
                    errorProvider38.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox38.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider38.SetError(textBox38, "Внимание ошибка! Значение плотности находится вне допустимого диапазона");
                }
            }
        }

        //***********************************************************************************
        // Проверяем второе поле. 6.5 Внутренний диаметр НКТ. 

        private void TextBox40_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox40.Text, out int TextBox40); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox40.Text))
            {
                errorProvider40.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox40, "введите значение");
            }
            else
            {
                if (TextBox40 < 0)
                {
                    textBox40.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider40.SetError(textBox40, "Внимание ошибка! Введено отрицательное значение диаметра");
                }

                else if (TextBox40 > 0 && TextBox40 <= 75)
                {
                    textBox40.ForeColor = Color.Black; // делаем черный                    
                    errorProvider40.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox40.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider40.SetError(textBox40, "Внимание ошибка! Значение находится вне допустимого диапазона");
                }
            }
        }

        private void Label89_Click(object sender, EventArgs e)
        {

        }

        //******************************************************************************
        // Проверяем третье поле. 6.6 Внутренний диаметр обсадной трубы.

        private void TextBox41_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox41.Text, out int TextBox41); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox41.Text))
            {
                errorProvider41.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox41, "введите значение");
            }
            else
            {
                if (TextBox41 < 0)
                {
                    textBox41.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider41.SetError(textBox41, "Внимание ошибка! Введено отрицательное значение диаметра");
                }

                else if (TextBox41 > 0)
                {
                    textBox41.ForeColor = Color.Black; // делаем черный                    
                    errorProvider41.Clear(); // очищаем ErrorProvider
                }
                else
                {
                    textBox41.ForeColor = Color.Red; // делаем шрифт красным

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider41.SetError(textBox41, "Внимание ошибка! Значение находится вне допустимого диапазона");
                }
            }
        }

        //***************************************************************************
        // Проверяем четвертое поле. 6.7 Теплоемкость нефти.

        private void TextBox42_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox42.Text, out int TextBox42); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox42.Text))
            {
                errorProvider42.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox42, "введите значение");
            }
            else
            {
                if (TextBox42 < 0)
                {
                    textBox42.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider42.SetError(textBox42, "Внимание ошибка! Введено отрицательное значение теплоемкости");
                }

                else if (TextBox42 >= 0)
                {
                    textBox42.ForeColor = Color.Black; // делаем черный                    
                    errorProvider42.Clear(); // очищаем ErrorProvider
                }
            }
        }


        //*****************************************************************************
        // Проверяем пятое поле. 6.8 Отношение длины верхней части к полной. 

        private void TextBox43_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox43.Text, out int TextBox43); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox43.Text))
            {
                errorProvider43.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox43, "введите значение");
            }
            else
            {
                if (TextBox43 < 0)
                {
                    textBox43.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider43.SetError(textBox43, "Внимание ошибка! Введено отрицательное значение");
                }

                else if (TextBox43 >= 0)
                {
                    textBox43.ForeColor = Color.Black; // делаем черный                    
                    errorProvider43.Clear(); // очищаем ErrorProvider
                }
            }
        }

        //*************************************************************************************
        // Проверяем шестое поле. 6.9 Длина холодного конца.

        private void TextBox44_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox44.Text, out int TextBox44); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox44.Text))
            {
                errorProvider44.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox44, "введите значение");
            }
            else
            {
                if (TextBox44 < 0)
                {
                    textBox44.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider44.SetError(textBox44, "Внимание ошибка! Введено отрицательное значение");
                }

                else if (TextBox44 >= 0)
                {
                    textBox44.ForeColor = Color.Black; // делаем черный                    
                    errorProvider44.Clear(); // очищаем ErrorProvider
                }
            }
        }

        //**************************************************************************************
        // Проверяем седьмое поле. 6.10 Толщина термического сопротивления грунта.

        private void TextBox45_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox45.Text, out int TextBox45); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox45.Text))
            {
                errorProvider45.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox45, "введите значение");
            }
            else
            {
                if (TextBox45 < 0)
                {
                    textBox45.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider45.SetError(textBox45, "Внимание ошибка! Введено отрицательное значение");
                }

                else if (TextBox45 >= 0)
                {
                    textBox45.ForeColor = Color.Black; // делаем черный                    
                    errorProvider45.Clear(); // очищаем ErrorProvider
                }
            }
        }

        //************************************************************************
        // Проверяем восьмое поле. 6.11 Запас по длине обогрева. 

        private void TextBox46_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox46.Text, out int TextBox46); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox46.Text))
            {
                errorProvider46.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox46, "введите значение");
            }
            else
            {
                if (TextBox46 < 0)
                {
                    textBox46.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider46.SetError(textBox46, "Внимание ошибка! Введено отрицательное значение");
                }

                else if (TextBox46 >= 0)
                {
                    textBox46.ForeColor = Color.Black; // делаем черный                    
                    errorProvider46.Clear(); // очищаем ErrorProvider
                }
            }
        }

        //***********************************************************************************
        // Проверяем девятое поле. 6.12 Запас по минимальной температуре на выходе.

        private void TextBox47_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox47.Text, out int TextBox47); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox47.Text))
            {
                errorProvider47.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox47, "введите значение");
            }
            else
            {
                if (TextBox47 < 0)
                {
                    textBox47.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider47.SetError(textBox47, "Внимание ошибка! Введено отрицательное значение");
                }

                else if (TextBox47 >= 0)
                {
                    textBox47.ForeColor = Color.Black; // делаем черный                    
                    errorProvider47.Clear(); // очищаем ErrorProvider
                }
            }
        }

        //*******************************************************************************
        // Проверяем одиннадцатое поле. 6.14 Диаметр кабеля.

        private void TextBox48_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox48.Text, out int TextBox48); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox48.Text))
            {
                errorProvider48.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox48, "введите значение");
            }
            else
            {
                if (TextBox48 < 0)
                {
                    textBox48.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider48.SetError(textBox48, "Внимание ошибка! Введено отрицательное значение");
                }

                else if (TextBox48 >= 0)
                {
                    textBox48.ForeColor = Color.Black; // делаем черный                    
                    errorProvider48.Clear(); // очищаем ErrorProvider
                }
            }
        }

        //******************************************************************************************
        // Проверяем двенадцатое поле. 6.15 Ручной выбор длины обогрева.

        private void TextBox49_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox49.Text, out int TextBox49); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox49.Text))
            {
                errorProvider49.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox49, "введите значение");
            }
            else
            {
                if (TextBox49 < 0)
                {
                    textBox49.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider48.SetError(textBox49, "Внимание ошибка! Введено отрицательное значение");
                }

                else if (TextBox49 >= 0)
                {
                    textBox49.ForeColor = Color.Black; // делаем черный                    
                    errorProvider49.Clear(); // очищаем ErrorProvider
                }
            }
        }

        //**********************************************************************************************
        // Проверяем тринадцатое поле. 6.16 Ручной выбор напряжения питания кабеля.

        private void TextBox50_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox50.Text, out int TextBox50); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox50.Text))
            {
                errorProvider50.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox50, "введите значение");
            }
            else
            {
                if (TextBox50 < 0)
                {
                    textBox50.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider50.SetError(textBox50, "Внимание ошибка! Введено отрицательное значение");
                }

                else if (TextBox50 >= 0)
                {
                    textBox50.ForeColor = Color.Black; // делаем черный                    
                    errorProvider50.Clear(); // очищаем ErrorProvider
                }
            }
        }

        //*************************************************************************************************


        private void TextBox51_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox51.Text, out int TextBox51); // 


            // проверяем если поле пустое            
            if (string.IsNullOrEmpty(textBox51.Text))
            {
                errorProvider51.Clear(); // очищаем ErrorProvider

                // показываем всплывающую подсказку
                ToolTip tool = new ToolTip();
                tool.SetToolTip(this.textBox51, "введите значение");
            }
            else
            {
                if (TextBox51 < 0)
                {
                    textBox51.ForeColor = Color.Red; // делаем красный

                    // выводим сообщение об ошибке используя ErrorProvider
                    errorProvider51.SetError(textBox51, "Внимание ошибка! Введено отрицательное значение");
                }

                else if (TextBox51 >= 0)
                {
                    textBox51.ForeColor = Color.Black; // делаем черный                    
                    errorProvider51.Clear(); // очищаем ErrorProvider
                }
            }
        }

        private void Label60_Click(object sender, EventArgs e)
        {

        }

        private void TextBox03_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox03_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DatabaseData onf = new DatabaseData();
            onf.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void button2_Click_1(object sender, EventArgs e)
        //{

        //}

        private void TextBox54_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')

            {

            }

            else
            {

                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }        

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // задаем значения первой вкладки
            int.TryParse(textBox52.Text, out int TextBox52);
            int.TryParse(textBox53.Text, out int TextBox53);
            int.TryParse(textBox54.Text, out int TextBox54);
            int.TryParse(textBox55.Text, out int TextBox55);

            // проверяем
            if (string.IsNullOrEmpty(textBox52.Text)
                || string.IsNullOrEmpty(textBox53.Text)
                || string.IsNullOrEmpty(textBox54.Text)
                || string.IsNullOrEmpty(textBox55.Text)
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

        private void TextBox52_MouseClick(object sender, MouseEventArgs e)
        {
            textBox52.BackColor = Color.LightYellow;
        }

        private void TextBox52_Leave(object sender, EventArgs e)
        {
            textBox52.BackColor = Color.White;
        }

        private void TextBox53_MouseClick(object sender, MouseEventArgs e)
        {
            textBox53.BackColor = Color.LightYellow;
        }

        private void TextBox53_Leave(object sender, EventArgs e)
        {
            textBox53.BackColor = Color.White;
        }

        private void TextBox54_MouseClick(object sender, MouseEventArgs e)
        {
            textBox54.BackColor = Color.LightYellow;
        }

        private void TextBox54_Leave(object sender, EventArgs e)
        {
            textBox54.BackColor = Color.White;
        }

        private void TextBox55_Leave(object sender, EventArgs e)
        {
            textBox55.BackColor = Color.White;
        }

        private void TextBox55_MouseClick(object sender, MouseEventArgs e)
        {
            textBox55.BackColor = Color.LightYellow;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void TextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.BackColor = Color.LightYellow;
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void TextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.BackColor = Color.LightYellow;
        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void TextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.BackColor = Color.LightYellow;
        }

        private void TextBox5_Leave(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }

        private void TextBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.BackColor = Color.LightYellow;
        }

        private void TextBox6_Leave(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }

        private void TextBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.BackColor = Color.LightYellow;
        }

        private void TextBox7_Leave(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
        }

        private void TextBox7_MouseClick(object sender, MouseEventArgs e)
        {
            textBox7.BackColor = Color.LightYellow;
        }

        private void TextBox8_Leave(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.White;
        }

        private void TextBox8_MouseClick(object sender, MouseEventArgs e)
        {
            textBox8.BackColor = Color.LightYellow;
        }

        private void TextBox9_Leave(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.White;
        }

        private void TextBox9_MouseClick(object sender, MouseEventArgs e)
        {
            textBox9.BackColor = Color.LightYellow;
        }

        private void TextBox10_MouseClick(object sender, MouseEventArgs e)
        {
            textBox10.BackColor = Color.LightYellow;
        }

        private void TextBox10_Leave(object sender, EventArgs e)
        {
            textBox10.BackColor = Color.White;
        }

        private void TextBox11_Leave(object sender, EventArgs e)
        {
            textBox11.BackColor = Color.White;
        }

        private void TextBox11_MouseClick(object sender, MouseEventArgs e)
        {
            textBox11.BackColor = Color.LightYellow;
        }

        private void TextBox12_Leave(object sender, EventArgs e)
        {
            textBox12.BackColor = Color.White;
        }

        private void TextBox12_MouseClick(object sender, MouseEventArgs e)
        {
            textBox12.BackColor = Color.LightYellow;
        }

        private void TextBox13_Leave(object sender, EventArgs e)
        {
            textBox13.BackColor = Color.White;
        }

        private void TextBox13_MouseClick(object sender, MouseEventArgs e)
        {
            textBox13.BackColor = Color.LightYellow;
        }

        private void TextBox14_Leave(object sender, EventArgs e)
        {
            textBox14.BackColor = Color.White;
        }

        private void TextBox14_MouseClick(object sender, MouseEventArgs e)
        {
            textBox14.BackColor = Color.LightYellow;
        }

        private void TextBox15_Leave(object sender, EventArgs e)
        {
            textBox15.BackColor = Color.White;
        }

        private void TextBox15_MouseClick(object sender, MouseEventArgs e)
        {
            textBox15.BackColor = Color.LightYellow;
        }

        private void TextBox16_Leave(object sender, EventArgs e)
        {
            textBox16.BackColor = Color.White;
        }

        private void TextBox16_MouseClick(object sender, MouseEventArgs e)
        {
            textBox16.BackColor = Color.LightYellow;            
        }

        private void TextBox17_Leave(object sender, EventArgs e)
        {
            textBox17.BackColor = Color.White;
        }

        private void TextBox18_Leave(object sender, EventArgs e)
        {
            textBox18.BackColor = Color.White;
        }

        private void TextBox18_MouseClick(object sender, MouseEventArgs e)
        {
            textBox18.BackColor = Color.LightYellow;
        }

        private void TextBox17_MouseClick(object sender, MouseEventArgs e)
        {
            textBox17.BackColor = Color.LightYellow;
        }

        private void TextBox19_Leave(object sender, EventArgs e)
        {
            textBox19.BackColor = Color.White;
        }

        private void TextBox19_MouseClick(object sender, MouseEventArgs e)
        {
            textBox19.BackColor = Color.LightYellow;
        }

        private void TextBox20_Leave(object sender, EventArgs e)
        {
            textBox20.BackColor = Color.White;
        }

        private void TextBox20_MouseClick(object sender, MouseEventArgs e)
        {
            textBox20.BackColor = Color.LightYellow;
        }

        private void TextBox21_MouseClick(object sender, MouseEventArgs e)
        {
            textBox21.BackColor = Color.LightYellow;
        }

        private void TextBox21_Leave(object sender, EventArgs e)
        {
            textBox21.BackColor = Color.White;
        }

        private void TextBox22_MouseClick(object sender, MouseEventArgs e)
        {
            textBox22.BackColor = Color.LightYellow;
        }

        private void TextBox22_Leave(object sender, EventArgs e)
        {
            textBox22.BackColor = Color.White;
        }

        private void TextBox23_MouseClick(object sender, MouseEventArgs e)
        {
            textBox23.BackColor = Color.LightYellow;
        }

        private void TextBox23_Leave(object sender, EventArgs e)
        {
            textBox23.BackColor = Color.White;
        }

        private void TextBox24_MouseClick(object sender, MouseEventArgs e)
        {
            textBox24.BackColor = Color.LightYellow;
        }

        private void TextBox24_Leave(object sender, EventArgs e)
        {
            textBox24.BackColor = Color.White;
        }

        private void TextBox25_MouseClick(object sender, MouseEventArgs e)
        {
            textBox25.BackColor = Color.LightYellow;
        }

        private void TextBox25_Leave(object sender, EventArgs e)
        {
            textBox25.BackColor = Color.White;
        }

        private void TextBox26_MouseClick(object sender, MouseEventArgs e)
        {
            textBox26.BackColor = Color.LightYellow;
        }

        private void TextBox26_Leave(object sender, EventArgs e)
        {
            textBox26.BackColor = Color.White;
        }

        private void TextBox27_MouseClick(object sender, MouseEventArgs e)
        {
            textBox27.BackColor = Color.LightYellow;
        }

        private void TextBox27_Leave(object sender, EventArgs e)
        {
            textBox27.BackColor = Color.White;
        }

        private void TextBox28_MouseClick(object sender, MouseEventArgs e)
        {
            textBox28.BackColor = Color.LightYellow;
        }

        private void TextBox28_Leave(object sender, EventArgs e)
        {
            textBox28.BackColor = Color.White;
        }

        private void TextBox29_MouseClick(object sender, MouseEventArgs e)
        {
            textBox29.BackColor = Color.LightYellow;
        }

        private void TextBox29_Leave(object sender, EventArgs e)
        {
            textBox29.BackColor = Color.White;
        }

        private void TextBox30_MouseClick(object sender, MouseEventArgs e)
        {
            textBox30.BackColor = Color.LightYellow;
        }

        private void TextBox30_Leave(object sender, EventArgs e)
        {
            textBox30.BackColor = Color.White;
        }

        private void TextBox31_MouseClick(object sender, MouseEventArgs e)
        {
            textBox31.BackColor = Color.LightYellow;
        }

        private void TextBox31_Leave(object sender, EventArgs e)
        {
            textBox31.BackColor = Color.White;
        }

        private void TextBox32_MouseClick(object sender, MouseEventArgs e)
        {
            textBox32.BackColor = Color.LightYellow;
        }

        private void TextBox32_Leave(object sender, EventArgs e)
        {
            textBox32.BackColor = Color.White;
        }

        private void TextBox33_MouseClick(object sender, MouseEventArgs e)
        {
            textBox33.BackColor = Color.LightYellow;
        }

        private void TextBox33_Leave(object sender, EventArgs e)
        {
            textBox33.BackColor = Color.White;
        }

        private void TextBox34_MouseClick(object sender, MouseEventArgs e)
        {
            textBox34.BackColor = Color.LightYellow;
        }

        private void TextBox34_Leave(object sender, EventArgs e)
        {
            textBox34.BackColor = Color.White;
        }

        private void TextBox35_MouseClick(object sender, MouseEventArgs e)
        {
            textBox35.BackColor = Color.LightYellow;
        }

        private void TextBox35_Leave(object sender, EventArgs e)
        {
            textBox35.BackColor = Color.White;
        }

        private void TextBox36_MouseClick(object sender, MouseEventArgs e)
        {
            textBox36.BackColor = Color.LightYellow;
        }

        private void TextBox36_Leave(object sender, EventArgs e)
        {
            textBox36.BackColor = Color.White;
        }

        private void TextBox37_MouseClick(object sender, MouseEventArgs e)
        {
            textBox37.BackColor = Color.LightYellow;
        }

        private void TextBox37_Leave(object sender, EventArgs e)
        {
            textBox37.BackColor = Color.White;
        }

        private void TextBox38_MouseClick(object sender, MouseEventArgs e)
        {
            textBox38.BackColor = Color.LightYellow;
        }

        private void TextBox38_Leave(object sender, EventArgs e)
        {
            textBox38.BackColor = Color.White;
        }

        private void TextBox39_MouseClick(object sender, MouseEventArgs e)
        {
            textBox39.BackColor = Color.LightYellow;
        }

        private void TextBox39_Leave(object sender, EventArgs e)
        {
            textBox39.BackColor = Color.White;
        }

        private void TextBox40_MouseClick(object sender, MouseEventArgs e)
        {
            textBox40.BackColor = Color.LightYellow;
        }

        private void TextBox40_Leave(object sender, EventArgs e)
        {
            textBox40.BackColor = Color.White;
        }

        private void TextBox41_MouseClick(object sender, MouseEventArgs e)
        {
            textBox41.BackColor = Color.LightYellow;
        }

        private void TextBox41_Leave(object sender, EventArgs e)
        {
            textBox41.BackColor = Color.White;
        }

        private void TextBox42_MouseClick(object sender, MouseEventArgs e)
        {
            textBox42.BackColor = Color.LightYellow;
        }

        private void TextBox42_Leave(object sender, EventArgs e)
        {
            textBox42.BackColor = Color.White;
        }

        private void TextBox43_MouseClick(object sender, MouseEventArgs e)
        {
            textBox43.BackColor = Color.LightYellow;
        }

        private void TextBox43_Leave(object sender, EventArgs e)
        {
            textBox43.BackColor = Color.White;
        }

        private void TextBox44_MouseClick(object sender, MouseEventArgs e)
        {
            textBox44.BackColor = Color.LightYellow;
        }

        private void TextBox44_Leave(object sender, EventArgs e)
        {
            textBox44.BackColor = Color.White;
        }

        private void TextBox45_MouseClick(object sender, MouseEventArgs e)
        {
            textBox45.BackColor = Color.LightYellow;
        }

        private void TextBox45_Leave(object sender, EventArgs e)
        {
            textBox45.BackColor = Color.White;
        }

        private void TextBox46_MouseClick(object sender, MouseEventArgs e)
        {
            textBox46.BackColor = Color.LightYellow;
        }

        private void TextBox46_Leave(object sender, EventArgs e)
        {
            textBox46.BackColor = Color.White;
        }

        private void TextBox47_MouseClick(object sender, MouseEventArgs e)
        {
            textBox47.BackColor = Color.LightYellow;
        }

        private void TextBox47_Leave(object sender, EventArgs e)
        {
            textBox47.BackColor = Color.White;
        }

        private void TextBox51_MouseClick(object sender, MouseEventArgs e)
        {
            textBox51.BackColor = Color.LightYellow;
        }

        private void TextBox51_Leave(object sender, EventArgs e)
        {
            textBox51.BackColor = Color.White;
        }

        private void TextBox48_MouseClick(object sender, MouseEventArgs e)
        {
            textBox48.BackColor = Color.LightYellow;
        }

        private void TextBox48_Leave(object sender, EventArgs e)
        {
            textBox48.BackColor = Color.White;
        }

        private void TextBox49_MouseClick(object sender, MouseEventArgs e)
        {
            textBox49.BackColor = Color.LightYellow;
        }

        private void TextBox49_Leave(object sender, EventArgs e)
        {
            textBox49.BackColor = Color.White;
        }

        private void TextBox50_MouseClick(object sender, MouseEventArgs e)
        {
            textBox50.BackColor = Color.LightYellow;
        }

        private void TextBox50_Leave(object sender, EventArgs e)
        {
            textBox50.BackColor = Color.White;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сохраняем изменения в БД", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}