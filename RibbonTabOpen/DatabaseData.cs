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
            // устанавливаем подключение
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\i.geraskin\Documents\GitHub\RibbonTabOpen\RibbonTabOpen\Database.mdf;Integrated Security=True");

            // открываем для записи
            con.Open();

            // отправка запроса записи полей формы
            string sql = "INSERT INTO [Database] (value) VALUES (@value)";

            cmd = new SqlCommand(sql, con);

            //cmd.Parameters.AddWithValue("@textBox52", value: textBox52.Text);
            //cmd.Parameters.AddWithValue("@textBox2", value: textBox2.Text);
            //cmd.Parameters.AddWithValue("@textBox3", value: textBox3.Text);
            //cmd.Parameters.AddWithValue("@Value1", value: textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Данные успешно сохранены в БД", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Удаляем строчку из БД
        /// </summary>
       
        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void DatabaseData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database._Database". При необходимости она может быть перемещена или удалена.
            this.databaseTableAdapter.Fill(this.database._Database);

        }
    }
}
