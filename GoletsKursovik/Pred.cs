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


           
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/User/Source/Repos/sezer2012/GoletsKursovik/GoletsKursovik/Database.accdb;";

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
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var Название_предприятия = textBox1.Text; var Адрес = textBox2.Text;
            var Телефон = textBox3.Text; var ФИО_директора = textBox4.Text;
            dataGridView1.Rows[selectedRowIndex].SetValues(Название_предприятия, Адрес, Телефон, ФИО_директора);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var Название_предприятия = textBox1.Text;
            var Адрес = textBox2.Text;
            var Телефон = textBox3.Text;
            var ФИО_директора = textBox4.Text;

            dataGridView1.Rows[selectedRowIndex].SetValues(Название_предприятия, Адрес, Телефон, ФИО_директора);
        }
    }
}
