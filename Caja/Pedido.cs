using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja
{
    enum TipoEntrega
    {
        DESPACHO, LOCAL
    }

    enum TipoPago
    {
        EFECTIVO, TRANSFERENCIA
    }

    class Pedido
    {
        private int _fecha;
        private readonly ArrayList _productos;
        private double _monto;
        private Cajero _cajero;
        private Repartidor _repartidor;
        private Cliente _cliente;

        public Pedido(ArrayList productos)
        {
            _fecha = System.DateTime.Now.Millisecond;
            Console.WriteLine("EPOCH: " + _fecha); // TESTING
            _monto = .0;
            _productos = productos;
            CalcularTotal();
        }

        // GETs y SETs
        public ArrayList Productos => _productos;

        public double Monto {
            get => _monto;
            private set
            {
                _monto = Math.Abs(value);
            }
        }

        public int Fecha { get => _fecha; set => _fecha = value; }
        internal Cajero Cajero { get => _cajero; set => _cajero = value; }
        internal Repartidor Repartidor { get => _repartidor; set => _repartidor = value; }
        internal Cliente Cliente { get => _cliente; set => _cliente = value; }

        // CUSTOM
        private void CalcularTotal()
        {
            // SUMATORIA
            foreach (Producto p in _productos)
                Monto = (p.Precio + Monto);
        }

        // Traduccion booleana
        public string IsDespacho()
        {
            return _repartidor == null ? "Entrega en local" : "Despacho a domicilio";
        }
    }
}
