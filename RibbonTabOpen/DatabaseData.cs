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
    public partial class DatabaseData : Form
    {
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

        private void BtnOpen_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
