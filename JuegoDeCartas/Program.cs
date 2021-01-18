using JuegoDeCartasLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POKER:");
            var mazoPoker = new MazoPoker();
            var mano = mazoPoker.RepartirCartas();

            foreach (var carta in mano)
            {
                Console.WriteLine($"{carta.Valor} de {carta.Palo}");
            }
            Console.WriteLine();

            Console.WriteLine("BLACK JACK:");
            var mazoBJ = new MazoBJ();
            var manoBJ = mazoBJ.RepartirCartas();

            foreach (var carta in manoBJ)
            {
                Console.WriteLine($"{ carta.Valor } de { carta.Palo }");
            }
            Console.WriteLine();

            Console.WriteLine("MANO DE TRUCO");


            Console.ReadLine();
        }
    }
}
