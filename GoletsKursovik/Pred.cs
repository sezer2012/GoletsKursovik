using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace GoletsKursovik
{
    public partial class Pred : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        int selectedRow;
        public Pred()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Pred = new Form1();
            Pred.Show();
        }
        private void Update3()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            sqlConnection.Open();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = dataGridView1.Rows[index].Cells[5].Value;
                if (rowState != null)
                {
                    var Название_предприятия = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var Адрес = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var Телефон = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var ФИО_директора = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var changeQuery = $"UPDATE Предприятия SET Название_предприятия = N'{Название_предприятия}', Адрес = '{Адрес}', Телефон = '{Телефон}', ФИО_директора = '{ФИО_директора}'";

                    var command = new SqlCommand(changeQuery, sqlConnection);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void UpdateDGW()
        {
            string selectQuery = "SELECT * FROM Предприятия";

            using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, sqlConnection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pred_Load(object sender, EventArgs e)
        {
            this.предприятияTableAdapter.Fill(this.databaseDataSet.Предприятия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Туры". При необходимости она может быть перемещена или удалена.
            RefreshGrid();


        }
        private void RefreshGrid()
        {
            string query = "SELECT * FROM Предприятия";



            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ilias/Source/Repos/sezer2012/GoletsKursovik/GoletsKursovik/Database.accdb;";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    dataGridView1.DataSource = null;
                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Туры");
                        dataGridView1.DataSource = ds.Tables["Туры"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PredSub form = new PredSub())
            {
                form.Text = "Добавить предприятие";
                form.label5.Text = "Добавление предприятия";

                if (form.ShowDialog() == DialogResult.OK)
                {
                    string название_предпр = form.textBox1.Text;
                    string адрес = form.textBox2.Text;
                    string телефон = form.textBox3.Text;
                    string ФИО_директора = form.textBox4.Text;
                    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ilias/Source/Repos/sezer2012/GoletsKursovik/GoletsKursovik/Database.accdb;";
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "INSERT INTO Предприятия (Название_предприятия, адрес, телефон , ФИО_директора) VALUES (@Названия_предприятия, @адрес, @телефон, @ФИО_директора)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Названия_предприятия", название_предпр);
                                cmd.Parameters.AddWithValue("@адрес", адрес);
                                cmd.Parameters.AddWithValue("@телефон", телефон);
                                cmd.Parameters.AddWithValue("@ФИО_директора", ФИО_директора);

                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Предприятие добавлено!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка: " + ex.Message);
                        }
                    }

                    // Обновляем содержимое после успешного добавления
                    RefreshGrid();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Получаем значение из первого столбца (ID) текущей строки
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

                // Запрашиваем у пользователя подтверждение удаления
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result == DialogResult.Yes)
                {
                    try
                    {

                        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ilias/Source/Repos/sezer2012/GoletsKursovik/GoletsKursovik/Database.accdb;";
                        using (OleDbConnection conn = new OleDbConnection(connectionString))
                        {
                            conn.Open();

                            // Параметризованный запрос для удаления записи по ID
                            string query = "DELETE FROM Предприятия WHERE id = @ID";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                // Добавляем параметр для запроса
                                cmd.Parameters.AddWithValue("@ID", id);

                                // Выполняем запрос
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Предприятите удалено!");

                                // Обновляем данные в DataGridView после удаления
                                RefreshGrid();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                // Проверка на то, что выбранная строка существует
                if (dataGridView1.CurrentRow != null)
                {
                    // Используем индекс строки для получения данных
                    int id = (int)dataGridView1.CurrentRow.Cells[0].Value; // id_тура - первый столбец
                    string название_предпр = dataGridView1.CurrentRow.Cells[1].Value.ToString(); // направление - второй столбец
                    string адрес = dataGridView1.CurrentRow.Cells[2].Value.ToString(); ; // длительность - третий столбец
                    string телефон = dataGridView1.CurrentRow.Cells[3].Value.ToString(); ; // стоимость - четвертый столбец
                    string ФИО_директора = dataGridView1.CurrentRow.Cells[4].Value.ToString(); // тип_тура - пятый столбец

                    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ilias/Source/Repos/sezer2012/GoletsKursovik/GoletsKursovik/Database.accdb;";
                    using (OleDbConnection conn = new OleDbConnection(connectionString))

                    using (PredSub form = new PredSub())
                    {
                        form.Text = "Изменить предприятие";
                        form.label5.Text = "Изменение предприятия";
                        // Предзаполняем форму данными из выбранной строки
                        form.textBox1.Text = название_предпр.ToString();
                        form.textBox2.Text = адрес.ToString();
                        form.textBox3.Text = телефон.ToString();
                        form.textBox4.Text = ФИО_директора.ToString();

                        // Ожидаем результат от пользователя в форме
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            // Считываем обновленные данные из формы
                            название_предпр = form.textBox1.Text;
                            адрес = form.textBox2.Text;
                            телефон = form.textBox3.Text;
                            ФИО_директора = form.textBox4.Text;

                            try
                            {
                           
                                // Обновляем данные в базе данных
                                conn.Open();
                                OleDbCommand cmd = new OleDbCommand("UPDATE Предприятия SET Название_предприятия = @Названия_предприятия, адрес = @адрес, телефон = @телефон, ФИО_директора = @ФИО_директора WHERE ID = @id", conn);
                                cmd.Parameters.AddWithValue("@Названия_предприятия", название_предпр);
                                cmd.Parameters.AddWithValue("@адрес", адрес);
                                cmd.Parameters.AddWithValue("@телефон", телефон);
                                cmd.Parameters.AddWithValue("@ФИО_директора", ФИО_директора);
                                cmd.Parameters.AddWithValue("@id", id);

                                // Выполняем запрос
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Предприятие обновлено!");
                                RefreshGrid(); // Обновляем таблицу
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка: " + ex.Message);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите запись для изменения.");
                }
            }
        }
    }
}
