using BE;
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
    public partial class UIAgregar : Form
    {
        public UIAgregar()
        {
            InitializeComponent();
        }

        private void UIAgregar_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        
            BLL.Usuario BLLUsuario = new BLL.Usuario();
            BE.Usuario BEUsuario = new BE.Usuario();

            BEUsuario.esMenor += BEUsuario_esMenor;


            BEUsuario.nombre=txtNombre.Text;
            BEUsuario.apellido=txtApellido.Text;
            BEUsuario.domicilio=txtDomicilio.Text;
            BEUsuario.edad = int.Parse(txtEdad.Text);

            if (BEUsuario.edad>=18)
            {
                BLLUsuario.agregar(BEUsuario);
                MessageBox.Show("Usuario Creado con exito");
            }                                   
        }

        private void BEUsuario_esMenor(int edad)
        {
            MessageBox.Show($"Es menor. Edad:{edad}");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
