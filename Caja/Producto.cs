using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja
{
    enum TipoProducto
    {
        PROMO_MEDIANA_BEBIDA
    }

    class Producto
    {
        private double _precio;
        private double _descuento;
        private TipoProducto _tipoProducto;

        public Producto()
        {
            _precio = 10000;
            _descuento = .0;
            _tipoProducto = TipoProducto.PROMO_MEDIANA_BEBIDA;
        }

        // GETs Y SETs
        public double Descuento
        {
            get => _descuento;
            set
            {
                if (value > 0 && value <= 100)
                    _descuento = value;
            }
        }

        public double Precio { get => _precio; set => _precio = value; }
        internal TipoProducto TipoProducto { get => _tipoProducto; set => _tipoProducto = value; }
    }
}
