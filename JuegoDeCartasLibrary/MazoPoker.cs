using JuegoDeCartasLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartasLibrary
{
    public class MazoPoker : Mazo
    {
        public MazoPoker()
        {
            CrearMazo();
            MezclarMazo();
        }

        public override List<CartaJugableModel> RepartirCartas()
        {
            var output = new List<CartaJugableModel>();

            for (int i = 0; i < 5; i++)
            {
                output.Add(PedirCarta());
            }

            return output; 
        }
    }
}
