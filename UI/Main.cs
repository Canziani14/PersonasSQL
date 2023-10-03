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
    public partial class Main : Form
    {
          public Main()
          {
              InitializeComponent();
          }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UIAgregar agregar = new UIAgregar();
            agregar.MdiParent = this;
            agregar.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar listar = new Listar();
            listar.MdiParent=this;
            listar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            UIModificarEliminar modificar = new UIModificarEliminar();
            modificar.MdiParent = this;
            modificar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UIModificarEliminar eliminar = new UIModificarEliminar();
            eliminar.MdiParent = this;
            eliminar.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
