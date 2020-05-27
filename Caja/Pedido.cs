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
        private readonly ArrayList _productos;
        private double _monto;

        public Pedido(ArrayList productos)
        {
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

        // CUSTOM
        private void CalcularTotal()
        {
            // SUMATORIA
            foreach (Producto p in _productos)
                Monto = (p.Precio + Monto);
        }
    }
}
