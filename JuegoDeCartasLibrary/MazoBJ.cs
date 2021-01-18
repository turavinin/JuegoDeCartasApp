using JuegoDeCartasLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartasLibrary
{
    public class MazoBJ : Mazo
    {
        public MazoBJ()
        {
            CrearMazo();
            MezclarMazo();
        }

        public override List<CartaJugableModel> RepartirCartas()
        {
            var output = new List<CartaJugableModel>();

            for (int i = 0; i < 2; i++)
            {
                output.Add(PedirCarta());
            }

            return output;
        }
    }
}
