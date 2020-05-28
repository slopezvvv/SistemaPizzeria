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
    public partial class IniciarCaja : Form
    {
        private static Cajero _cajero;
        private const string _nombreCajero = "FAVIO ALVAREZ";
        private const int _telefonoCajero = 937843423;

        public IniciarCaja()
        {
            InitializeComponent();
        }

        // EVENTOS
        private void _btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void _btnIngresar_Click(object sender, EventArgs e)
        {
            string txtRut = _txtRut.Text;
            char digito = _txtDigito.Text[0];
            string txtPass = _txtPass.Text;

            int rut;
            if (int.TryParse(txtRut, out rut))
            {
                _cajero = new Cajero(_nombreCajero, rut, digito, _telefonoCajero, txtPass);
                MenuPrincipal.IniciarDatosCajero();
            }
            else
                MessageBox.Show("Meta bien los deos! se pide un rut numerico >:C");
        }

        // GETs y SETs
        internal static Cajero Cajero { get => _cajero; set => _cajero = value; }
    }
}
