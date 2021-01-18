using JuegoDeCartasLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartasLibrary.Model
{
    public class CartaJugableModel
    {
        public PaloInglesa PaloInglesa { get; set; }
        public ValorInglesa ValorInglesa { get; set; }
        public PaloEspañola PaloEspañola { get; set; }
        public ValorEspañola ValorEspañola { get; set; }
    }
}
