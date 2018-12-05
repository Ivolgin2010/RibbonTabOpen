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
    public partial class Ribbon : Form
    {
        public Ribbon()
        {
            InitializeComponent();
        }

        // вызываем окно ввода данных       
        private new void Click(object sender, EventArgs e)
        {
            DataTabs dataTabs = new DataTabs();
            dataTabs.Show();
        }
        
        // выходим из функционального окна

        private void Close(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Ribbon_Load(object sender, EventArgs e)
        {

        }

        //*********************************************************************************
        // открываем файл для просмотра

        private void Click_OpenRibbon(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Файлы txt (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string text = File.ReadAllText(filename);                
            }
        }

        // выводим историю открытия файла

        private void Click_History(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(filename);

            //OpenFileDialog openFileDialog1 = new OpenFileDialog()
            //string filename = openFileDialog1.FileName;
        }

        private void Ribbon1_Click(object sender, EventArgs e)
        {

        }

        // вызываем справку Help

        private void Click_Help(object sender, EventArgs e)
        {
            // Help.ShowHelp(this, "C:\\My folder\\Downhole Heating Software Creation\\С#\\GUI C# code\\GUI help.chm", HelpNavigator.TopicId, "30");

            //Help.ShowHelp(this, @"C:\Users\i.geraskin\Documents\GitHub\RibbonTabOpen\RibbonTabOpen\html\help.html", HelpNavigator.TopicId, "30");

            HelpWindow help = new HelpWindow();
            help.Show();
            //StreamReader sr = new StreamReader(@"C: \Users\i.geraskin\Documents\GitHub\RibbonTabOpen\RibbonTabOpen\html\help.html");
            //webBrowser1.DocumentStream = sr.BaseStream;

        }

        //******************************************************************************
        // строим графики

        private void Click_Plot(object sender, EventArgs e)
        {
            PlotData plot = new PlotData();
            plot.Show();
        }

        //********************************************************************************
        // открываем отчет для просмотра

        private void Click_Viewer(object sender, EventArgs e)
        {
            Viewer viewer = new Viewer();
            viewer.Show();
        }

        //*********************************************************************************
        // печатаем отчет

        private void Click_Print(object sender, EventArgs e)
        {
            PrintForm print = new PrintForm();
            print.Show();
        }

        //********************************************************************************
        // запускаем расчет

        private void Click_Start(object sender, EventArgs e)
        {
            ProgressBar pb = new ProgressBar();
            pb.Show();

           // MessageBox.Show("В этом месте будет ProgressBar", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //********************************************************************************
        // создаем отчет

        private void Click_Report(object sender, EventArgs e)
        {
            // Объявляем строковую переменную "path", которая описывает путь к файлу            

            Stream myStream;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = @"C:\Users\i.geraskin\source\repos",
                Filter = "Файлы txt (*.txt)| *.txt",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.

                    myStream.Close();
                }
            }

            /* В аргументах инициализатора нового экземпляра класса, наряду с
             * переменной "path", нужно указать свойство "true" - разрешена
               дозапись в существующий файл или "false" - переписать файл*/

            StreamWriter cr = new StreamWriter(saveFileDialog.FileName);            

            // добавляем промежуточный разделитель

            string div = "**************************************************************************************************";
            
            //--------------------------- Определяем переменные ---------------------------------------//

           //string company = textBox01.Text; // оператор

            //-------------------------------- создаем заголовок файла -------------------------------------------//

            cr.WriteLine("Наименование: Отчет");            
            cr.WriteLine("\n");
            cr.WriteLine("Разработчик: ООО ОКБ 'Гамма' ");
            cr.WriteLine("\n");
            cr.WriteLine("Дата сохранения:  " + DateTime.Now.ToString());
            cr.WriteLine("\n");
            cr.WriteLine("Описание: Расчет электрического обогрева нефтяной скважин с ЭЦН.");
            cr.WriteLine("\n");
            cr.WriteLine("Cкважина №: ");
            cr.WriteLine("\n");
            cr.WriteLine(div.ToString());
            cr.WriteLine("\n");

            //---------------------------------------------------------------------------------------------------//

            cr.WriteLine("Температура парафинизации в устье скважины: ");
            cr.WriteLine("\n");
            cr.WriteLine("Интервал регулирования температуры системой управления: ");
            cr.WriteLine("\n");
            cr.WriteLine(div.ToString());
            cr.WriteLine("\n");

            //---------------------------------------------------------------------------------------------------//
            cr.WriteLine("Номинальный дебит скважины по жидкости: ");
            cr.WriteLine("\n");
            cr.WriteLine("Минимальная глубина обогрева для номинального дебита: ");
            cr.WriteLine("\n");
            cr.WriteLine("Длина нагревателя Stream Tracer 1.0/50 с запасом: ");
            cr.WriteLine("\n");
            cr.WriteLine("В том числе: надземная часть ");
            cr.WriteLine("\n");
            cr.WriteLine("Зона повышенной мощности (верхняя часть): ");
            cr.WriteLine("\n");
            cr.WriteLine("Зона пониженной мощности (нижняя часть): ");
            cr.WriteLine("\n");
            cr.WriteLine(div.ToString());
            cr.WriteLine("\n");

            //---------------------------------------------------------------------------------------------------//
            cr.WriteLine("Напряжение питания для нагревателя длиной: ");
            cr.WriteLine("\n");
            cr.WriteLine("Рабочий ток: ");
            cr.WriteLine("\n");
            cr.WriteLine("Мощность нагревателя при номинальном дебите: ");
            cr.WriteLine("\n");
            cr.WriteLine("Линейная мощность верхней зоны обогрева скважины: ");
            cr.WriteLine("\n");            
            cr.WriteLine("Линейная мощность нижней зоны обогрева скважины: ");
            cr.WriteLine("\n");
            cr.WriteLine("Максимальная температура жилы при номинальном дебите: ");
            cr.WriteLine("\n");
            cr.WriteLine("Максимальная температура жилы (по алгоритму): ");
            cr.WriteLine("\n");
            cr.WriteLine(div.ToString());
            cr.WriteLine("\n");

            //-------------------------------------------------------------------------------------------------------//

            cr.WriteLine("Минимальный дебит скважины по жидкости: ");
            cr.WriteLine("\n");
            cr.WriteLine("Минимальная глубина обогрева для минимального дебита: ");
            cr.WriteLine("\n");
            cr.WriteLine("Длина нагревателя Stream Tracer 1.0/50 с запасом: ");
            cr.WriteLine("\n");
            cr.WriteLine("В том числе: надземная часть: ");
            cr.WriteLine("\n");
            cr.WriteLine("Зона повышенной мощнсти (верхняя часть): ");
            cr.WriteLine("\n");
            cr.WriteLine("Зона пониженной мощности (нижняя часть): ");
            cr.WriteLine("\n");
            cr.WriteLine(div.ToString());
            cr.WriteLine("\n");

            //---------------------------------------------------------------------------------------------------------//

            cr.WriteLine("Напряжение питания для нагреывателя длиной: ");
            cr.WriteLine("\n");
            cr.WriteLine("Рабочий ток: ");
            cr.WriteLine("\n");
            cr.WriteLine("Мощность нагревателя при минимальном дебите: ");
            cr.WriteLine("\n");
            cr.WriteLine("Линейная мощность верхней зоны обогрева скважины: ");
            cr.WriteLine("\n");            
            cr.WriteLine("Линейная мощность нижней зоны обогрева скважины: ");
            cr.WriteLine("\n");
            cr.WriteLine("Максимальная температура жилы при минимальном дебите: ");
            cr.WriteLine("\n");
            cr.WriteLine("Максимальная температура жилы (по алгоритму): ");
            cr.WriteLine("\n");
            cr.WriteLine(div.ToString());
            cr.WriteLine("\n");

            //---------------------------------------------------------------------------------------------------//

            cr.WriteLine("Расчет для заданных: глубины обогрева ");
            cr.WriteLine("\n");
            cr.WriteLine(" и напряжения питания:");
            cr.WriteLine("\n");
            cr.WriteLine("Требуется нагреватель Stream Tracer 1.0/35 длиной: ");
            cr.WriteLine("\n");
            cr.WriteLine("В том числе: надземная часть ");
            cr.WriteLine("\n");
            cr.WriteLine("зона повышенной мощности (верхняя часть): ");
            cr.WriteLine("\n");
            cr.WriteLine("зона пониженной мощности (нижняя часть): ");
            cr.WriteLine("\n");
            cr.WriteLine(div.ToString());
            cr.WriteLine("\n");

            //--------------------------------------------------------------------------------------------------//

            cr.WriteLine("При номинальном дебите: ");
            cr.WriteLine("\n");
            cr.WriteLine("ожидаемое значение рабочего тока: ");
            cr.WriteLine("\n");
            cr.WriteLine("Мощность нагревателя составит: ");
            cr.WriteLine("\n");
            cr.WriteLine("Линейная мощность верхней зоны обогрева скважины: ");
            cr.WriteLine("\n");            
            cr.WriteLine("Линейная мощность нижней зоны обогрева скважины: ");
            cr.WriteLine("\n");
            cr.WriteLine("Расчетная температура флюида в устье скважины: ");
            cr.WriteLine("\n");
            cr.WriteLine("Максимальная температура жилы при номинальном дебете: ");
            cr.WriteLine("\n");
            cr.WriteLine("Максимальная температура жилы (по алгоритму): ");
            cr.WriteLine("\n");
            cr.WriteLine(div.ToString());

            //------------------------------------------------------------------------------------------------------//

            // Выводим сообщение что все Ок

            MessageBox.Show("Отчет успешно создан!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //********************************************************************************
        // сохраняем файл

        private void Click_SaveAs(object sender, EventArgs e)
        {

        }

        private void Click_shortcutOpen(object sender, EventArgs e)
        {
            MessageBox.Show("Помещаем здесь код диалогового окна открытия файла", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Click_shortcutSaveAs(object sender, EventArgs e)
        {
            MessageBox.Show("Помещаем здесь код диалогового окна сохранения файла", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Click_Undo(object sender, EventArgs e)
        {
            MessageBox.Show("Помещаем здесь код отмены действия", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Click_Redo(object sender, EventArgs e)
        {
            MessageBox.Show("Помещаем здесь код отмены предыдущего действие", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
