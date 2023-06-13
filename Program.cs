using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Carta uno = new Carta('A', 1);
                Carta dos = new Carta('B', 2);
                Carta tres = new Carta('C', 3);
                Carta cuatro = new Carta('D', 4);
                Carta cinco = new Carta('E', 5);
                Carta seis = new Carta('F', 6);
                Carta siete = new Carta('G', 7);
                Carta ocho = new Carta('H', 8);
                Carta nueve = new Carta('I', 9);
                Carta diez = new Carta('J', 10);

            Carta[] listaCartas = { uno, dos, tres, cuatro, cinco, seis, siete, ocho, nueve, diez };

            foreach (var carta in listaCartas)
            {
                Console.WriteLine(carta.ToString());
            }

            Console.ReadLine();
            }
        }
}