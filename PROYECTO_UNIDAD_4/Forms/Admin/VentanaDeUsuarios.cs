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

namespace PROYECTO_UNIDAD_4.Forms.Admin
{
    public partial class VentanaDeUsuarios : Form
    {
        public VentanaDeUsuarios()
        {
            InitializeComponent();
            this.Load += VentanaDeUsuarios_Load; // Vincular el evento Load al método

        }

        private void VentanaDeUsuarios_Load(object sender, EventArgs e)
        {
            dgvTablaUsuarios.DataSource = UtilidadesPedido.TodosLosUsuariosLista;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvTablaUsuarios.CurrentRow == null || dgvTablaUsuarios.CurrentRow.Index == -1)
            {
                MessageBox.Show("Seleccione un usuario en la tabla para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el índice de la fila seleccionada
            int indiceFila = dgvTablaUsuarios.CurrentRow.Index;

            // Confirmar la eliminación
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?",
                                                 "Confirmar Eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // Eliminar el usuario de la lista
                UtilidadesPedido.TodosLosUsuariosLista.RemoveAt(indiceFila);

                // Actualizar el DataGridView
                dgvTablaUsuarios.DataSource = null; // Limpiar la fuente de datos
                dgvTablaUsuarios.DataSource = UtilidadesPedido.TodosLosUsuariosLista; // Reasignar la lista actualizada

                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
                // Verificar si hay una fila seleccionada en el DataGridView
                if (dgvTablaUsuarios.CurrentRow == null || dgvTablaUsuarios.CurrentRow.Index == -1)
                {
                    MessageBox.Show("Seleccione un usuario en la tabla para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int indiceFila = dgvTablaUsuarios.CurrentRow.Index;

                // Verificar que el índice esté dentro del rango de la lista
                if (indiceFila < 0 || indiceFila >= UtilidadesPedido.TodosLosUsuariosLista.Count)
                {
                    MessageBox.Show("Seleccione un usuario válido en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text) || cmbTipoUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe llenar todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener los valores de los campos de edición
                string nombre = txtUsuario.Text;
                string contra = txtContraseña.Text;
                string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString();

                // Editar el usuario en la lista
                Usuarios usuarioSeleccionado = UtilidadesPedido.TodosLosUsuariosLista[indiceFila];
                usuarioSeleccionado.Nombre = nombre;
                usuarioSeleccionado.Contraseña = contra;
                usuarioSeleccionado.TipoUsuario = tipoUsuario;
                dgvTablaUsuarios.DataSource = null; // Elimina la fuente de datos actual
                dgvTablaUsuarios.DataSource = UtilidadesPedido.TodosLosUsuariosLista; // Vuelve a asignar la fuente

                // Limpiar los campos de edición
                txtUsuario.Clear();
                txtContraseña.Clear();
                cmbTipoUsuario.SelectedIndex = -1;

                MessageBox.Show("Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {


            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text) || cmbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe llenar todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtUsuario.Text;
            string contra = txtContraseña.Text;
            string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString();

            // Verificar si el usuario ya existe en la lista
            bool existeUsuario = UtilidadesPedido.TodosLosUsuariosLista.Any(u => u.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (existeUsuario)
            {
                MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro nombre.", "Usuario Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear el nuevo usuario
            Usuarios nuevoUsuario = new Usuarios(nombre,contra,tipoUsuario);
            

            // Agregar el nuevo usuario a la lista
            UtilidadesPedido.TodosLosUsuariosLista.Add(nuevoUsuario);

            // Actualizar el DataGridView
            dgvTablaUsuarios.DataSource = null;
            dgvTablaUsuarios.DataSource = UtilidadesPedido.TodosLosUsuariosLista;

            // Limpiar los campos de entrada
            txtUsuario.Clear();
            txtContraseña.Clear();
            cmbTipoUsuario.SelectedIndex = -1;

            MessageBox.Show("Usuario agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvTablaUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada
            if (dgvTablaUsuarios.CurrentRow != null && dgvTablaUsuarios.CurrentRow.Index > -1)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFila = dgvTablaUsuarios.CurrentRow.Index;

                // Verificar que el índice esté dentro del rango de la lista de usuarios
                if (indiceFila >= 0 && indiceFila < UtilidadesPedido.TodosLosUsuariosLista.Count)
                {
                    // Obtener el usuario seleccionado de la lista
                    Usuarios usuarioSeleccionado = UtilidadesPedido.TodosLosUsuariosLista[indiceFila];

                    // Llenar los campos de texto con los datos del usuario
                    txtUsuario.Text = usuarioSeleccionado.Nombre;
                    txtContraseña.Text = usuarioSeleccionado.Contraseña; // Asumiendo que es el correo o podrías tener otro campo de contraseña
                    cmbTipoUsuario.SelectedItem = usuarioSeleccionado.TipoUsuario;
                }
            }
        }
    }
}
