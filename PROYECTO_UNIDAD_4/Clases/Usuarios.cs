using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_UNIDAD_4.Clases
{
    internal class Usuarios
    {
        public string Nombre {  get; set; }
        public string Contraseña { get; set; }

        public string TipoUsuario { get; set; }

        public Usuarios(string nombre, string contraseña, string tipoUsuario)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            TipoUsuario = tipoUsuario;
        }

        public void MostrarMensajecONFIRMACION()
        {
            MessageBox.Show("LA CUENTA HA SIDO CREADA","OPERACIÓN EXITOSA");
        }
    }
}
