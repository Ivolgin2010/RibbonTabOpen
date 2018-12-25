using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RibbonTabOpen
{
    public partial class DatabaseData : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        public DatabaseData()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Закрываем форму
        /// </summary>       

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Загружаем данные из БД в поля вкладок
        /// </summary>
        /// 
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Close();


        }

        /// <summary>
        ///  Открываем БД
        /// </summary>
        
        private void BtnOpen_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Удаляем строчку из БД
        /// </summary>
       
        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
