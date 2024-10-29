using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_UNIDAD_4.Clases
{
    internal class abrirForms
    {

        public void AbrirFormEnPanel(Panel panelContenedor, Form formHija)
        {

            if (panelContenedor.Controls.Count > 0)
            {

                var controlAnterior = panelContenedor.Controls[0] as Form;


                if (controlAnterior != null)
                {
                    controlAnterior.Close();
                    controlAnterior.Dispose();
                    panelContenedor.Controls.Remove(controlAnterior);
                }
            }

            formHija.TopLevel = false;
            formHija.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHija);
            panelContenedor.Tag = formHija;
            formHija.BringToFront();
            formHija.Show();
        }
    }
}

    

