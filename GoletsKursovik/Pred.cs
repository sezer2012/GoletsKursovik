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

        private void LoadData() {

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;";

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

          

           
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/nikit/Source/Repos/sezer2012/GoletsKursovik/GoletsKursovik/Database.accdb;";

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
    }
}
