using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_.models
{
    public class Veiculo
    {
        public string Placa { get; private set; }

        public Veiculo(string placa)
        {
            Placa = placa.ToUpper();
        }
    }
}