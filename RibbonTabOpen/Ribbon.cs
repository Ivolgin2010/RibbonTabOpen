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

        private void click(object sender, EventArgs e)
        {
            DataTabs newForm1 = new DataTabs();
            newForm1.Show();
        }

        private void close(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Ribbon_Load(object sender, EventArgs e)
        {

        }

        private void click_OpenRibbon(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Файлы txt (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string text = File.ReadAllText(filename);
                
            }
        }

        private void click_History(object sender, EventArgs e)
        {
           //StreamReader sr = new StreamReader(filename);
        }

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void click_Help(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\My folder\\Downhole Heating Software Creation\\С#\\GUI C# code\\GUI help.chm", HelpNavigator.TopicId, "30");
        }

        private void click_Plot(object sender, EventArgs e)
        {
            PlotData plot = new PlotData();
            plot.Show();
        }

        private void click_Viewer(object sender, EventArgs e)
        {
            Viewer view = new Viewer();
            view.Show();
        }

        private void click_Print(object sender, EventArgs e)
        {
            PrintForm print = new PrintForm();
            print.Show();
        }
    }
}
