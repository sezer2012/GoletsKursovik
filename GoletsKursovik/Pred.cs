using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Pred_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Предприятия". При необходимости она может быть перемещена или удалена.
            this.предприятияTableAdapter.Fill(this.databaseDataSet.Предприятия);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
