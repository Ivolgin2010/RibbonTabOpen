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

        private new void Click(object sender, EventArgs e)
        {
            DataTabs newForm1 = new DataTabs();
            newForm1.Show();
        }

        private void Close(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Ribbon_Load(object sender, EventArgs e)
        {

        }

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

        private void Click_History(object sender, EventArgs e)
        {
           //StreamReader sr = new StreamReader(filename);
        }

        private void Ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void Click_Help(object sender, EventArgs e)
        {
           // Help.ShowHelp(this, "C:\\My folder\\Downhole Heating Software Creation\\С#\\GUI C# code\\GUI help.chm", HelpNavigator.TopicId, "30");
            Help.ShowHelp(this, "C:\\Users\\i.geraskin\\Documents\\GitHub\\RibbonTabOpen\\RibbonTabOpen\\html\\help.html", HelpNavigator.TopicId, "30");
        }

        private void Click_Plot(object sender, EventArgs e)
        {
            PlotData plot = new PlotData();
            plot.Show();
        }

        private void Click_Viewer(object sender, EventArgs e)
        {
            Viewer view = new Viewer();
            view.Show();
        }

        private void Click_Print(object sender, EventArgs e)
        {
            PrintForm print = new PrintForm();
            print.Show();
        }
    }
}
