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
            DataTabs newForm1 = new DataTabs();
            newForm1.Show();
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

            Help.ShowHelp(this, "C:\\Users\\i.geraskin\\Documents\\GitHub\\RibbonTabOpen\\RibbonTabOpen\\html\\help.html", HelpNavigator.TopicId, "30");
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
            Viewer view = new Viewer();
            view.Show();
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

        }

        //********************************************************************************
        // создаем отчет

        private void Click_Report(object sender, EventArgs e)
        {

        }

        //********************************************************************************
        // сохраняем файл

        private void Click_SaveAs(object sender, EventArgs e)
        {

        }
    }
}
