using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aestrella
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            Configuracion.mapaU = new mapa();
            Configuracion.menuU = this;
            Configuracion.Dimensionx = (int)columnas.Value;
            Configuracion.Dimensiony = (int)filas.Value;
            try
            {
                Configuracion.Pesocruz = Single.Parse(pesocruz.Text);
                Configuracion.Pesodiagonal = Single.Parse(pesodiag.Text);
                Configuracion.mapaU.Show();
                Configuracion.menuU.Hide();
            }
            catch
            {
                MessageBox.Show("Pesos no validos");
            }
        }
    }
}
