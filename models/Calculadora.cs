using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_.models
{
    public class Calculadora
    {
        public void somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }


        public void subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void divisao(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        
        public void potencia(int x,int y)
        {
           double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
    }
}