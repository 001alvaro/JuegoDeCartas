using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JuegoDeCartas
{
    public class Carta
    {
        private char palo;
        private int numero;

        public char Palo { get { return palo; } set { palo = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
        public Carta() { }

        public Carta(char p, int n)
        {
            this.palo = p;
            this.numero = n;
        }

        public override string ToString()
        {
            return "Tu carta es " + palo + " con el valor " + numero;
        }
    }
}