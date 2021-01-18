using JuegoDeCartasLibrary.Enum;
using JuegoDeCartasLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartasLibrary
{
    public sealed class MazoTruco : Mazo
    {
        public MazoTruco()
        {
            CrearMazo();
            MezclarMazo();
        }

        protected override void CrearMazo()
        {
            // Limpiar mazo cada vez que se llama a crearlo
            mazoCompleto.Clear();

            // Llenar mazo con cada palo y sus respectivos valores
            for (int palo = 0; palo < 3; palo++)
            {
                for (int valor = 0; valor < 13; valor++)
                {
                    mazoCompleto.Add(new CartaJugableModel { PaloEspañola = (PaloEspañola)palo, ValorEspañola = (ValorEspañola)valor });
                }
            }

        }

        public override List<CartaJugableModel> RepartirCartas()
        {
            var output = new List<CartaJugableModel>();

            for (int i = 0; i < 3; i++)
            {
                output.Add(PedirCarta());
            }

            return output;
        }
    }
}
