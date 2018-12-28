using CsvHelper;
using System;
using System.ComponentModel;
using System.IO;
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
            for (int i = 1; i <= 100; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    Thread.Sleep(100);

                    Calculation();

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
                Close();
            }
            else
            {
                MessageBox.Show("Рысчет выполнен успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }                    

        private void Calculation()
        {
            // сохраняем заголовки в файл 
            string FileName = @"C:\Users\i.geraskin\source\repos\CalcData.csv";
            
            using (StreamWriter streamWriter = new StreamWriter(FileName))
            {
                using (var csvWriter = new CsvWriter(streamWriter))
                {
                    // указываем разделитель (каждый заголовок запишется в свою ячейку)
                    csvWriter.Configuration.Delimiter = ";";

                    // записываем заголовки
                    csvWriter.WriteField("Depth");
                    csvWriter.WriteField("Paraffins");
                    csvWriter.WriteField("Nom. debit");
                    csvWriter.WriteField("Temp_oil");
                    csvWriter.WriteField("Temp_wire");
                    csvWriter.NextRecord();
                }
            }           

        }
    }
}
