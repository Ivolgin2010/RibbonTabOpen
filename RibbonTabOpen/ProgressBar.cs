using System;
using System.ComponentModel;
using System.Threading;
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
            backgroundWorker.CancelAsync();
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }
        
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    SimulateHeavyJob();
                    backgroundWorker.ReportProgress(i);
                }
            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label2.Text = progressBar1.Value.ToString() + "%";
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Внимание! Расчет был прерван", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                this.Close();
            }
            else
            {
                Display();
            }
        }
        
        private void SimulateHeavyJob()
        {
            Thread.Sleep(100);
        }           

        private void Display()
        {
            MessageBox.Show("Рысчет выполнен успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        
    }
}
