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
        //private object dataTabs;

        public AddWindow()
        {
            InitializeComponent();
        }        

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //********************************************************************************
        // Сохраняем данные в файл

        public void Button1_Click(object sender, EventArgs e)
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

            string company = textBox01.Text; // оператор
            string name = textBox02.Text;    // наименование месторождения
            string number = textBox03.Text;  // номер скважины
            string label = textBox04.Text;   // 

            // Данные первой вкладки

            DataTabs TextBox1 = new DataTabs();
            string value = TextBox1.textBox1.Text;
            
            //string h_bhole = textBox1.Text;

            //DataTabs TextBox2 = new DataTabs();
            //string h_obs = TextBox2.textBox2.Text;


            //string d_vnesh_obs = textBox3.Text;
            //string h_nkt = textBox4.Text;
            //string d_vnesh_nkt = textBox5.Text;
            //string h_stat = textBox6.Text;

            //// Данные второй вкладки

            //string t_bhole = textBox10.Text;
            //string h_ice = textBox11.Text;
            //string t_month = textBox12.Text;
            //string t_maxh = textBox13.Text;

            //// Данные третьей вкладки

            //string ro = textBox.Text;
            //string visc_plast = textBox.Text;
            //string pn_plast = textBox.Text;
            //string tkpn = textBox.Text;
            //string g_plast = textBox.Text;

            //// Данные четвертой вкладки

            //string nomdebit = textBox.Text;
            //string debit_oil = textBox.Text;
            //string g = textBox.Text;
            //string water = textBox.Text;
            //string h_din = textBox.Text;
            //string p_wellhead = textBox.Text;
            //string t_wellhead = textBox.Text;
            //string debit = textBox.Text;
            //string scraper = textBox.Text;
            //string h_aspo = textBox.Text;

            //// Данные пятой вкладки

            //string ro_oil = textBox.Text;
            //string visc_oil = textBox.Text;
            //string cp = textBox.Text;
            //string asf = textBox.Text;
            //string silica_gel = textBox.Text;
            //string freezing_oil = textBox.Text;
            //string t_0 = textBox.Text;
            //string melting = textBox.Text;
            //string ro_gas = textBox.Text;
            //string ro_water = textBox.Text;

            //// Данные шестой вкладки

            //string ESP_gas = textBox.Text;
            //string u_ESP = textBox.Text;
            //string f_ESP = textBox.Text;
            //string i_ESP = textBox.Text;
            //string d_vnut_nkt = textBox.Text;
            //string d_vnut_obs = textBox.Text;
            //string c_neft = textBox.Text;
            //string kll = textBox.Text;
            //string holkon = textBox.Text;
            //string sh_gr = textBox.Text;
            //string glub_zap = textBox.Text;
            //string min_T_zap = textBox.Text;
            //string stavka = textBox.Text;
            //string d_kab = textBox.Text;
            //string long_ = textBox.Text;
            //string u_u = textBox.Text;

            //-------------------------------- создаем заголовок файла -------------------------------------------//

            sw.WriteLine(div2.ToString());
            //sw.WriteLine("\n");
            sw.WriteLine("Название: Сохраненные анкетные данные");
            //sw.WriteLine("\n");
            //sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");
            sw.WriteLine("Разработчик: ООО ОКБ 'Гамма' ");
            sw.WriteLine("\n");
            sw.WriteLine("Дата сохранения: " + DateTime.Now.ToString());
            sw.WriteLine("\n");
            sw.WriteLine("Оператор : " + company.ToString());
            sw.WriteLine("\n");
            sw.WriteLine("Наименование месторождения: " + name.ToString());
            sw.WriteLine("\n");
            sw.WriteLine("Номер скважины: " + number.ToString());
            sw.WriteLine("\n");
            sw.WriteLine("Марка ЭЦН: " + label.ToString());
            sw.WriteLine("\n");
            sw.WriteLine(div1.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные первой вкладки ---------------------------------------------//

            sw.WriteLine("Глубина забоя, м: " + value.ToString());
            sw.WriteLine("\n");
            sw.WriteLine("Длина эксплуатационной колонны (с хвостовиком), м: ");          
            sw.WriteLine("\n");
            sw.WriteLine("Диаметр эксплуатационной колонны,м: ");
            sw.WriteLine("\n");
            sw.WriteLine("Длина колонны НКТ, м: ");
            sw.WriteLine("\n");
            sw.WriteLine("Диаметр колонны НКТ, м: ");
            sw.WriteLine("\n");
            sw.WriteLine("Статический уровень флюида в скважине, м: ");
            sw.WriteLine("\n");
            sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные второй вкладки ---------------------------------------------//

            sw.WriteLine("Температура нефтяного пласта, град С:");
            sw.WriteLine("\n");
            sw.WriteLine("Глубина вечномерзлых грунтов, м:");
            sw.WriteLine("\n");
            sw.WriteLine("Средняя температура наиболее холодного месяца, град С:");
            sw.WriteLine("\n");
            sw.WriteLine("Максимальная температура наиболее теплого месяца, град С:");
            sw.WriteLine("\n");
            sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные третьей вкладки ---------------------------------------------//

            sw.WriteLine("Плотность нефтяного флюида в условиях пласта, кг/м3:");
            sw.WriteLine("\n");
            sw.WriteLine("Вязкость нефтяного флюида в условиях пласта, мПа*с:");
            sw.WriteLine("\n");
            sw.WriteLine("Давление насыщения в условиях пласта, МПа:");
            sw.WriteLine("\n");
            sw.WriteLine("Температурный коэффициент давления насыщения:");
            sw.WriteLine("\n");
            sw.WriteLine("Газосодержание пластовой жидкости, м3/м3:");
            sw.WriteLine("\n");
            sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные четвертой вкладки ---------------------------------------------//
            sw.WriteLine("Дебит по жидкости (с чистой НКТ), м3/сут:");
            sw.WriteLine("\n");
            sw.WriteLine("Дебит по нефти, т/сут:");
            sw.WriteLine("\n");
            sw.WriteLine("Газовый фактор, м3/м3:");
            sw.WriteLine("\n");
            sw.WriteLine("Содержание воды, массовая доля, проц. по массе: ");
            sw.WriteLine("\n");
            sw.WriteLine("Динамический уровень, м от устья:");
            sw.WriteLine("\n");
            sw.WriteLine("Давление на устье, МПа: ");
            sw.WriteLine("\n");
            sw.WriteLine("Температура жидкости на выходе из скважины, град С: ");
            sw.WriteLine("\n");
            sw.WriteLine("Минимальный дебит по жидкости м3/сут:");
            sw.WriteLine("\n");
            sw.WriteLine("Глубина спуска скребка при механической очистке, м: ");
            sw.WriteLine("\n");
            sw.WriteLine("Максимальная глубина отложения АСПО (по данным КРС), м:");            
            sw.WriteLine("\n");
            sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные пятой вкладки ---------------------------------------------//
            sw.WriteLine("Плотность дегазированной нефти в норм. условиях,кг/м3:");
            sw.WriteLine("\n");
            sw.WriteLine("Вязкость дегазированной нефти, мПа*с:");
            sw.WriteLine("\n");
            sw.WriteLine("Содержание парафина, массовая доля, проц.:");
            sw.WriteLine("\n");
            sw.WriteLine("Содержание асфальтенов, массовая доля, проц.:");
            sw.WriteLine("\n");
            sw.WriteLine("Содержание смол силикагелевых, массовая доля, проц.:");
            sw.WriteLine("\n");
            sw.WriteLine("Температура застывания нефти, град С:");
            sw.WriteLine("\n");
            sw.WriteLine("Температура насыщения нефти парафином, град С:");
            sw.WriteLine("\n");
            sw.WriteLine("Температура плавления парафинов, град С:");
            sw.WriteLine("\n");
            sw.WriteLine("Плотность сопутствующего газа, кг/м3:");
            sw.WriteLine("\n");
            sw.WriteLine("Плотность сопутствующей воды, кг/м3:");
            sw.WriteLine("\n");
            sw.WriteLine(div2.ToString());
            sw.WriteLine("\n");

            //--------------------------- Данные шестой вкладки ---------------------------------------------//

            sw.WriteLine("Допустимое газосодержание при откачке нефтегазовой смеси по объему, проц.: ");
            sw.WriteLine("\n");
            sw.WriteLine("Напряжение питания ПЭД, В: ");
            sw.WriteLine("\n");
            sw.WriteLine("Частота питающего напряжения, Гц: ");
            sw.WriteLine("\n");
            sw.WriteLine("Ток потребления ПЭД, А: ");
            sw.WriteLine("\n");
            sw.WriteLine("Толщина стенки НКТ, мм: ");
            sw.WriteLine("\n");
            sw.WriteLine("Толщина стенки ОК, мм: ");          
            sw.WriteLine("\n");
            sw.WriteLine("Теплоемкость нефти, Дж/кг·К: ");
            sw.WriteLine("\n");
            sw.WriteLine("Отношение длины верхней части к полной. 1 = одна ступень: ");
            sw.WriteLine("\n");
            sw.WriteLine("Длина холодного конца, м: ");
            sw.WriteLine("\n");
            sw.WriteLine("Толщина термического сопротивления грунта, м: ");
            sw.WriteLine("\n");
            sw.WriteLine("Запас по длине обогрева, м: ");
            sw.WriteLine("\n");
            sw.WriteLine("Запас по минимальной температуре на выходе, °С: ");
            sw.WriteLine("\n");
            sw.WriteLine("Диапазон регулирования по температуре на выходе, °С: ");
            sw.WriteLine("\n");
            sw.WriteLine("Диаметр кабеля, мм: ");
            sw.WriteLine("\n");
            sw.WriteLine("Ручной выбор длины обогрева, м: ");
            sw.WriteLine("\n");
            sw.WriteLine("Ручной выбор напряжения питания кабеля, В: ");
            sw.WriteLine("\n");
            sw.WriteLine(div3.ToString());

            /* Перед выходом из приложения не забываем закрывать файл */
            sw.Close();

            // делаем кнопку 'Сохранить' неактивной
            button1.Enabled = false;

            // выводим сообщение об успешности сохранения данных

            MessageBox.Show("Данные были успешно сохранены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);         

        }
        
    }
}