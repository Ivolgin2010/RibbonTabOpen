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
            //// устанавливаем подключение
            //con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\i.geraskin\Documents\GitHub\RibbonTabOpen\RibbonTabOpen\Database.mdf;Integrated Security=True");

            //// открываем для записи
            //con.Open();

            //// отправка запроса записи полей формы
            //string sql = "SELECT * FROM [Database]";

            //cmd = new SqlCommand(sql, con);

            //dr = cmd.ExecuteReader();
            //DataTabs f = new DataTabs();             



        }

        /// <summary>
        ///  Открываем БД для записи значений
        /// </summary>
        
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            // устанавливаем подключение
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\i.geraskin\Documents\GitHub\RibbonTabOpen\RibbonTabOpen\Database.mdf;Integrated Security=True");

            // открываем для записи
            con.Open();

            // отправка запроса записи полей формы
            string sql = "INSERT INTO [Database] (Company, Name, Number, Label) VALUES (@Company, @Name, @Number, @Label)";

            cmd = new SqlCommand(sql, con);

            DataTabs databaseData = new DataTabs();

            cmd.Parameters.AddWithValue("@textBox52", value: databaseData.GetTextBox52);
            cmd.Parameters.AddWithValue("@textBox53", value: databaseData.GetTextBox53);
            cmd.Parameters.AddWithValue("@textBox54", value: databaseData.GetNumber);
            cmd.Parameters.AddWithValue("@textBox55", value: databaseData.GetTextBox55);
            cmd.ExecuteNonQuery();
            con.Close();

            // выводим сообщение
            MessageBox.Show("Данные успешно сохранены в БД", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Удаляем строчку из формы и БД
        /// </summary>       
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить данные?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {                
                //------- удаляем данные из таблицы dataGridView ---------//
                // определяем строку
                int rowIndex = dataGridView.CurrentCell.RowIndex;

                // удаляем строку
                dataGridView.Rows.RemoveAt(rowIndex);

                // ... и удаляем данные из БД
                // устанавливаем подключение
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\i.geraskin\Documents\GitHub\RibbonTabOpen\RibbonTabOpen\Database.mdf;Integrated Security=True");

                // открываем 
                con.Open();

                // отправка запроса записи полей формы
                string sql = "DELETE FROM [Database] WHERE ID=" + rowIndex;

                cmd = new SqlCommand(sql, con);

                cmd.ExecuteNonQuery();

                // закрываем
                con.Close();

                // выводим сообщение, что все хорошо
                MessageBox.Show("Данные успешно удалены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);                                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void DatabaseData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database._Database". При необходимости она может быть перемещена или удалена.
            this.databaseTableAdapter.Fill(this.database._Database);

        }
    }
}
