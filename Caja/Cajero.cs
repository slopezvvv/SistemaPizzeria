using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja
{
    class Cajero : Persona
    {
        private readonly int _rut;
        private readonly char _digito;
        private string _pass;
        public Cajero(string nombre, int rut, char digito, int telefono, string pass) : base(nombre, telefono)
        {
            _digito = digito;
            _rut = ValidarRut(rut, 'k') ? rut : -1;
            _pass = pass;
        }
        public int Rut => _rut;
        public string Pass { get => _pass; set => _pass = value; }

        public char Digito => _digito;

        private bool ValidarRut(int rut, char digito)
        {
            return true;
        }
    }
}
