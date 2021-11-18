using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3Camadas.Ui
{
    public partial class Netflix : Form
    {
        public Netflix()
        {
            InitializeComponent();
        }

        private void lblMedicamento_Click(object sender, EventArgs e)
        {

        }

        private void lblComposicao_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNetflix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvNetflix.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtfilme.Text = dgvNetflix.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcategoria.Text = dgvNetflix.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void Netflix_Load(object sender, EventArgs e)
        {

        }
    }
}
