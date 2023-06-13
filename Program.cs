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
                Carta[] carta = new Carta[52];

            char letra = 'A';
            for (int i = 0;  i < carta.Length; i++)
            {
                carta[i] = new Carta(letra++, i + 1);
            }

            for (int i = 0; i < carta.Length; i++)
            {
                if (carta[i].Palo == 'Z')
                {
                    Console.WriteLine("ESTA ES MI CARTA Z!!!");
                    Console.WriteLine(carta[i]);
                }
            }
            Console.ReadLine();
            }
        }
}