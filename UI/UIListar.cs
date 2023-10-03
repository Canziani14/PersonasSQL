using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();

            #region propiedades dtg
            dtgUsuarios.AutoResizeColumns();
            dtgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgUsuarios.AllowUserToAddRows= false;
            dtgUsuarios.MultiSelect = false;
            dtgUsuarios.ReadOnly = true;
            #endregion
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UIListar_Load(object sender, EventArgs e)
        {
            BLL.Usuario BLLUsuario = new BLL.Usuario();
            dtgUsuarios.DataSource = BLLUsuario.listar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
