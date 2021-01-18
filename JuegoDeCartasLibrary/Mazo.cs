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
        public List<CartaJugableModel> mazoCompleto = new List<CartaJugableModel>();
        public List<CartaJugableModel> cartasDisponibles = new List<CartaJugableModel>();
        public List<CartaJugableModel> cartasDesechadas = new List<CartaJugableModel>();

        public void CrearMazo()
        {
        }
    }
}
