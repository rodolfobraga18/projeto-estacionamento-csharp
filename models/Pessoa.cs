using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_.models
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public void Apresentar()
        {

            Console.WriteLine($"OLÁ, MEU NOME É {nome}, tenho {idade} anos");


        }



    }

}