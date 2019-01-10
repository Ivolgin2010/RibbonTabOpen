using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RibbonTabOpen
{
    public partial class MainWindow : Form
    {
        public MainWindow()

        {   // инициализируем поток
            Thread splashScreen = new Thread(new ThreadStart(StartForm));

            // запукскаем его
            splashScreen.Start();

            // ждем 2500 мсек
            Thread.Sleep(2500);

            InitializeComponent();

            // выходим из потока
            splashScreen.Abort();
        }

        // запускаем стартовое окно
        public void StartForm()
        {

           Application.Run(new FrmSplash());            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Ribbon newForm = new Ribbon();
                newForm.Show();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Ribbon newForm = new Ribbon();
            newForm.Show();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перспективный значок. Здесь будет расчет электрообогрева нефтяной скважины, оборудованной станком-качалкой.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }        

        private void MouseHover_Exit(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "нажмите для выхода из программы";
        }

        private void MouseLeave_Exit(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Добро пожаловать";
        }

        private void MouseHover_About(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "вызов сведений о программе";
        }

        private void MouseLeave_About(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Добро пожаловать";
        }        

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перспективный значок. Здесь будет расчет электрообогрева газлифтной нефтяной скважины.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перспективный значок. Здесь будет расчет электрообогрева нефтяной скважины, оборудованной винтовым насосом.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
