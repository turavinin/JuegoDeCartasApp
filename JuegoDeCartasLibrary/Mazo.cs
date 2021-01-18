using JuegoDeCartasLibrary.Enum;
using JuegoDeCartasLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartasLibrary
{
    public abstract class Mazo
    {
        internal List<CartaJugableModel> mazoCompleto = new List<CartaJugableModel>();
        internal List<CartaJugableModel> cartasDisponibles = new List<CartaJugableModel>();
        internal List<CartaJugableModel> cartasDesechadas = new List<CartaJugableModel>();

        internal virtual void CrearMazo()
        {
            // Limpiar mazo cada vez que se llama a crearlo
            mazoCompleto.Clear();

            // Llenar mazo con cada palo y sus respectivos valores
            for (int palo = 0; palo < 3; palo++)
            {
                for (int valor = 0; valor < 13; valor++)
                {
                    mazoCompleto.Add(new CartaJugableModel { Palo = (PaloInglesa)palo, Valor = (ValorInglesa)valor });
                }
            }
        }

        internal void MezclarMazo()
        {
            Random rdm = new Random();
            cartasDisponibles = mazoCompleto.OrderBy(x => rdm.Next()).ToList();
        }

        public abstract List<CartaJugableModel> RepartirCartas();

        public CartaJugableModel PedirCarta()
        {
            CartaJugableModel output = cartasDisponibles.Take(1).First();
            cartasDisponibles.Remove(output);

            return output;

        }
    }
}
