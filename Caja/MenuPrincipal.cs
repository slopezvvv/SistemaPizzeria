using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class MenuPrincipal : Form
    {
        private readonly IniciarCaja _iniciarCaja;

        public MenuPrincipal()
        {
            InitializeComponent();
            _iniciarCaja = new IniciarCaja();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarCaja.Cajero = null;
        }

        private void iniciarCajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!_iniciarCaja.Visible)
                _iniciarCaja.Show();
        }

        // CUSTOM
        public static void IniciarDatosCajero()
        {
            Cajero cajero = IniciarCaja.Cajero;
            if (cajero != null)
            {
                _lblRutCajero.Text = cajero.Rut.ToString() + "-" + cajero.Digito;
                _lblNombreCajero.Text = cajero.Nombre;
            }
        }
    }
}
