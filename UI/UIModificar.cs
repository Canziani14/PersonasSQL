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
    public partial class UIModificarEliminar : Form
    {
        public UIModificarEliminar()
        {
            InitializeComponent();
        }
        
        BE.Usuario usuarioSelected;

        BLL.Usuario BLLUsuario = new BLL.Usuario();

        private void dtgUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgUsuario.SelectedRows.Count > 0)
            {
                usuarioSelected = ((BE.Usuario)dtgUsuario.SelectedRows[0].DataBoundItem);
                this.CompletarUsuario(usuarioSelected);
            }
        }

        private void UIModificar_Load(object sender, EventArgs e)
        {
            dtgUsuario.DataSource = BLLUsuario.listar();
        }

        private void CompletarUsuario(BE.Usuario usuario)
        {
            txtID.Text = usuario.ID.ToString();
            txtNombre.Text = usuario.nombre;
            txtApellido.Text = usuario.apellido;
            txtDireccion.Text = usuario.domicilio;
            txtEdad.Text = usuario.edad.ToString();
        }

        private void LimpiarGrilla()
        {
            dtgUsuario.DataSource = null;
            dtgUsuario.DataSource = BLLUsuario.listar();        
        }
        private void LimpiarTextBoxs()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtEdad.Clear();
        }
     
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (usuarioSelected != null)
            {
                if (BLLUsuario.actualizar(new BE.Usuario()
                {
                    ID = int.Parse(txtID.Text),
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    domicilio = txtDireccion.Text,
                    edad = int.Parse(txtEdad.Text)
                }
                ))
                {
                    MessageBox.Show("Usuario Actulizado con exito");
                    LimpiarGrilla();
                    LimpiarTextBoxs();
                }
                else
                {
                    MessageBox.Show("El usuario no pudo ser actualizado");
                }
            }
        }
       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usuarioSelected != null)
            {
                if (BLLUsuario.eliminar(usuarioSelected))
                {
                    MessageBox.Show($"El usuario : {usuarioSelected.ID} - {usuarioSelected.nombre} ha sido borrado");
                    LimpiarGrilla();
                    LimpiarTextBoxs();

                }
                else
                {
                    MessageBox.Show("No se pudo borrar el usuario");
                }


            }
            else
            {
                MessageBox.Show("Por favor selecccione un usuario para continuar");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }


}
