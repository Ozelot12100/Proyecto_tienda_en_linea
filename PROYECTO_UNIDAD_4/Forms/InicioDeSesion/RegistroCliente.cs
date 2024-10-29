using PROYECTO_UNIDAD_4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_UNIDAD_4.Forms.InicioDeSesion
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrase_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Debe de llenar TODOS los campos.", "Campos Vacíos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuarios usuarioEncontrado = UtilidadesPedido.TodosLosUsuariosLista
                             .FirstOrDefault(u =>
                                 u.Nombre.Equals(usuario, StringComparison.OrdinalIgnoreCase));

            if (usuarioEncontrado == null)
            {
                Usuarios nuevoCliente = new Usuarios(usuario, contraseña, "Cliente");
                UtilidadesPedido.TodosLosUsuariosLista.Add(nuevoCliente);

                // Creamos el nuevo usuario cliente
                MessageBox.Show($"Su cuentaha sido creada con exito", "Operacion exitosa",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                // Usuario ya existente
                MessageBox.Show($"Este nombre de usuario no esta disponible", "Error al crear nueva cuenta",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }
    }
}
