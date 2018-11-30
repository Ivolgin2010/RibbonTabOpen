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
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            label2.Text = progressBar1.Value.ToString() + "%";       
            


            //MessageBox.Show("Рысчет успешно выполнен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
