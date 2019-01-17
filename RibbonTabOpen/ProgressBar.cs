using CsvHelper;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


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

            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                //Thread.Sleep(100);
                
                WriteCsvFilebyInterop();

                //backgroundWorker.ReportProgress(i);
            }

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (backgroundWorker.CancellationPending)
            //    {
            //        e.Cancel = true;
            //    }
            //    else
            //    {
            //        //Thread.Sleep(100);

            //        WriteCsvFile();

            //        //backgroundWorker.ReportProgress(i);
            //    }
            //}            
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
                MessageBox.Show("Расчет выполнен успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }        
        
        /// <summary>
        /// Сохраняем данные при помощи CsvHelper
        /// </summary>

        //private void WriteCsvFile()
        //{
        //    // сохраняем заголовки в файл 
        //    string FileName = "CalcData.csv";        //    

        //    using (StreamWriter streamWriter = new StreamWriter(FileName))
        //    {

        //        using (var csvWriter = new CsvWriter(streamWriter))
        //        {
        //            // указываем разделитель (каждый заголовок запишется в свою ячейку)
        //            csvWriter.Configuration.Delimiter = ";";

        //            //csvWriter.WriteField(string.Empty);
        //            //csvWriter.WriteField(string.Empty);
                    

        //            // записываем заголовки
        //            csvWriter.WriteField("Depth");
        //            csvWriter.WriteField("Termogramma");
        //            csvWriter.WriteField("Paraffins");
        //            csvWriter.WriteField("Nom_debit");
        //            csvWriter.WriteField("Temp_oil");
        //            csvWriter.WriteField("Temp_wire");
        //            csvWriter.WriteField("");                    
        //            csvWriter.NextRecord();
        //        }
                
        //    }            
        //}

        /// <summary>
        /// Сохраняем данные в CSV файл при помощи библиотеки Microsoft.Office.Interopt
        /// </summary>

        private void WriteCsvFilebyInterop()
        {
            //Объявляем приложение
            Excel.Application ex = new Excel.Application
            {
                //-------------- перечисляем свойства --------------//

                //Отобразить Excel
                Visible = false,

                //Количество листов в рабочей книге
                SheetsInNewWorkbook = 2

                //
                
            };

            //Добавить рабочую книгу
            Workbook workBook = ex.Workbooks.Add(Type.Missing);

            //Отключить отображение окон с сообщениями
            ex.DisplayAlerts = false;

            //Получаем первый лист документа (счет начинается с 1)
            Worksheet sheet = (Worksheet)ex.Worksheets.get_Item(1);

            //Название листа (вкладки снизу)
            sheet.Name = "Данные";

            //Пример заполнения ячеек

            //int.TryParse(textBox1.Text, out int TextBox1);

            // заполняем поле глубины столбец
            for (int i = 1; i <= 10; i++)
            {
                sheet.Cells[i, 1] = string.Format("{0}", i);
            }

            // заполняем второй столбец
            for (int i = 1; i <= 10; i++)
            {
                sheet.Cells[i, 2] = string.Format("{0}", i);
            }

            // заполняем второй столбец
            for (int i = 1; i <= 10; i++)
            {
                sheet.Cells[i, 3] = string.Format("{0}", i);
            }

            // заполняем третий столбец
            for (int i = 1; i <= 10; i++)
            {
                sheet.Cells[i, 4] = string.Format("{0}", i);
            }

            // заполняем четвертый столбец
            for (int i = 1; i <= 10; i++)
            {
                sheet.Cells[i, 5] = string.Format("{0}", i);
            }
               
            // заполняем пятый столбец
            for (int i = 1; i <= 10; i++)
            {
                sheet.Cells[i, 6] = string.Format("{0}", i);
            }

            // добавляем пустую строку
            Range cellRange = (Range)sheet.Cells[1, 1];

            Range rowRange = cellRange.EntireRow;

            rowRange.Insert(XlInsertShiftDirection.xlShiftDown, false);

            // создаем заголовки
            sheet.Cells[1, 1] = string.Format("Depth");
            sheet.Cells[1, 2] = string.Format("Termogramma");
            sheet.Cells[1, 3] = string.Format("Paraffins");
            sheet.Cells[1, 4] = string.Format("Nom_debit");
            sheet.Cells[1, 5] = string.Format("Temp_oil");
            sheet.Cells[1, 6] = string.Format("Temp_wire");

            //----------------------------- сохраняем данные --------------------------------//
            // задаем путь к файлу

            //Directory.CreateDirectory("Resources\\Results");
            //string fileTest = @"C:\Users\i.geraskin\Documents\GitHub\RibbonTabOpen\RibbonTabOpen\Resources\CalcData.csv";
            string fileTest = @"C:\Program Files(x86)\OKB Gamma\Setup\CalcData.csv";
            
            

            // сохраняем данные (задаем путь к файлу, формат CSV, используем настройки Excel)
            workBook.SaveAs(fileTest, FileFormat: XlFileFormat.xlCSV, Local: true);

            // закрываем рабочую книгу
            workBook.Close();

            // закрываем приложение
            ex.Quit();
        }

    }
}
