using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoletsKursovik
{
    public partial class PredSub : Form
    {
        public PredSub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                this.DialogResult = DialogResult.OK;
                this.Close();
            
        }
    }
}
