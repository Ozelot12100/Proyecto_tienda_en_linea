using Microsoft.VisualBasic.ApplicationServices;
using PROYECTO_UNIDAD_4.Clases;
using PROYECTO_UNIDAD_4.Forms;
using PROYECTO_UNIDAD_4.Forms.Admin;
using PROYECTO_UNIDAD_4.Forms.InicioDeSesion;
using PROYECTO_UNIDAD_4.Forms.Vendedor;

namespace PROYECTO_UNIDAD_4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            //verificacion de administrador cliente o vendedor
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
                                 u.Nombre.Equals(usuario, StringComparison.OrdinalIgnoreCase) &&
                                 u.Contraseña == contraseña);

            if (usuarioEncontrado == null)
            {
                // Credenciales INCORRECTAS
                MessageBox.Show($"Usuario o contraseña incorrecto", "Login fallido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                // Credenciales correctas
                MessageBox.Show($"Bienvenido {usuarioEncontrado.TipoUsuario} {usuarioEncontrado.Nombre}!", "Login Exitoso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (usuarioEncontrado.TipoUsuario == "Administrador")
            {
                DashboardAdmin abrir = new DashboardAdmin();
                abrir.ShowDialog();
                this.Hide();
            }
            else if (usuarioEncontrado.TipoUsuario == "Cliente")
            {
                ClienteDashBoard abrir = new ClienteDashBoard();
                abrir.ShowDialog();
                this.Hide();
            }
            else if (usuarioEncontrado.TipoUsuario == "Vendedor")
            {
                Vendedor abrir = new Vendedor();
                abrir.ShowDialog();
                this.Hide();
            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrame_Click(object sender, EventArgs e)
        {
            RegistroCliente abrir = new RegistroCliente();
            abrir.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
